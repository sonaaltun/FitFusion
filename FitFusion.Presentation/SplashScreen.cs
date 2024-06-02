namespace FitSecretProject.Presentation
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(160, 196, 157);
            this.pictureBox1.BackColor = Color.FromArgb(160, 196, 157);
            this.Cursor = Cursors.Hand;
        }



        private void SplashScreen_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
