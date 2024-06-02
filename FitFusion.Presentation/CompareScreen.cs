
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


namespace FitSecretProject.Presentation;

public partial class CompareScreen : Form
{
    private readonly User _loginUser;
    public CompareScreen(User loginUser)
    {
        InitializeComponent();
        //background colors
        pnlSidebar.BackColor = Color.FromArgb(160, 196, 157);
        pnlHeader.BackColor = Color.FromArgb(160, 196, 157);
        dgvCompare.BackgroundColor = Color.FromArgb(225, 236, 200);
        lblTitle.ForeColor = Color.FromArgb(160, 196, 157);
        lblMostEatenDishes.ForeColor = Color.FromArgb(160, 196, 157);
        lblMostDishes.ForeColor = Color.FromArgb(160, 196, 157);
        dgvFoodsReports.BackgroundColor = Color.FromArgb(225, 236, 200);
        dgvMealsFoodReports.BackgroundColor = Color.FromArgb(225, 236, 200);

        _loginUser = loginUser;
        cbMealTypes.SelectedIndex = 0;
        // material skin 3rd party component

        dgvFoodsReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvFoodsReports.AutoResizeColumns();

        dgvMealsFoodReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvMealsFoodReports.AutoResizeColumns();

        dgvCompare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCompare.AutoResizeColumns();

        List<string> mailList = new List<string> { "Breakfast", "Lunch", "Aperatives", "Dinner" };
        cbMealTypes.DataSource = null;
        cbMealTypes.DataSource=mailList;


        lblMainname.Text = _loginUser.FirstName + " " + _loginUser.LastName;
    }



    private void CompareScreen_Load(object sender, EventArgs e)
    {
        this.BackColor = Color.FromArgb(247, 255, 229);
        RefreshSelectedFoodList();
        RefreshFoodReportsList();
        RefreshMealsFoodReportsList();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        this.Close();
        LoginScreen loginScreen = new LoginScreen();
        loginScreen.Show();
    }

    private void btnAddfood_Click(object sender, EventArgs e)
    {

        MeScreen meScreen = new MeScreen(_loginUser);
        meScreen.Show();
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

    private void cbMealTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
        RefreshSelectedFoodList();
        RefreshMealsFoodReportsList();
    }

    private void RefreshSelectedFoodList()
    {
        var selectedFirstDate = dtpSelectedFirst.Value.Date;
        var selectedSecondDate = dtpSelectedSecond.Value.Date;
        var selectedMealType = cbMealTypes.SelectedText.ToString();

        dgvCompare.DataSource = null;
        dgvCompare.DataSource = UnitOfWork.Instance.UserMealControllers.GetAllUserReports(selectedFirstDate, selectedSecondDate, selectedMealType);
    }

    private void dtpSelectedFirst_ValueChanged(object sender, EventArgs e)
    {
        RefreshSelectedFoodList();
        RefreshFoodReportsList();
        RefreshMealsFoodReportsList();
    }

    private void RefreshMealsFoodReportsList()
    {
        var selectedFirstDate = dtpSelectedFirst.Value.Date;
        var selectedSecondDate = dtpSelectedSecond.Value.Date;
        var selectedMealType = cbMealTypes.SelectedItem.ToString();

        dgvMealsFoodReports.DataSource = null;
        dgvMealsFoodReports.DataSource = UnitOfWork.Instance.UserFoodControllers.GetAllFoodsReports(selectedFirstDate, selectedSecondDate, selectedMealType);
        dgvMealsFoodReports.Columns["FoodId"].Visible = false;

    }

    private void RefreshFoodReportsList()
    {
        var selectedFirstDate = dtpSelectedFirst.Value.Date;
        var selectedSecondDate = dtpSelectedSecond.Value.Date;
        

        dgvFoodsReports.DataSource = null;
        dgvFoodsReports.DataSource = UnitOfWork.Instance.UserFoodControllers.GetAllFoodsReports(selectedFirstDate,selectedSecondDate);

        dgvFoodsReports.Columns["FoodId"].Visible = false;
    }

    private void dtpSelectedSecond_ValueChanged(object sender, EventArgs e)
    {
        RefreshSelectedFoodList();
        RefreshFoodReportsList();
        RefreshMealsFoodReportsList();
    }
}
