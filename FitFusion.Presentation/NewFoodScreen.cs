using FitFusion.BLL.VMs;
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
    public partial class NewFoodScreen : Form
    {
        private readonly User _loginUser;
        
        public NewFoodScreen(User loginUser)
        {
            InitializeComponent();
            pnlNewFood.BackColor = Color.FromArgb(160, 196, 157);
            panel1.BackColor = Color.FromArgb(160, 196, 157);
            panel2.BackColor = Color.FromArgb(160, 196, 157);
            panel3.BackColor = Color.FromArgb(160, 196, 157);
            pnlBorder1.BackColor = Color.FromArgb(160, 196, 157);
            pnlBorder2.BackColor = Color.FromArgb(160, 196, 157);
            pnlBorder3.BackColor = Color.FromArgb(160, 196, 157);
            pnlBorder4.BackColor = Color.FromArgb(160, 196, 157);

            btnSave.BackColor = Color.FromArgb(160, 196, 157);
            groupBox1.BackColor = Color.FromArgb(196, 215, 178);
            _loginUser = loginUser;
            RefreshCategories();
        }
        string filePath;

        private void RefreshCategories()
        {
            cbFoodCategory.DataSource = null;
            cbFoodCategory.DataSource = UnitOfWork.Instance.CategoryControllers.GetCategories();
            cbFoodCategory.DisplayMember = "CategoryName";
            cbFoodCategory.ValueMember = "Id";
        }

        private void NewFoodScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(225, 236, 200);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedCategory = cbFoodCategory.SelectedItem as CategoryVm;
            var imageBytes = UnitOfWork.Instance.FoodControllers.ConvertImageToBytes(filePath);

            if (UnitOfWork.Instance.FoodControllers.AddFood(_loginUser, imageBytes, selectedCategory, txtFoodName.Text, txtAmount.Text, txtProtein.Text, txtFat.Text, txtCarbonhydrat.Text))
            {
                MainScreen mainScreen = new MainScreen(_loginUser);
                mainScreen.Show();
                this.Close();
            }
            else 
            {
                return; 
            }
 
            

        }

        private void imgQuit_Click(object sender, EventArgs e)
        {
            User user = new User();
            MainScreen mainScreen = new MainScreen(user);
            mainScreen.Show();
            this.Close();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSelectedPicture.Image = Image.FromFile(openFileDialog.FileName);
                string selectedFilePath = openFileDialog.FileName;
                filePath = selectedFilePath;
                
            }
        }
    }
}

