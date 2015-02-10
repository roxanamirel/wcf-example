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

namespace WCFClient.Secretary
{
    public partial class SecretaryForm : Form,IMessageCallback
    {
        private string endPointAddr = "net.tcp://192.168.56.1:8000/MyService";
        private NetTcpBinding tcpBinding = new NetTcpBinding();
        private EndpointAddress endpointAddress;
       
        public SecretaryForm()
        {
            InitializeComponent();
            tcpBinding.TransactionFlow = false;
            tcpBinding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
            tcpBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcpBinding.Security.Mode = SecurityMode.None;
            endpointAddress = new EndpointAddress(endPointAddr);
        
          
        }

      public  void OnMessageAdded(Guid doctorId)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
                using (proxy as IDisposable)
                {
                    Guid patientId = Guid.NewGuid();
                   
                    Patient patient = new Patient();
                    patient.Id = patientId;
                    patient.Name = nameText.Text;
                    patient.CNP = cnptext.Text;
                    patient.IdentityCardNo = idctext.Text;
                    patient.BirthDate = Convert.ToDateTime(birthtext.Text);
                    patient.Address = addresstext.Text;
                    proxy.AddPatient(patient);
                    MessageBox.Show("Patient added!");
                    nameText.Text = "";
                    cnptext.Text = "";
                    idctext.Text = "";
                    birthtext.Text = "";
                    addresstext.Text = "";

                }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SecretaryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet3.Consultation' table. You can move, or remove it, as needed.
            this.consultationTableAdapter.Fill(this.clinicDataSet3.Consultation);
            // TODO: This line of code loads data into the 'clinicDataSet2.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.clinicDataSet2.Doctor);
            // TODO: This line of code loads data into the 'clinicDataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter1.Fill(this.clinicDataSet1.Patient);
            // TODO: This line of code loads data into the 'clinicDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            Guid consultationId = Guid.NewGuid();
            Consultation consultation = new Consultation();
            consultation.Id = consultationId;
            long l = (long)numericUpDown1.Value;
            TimeSpan ts = new TimeSpan(l);
            consultation.Hour = ts;
            consultation.Date = Convert.ToDateTime(monthCalendar1.SelectionRange.Start.ToString());
            consultation.Result = "First consult";
            Patient patient = new Patient();
            Clinic.Models.Doctor doctor = new Clinic.Models.Doctor();

