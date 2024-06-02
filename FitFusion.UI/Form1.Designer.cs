namespace FitFusion.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblSignUp = new LinkLabel();
            lblEmail = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Location = new Point(161, 99);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 27);
            txtMail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(161, 151);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(161, 201);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "GİRİŞ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Location = new Point(186, 258);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(61, 20);
            lblSignUp.TabIndex = 3;
            lblSignUp.TabStop = true;
            lblSignUp.Text = "Sign Up";
            lblSignUp.LinkClicked += lblSignUp_LinkClicked;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(85, 102);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 158);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 5;
            label2.Text = "Şifre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 311);
            Controls.Add(label2);
            Controls.Add(lblEmail);
            Controls.Add(lblSignUp);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtMail);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lblSignUp;
        private Label lblEmail;
        private Label label2;
    }
}
