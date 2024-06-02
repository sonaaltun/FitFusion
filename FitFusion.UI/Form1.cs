namespace FitFusion.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UnitOfWork.Instance.UserControls.Login(txtMail.Text, txtPassword.Text);
        }
    }
}
