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
    public partial class AdminLogin : Form
    {
        private readonly User _loginUser;

        public AdminLogin(User user)
        {
            InitializeComponent();
            _loginUser = user;
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(160, 196, 157);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(UnitOfWork.Instance.UserControls.AdminLogin(txtUsername.Text, txtPassword.Text)  == true)
            {
                this.Close();
            }
            else { return; }
            
        }
    }
}
