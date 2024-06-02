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
    public partial class UserSignup : Form
    {
        public UserSignup()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(160, 196, 157);
            this.Cursor = Cursors.Hand;
        }

        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }

        private void btnUsersignup_Click(object sender, EventArgs e)
        {
            if (UnitOfWork.Instance.UserControls.SignUp(txtFirstname.Text, txtLastname.Text, txtUsername.Text, txtPassword1.Text, txtPassword2.Text))
            {
                UserLogin userLogin = new UserLogin();
                this.Close();
                userLogin.Show();
            }
            else
            {
                MessageBox.Show("There is an error was encountered.");
            }

        }

        private void btnUsersignup_MouseHover(object sender, EventArgs e)
        {
            btnUsersignup.BackColor = Color.FromArgb(78, 94, 61);
        }

        private void btnUsersignup_MouseLeave(object sender, EventArgs e)
        {
            btnUsersignup.BackColor = Color.FromArgb(160, 196, 157);
        }

        private void imgQuit_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void lblPasswordRules_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Password Rules:\n-Password must be 8 characters at least\n-Password must contains two capital letters at least\n-Password must contains two number at least\n-Password must contais three lowercase letters\n-Password must contains two special characters'!, :, +, *' at least");
        }
    }
}
