using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FitFusion.Entity.NewEntity;
using FitFusion.Presentation;
using RestSharp;
using Newtonsoft.Json;
using FitFusion.Presentation.AI;



namespace FitSecretProject.Presentation;

public partial class AnalyzeScreen : Form
{
    private Point[] caloriePoints;
    private readonly User _loginUser;
    private readonly FitFusionAnalyzer _analysisResult;
    public AnalyzeScreen(User user)
    {
        InitializeComponent();
        pnlSidebar.BackColor = Color.FromArgb(160, 196, 157);
        pnlHeader.BackColor = Color.FromArgb(160, 196, 157);
        _loginUser = user;

        this.Paint += new PaintEventHandler(AnalyzeScreen_Load);

        dgvUserMealList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvUserMealList.AutoResizeColumns();


        _analysisResult = new FitFusionAnalyzer();

    }

    double fat = 1;
    double carbonhydrat = 1;
    double protein = 1;
    int calories;




    private void AnalyzeScreen_Load(object sender, EventArgs e)
    {
        this.BackColor = Color.FromArgb(247, 255, 229);
        dgvUserMealList.BackgroundColor = Color.FromArgb(225, 236, 200);
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

        float total = (float)(fat + carbonhydrat + protein);

        float startAngle = 0;
        float[] angles = new float[] { (float)(protein / total) * 360, (float)(carbonhydrat / total) * 360, (float)(fat / total) * 360 };

        Brush[] brushes = new Brush[] { Brushes.LightGreen, Brushes.LightBlue, Brushes.Pink }; // Colors for each segment

        for (int i = 0; i < angles.Length; i++)
        {
            float sweepAngle = angles[i];
            e.Graphics.FillPie(brushes[i], 50, 50, 200, 200, startAngle, sweepAngle);
            startAngle += sweepAngle;
        }
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        LoginScreen loginScreen = new LoginScreen();
        loginScreen.Show();
        this.Close();
    }

    private void btnCompare_Click(object sender, EventArgs e)
    {
        CompareScreen compareScreen = new CompareScreen(_loginUser);
        compareScreen.Show();
        this.Close();
    }

    private void btnAddfood_Click(object sender, EventArgs e)
    {

        MeScreen meScreen = new MeScreen(_loginUser);
        meScreen.Show();
        this.Close();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

        MainScreen mainScreen = new MainScreen(_loginUser);
        mainScreen.Show();
        this.Close();
    }


    private async void dtpAnalyzTime_ValueChanged(object sender, EventArgs e)
    {
        DrawChart();
        RefreshUserMealList();
        lblAiAnalysis.Text = $"{dtpAnalyzTime.Value.Day} tarihinde toplam tüketiminiz;\n {calories} Kalori\n {protein} Protein\n {fat} Yağ\n {carbonhydrat} Karbonhidrat. Bu değerlere göre tavsiyeleriniz yaz.";

        //yapay zeka 
        //lblYapay.Text= await _analysisResult.GenerateContentAsync(lblAiAnalysis.Text);

        string output = await _analysisResult.SendRequestAndGetResponse(lblAiAnalysis.Text);
        output = output.Replace("\\n", Environment.NewLine)
                           .Replace("\n", "")
                           .Replace("**", "");

        rtbYapay.Text = output;

    }

    private void RefreshUserMealList()
    {
        dgvUserMealList.DataSource = null;
        dgvUserMealList.DataSource = UnitOfWork.Instance.UserMealControllers.GetUserMealVms(_loginUser, dtpAnalyzTime.Value.Date);
        dgvUserMealList.Columns["Id"].Visible = false;
    }

    private void DrawChart()
    {
        // Seçilen tarih için verileri al
        (calories, fat, protein, carbonhydrat) = UnitOfWork.Instance.UserFoodControllers.GetSelectedTimeUserFoods(_loginUser, dtpAnalyzTime.Value.Date);
        var total = fat + protein + carbonhydrat;

        // Grafik çizimini temizle
        panel2.Invalidate();

        using (Graphics g = panel2.CreateGraphics())
        {
            float startAngle = 0; // Starting angle
            float[] angles = new float[] { (float)(protein / total) * 360, (float)(fat / total) * 360, (float)(carbonhydrat / total) * 360 };

            Brush[] brushes = new Brush[] { Brushes.LightGreen, Brushes.LightBlue, Brushes.Pink }; // Colors for each segment

            for (int i = 0; i < angles.Length; i++)
            {
                float sweepAngle = angles[i];
                g.FillPie(brushes[i], 50, 50, 200, 200, startAngle, sweepAngle);
                startAngle += sweepAngle;
            }
        }

    }

   
}
