using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using Clinic.Models;
using System.ServiceModel;
using WCFClient.Admin;
using WCFClient.Secretary;
using WCFClient.Doctor;



namespace Clinic.GUI
{
    public partial class Login : Form
    {
         
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {

            if (UsernameBox.Text != "" && Password.Text != "")
            {

                string endPointAddr = "net.tcp://192.168.56.1:8000/MyService";
                NetTcpBinding tcpBinding = new NetTcpBinding();
                tcpBinding.TransactionFlow = false;
                tcpBinding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
                tcpBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
                tcpBinding.Security.Mode = SecurityMode.None;
                EndpointAddress endpointAddress = new EndpointAddress(endPointAddr);
                IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);

                using (proxy as IDisposable)
                {
                    User user = proxy.GetUserByName(UsernameBox.Text);
                    if (user.Password.Equals(PasswordtextBox.Text))
                    {
                        string role = "";
                        if (user.Role != null)
                        {
                            role = user.Role;
                        }

                        if (role.Equals("Admin"))
                        {
                            AdminForm1 af = new AdminForm1();
                            af.Show();
                            this.Hide();
                        }
                        else if (role.Equals("Secretary"))
                        {
                            SecretaryForm sf = new SecretaryForm();
                            sf.Show();
                            this.Hide();

                        }
                        else if (role.Equals("Doctor"))
                        {
                            DoctorForm df = new DoctorForm(user);
                            df.Show();
                            this.Hide();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Credentials not found");
                    }
                }


            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
    }
}
