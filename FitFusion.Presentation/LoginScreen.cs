using FitFusion.Entity.NewEntity;
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
    public partial class LoginScreen : Form
    {
        private readonly User _loginUser;
        public LoginScreen()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(160, 196, 157);


        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.FromArgb(78, 94, 61);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.FromArgb(78, 94, 61);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.FromArgb(160, 196, 157);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.FromArgb(160, 196, 157);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminLogin adminLogin = new AdminLogin(_loginUser);
            adminLogin.Show();
        }
    }
}
