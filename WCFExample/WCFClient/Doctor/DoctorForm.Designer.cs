namespace WCFClient.Doctor
{
    partial class DoctorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet4 = new WCFClient.ClinicDataSet4();
            this.patientTableAdapter = new WCFClient.ClinicDataSet4TableAdapters.PatientTableAdapter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet4)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox3
            // 
            this.listBox3.DisplayMember = "Date";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(270, 37);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 148);
            this.listBox3.TabIndex = 14;
            this.listBox3.ValueMember = "Id";
            this.listBox3.Visible = false;
            this.listBox3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox3_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(144, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 48);
            this.button3.TabIndex = 13;
            this.button3.Text = "Get Consultations";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Select patient:";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.patientBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 148);
            this.listBox1.TabIndex = 11;
            this.listBox1.ValueMember = "Id";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.clinicDataSet4;
            // 
            // clinicDataSet4
            // 
            this.clinicDataSet4.DataSetName = "ClinicDataSet4";
            this.clinicDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 263);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 24;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 23;
            this.textBox3.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(113, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 21;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Hour";
            this.label15.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Date";
            this.label14.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Result";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Doctor";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Patient";
            this.label11.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 410);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.listBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultation Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 47);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet4)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private ClinicDataSet4 clinicDataSet4;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private ClinicDataSet4TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
    }
}