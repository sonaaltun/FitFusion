namespace FitSecretProject.Presentation
{
    partial class AnalyzeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzeScreen));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAddfood = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lblMainname = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            btnContact = new Button();
            btnAnalyze = new Button();
            btnCompare = new Button();
            pictureBox1 = new PictureBox();
            pnlSidebar = new Panel();
            pnlHeader = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            lblFat = new Label();
            lblCarbon = new Label();
            lblProtein = new Label();
            dgvUserMealList = new DataGridView();
            dtpAnalyzTime = new DateTimePicker();
            rtbYapay = new RichTextBox();
            lblAiAnalysis = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserMealList).BeginInit();
            SuspendLayout();
            // 
            // btnAddfood
            // 
            btnAddfood.FlatAppearance.BorderColor = Color.OliveDrab;
            btnAddfood.FlatStyle = FlatStyle.Popup;
            btnAddfood.Font = new Font("Bahnschrift SemiBold", 9F);
            btnAddfood.ForeColor = Color.Ivory;
            btnAddfood.Location = new Point(38, 428);
            btnAddfood.Name = "btnAddfood";
            btnAddfood.Size = new Size(231, 52);
            btnAddfood.TabIndex = 23;
            btnAddfood.Text = "ME";
            btnAddfood.UseVisualStyleBackColor = true;
            btnAddfood.Click += btnAddfood_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(102, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(83, 29);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 10;
            label1.Text = "Profile";
            // 
            // lblMainname
            // 
            lblMainname.AutoSize = true;
            lblMainname.Font = new Font("Bahnschrift SemiBold", 12F);
            lblMainname.ForeColor = Color.White;
            lblMainname.Location = new Point(113, 348);
            lblMainname.Name = "lblMainname";
            lblMainname.Size = new Size(62, 24);
            lblMainname.TabIndex = 21;
            lblMainname.Text = "Guest";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(113, 303);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 20;
            label2.Text = "Hello, ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 821);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(98, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnContact
            // 
            btnContact.FlatStyle = FlatStyle.Popup;
            btnContact.Font = new Font("Bahnschrift SemiBold", 9F);
            btnContact.ForeColor = Color.Ivory;
            btnContact.Location = new Point(38, 668);
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
            btnAnalyze.ForeColor = Color.Ivory;
            btnAnalyze.Location = new Point(38, 588);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(231, 52);
            btnAnalyze.TabIndex = 17;
            btnAnalyze.Text = "ANALYZE";
            btnAnalyze.UseVisualStyleBackColor = true;
            // 
            // btnCompare
            // 
            btnCompare.FlatAppearance.BorderColor = Color.OliveDrab;
            btnCompare.FlatStyle = FlatStyle.Popup;
            btnCompare.Font = new Font("Bahnschrift SemiBold", 9F);
            btnCompare.ForeColor = Color.Ivory;
            btnCompare.Location = new Point(38, 505);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(231, 52);
            btnCompare.TabIndex = 16;
            btnCompare.Text = "COMPARE";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FitFusion.Presentation.Properties.Resources.user__3_;
            pictureBox1.Location = new Point(53, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(pictureBox3);
            pnlSidebar.Controls.Add(btnAddfood);
            pnlSidebar.Controls.Add(panel1);
            pnlSidebar.Controls.Add(lblMainname);
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(btnContact);
            pnlSidebar.Controls.Add(btnAnalyze);
            pnlSidebar.Controls.Add(btnCompare);
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Location = new Point(0, -3);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(306, 905);
            pnlSidebar.TabIndex = 24;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pictureBox2);
            pnlHeader.Controls.Add(label3);
            pnlHeader.Location = new Point(305, -3);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1035, 153);
            pnlHeader.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(982, 19);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 20F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 51);
            label3.Name = "label3";
            label3.Size = new Size(158, 41);
            label3.TabIndex = 0;
            label3.Text = "ANALYZE";
            // 
            // panel2
            // 
            panel2.Location = new Point(573, 439);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 463);
            panel2.TabIndex = 26;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.Location = new Point(386, 586);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(30, 31);
            button2.TabIndex = 28;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Location = new Point(386, 547);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(30, 31);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightBlue;
            button3.Location = new Point(386, 625);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(30, 31);
            button3.TabIndex = 29;
            button3.UseVisualStyleBackColor = false;
            // 
            // lblFat
            // 
            lblFat.AutoSize = true;
            lblFat.Location = new Point(421, 553);
            lblFat.Name = "lblFat";
            lblFat.Size = new Size(28, 20);
            lblFat.TabIndex = 30;
            lblFat.Text = "Fat";
            // 
            // lblCarbon
            // 
            lblCarbon.AutoSize = true;
            lblCarbon.Location = new Point(421, 631);
            lblCarbon.Name = "lblCarbon";
            lblCarbon.Size = new Size(99, 20);
            lblCarbon.TabIndex = 32;
            lblCarbon.Text = "Carbonhydrat";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Location = new Point(421, 591);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(56, 20);
            lblProtein.TabIndex = 31;
            lblProtein.Text = "Protein";
            // 
            // dgvUserMealList
            // 
            dgvUserMealList.BorderStyle = BorderStyle.Fixed3D;
            dgvUserMealList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUserMealList.DefaultCellStyle = dataGridViewCellStyle1;
            dgvUserMealList.Location = new Point(327, 156);
            dgvUserMealList.Margin = new Padding(3, 4, 3, 4);
            dgvUserMealList.MultiSelect = false;
            dgvUserMealList.Name = "dgvUserMealList";
            dgvUserMealList.ReadOnly = true;
            dgvUserMealList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dgvUserMealList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUserMealList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserMealList.Size = new Size(971, 157);
            dgvUserMealList.TabIndex = 33;
            // 
            // dtpAnalyzTime
            // 
            dtpAnalyzTime.Font = new Font("Bahnschrift SemiBold", 9F);
            dtpAnalyzTime.Format = DateTimePickerFormat.Short;
            dtpAnalyzTime.Location = new Point(327, 356);
            dtpAnalyzTime.Name = "dtpAnalyzTime";
            dtpAnalyzTime.Size = new Size(117, 26);
            dtpAnalyzTime.TabIndex = 35;
            dtpAnalyzTime.ValueChanged += dtpAnalyzTime_ValueChanged;
            // 
            // rtbYapay
            // 
            rtbYapay.BorderStyle = BorderStyle.FixedSingle;
            rtbYapay.Font = new Font("Bahnschrift SemiBold", 10F);
            rtbYapay.Location = new Point(897, 395);
            rtbYapay.Name = "rtbYapay";
            rtbYapay.Size = new Size(401, 461);
            rtbYapay.TabIndex = 38;
            rtbYapay.Text = "";
            // 
            // lblAiAnalysis
            // 
            lblAiAnalysis.AutoSize = true;
            lblAiAnalysis.Location = new Point(698, 356);
            lblAiAnalysis.Name = "lblAiAnalysis";
            lblAiAnalysis.Size = new Size(50, 20);
            lblAiAnalysis.TabIndex = 36;
            lblAiAnalysis.Text = "label4";
            lblAiAnalysis.Visible = false;
            // 
            // AnalyzeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 900);
            Controls.Add(button2);
            Controls.Add(rtbYapay);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(lblAiAnalysis);
            Controls.Add(lblFat);
            Controls.Add(dtpAnalyzTime);
            Controls.Add(lblCarbon);
            Controls.Add(dgvUserMealList);
            Controls.Add(lblProtein);
            Controls.Add(panel2);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnalyzeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnalyzeScreen";
            Load += AnalyzeScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserMealList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddfood;
        private Panel panel1;
        private Label label1;
        private Label lblMainname;
        private Label label2;
        private PictureBox pictureBox3;
        private Button btnContact;
        private Button btnAnalyze;
        private Button btnCompare;
        private PictureBox pictureBox1;
        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Label label3;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblFat;
        private Label lblProtein;
        private Label lblCarbon;
        private DataGridView dgvUserMealList;
        private PictureBox pictureBox2;
        private DateTimePicker dtpAnalyzTime;
        private RichTextBox rtbYapay;
        private Label lblAiAnalysis;
    }
}