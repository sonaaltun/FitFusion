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
    public partial class MeScreen : Form
    {
        private readonly User _loginUser;
        public MeScreen(User user)
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(160, 196, 157);
            panel3.BackColor = Color.FromArgb(160, 196, 157);

            _loginUser = user;
            lblMainname.Text = _loginUser.FirstName + " " + _loginUser.LastName;


        }

        private void MeScreen_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(247, 255, 229);
            groupBox1.BackColor = Color.FromArgb(225, 236, 200);
            groupBox1.ForeColor = Color.FromArgb(160, 196, 157);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var result = UnitOfWork.Instance.UserControls.BodyIndex(txtWeight.Text, txtHeight.Text, _loginUser);

            if (result >= 18.5 && result <= 24.9)
            {
                lblMessage.ForeColor = Color.YellowGreen;
                lblMessage.Text = $"Your BMI is {result.ToString("N2")}. Your weight is normal";
            }
            else if (result > 25)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = $"Your BMI is {result.ToString("N2")}. Your weight is risky";
            }
            lblMessage.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            CompareScreen compareScreen = new CompareScreen(_loginUser);
            compareScreen.Show();
            this.Close();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            AnalyzeScreen analyzeScreen = new AnalyzeScreen(_loginUser);
            analyzeScreen.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            MainScreen mainScreen = new MainScreen(_loginUser);
            mainScreen.Show();
            this.Close();
        }
    }
}
