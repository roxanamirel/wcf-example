using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace socket
{
    public class Server
    {
        ManualResetEvent allDone = new ManualResetEvent(false);

        public void Start()
        {
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Loopback, 1440));
            while (true)
            {

                Console.WriteLine("Waiting for connection...");
                allDone.Reset();
                listener.Listen(100);
                listener.BeginAccept(Accept, listener);
                allDone.WaitOne();
                if (sender.Connected)
                {
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Disconnect(true); 

                }
                sender.BeginConnect(new IPEndPoint(IPAddress.Loopback, 1442), Connect, sender);

            }
        }

        public void Accept(IAsyncResult result)
        {
            Console.WriteLine("Connection received");
            Status status = new Status();
            status.Socket = ((Socket)result.AsyncState).EndAccept(result);
            status.Socket.BeginReceive(status.buffer, 0, status.buffer.Length, SocketFlags.None, Receive, status);
        }


        public void Receive(IAsyncResult result)
        {
            Status status = (Status)result.AsyncState;
            int read = status.Socket.EndReceive(result);
            if (read > 0)
            {
                for (int i = 0; i < read; i++)
                {
                    status.TransmissionBuffer.Add(status.buffer[i]);
                }

                //we need to read again if this is true
                if (read == status.buffer.Length)
                {
                    status.Socket.BeginReceive(status.buffer, 0, status.buffer.Length, SocketFlags.None, Receive, status);
                    Console.WriteLine("Past niet!");
                }
                else
                {
                    Done(status);
                }
            }
            else
            {
                Done(status);
            }
        }



        public void Done(Status status)
        {
            Console.WriteLine("Received: " + status.msg);
            Status send = status.DeSerialize();
            ConcreteSubject cs = new ConcreteSubject();
            Doctor d = new Doctor();

            Console.WriteLine("Starting"+ send.msg);
            cs.AddObservers(d);
            cs.CheckIn();
            Console.ReadLine();
            allDone.Set();
        }
        public void Connect(IAsyncResult result)
        {
            Status status = new Status();
            status.Socket = (Socket)result.AsyncState;
            status.Socket.EndConnect(result);
            status.msg = "I received";
            status.number = 10;

            byte[] buffer = status.Serialize();
            status.Socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, Send, status);
        }
        public void Send(IAsyncResult result)
        {
            Status status = (Status)result.AsyncState;
            int size = status.Socket.EndSend(result);
            Console.Out.WriteLine("Send data: " + size + " bytes.");
            Console.ReadLine();
            allDone.Set();
        }

    }
}
