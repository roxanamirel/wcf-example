using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Clinic.Models;
using System.Media;

namespace WCFClient.Doctor
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public partial class DoctorForm : Form,IMessageCallback
    {

        private string endPointAddr = "net.tcp://192.168.56.1:8000/MyService";
        private NetTcpBinding tcpBinding = new NetTcpBinding();
        private EndpointAddress endpointAddress;
        private User user;
        public DoctorForm(User user)
        {
            InitializeComponent();
            tcpBinding.TransactionFlow = false;
            tcpBinding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
            tcpBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcpBinding.Security.Mode = SecurityMode.None;
            endpointAddress = new EndpointAddress(endPointAddr);       
            this.user = user;
            
            InstanceContext context = new InstanceContext(this);
            DuplexChannelFactory<IMessage> dupFactory = null;
            NetTcpBinding netbinding = new NetTcpBinding();
            netbinding.Security.Mode = SecurityMode.None;

            IMessage clientProxy = null;
            dupFactory = new DuplexChannelFactory<IMessage>(context,
                 netbinding, endpointAddress);
            dupFactory.Open();
            clientProxy = dupFactory.CreateChannel();
            clientProxy.Subscribe();


        }
       public void OnMessageAdded(Guid doctorId)
        {
           
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                Clinic.Models.Doctor doctor = proxy.GetDoctorByUserId(user.Id);
                if (doctor.Id == doctorId)
                {

                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\user\Desktop\WCFExample_src\WCFExample\alert.wav");
                    simpleSound.Play();
                    MessageBox.Show("Patient has arrived");
                    
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.DataBindings.Clear();
            listBox3.Visible = true;
            string id = listBox1.SelectedValue.ToString();
            Guid patientId = new Guid(id);
            Clinic.Models.Doctor doctor = new Clinic.Models.Doctor();
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                var patientCons = proxy.GetConsultationsByPatientId(patientId);
                
                doctor = proxy.GetDoctorByUserId(user.Id);
                List<Consultation> cons = new List<Consultation>();
                foreach (Consultation c in patientCons)
                {
                    if (c.DoctorId == doctor.Id)
                    {
                        cons.Add(c);
                    }
                }
                listBox3.DataSource = cons;

            }
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet4.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.clinicDataSet4.Patient);

        }
        Consultation cons;
        private void listBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = listBox3.SelectedValue.ToString();
            tabControl1.SelectedTab = tabPage2;
            Guid consultationId = new Guid(id);
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                cons = proxy.getConsultationById(consultationId);
                textBox1.Text = proxy.GetPatientById(cons.PatientId).Name;
                textBox2.Text = proxy.GetDoctorById(cons.DoctorId).Name;
                richTextBox1.Text = cons.Result;
                textBox3.Text = cons.Date.ToString();
                textBox4.Text = cons.Hour.ToString();
            }
            button1.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            richTextBox1.Visible = true;
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cons.Result = richTextBox1.Text;
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                proxy.UpdateConsultation(cons);
            }
            MessageBox.Show("Result was added ");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
