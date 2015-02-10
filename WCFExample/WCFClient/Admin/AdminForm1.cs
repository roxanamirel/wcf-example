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

namespace WCFClient.Admin
{
    public partial class AdminForm1 : Form
    {
        private string endPointAddr = "net.tcp://192.168.56.1:8000/MyService";
        private NetTcpBinding tcpBinding = new NetTcpBinding();
        private EndpointAddress endpointAddress;
        public AdminForm1()
        {
            InitializeComponent();
            tcpBinding.TransactionFlow = false;
            tcpBinding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
            tcpBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcpBinding.Security.Mode = SecurityMode.None;
            endpointAddress = new EndpointAddress(endPointAddr);
        }

       
        private void AdminForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet6.Secretary' table. You can move, or remove it, as needed.
            this.secretaryTableAdapter.Fill(this.clinicDataSet6.Secretary);
            // TODO: This line of code loads data into the 'clinicDataSet5.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.clinicDataSet5.Doctor);

        }
        private User user = new User();
        private void button1_Click(object sender, EventArgs e)
        {
            string role = "";
            if(radioButton1.Checked) 
            {
                role = "Secretary";
            }
            if (radioButton2.Checked)
            {
                role = "Doctor";
            }
            string name = textBox1.Text;
            string pass = textBox2.Text;
            string username = textBox3.Text;
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
         
            user.Id = Guid.NewGuid();
            user.Password = pass;
            user.Username = username;
            if (role.Equals("Secretary"))
            {
                Clinic.Models.Secretary s = new Clinic.Models.Secretary();
                user.Role = "Secretary";
                s.Name = name;
                s.Id = Guid.NewGuid();
                s.UserId = user.Id;
                using (proxy as IDisposable)
                {
                    proxy.AddUser(user);
                    proxy.AddSecretary(s);
                }

            }
            else if (role.Equals("Doctor"))
            {

                Clinic.Models.Doctor d = new Clinic.Models.Doctor();
                user.Role = "Doctor";
                d.Name = name;
                d.Id = Guid.NewGuid();
                d.UserId = user.Id;
                using (proxy as IDisposable)
                {
                    proxy.AddUser(user);
                    proxy.AddDoctor(d);
                }

            }
            MessageBox.Show("A new user was added"); 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        Clinic.Models.Doctor doctor = new Clinic.Models.Doctor();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            string id = listBox1.SelectedValue.ToString();
            tabControl1.SelectedTab = tabPage2;
            button2.Visible = true;
            button1.Visible = false;
            Guid doctorId = new Guid(id);
            
            User user = new User();
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
               doctor = proxy.GetDoctorById(doctorId);
               user = proxy.GetUserById(doctor.UserId);
            }
            textBox1.Text = doctor.Name;
            textBox2.Text = user.Password;
            textBox3.Text = user.Username;
            if (user.Role == "Secretary")
            {
                radioButton1.Checked = true;
            }
            else if (user.Role == "Doctor")
            {
                radioButton2.Checked = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string role = "";
            string name = textBox1.Text;
            string pass = textBox2.Text;
            string username = textBox3.Text;
      
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            if (radioButton1.Checked)
            {
                role = "Secretary";
                secretary.Name = name;
              
                using (proxy as IDisposable)
                {
                    User userr = proxy.GetUserById(secretary.UserId);
                    userr.Password = pass;
                    userr.Username = username;
                    userr.Role = role;
                    proxy.UpdateUser(userr);
                    proxy.UpdateSecretary(secretary);

                }
            }
            if (radioButton2.Checked)
            {
                role = "Doctor";
                doctor.Name = name;
                user.Id = doctor.UserId;
                using (proxy as IDisposable)
                {
                    User userr = proxy.GetUserById(doctor.UserId);
                    userr.Password = pass;
                    userr.Username = username;
                    userr.Role = role;
                    proxy.UpdateDoctor(doctor);
                    proxy.UpdateUser(userr);
                   

                }
            }

            MessageBox.Show("Information updated"); 
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string id = listBox1.SelectedValue.ToString();
            Guid doctorId = new Guid(id);
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                Clinic.Models.Doctor d = proxy.GetDoctorById(doctorId);
                proxy.DeleteDoctor(doctorId);
                proxy.DeleteUser(d.UserId);
            }
            MessageBox.Show("The user was deleted");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {        
              var x = proxy.GetAllDoctors();
              listBox1.DataSource = x;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                var x = proxy.GetAllSecretaries();
                listBox2.DataSource = x;
            }

        }
        private Clinic.Models.Secretary secretary = new Clinic.Models.Secretary();
        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = listBox2.SelectedValue.ToString();
            tabControl1.SelectedTab = tabPage2;
            button2.Visible = true;
            button1.Visible = false;
            Guid secretaryId = new Guid(id);

            User user = new User();
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                secretary = proxy.GetSecretaryById(secretaryId);
                user = proxy.GetUserById(secretary.UserId);
            }
            textBox1.Text = secretary.Name;
            textBox2.Text = user.Password;
            textBox3.Text = user.Username;
            if (user.Role == "Secretary")
            {
                radioButton1.Checked = true;
            }
            else if (user.Role == "Doctor")
            {
                radioButton2.Checked = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = listBox2.SelectedValue.ToString();
            Guid secretaryId = new Guid(id);
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                Clinic.Models.Secretary d = proxy.GetSecretaryById(secretaryId);
                proxy.DeleteSecretary(secretaryId);
                proxy.DeleteUser(d.UserId);
            }
            MessageBox.Show("The user was deleted");
        }

       


    }
}
