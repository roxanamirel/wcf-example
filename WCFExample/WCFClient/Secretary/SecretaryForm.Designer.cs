namespace WCFClient.Secretary
{
    partial class SecretaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretaryForm));
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet = new WCFClient.ClinicDataSet();
            this.consultationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet3 = new WCFClient.ClinicDataSet3();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet2 = new WCFClient.ClinicDataSet2();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet1 = new WCFClient.ClinicDataSet1();
            this.patientTableAdapter = new WCFClient.ClinicDataSetTableAdapters.PatientTableAdapter();
            this.patientTableAdapter1 = new WCFClient.ClinicDataSet1TableAdapters.PatientTableAdapter();
            this.doctorTableAdapter = new WCFClient.ClinicDataSet2TableAdapters.DoctorTableAdapter();
            this.consultationTableAdapter = new WCFClient.ClinicDataSet3TableAdapters.ConsultationTableAdapter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identityCardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.birthtext = new System.Windows.Forms.TextBox();
            this.cnptext = new System.Windows.Forms.TextBox();
            this.idctext = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.clinicDataSet;
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "ClinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultationBindingSource
            // 
            this.consultationBindingSource.DataMember = "Consultation";
            this.consultationBindingSource.DataSource = this.clinicDataSet3;
            // 
            // clinicDataSet3
            // 
            this.clinicDataSet3.DataSetName = "ClinicDataSet3";
            this.clinicDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.clinicDataSet2;
            // 
            // clinicDataSet2
            // 
            this.clinicDataSet2.DataSetName = "ClinicDataSet2";
            this.clinicDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.clinicDataSet1;
            // 
            // clinicDataSet1
            // 
            this.clinicDataSet1.DataSetName = "ClinicDataSet1";
            this.clinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // consultationTableAdapter
            // 
            this.consultationTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(763, 432);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultation Details";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(229, 315);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 46);
            this.button9.TabIndex = 12;
            this.button9.Text = "Check IN";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 47);
            this.button5.TabIndex = 11;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 267);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(118, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Hour";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Result";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Doctor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Patient";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.listBox3);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.monthCalendar1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(763, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Schedule Consultation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.DataSource = this.consultationBindingSource;
            this.listBox3.DisplayMember = "Date";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(52, 266);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 148);
            this.listBox3.TabIndex = 10;
            this.listBox3.ValueMember = "Id";
            this.listBox3.Visible = false;
            this.listBox3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox3_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(52, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "Get Consultations";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 54);
            this.button2.TabIndex = 8;
            this.button2.Text = "Schedule";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(282, 302);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Select hour:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(282, 53);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Select date:";
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.doctorBindingSource;
            this.listBox2.DisplayMember = "Name";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(560, 53);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 148);
            this.listBox2.TabIndex = 3;
            this.listBox2.ValueMember = "Id";
            this.listBox2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Select doctor:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Select patient:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.patientBindingSource1;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(52, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 148);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Id";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PatientsINFO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Patient Information";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.identityCardNoDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(27, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // identityCardNoDataGridViewTextBoxColumn
            // 
            this.identityCardNoDataGridViewTextBoxColumn.DataPropertyName = "IdentityCardNo";
            this.identityCardNoDataGridViewTextBoxColumn.HeaderText = "IdentityCardNo";
            this.identityCardNoDataGridViewTextBoxColumn.Name = "identityCardNoDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.addresstext);
            this.tabPage1.Controls.Add(this.birthtext);
            this.tabPage1.Controls.Add(this.cnptext);
            this.tabPage1.Controls.Add(this.idctext);
            this.tabPage1.Controls.Add(this.nameText);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CRUD Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(18, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 45);
            this.button7.TabIndex = 12;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 48);
            this.button6.TabIndex = 11;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(103, 161);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(100, 22);
            this.addresstext.TabIndex = 9;
            // 
            // birthtext
            // 
            this.birthtext.Location = new System.Drawing.Point(103, 129);
            this.birthtext.Name = "birthtext";
            this.birthtext.Size = new System.Drawing.Size(100, 22);
            this.birthtext.TabIndex = 8;
            // 
            // cnptext
            // 
            this.cnptext.Location = new System.Drawing.Point(103, 92);
            this.cnptext.Name = "cnptext";
            this.cnptext.Size = new System.Drawing.Size(100, 22);
            this.cnptext.TabIndex = 7;
            // 
            // idctext
            // 
            this.idctext.Location = new System.Drawing.Point(103, 61);
            this.idctext.Name = "idctext";
            this.idctext.Size = new System.Drawing.Size(100, 22);
            this.idctext.TabIndex = 6;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(103, 29);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 22);
            this.nameText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "BirthDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 461);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.ContextMenuStripChanged += new System.EventHandler(this.tabControl1_ContextMenuStripChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // SecretaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "SecretaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecretaryForm";
            this.Load += new System.EventHandler(this.SecretaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ClinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private ClinicDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private ClinicDataSet1 clinicDataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private ClinicDataSet1TableAdapters.PatientTableAdapter patientTableAdapter1;
        private ClinicDataSet2 clinicDataSet2;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private ClinicDataSet2TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private ClinicDataSet3 clinicDataSet3;
        private System.Windows.Forms.BindingSource consultationBindingSource;
        private ClinicDataSet3TableAdapters.ConsultationTableAdapter consultationTableAdapter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identityCardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.TextBox birthtext;
        private System.Windows.Forms.TextBox cnptext;
        private System.Windows.Forms.TextBox idctext;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button9;

    }
}