            string id = listBox1.SelectedValue.ToString();
            Guid patientId = new Guid(id);
            string idd = listBox2.SelectedValue.ToString();
            Guid doctorId = new Guid(idd);
            consultation.DoctorId = doctorId;
            consultation.PatientId = patientId;
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                proxy.AddConsultation(consultation);
            }
            MessageBox.Show("A new consultation was added ");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.DataBindings.Clear();
            listBox3.Visible = true;
            string id = listBox1.SelectedValue.ToString();
            Guid patientId = new Guid(id);
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
               var  patientCons = proxy.GetConsultationsByPatientId(patientId);
                listBox3.DataSource = patientCons;
               
            }
            

        }
        Consultation cons;
        private void listBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            string id = listBox3.SelectedValue.ToString();
            Guid consultationId = new Guid(id);
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using(proxy as IDisposable)
            {
                cons = proxy.getConsultationById(consultationId);
                textBox1.Text = proxy.GetPatientById(cons.PatientId).Name;
                textBox2.Text = proxy.GetDoctorById(cons.DoctorId).Name;
                richTextBox1.Text = cons.Result;
                textBox3.Text = cons.Date.ToString();
                textBox4.Text = cons.Hour.Value.ToString();
            }
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           // long l =Convert.ToInt64(textBox4.Text);
            //TimeSpan ts = new TimeSpan(l);
            //consultation.Hour = ts;

            cons.Date = Convert.ToDateTime(textBox3.Text);
            cons.Result = richTextBox1.Text;

            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                proxy.UpdateConsultation(cons);
            }
            MessageBox.Show("Consultation was updated");
        }

        

        private void label8_Click(object sender, EventArgs e)
        {
            
            listBox2.Visible = true;
            
            long l = (long)numericUpDown1.Value;
            TimeSpan ts = new TimeSpan(l);

            DateTime date = Convert.ToDateTime(monthCalendar1.SelectionRange.Start.ToString());

            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            var availableDoctors = new List<Clinic.Models.Doctor>();
            using (proxy as IDisposable)
            {
                var doctors = proxy.GetAllDoctors();
                foreach (Clinic.Models.Doctor d in doctors)
                {
                    var consults = proxy.GetConsultationsByDoctorId(d.Id);
                    if (consults.Count() == 0)
                    {
                        availableDoctors.Add(d);
                    }
                    else
                    {
                        foreach (Consultation c in consults)
                        {
                            DateTime dt = c.Date.Value;
                            TimeSpan t = c.Hour.Value;
                            if (dt.Day != date.Day || (dt.Day == date.Day && t != ts))
                            {
                            availableDoctors.Add(d);
                            break;
                            }
                        }
                    }
                }
            }
            var ava = availableDoctors;
            listBox2.DataSource = ava;

            //foreach (Clinic.Models.Doctor d in availableDoctors)
            //{
            //    listBox2.DisplayMember = d.Name;
            //}
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_ContextMenuStripChanged(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }
        private Patient p = new Patient();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = dataGridView1.CurrentCell.Value;
            Guid patientId = new Guid(x.ToString());
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            
            using (proxy as IDisposable)
            {
                p = proxy.GetPatientById(patientId);
                tabControl1.SelectedTab = tabPage1;
                button1.Visible = false;
                button6.Visible = true;
                button7.Visible = true;
            }
            nameText.Text = p.Name;
            idctext.Text = p.IdentityCardNo;
            cnptext.Text = p.CNP;
            addresstext.Text = p.Address;
            birthtext.Text = p.BirthDate.ToString();


        }

        private void label7_Click(object sender, EventArgs e)
        {
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                var x = proxy.GetAllPatients();
                listBox1.DataSource = x;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);

            using (proxy as IDisposable)
            {
                proxy.DeleteConsultation(cons.Id);
            }
            MessageBox.Show("The consult was deleted ");

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                var x = proxy.GetAllPatients();
                dataGridView1.DataSource = x;
            }
          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            p.Name = nameText.Text;
            p.IdentityCardNo = idctext.Text;
            p.CNP = cnptext.Text;
            p.Address = addresstext.Text;
            p.BirthDate= Convert.ToDateTime(birthtext.Text);

            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                proxy.UpdatePatient(p);
            }
            MessageBox.Show("Patient Information was updated ");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);
            using (proxy as IDisposable)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this patient?", "Delete Patient ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var x = proxy.GetConsultationsByPatientId(p.Id);
                    if (x.Count() != 0)
                    {
                        foreach (Consultation t in x)
                        {
                            proxy.DeleteConsultation(t.Id);
                        }
                    }
                    proxy.DeletePatient(p.Id);
                }
                else if (dialogResult == DialogResult.No)
                {
                   
                }
                
            }
          
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            listBox2.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox2.Visible = false;
        }


        private void button9_Click(object sender, EventArgs e)
        {
            string id = listBox1.SelectedValue.ToString();
            Guid patientId = new Guid(id);
            InstanceContext context = new InstanceContext(this);
            DuplexChannelFactory<IMessage> dupFactory = null;
            NetTcpBinding netbinding = new NetTcpBinding();
            netbinding.Security.Mode = SecurityMode.None;
            IMessage clientProxy = null;
            dupFactory = new DuplexChannelFactory<IMessage>(context,
                 netbinding, endpointAddress);
            dupFactory.Open();
            clientProxy = dupFactory.CreateChannel();
            IService1 proxy = ChannelFactory<IService1>.CreateChannel(tcpBinding, endpointAddress);

            using (proxy as IDisposable)
            {
                var x = proxy.GetConsultationsByPatientId(patientId);
                foreach (Consultation c in x)
                {
                    clientProxy.AddMessage(c.DoctorId);
                    break;

                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
       
    }
}
