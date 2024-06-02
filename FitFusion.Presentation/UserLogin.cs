using FitFusion.Entity.NewEntity;
using FitFusion.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitSecretProject.Presentation
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(160, 196, 157);
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(78, 94, 61);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(160, 196, 157);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UnitOfWork.Instance.UserControls.Login(txtUsername.Text, txtPassword.Text);
            this.Close();
           
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            UserSignup userSignup = new UserSignup();
            userSignup.Show();
            this.Hide();
        }
        private void imgQuit_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
