namespace FitSecretProject.Presentation
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            panel1 = new Panel();
            lnkSignUp = new LinkLabel();
            label4 = new Label();
            imgQuit = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgQuit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 179);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 0;
            label1.Text = "Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(135, 231);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(227, 173);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(154, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(227, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(154, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Bahnschrift SemiBold", 9F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(227, 288);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(154, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseHover += btnLogin_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(271, 88);
            label3.Name = "label3";
            label3.Size = new Size(72, 24);
            label3.TabIndex = 5;
            label3.Text = "LOG IN";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lnkSignUp);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(162, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 445);
            panel1.TabIndex = 6;
            // 
            // lnkSignUp
            // 
            lnkSignUp.AutoSize = true;
            lnkSignUp.Location = new Point(363, 341);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(61, 20);
            lnkSignUp.TabIndex = 7;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Sign Up";
            lnkSignUp.LinkClicked += lnkSignUp_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(135, 341);
            label4.Name = "label4";
            label4.Size = new Size(239, 18);
            label4.TabIndex = 6;
            label4.Text = "Don't you already have an account?";
            // 
            // imgQuit
            // 
            imgQuit.Image = (Image)resources.GetObject("imgQuit.Image");
            imgQuit.Location = new Point(795, 12);
            imgQuit.Name = "imgQuit";
            imgQuit.Size = new Size(27, 25);
            imgQuit.SizeMode = PictureBoxSizeMode.Zoom;
            imgQuit.TabIndex = 8;
            imgQuit.TabStop = false;
            imgQuit.Click += imgQuit_Click;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 717);
            Controls.Add(imgQuit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLogin";
            Load += UserLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgQuit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label3;
        private Panel panel1;
        private LinkLabel lnkSignUp;
        private Label label4;
        private PictureBox imgQuit;
    }
}