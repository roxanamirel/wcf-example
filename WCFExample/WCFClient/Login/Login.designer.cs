namespace Clinic.GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Loginbutton);
            this.panel1.Controls.Add(this.PasswordtextBox);
            this.panel1.Controls.Add(this.UsernameBox);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Location = new System.Drawing.Point(196, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 231);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(196, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "                    ";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(196, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "          ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(52, 168);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(100, 40);
            this.Loginbutton.TabIndex = 4;
            this.Loginbutton.Text = "login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(52, 123);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordtextBox.TabIndex = 3;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(52, 56);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(100, 22);
            this.UsernameBox.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(49, 103);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(75, 18);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(49, 29);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 18);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 506);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}