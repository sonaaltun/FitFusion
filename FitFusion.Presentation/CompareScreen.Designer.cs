namespace FitSecretProject.Presentation
{
    partial class CompareScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompareScreen));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAddfood = new Button();
            label1 = new Label();
            lblMainname = new Label();
            label2 = new Label();
            btnContact = new Button();
            btnAnalyze = new Button();
            btnCompare = new Button();
            pictureBox1 = new PictureBox();
            pnlSidebar = new Panel();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            dgvCompare = new DataGridView();
            pnlHeader = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            lblTitle = new Label();
            cbMealTypes = new ComboBox();
            dtpSelectedFirst = new DateTimePicker();
            dtpSelectedSecond = new DateTimePicker();
            dgvMealsFoodReports = new DataGridView();
            dgvFoodsReports = new DataGridView();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblMostEatenDishes = new Label();
            lblMostDishes = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompare).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMealsFoodReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodsReports).BeginInit();
            SuspendLayout();
            // 
            // btnAddfood
            // 
            btnAddfood.FlatAppearance.BorderColor = Color.OliveDrab;
            btnAddfood.FlatStyle = FlatStyle.Popup;
            btnAddfood.Font = new Font("Bahnschrift SemiBold", 9F);
            btnAddfood.ForeColor = Color.White;
            btnAddfood.Location = new Point(38, 379);
            btnAddfood.Name = "btnAddfood";
            btnAddfood.Size = new Size(231, 52);
            btnAddfood.TabIndex = 22;
            btnAddfood.Text = "ME";
            btnAddfood.UseVisualStyleBackColor = true;
            btnAddfood.Click += btnAddfood_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 9F);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(11, 4);
            label1.Name = "label1";
            label1.Size = new Size(42, 14);
            label1.TabIndex = 10;
            label1.Text = "Profile";
            // 
            // lblMainname
            // 
            lblMainname.AutoSize = true;
            lblMainname.Font = new Font("Bahnschrift SemiBold", 10F);
            lblMainname.ForeColor = Color.White;
            lblMainname.Location = new Point(105, 324);
            lblMainname.Name = "lblMainname";
            lblMainname.Size = new Size(54, 21);
            lblMainname.TabIndex = 20;
            lblMainname.Text = "Guest";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(113, 284);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 19;
            label2.Text = "Hello, ";
            // 
            // btnContact
            // 
            btnContact.FlatStyle = FlatStyle.Popup;
            btnContact.Font = new Font("Bahnschrift SemiBold", 9F);
            btnContact.ForeColor = Color.White;
            btnContact.Location = new Point(38, 619);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(231, 52);
            btnContact.TabIndex = 18;
            btnContact.Text = "CONTACT US";
            btnContact.UseVisualStyleBackColor = true;
            // 
            // btnAnalyze
            // 
            btnAnalyze.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnAnalyze.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnAnalyze.FlatStyle = FlatStyle.Popup;
            btnAnalyze.Font = new Font("Bahnschrift SemiBold", 9F);
            btnAnalyze.ForeColor = Color.White;
            btnAnalyze.Location = new Point(38, 539);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(231, 52);
            btnAnalyze.TabIndex = 17;
            btnAnalyze.Text = "ANALYZE";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnCompare
            // 
            btnCompare.FlatAppearance.BorderColor = Color.OliveDrab;
            btnCompare.FlatStyle = FlatStyle.Popup;
            btnCompare.Font = new Font("Bahnschrift SemiBold", 9F);
            btnCompare.ForeColor = Color.White;
            btnCompare.Location = new Point(38, 456);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(231, 52);
            btnCompare.TabIndex = 16;
            btnCompare.Text = "COMPARE";
            btnCompare.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FitFusion.Presentation.Properties.Resources.user__3_;
            pictureBox1.Location = new Point(53, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(pictureBox3);
            pnlSidebar.Controls.Add(panel1);
            pnlSidebar.Controls.Add(btnAddfood);
            pnlSidebar.Controls.Add(lblMainname);
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(btnContact);
            pnlSidebar.Controls.Add(btnAnalyze);
            pnlSidebar.Controls.Add(btnCompare);
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Location = new Point(0, -3);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(306, 903);
            pnlSidebar.TabIndex = 23;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 824);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(98, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(105, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(83, 29);
            panel1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 11F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 10;
            label3.Text = "Profile";
            // 
            // dgvCompare
            // 
            dgvCompare.BorderStyle = BorderStyle.Fixed3D;
            dgvCompare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompare.Location = new Point(791, 273);
            dgvCompare.Margin = new Padding(3, 4, 3, 4);
            dgvCompare.MultiSelect = false;
            dgvCompare.Name = "dgvCompare";
            dgvCompare.ReadOnly = true;
            dgvCompare.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvCompare.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCompare.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompare.Size = new Size(495, 535);
            dgvCompare.TabIndex = 24;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pictureBox2);
            pnlHeader.Controls.Add(label4);
            pnlHeader.Location = new Point(304, -3);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1035, 173);
            pnlHeader.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(983, 19);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 20F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 59);
            label4.Name = "label4";
            label4.Size = new Size(170, 41);
            label4.TabIndex = 0;
            label4.Text = "COMPARE";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Bahnschrift SemiBold", 12F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(791, 235);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 24);
            lblTitle.TabIndex = 26;
            lblTitle.Text = "Leader Table";
            // 
            // cbMealTypes
            // 
            cbMealTypes.FlatStyle = FlatStyle.Popup;
            cbMealTypes.FormattingEnabled = true;
            cbMealTypes.Items.AddRange(new object[] { "Breakfast", "Lunch", "Apperatives", "Dinner" });
            cbMealTypes.Location = new Point(584, 239);
            cbMealTypes.Name = "cbMealTypes";
            cbMealTypes.Size = new Size(124, 28);
            cbMealTypes.TabIndex = 27;
            cbMealTypes.SelectedIndexChanged += cbMealTypes_SelectedIndexChanged;
            // 
            // dtpSelectedFirst
            // 
            dtpSelectedFirst.Format = DateTimePickerFormat.Short;
            dtpSelectedFirst.Location = new Point(1168, 205);
            dtpSelectedFirst.Name = "dtpSelectedFirst";
            dtpSelectedFirst.Size = new Size(118, 27);
            dtpSelectedFirst.TabIndex = 29;
            dtpSelectedFirst.ValueChanged += dtpSelectedFirst_ValueChanged;
            // 
            // dtpSelectedSecond
            // 
            dtpSelectedSecond.Format = DateTimePickerFormat.Short;
            dtpSelectedSecond.Location = new Point(1168, 239);
            dtpSelectedSecond.Name = "dtpSelectedSecond";
            dtpSelectedSecond.Size = new Size(118, 27);
            dtpSelectedSecond.TabIndex = 30;
            dtpSelectedSecond.ValueChanged += dtpSelectedSecond_ValueChanged;
            // 
            // dgvMealsFoodReports
            // 
            dgvMealsFoodReports.BorderStyle = BorderStyle.Fixed3D;
            dgvMealsFoodReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMealsFoodReports.Location = new Point(337, 273);
            dgvMealsFoodReports.Name = "dgvMealsFoodReports";
            dgvMealsFoodReports.ReadOnly = true;
            dgvMealsFoodReports.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dgvMealsFoodReports.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvMealsFoodReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMealsFoodReports.Size = new Size(371, 217);
            dgvMealsFoodReports.TabIndex = 31;
            // 
            // dgvFoodsReports
            // 
            dgvFoodsReports.BorderStyle = BorderStyle.Fixed3D;
            dgvFoodsReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodsReports.Location = new Point(337, 591);
            dgvFoodsReports.Name = "dgvFoodsReports";
            dgvFoodsReports.ReadOnly = true;
            dgvFoodsReports.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dgvFoodsReports.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvFoodsReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodsReports.Size = new Size(371, 217);
            dgvFoodsReports.TabIndex = 32;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Bahnschrift SemiBold", 9F);
            lblStartDate.Location = new Point(1081, 211);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(79, 18);
            lblStartDate.TabIndex = 33;
            lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Bahnschrift SemiBold", 9F);
            lblEndDate.Location = new Point(1081, 245);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(75, 18);
            lblEndDate.TabIndex = 34;
            lblEndDate.Text = "End Date :";
            // 
            // lblMostEatenDishes
            // 
            lblMostEatenDishes.AutoSize = true;
            lblMostEatenDishes.Font = new Font("Bahnschrift SemiBold", 11F);
            lblMostEatenDishes.ForeColor = Color.White;
            lblMostEatenDishes.Location = new Point(337, 239);
            lblMostEatenDishes.Name = "lblMostEatenDishes";
            lblMostEatenDishes.Size = new Size(234, 23);
            lblMostEatenDishes.TabIndex = 35;
            lblMostEatenDishes.Text = "Most Eaten Dishes in Meal";
            // 
            // lblMostDishes
            // 
            lblMostDishes.AutoSize = true;
            lblMostDishes.Font = new Font("Bahnschrift SemiBold", 11F);
            lblMostDishes.ForeColor = Color.White;
            lblMostDishes.Location = new Point(337, 557);
            lblMostDishes.Name = "lblMostDishes";
            lblMostDishes.Size = new Size(167, 23);
            lblMostDishes.TabIndex = 36;
            lblMostDishes.Text = "Most Eaten Dishes";
            // 
            // CompareScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 900);
            Controls.Add(lblMostDishes);
            Controls.Add(lblMostEatenDishes);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblTitle);
            Controls.Add(dgvFoodsReports);
            Controls.Add(dgvMealsFoodReports);
            Controls.Add(dtpSelectedSecond);
            Controls.Add(dtpSelectedFirst);
            Controls.Add(cbMealTypes);
            Controls.Add(pnlHeader);
            Controls.Add(dgvCompare);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CompareScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompareScreen";
            Load += CompareScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompare).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMealsFoodReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodsReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddfood;
        
        private Label label1;
        private Label lblMainname;
        private Label label2;
        private Button btnContact;
        private Button btnAnalyze;
        private Button btnCompare;
        private PictureBox pictureBox1;
        private Panel pnlSidebar;
       
        private DataGridView dgvCompare;
        private Panel pnlHeader;
        private Panel panel1;
        private Label label3;
        private Label lblTitle;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox2;
        private ComboBox cbMealTypes;
        private DateTimePicker dtpSelectedFirst;
        private DateTimePicker dtpSelectedSecond;
        private DataGridView dgvMealsFoodReports;
        private DataGridView dgvFoodsReports;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblMostEatenDishes;
        private Label lblMostDishes;
    }
}