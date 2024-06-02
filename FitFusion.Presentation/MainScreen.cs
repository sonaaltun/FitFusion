using FitFusion.BLL.VMs;
using FitFusion.Entity.NewEntity;
using FitFusion.Presentation;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class MainScreen : Form
    {
        bool control;
        int menu_height;
        private readonly FitFusion.Entity.NewEntity.User _loginUser;
        MeScreen _meScreen;
        public MainScreen(FitFusion.Entity.NewEntity.User user)
        {
            _loginUser = user;
            InitializeComponent();
            pnlHome.BackColor = Color.FromArgb(160, 196, 157);
            pnlUser.BackColor = Color.FromArgb(160, 196, 157);
            //slide bars color
            pnlBreakfast.BackColor = Color.FromArgb(160, 196, 157);
            pnlLunch.BackColor = Color.FromArgb(160, 196, 157);
            pnlAperatives.BackColor = Color.FromArgb(160, 196, 157);
            pnlDinner.BackColor = Color.FromArgb(160, 196, 157);
            //datagridview colors
            dgvBreakfast.BackgroundColor = Color.FromArgb(225, 236, 200);
            dgvLunch.BackgroundColor = Color.FromArgb(225, 236, 200);
            dgvAperatives.BackgroundColor = Color.FromArgb(225, 236, 200);
            dgvDinner.BackgroundColor = Color.FromArgb(225, 236, 200);
            dgvMeals.BackgroundColor = Color.FromArgb(225, 236, 200);
            //button colors
            btnRemove.BackColor = Color.FromArgb(160, 196, 157);
            btnAdd.BackColor = Color.FromArgb(160, 196, 157);

            btnNewfood.BackColor = Color.FromArgb(160, 196, 157);


            //meals datagrid fill
            dgvMeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMeals.AutoResizeColumns();

            this.Cursor = Cursors.Hand;
            dgvBreakfast.Hide();
            control = false;
            menu_height = dgvBreakfast.Height;


            _meScreen = new MeScreen(_loginUser);
            lblUserName.Text = _loginUser.FirstName + " " + _loginUser.LastName;

            //meal datagridlerin boyutlarının otomatikleştirilmesi

            dgvAperatives.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAperatives.AutoResizeColumns();

            dgvBreakfast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBreakfast.AutoResizeColumns();

            dgvDinner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDinner.AutoResizeColumns();

            dgvLunch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLunch.AutoResizeColumns();




            RefreshFoodList();
            RefreshPortionList();
            RefreshAllMeals();

        }
        PictureBox clickedPictureBox;
        DateTime time;
        string type;



        private void RefreshPortionList()
        {
            cbPortions.DataSource = null;
            cbPortions.DataSource = UnitOfWork.Instance.PortionControllers.GetPortionList();
            cbPortions.DisplayMember = "PortionType";
            cbPortions.ValueMember = "Id";
        }

        private void RefreshFoodList()
        {
            dgvMeals.DataSource = null;
            dgvMeals.DataSource = UnitOfWork.Instance.FoodControllers.GetFoodList(_loginUser);
            dgvMeals.Columns["Id"].Visible = false;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 255, 229);
            RefreshFoodList();

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = null;
        }

        private void btnAddfood_Click(object sender, EventArgs e)
        {
            _meScreen.Show();
            this.Close();

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

        private void btnNewfood_Click(object sender, EventArgs e)
        {
            NewFoodScreen newFoodScreen = new NewFoodScreen(_loginUser);
            newFoodScreen.Show();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pnlLunch.Visible = false;
            pnlAperatives.Visible = false;
            pnlDinner.Visible = false;
            clickedPictureBox = pictureBox2;
            type = "Breakfas";
            //RefreshBreakfastList(_loginUser, time, type);



            if (dgvBreakfast.Height == 0)
            {
                // Eğer panel kapalıysa, açmak için
                dgvBreakfast.Height = menu_height;
                dgvBreakfast.Visible = true;

                //bu panel açıldığında diğer paneller kapansın
                dgvAperatives.Visible = false;
                dgvLunch.Visible = false;
                dgvDinner.Visible = false;
            }
            else
            {
                // Eğer panel açıksa, kapatmak için
                dgvBreakfast.Height = 0;
                dgvBreakfast.Visible = false;
                pnlLunch.Visible = true;
                pnlAperatives.Visible = true;
                pnlDinner.Visible = true;

            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            pnlAperatives.Visible = false;
            pnlDinner.Visible = false;
            dgvLunch.Visible = false;
            clickedPictureBox = pictureBox4;
            type = "Lunch";
            //RefreshLunchList(_loginUser, time, type);


            if (dgvLunch.Height == 0)
            {
                // Eğer panel kapalıysa, açmak için
                dgvLunch.Height = menu_height;
                dgvLunch.Visible = true;

                dgvAperatives.Visible = false;
                dgvDinner.Visible = false;
                dgvBreakfast.Visible = false;
            }
            else
            {
                // Eğer panel açıksa, kapatmak için
                dgvLunch.Height = 0;
                dgvLunch.Visible = false;

                pnlAperatives.Visible = true;
                pnlDinner.Visible = true;

            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            pnlDinner.Visible = false;
            clickedPictureBox = pictureBox5;
            type = "Aperatives";
            //RefreshAperativesList(_loginUser, time, type);


            if (dgvAperatives.Height == 0)
            {
                // Eğer panel kapalıysa, açmak için
                dgvAperatives.Height = menu_height;
                dgvAperatives.Visible = true;

                dgvBreakfast.Visible = false;
                dgvLunch.Visible = false;
                dgvDinner.Visible = false;
            }
            else
            {
                // Eğer panel açıksa, kapatmak için
                dgvAperatives.Height = 0;
                dgvAperatives.Visible = false;
                pnlDinner.Visible = true;


            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

            clickedPictureBox = pictureBox6;
            type = "Dinner";
            //RefreshDinnerList(_loginUser, time, type);

            if (dgvDinner.Height == 0)
            {
                // Eğer panel kapalıysa, açmak için
                dgvDinner.Height = menu_height;
                dgvDinner.Visible = true;

                dgvBreakfast.Visible = false;
                dgvLunch.Visible = false;
                dgvAperatives.Visible = false;
            }
            else
            {
                // Eğer panel açıksa, kapatmak için
                dgvDinner.Height = 0;
                dgvDinner.Visible = false;


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            if (clickedPictureBox == pictureBox2)
            {
                var selectedMealType = "Breakfast";
                var selectedFood = UnitOfWork.Instance.FoodControllers.GetFood((Guid)dgvMeals.SelectedRows[0].Cells["Id"].Value);
                var selectedPortion = UnitOfWork.Instance.PortionControllers.GetPortion(cbPortions.SelectedItem as PortionVm);
                var selectedTime = dtpMealTime.Value.Date;
                var portionAmount = (int)nudPortionAmount.Value;

                type = selectedMealType;
                time = selectedTime;

                UnitOfWork.Instance.UserFoodControllers.AddUserFood(_loginUser, selectedFood, selectedPortion, selectedTime, portionAmount, selectedMealType);
                RefreshBreakfastList(_loginUser, selectedTime, selectedMealType);

            }
            else if (clickedPictureBox == pictureBox4)
            {
                var selectedMealType = "Lunch";
                var selectedFood = UnitOfWork.Instance.FoodControllers.GetFood((Guid)dgvMeals.SelectedRows[0].Cells["Id"].Value);
                var selectedPortion = UnitOfWork.Instance.PortionControllers.GetPortion(cbPortions.SelectedItem as PortionVm);
                var selectedTime = dtpMealTime.Value.Date;
                var portionAmount = (int)nudPortionAmount.Value;

                type = selectedMealType;
                time = selectedTime;

                UnitOfWork.Instance.UserFoodControllers.AddUserFood(_loginUser, selectedFood, selectedPortion, selectedTime, portionAmount, selectedMealType);
                RefreshLunchList(_loginUser, selectedTime, selectedMealType);



            }
            else if (clickedPictureBox == pictureBox5)
            {
                var selectedMealType = "Aperatives";
                var selectedFood = UnitOfWork.Instance.FoodControllers.GetFood((Guid)dgvMeals.SelectedRows[0].Cells["Id"].Value);
                var selectedPortion = UnitOfWork.Instance.PortionControllers.GetPortion(cbPortions.SelectedItem as PortionVm);
                var selectedTime = dtpMealTime.Value.Date;
                var portionAmount = (int)nudPortionAmount.Value;

                type = selectedMealType;
                time = selectedTime;

                UnitOfWork.Instance.UserFoodControllers.AddUserFood(_loginUser, selectedFood, selectedPortion, selectedTime, portionAmount, selectedMealType);
                RefreshAperativesList(_loginUser, selectedTime, selectedMealType);



            }
            else if (clickedPictureBox == pictureBox6)
            {
                var selectedMealType = "Dinner";
                var selectedFood = UnitOfWork.Instance.FoodControllers.GetFood((Guid)dgvMeals.SelectedRows[0].Cells["Id"].Value);
                var selectedPortion = UnitOfWork.Instance.PortionControllers.GetPortion(cbPortions.SelectedItem as PortionVm);
                var selectedTime = dtpMealTime.Value.Date;
                var portionAmount = (int)nudPortionAmount.Value;

                type = selectedMealType;
                time = selectedTime;

                UnitOfWork.Instance.UserFoodControllers.AddUserFood(_loginUser, selectedFood, selectedPortion, selectedTime, portionAmount, selectedMealType);
                RefreshDinnerList(_loginUser, selectedTime, selectedMealType);

            }


        }

        private void RefreshDinnerList(FitFusion.Entity.NewEntity.User user, DateTime selectedTime, string mealType)
        {
            dgvDinner.DataSource = null;
            dgvDinner.DataSource = UnitOfWork.Instance.UserFoodControllers.GetMealUserFoods(user, mealType, selectedTime.Date);
            dgvDinner.Columns["Id"].Visible = false;
        }

        private void RefreshAperativesList(FitFusion.Entity.NewEntity.User user, DateTime selectedTime, string mealType)
        {
            dgvAperatives.DataSource = null;
            dgvAperatives.DataSource = UnitOfWork.Instance.UserFoodControllers.GetMealUserFoods(user, mealType, selectedTime.Date);
            dgvAperatives.Columns["Id"].Visible = false;
        }

        private void RefreshLunchList(FitFusion.Entity.NewEntity.User user, DateTime selectedTime, string mealType)
        {
            dgvLunch.DataSource = null;
            dgvLunch.DataSource = UnitOfWork.Instance.UserFoodControllers.GetMealUserFoods(user, mealType, selectedTime.Date);
            dgvLunch.Columns["Id"].Visible = false;
        }

        private void RefreshBreakfastList(FitFusion.Entity.NewEntity.User user, DateTime selectedTime, string mealType)
        {
            dgvBreakfast.DataSource = null;
            dgvBreakfast.DataSource = UnitOfWork.Instance.UserFoodControllers.GetMealUserFoods(user, mealType, selectedTime.Date);
            dgvBreakfast.Columns["Id"].Visible = false;
        }

        private void dtpMealTime_ValueChanged(object sender, EventArgs e)
        {
            RefreshAllMeals();
        }

        private void RefreshAllMeals()
        {
            string mealTypeAperatives = "Aperatives";
            string mealTypeLunchs = "Lunch";
            string mealTypeBreakfast = "Breakfast";
            string mealTypeDinner = "Dinner";
            RefreshAperativesList(_loginUser, dtpMealTime.Value.Date, mealTypeAperatives);
            RefreshBreakfastList(_loginUser, dtpMealTime.Value.Date, mealTypeBreakfast);
            RefreshDinnerList(_loginUser, dtpMealTime.Value.Date, mealTypeDinner);
            RefreshLunchList(_loginUser, dtpMealTime.Value.Date, mealTypeLunchs);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (clickedPictureBox == pictureBox2)
            {
                var selectedId = (Guid)dgvBreakfast.SelectedRows[0].Cells["Id"].Value;
                UnitOfWork.Instance.UserFoodControllers.RemoveUserFood(selectedId);
            }
            else if (clickedPictureBox == pictureBox4)
            {
                var selectedId = (Guid)dgvLunch.SelectedRows[0].Cells["Id"].Value;
                UnitOfWork.Instance.UserFoodControllers.RemoveUserFood(selectedId);
            }
            else if (clickedPictureBox == pictureBox5)
            {
                var selectedId = (Guid)dgvAperatives.SelectedRows[0].Cells["Id"].Value;
                UnitOfWork.Instance.UserFoodControllers.RemoveUserFood(selectedId);
            }
            else if (clickedPictureBox == pictureBox6)
            {
                var selectedId = (Guid)dgvDinner.SelectedRows[0].Cells["Id"].Value;
                UnitOfWork.Instance.UserFoodControllers.RemoveUserFood(selectedId);
            }
            RefreshAllMeals();
        }

        private void dgvMeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var bytes = UnitOfWork.Instance.FoodControllers.GetFood((Guid)dgvMeals.SelectedRows[0].Cells["Id"].Value).ImageData;
            Image image = UnitOfWork.Instance.FoodControllers.ConvertBytesToImage(bytes);
            pbFoodPicture.Image = image;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvMeals.DataSource = null;
            dgvMeals.DataSource = UnitOfWork.Instance.FoodControllers.GetSearchedFoods(txtSearch.Text);
            dgvMeals.Columns["Id"].Visible = false;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }
    }
}
