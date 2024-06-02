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
    public partial class AdminMainScreen : Form
    {
        private readonly User _loginUser;
        public AdminMainScreen(User user)
        {
            InitializeComponent();
            //header panel color
            pnlHeader.BackColor = Color.FromArgb(160, 196, 157);

            //groupbox colors
            gbFood.BackColor = Color.FromArgb(225, 236, 200);
            gbCategory.BackColor = Color.FromArgb(225, 236, 200);
            gPortion.BackColor = Color.FromArgb(225, 236, 200);
            //button colors

            //datagridview color
            dgvFoodList.BackgroundColor = Color.FromArgb(225, 236, 200);
            dgvCategoryList.BackgroundColor = Color.FromArgb(225, 236, 200);
            dgvPortionList.BackgroundColor = Color.FromArgb(225, 236, 200);

            _loginUser = user;

            dgvFoodList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoodList.AutoResizeColumns();

            dgvCategoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoryList.AutoResizeColumns();

            dgvPortionList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPortionList.AutoResizeColumns();



            RefreshFodList();
            RefreshCategoriesComboBox();
            RefreshCategoryList();
            RefreshPortionList();
        }

        private void RefreshPortionList()
        {
            dgvPortionList.DataSource = null;
            dgvPortionList.DataSource = UnitOfWork.Instance.PortionControllers.GetPortionList();
            dgvPortionList.Columns["Id"].Visible = false;

        }

        private void RefreshCategoryList()
        {
            dgvCategoryList.DataSource = null;
            dgvCategoryList.DataSource = UnitOfWork.Instance.CategoryControllers.GetCategories();
            dgvCategoryList.Columns["Id"].Visible = false;
        }

        private void RefreshCategoriesComboBox()
        {
            cbFoodCategories.DataSource = null;
            cbFoodCategories.DataSource = UnitOfWork.Instance.CategoryControllers.GetCategories();
            cbFoodCategories.DisplayMember = "CategoryName";
            cbFoodCategories.ValueMember = "Id";
        }

        string filePath;

        private void AdminMainScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 255, 229);
        }

        private void imgQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Assuming you have a PictureBox named pictureBox1 on your form

                }
            }
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //pbSelectedPicture.Image = Image.FromFile(openFileDialog.FileName);
                string selectedFilePath = openFileDialog.FileName;
                filePath = selectedFilePath;

            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var selectedCategory = cbFoodCategories.SelectedItem as CategoryVm;
            var imageBytes = UnitOfWork.Instance.FoodControllers.ConvertImageToBytes(filePath);
            string calories = Convert.ToString(nudCalories.Value);
            string fat = Convert.ToString(nudFat.Value);
            string protein = Convert.ToString(nudProtein.Value);
            string carbonhydrat = Convert.ToString(nudCarbonhydrat.Value);

            UnitOfWork.Instance.FoodControllers.AddFood(_loginUser, imageBytes, selectedCategory, txtFoodName.Text, calories, protein, fat, carbonhydrat);
            RefreshFodList();
            CleanFoodText();


        }

        private void RefreshFodList()
        {
            dgvFoodList.DataSource = null;
            dgvFoodList.DataSource = UnitOfWork.Instance.FoodControllers.GetFoodList();
            dgvFoodList.Columns["Id"].Visible = false;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            UnitOfWork.Instance.CategoryControllers.AddCategory(txtCategoryName.Text, rtbDescription.Text);
            RefreshCategoryList();
            RefreshCategoriesComboBox();
            CleanCategoryText();
        }

        private void CleanCategoryText()
        {
            txtCategoryName.Text = string.Empty;
            rtbDescription.Text = string.Empty;
        }

        private void btnAddPortion_Click(object sender, EventArgs e)
        {
            UnitOfWork.Instance.PortionControllers.AddPortion(txtPortionType.Text, (int)nudPortionAmount.Value);
            RefreshPortionList();
            CleanPortionText();
        }

        private void CleanPortionText()
        {
            txtPortionType.Text = string.Empty;
            nudPortionAmount.Value = 0;
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dELETEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UnitOfWork.Instance.FoodControllers.RemoveFood((Guid)dgvFoodList.SelectedRows[0].Cells["Id"].Value);
            RefreshFodList();
        }

        private void dELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UnitOfWork.Instance.CategoryControllers.RemoveCategory((Guid)dgvCategoryList.SelectedRows[0].Cells["Id"].Value);
            RefreshCategoryList();
            RefreshCategoriesComboBox();
        }

        private void dELETEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UnitOfWork.Instance.PortionControllers.RemovePortion((Guid)dgvPortionList.SelectedRows[0].Cells["Id"].Value);
            RefreshPortionList();
        }

        private void uPDATEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var selectedPortion = UnitOfWork.Instance.PortionControllers.GetPortion((Guid)dgvPortionList.SelectedRows[0].Cells["Id"].Value);

            txtPortionType.Text = selectedPortion.PortionType.ToString();
            nudPortionAmount.Value = (decimal)selectedPortion.Amount;
        }


        private void btnUpdatePortion_Click(object sender, EventArgs e)
        {
            var selectedPortion = UnitOfWork.Instance.PortionControllers.GetPortion((Guid)dgvPortionList.SelectedRows[0].Cells["Id"].Value);
            selectedPortion.PortionType = txtPortionType.Text;
            selectedPortion.Amount = (int)nudPortionAmount.Value;
            UnitOfWork.Instance.PortionControllers.UpdatePortion(selectedPortion);
            RefreshPortionList();
            CleanPortionText();
        }

        private void uPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var selectedCategory = UnitOfWork.Instance.CategoryControllers.GetCategory((Guid)dgvCategoryList.SelectedRows[0].Cells["Id"].Value);
            txtCategoryName.Text = selectedCategory.CategoryName.ToString();
            rtbDescription.Text = selectedCategory.Description.ToString();
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            var selectedCategory = UnitOfWork.Instance.CategoryControllers.GetCategory((Guid)dgvCategoryList.SelectedRows[0].Cells["Id"].Value);
            selectedCategory.CategoryName = txtCategoryName.Text;
            selectedCategory.Description = rtbDescription.Text;
            UnitOfWork.Instance.CategoryControllers.UpdateCategory(selectedCategory);
            RefreshCategoryList();
            CleanCategoryText();

        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedFood = UnitOfWork.Instance.FoodControllers.GetFood((Guid)dgvFoodList.SelectedRows[0].Cells["Id"].Value);
            txtFoodName.Text = selectedFood.Name.ToString();
            nudCalories.Value = (decimal)selectedFood.CaloriesPerServing;
            nudProtein.Value = (decimal)selectedFood.Protein;
            nudFat.Value = (decimal)selectedFood.Fat;
            nudCarbonhydrat.Value = (decimal)selectedFood.Carbonhydrat;
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            var selectedFood = UnitOfWork.Instance.FoodControllers.GetFood((Guid)dgvFoodList.SelectedRows[0].Cells["Id"].Value);
            selectedFood.Name = txtFoodName.Text;
            selectedFood.CaloriesPerServing = (int)nudCalories.Value;
            selectedFood.Protein = (int)nudProtein.Value;
            selectedFood.Fat = (int)nudFat.Value;
            selectedFood.Carbonhydrat = (int)nudCarbonhydrat.Value;
            selectedFood.ImageData = UnitOfWork.Instance.FoodControllers.ConvertImageToBytes(filePath);
            UnitOfWork.Instance.FoodControllers.UpdateFood(selectedFood);
            RefreshFodList();
            CleanFoodText();
            
        }

        private void CleanFoodText()
        {
            txtFoodName.Text = string.Empty;
            nudCalories.Value = 0;
            nudProtein.Value = 0;
            nudFat.Value = 0;
            nudCarbonhydrat .Value = 0;   
        }
    }
}
