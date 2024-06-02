namespace FitSecretProject.Presentation
{
    partial class UserSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignup));
            panel1 = new Panel();
            lblPasswordRules = new LinkLabel();
            imgQuit = new PictureBox();
            txtPassword2 = new TextBox();
            label6 = new Label();
            btnUsersignup = new Button();
            txtPassword1 = new TextBox();
            label5 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgQuit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPasswordRules);
            panel1.Controls.Add(imgQuit);
            panel1.Controls.Add(txtPassword2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnUsersignup);
            panel1.Controls.Add(txtPassword1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtLastname);
            panel1.Controls.Add(txtFirstname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 11);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 691);
            panel1.TabIndex = 0;
            // 
            // lblPasswordRules
            // 
            lblPasswordRules.AutoSize = true;
            lblPasswordRules.Font = new Font("Segoe UI", 9F);
            lblPasswordRules.Location = new Point(703, 657);
            lblPasswordRules.Name = "lblPasswordRules";
            lblPasswordRules.Size = new Size(109, 20);
            lblPasswordRules.TabIndex = 21;
            lblPasswordRules.TabStop = true;
            lblPasswordRules.Text = "Password Rules";
            lblPasswordRules.LinkClicked += lblPasswordRules_LinkClicked;
            // 
            // imgQuit
            // 
            imgQuit.Image = (Image)resources.GetObject("imgQuit.Image");
            imgQuit.Location = new Point(780, 3);
            imgQuit.Name = "imgQuit";
            imgQuit.Size = new Size(27, 25);
            imgQuit.SizeMode = PictureBoxSizeMode.Zoom;
            imgQuit.TabIndex = 20;
            imgQuit.TabStop = false;
            imgQuit.Click += imgQuit_Click;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(367, 380);
            txtPassword2.Margin = new Padding(3, 4, 3, 4);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.Size = new Size(176, 28);
            txtPassword2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(251, 388);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 10;
            label6.Text = "Password";
            // 
            // btnUsersignup
            // 
            btnUsersignup.Cursor = Cursors.Hand;
            btnUsersignup.FlatStyle = FlatStyle.Popup;
            btnUsersignup.Font = new Font("Bahnschrift SemiBold", 12F);
            btnUsersignup.ForeColor = Color.White;
            btnUsersignup.Location = new Point(367, 439);
            btnUsersignup.Margin = new Padding(3, 4, 3, 4);
            btnUsersignup.Name = "btnUsersignup";
            btnUsersignup.Size = new Size(176, 45);
            btnUsersignup.TabIndex = 9;
            btnUsersignup.Text = "Sign Up";
            btnUsersignup.UseVisualStyleBackColor = true;
            btnUsersignup.Click += btnUsersignup_Click;
            btnUsersignup.MouseLeave += btnUsersignup_MouseLeave;
            btnUsersignup.MouseHover += btnUsersignup_MouseHover;
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(367, 327);
            txtPassword1.Margin = new Padding(3, 4, 3, 4);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.PasswordChar = '*';
            txtPassword1.Size = new Size(176, 28);
            txtPassword1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(251, 334);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(367, 271);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(176, 28);
            txtUsername.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(251, 278);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 5;
            label4.Text = "Mail";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(367, 218);
            txtLastname.Margin = new Padding(3, 4, 3, 4);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(176, 28);
            txtLastname.TabIndex = 4;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(367, 164);
            txtFirstname.Margin = new Padding(3, 4, 3, 4);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(176, 28);
            txtFirstname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(251, 225);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(251, 171);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(379, 96);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // UserSignup
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(835, 715);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiBold", 10F);
            ForeColor = Color.Ivory;
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgQuit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtPassword1;
        private Label label5;
        private TextBox txtUsername;
        private Button btnUsersignup;
        private TextBox txtPassword2;
        private Label label6;
        private PictureBox imgQuit;
        private LinkLabel lblPasswordRules;
    }
}