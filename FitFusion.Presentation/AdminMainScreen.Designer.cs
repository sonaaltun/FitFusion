namespace FitSecretProject.Presentation
{
    partial class AdminMainScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainScreen));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            imgQuit = new PictureBox();
            lblHeader = new Label();
            gbFood = new GroupBox();
            lblFoodCategoryName = new Label();
            cbFoodCategories = new ComboBox();
            btnSelectPicture = new Button();
            label3 = new Label();
            dgvFoodList = new DataGridView();
            cmsFood = new ContextMenuStrip(components);
            uPDATEToolStripMenuItem = new ToolStripMenuItem();
            dELETEToolStripMenuItem = new ToolStripMenuItem();
            nudCarbonhydrat = new NumericUpDown();
            lblCarbonhydrat = new Label();
            nudFat = new NumericUpDown();
            nudProtein = new NumericUpDown();
            nudCalories = new NumericUpDown();
            lblFat = new Label();
            btnUpdateFood = new Button();
            btnAddFood = new Button();
            lblProtein = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFoodName = new TextBox();
            gbCategory = new GroupBox();
            rtbDescription = new RichTextBox();
            lblDescription = new Label();
            dgvCategoryList = new DataGridView();
            cmsCategory = new ContextMenuStrip(components);
            uPDATEToolStripMenuItem1 = new ToolStripMenuItem();
            dELETEToolStripMenuItem1 = new ToolStripMenuItem();
            btnUpdateCategory = new Button();
            lblCategoryName = new Label();
            btnAddCategory = new Button();
            txtCategoryName = new TextBox();
            gPortion = new GroupBox();
            nudPortionAmount = new NumericUpDown();
            btnUpdatePortion = new Button();
            dgvPortionList = new DataGridView();
            cmsPortion = new ContextMenuStrip(components);
            uPDATEToolStripMenuItem2 = new ToolStripMenuItem();
            dELETEToolStripMenuItem2 = new ToolStripMenuItem();
            btnAddPortion = new Button();
            lblPortionType = new Label();
            txtPortionType = new TextBox();
            lblPortionAmount = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgQuit).BeginInit();
            gbFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).BeginInit();
            cmsFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCarbonhydrat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProtein).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCalories).BeginInit();
            gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryList).BeginInit();
            cmsCategory.SuspendLayout();
            gPortion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPortionAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPortionList).BeginInit();
            cmsPortion.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(imgQuit);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Location = new Point(-1, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1341, 88);
            pnlHeader.TabIndex = 0;
            // 
            // imgQuit
            // 
            imgQuit.Image = (Image)resources.GetObject("imgQuit.Image");
            imgQuit.Location = new Point(1299, 15);
            imgQuit.Name = "imgQuit";
            imgQuit.Size = new Size(27, 25);
            imgQuit.SizeMode = PictureBoxSizeMode.Zoom;
            imgQuit.TabIndex = 9;
            imgQuit.TabStop = false;
            imgQuit.Click += imgQuit_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Bahnschrift SemiBold", 20F);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(29, 27);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(121, 41);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "ADMIN";
            // 
            // gbFood
            // 
            gbFood.Controls.Add(lblFoodCategoryName);
            gbFood.Controls.Add(cbFoodCategories);
            gbFood.Controls.Add(btnSelectPicture);
            gbFood.Controls.Add(label3);
            gbFood.Controls.Add(dgvFoodList);
            gbFood.Controls.Add(nudCarbonhydrat);
            gbFood.Controls.Add(lblCarbonhydrat);
            gbFood.Controls.Add(nudFat);
            gbFood.Controls.Add(nudProtein);
            gbFood.Controls.Add(nudCalories);
            gbFood.Controls.Add(lblFat);
            gbFood.Controls.Add(btnUpdateFood);
            gbFood.Controls.Add(btnAddFood);
            gbFood.Controls.Add(lblProtein);
            gbFood.Controls.Add(label2);
            gbFood.Controls.Add(label1);
            gbFood.Controls.Add(txtFoodName);
            gbFood.Font = new Font("Bahnschrift SemiBold", 9F);
            gbFood.Location = new Point(109, 96);
            gbFood.Margin = new Padding(3, 4, 3, 4);
            gbFood.Name = "gbFood";
            gbFood.Padding = new Padding(3, 4, 3, 4);
            gbFood.Size = new Size(1142, 328);
            gbFood.TabIndex = 1;
            gbFood.TabStop = false;
            gbFood.Text = "Food";
            // 
            // lblFoodCategoryName
            // 
            lblFoodCategoryName.AutoSize = true;
            lblFoodCategoryName.Font = new Font("Bahnschrift SemiBold", 10F);
            lblFoodCategoryName.ForeColor = Color.White;
            lblFoodCategoryName.Location = new Point(33, 60);
            lblFoodCategoryName.Name = "lblFoodCategoryName";
            lblFoodCategoryName.Size = new Size(120, 21);
            lblFoodCategoryName.TabIndex = 21;
            lblFoodCategoryName.Text = "Food Category";
            // 
            // cbFoodCategories
            // 
            cbFoodCategories.FormattingEnabled = true;
            cbFoodCategories.Location = new Point(156, 60);
            cbFoodCategories.Name = "cbFoodCategories";
            cbFoodCategories.Size = new Size(114, 26);
            cbFoodCategories.TabIndex = 20;
            // 
            // btnSelectPicture
            // 
            btnSelectPicture.Location = new Point(166, 249);
            btnSelectPicture.Name = "btnSelectPicture";
            btnSelectPicture.Size = new Size(86, 26);
            btnSelectPicture.TabIndex = 19;
            btnSelectPicture.Text = "SELECT";
            btnSelectPicture.UseVisualStyleBackColor = true;
            btnSelectPicture.Click += btnSelectPicture_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 249);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 18;
            label3.Text = "Food Picture";
            // 
            // dgvFoodList
            // 
            dgvFoodList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodList.ContextMenuStrip = cmsFood;
            dgvFoodList.Location = new Point(334, 27);
            dgvFoodList.Margin = new Padding(3, 4, 3, 4);
            dgvFoodList.MultiSelect = false;
            dgvFoodList.Name = "dgvFoodList";
            dgvFoodList.ReadOnly = true;
            dgvFoodList.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvFoodList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvFoodList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodList.Size = new Size(775, 262);
            dgvFoodList.TabIndex = 17;
            // 
            // cmsFood
            // 
            cmsFood.ImageScalingSize = new Size(20, 20);
            cmsFood.Items.AddRange(new ToolStripItem[] { uPDATEToolStripMenuItem, dELETEToolStripMenuItem });
            cmsFood.Name = "cmsFood";
            cmsFood.Size = new Size(133, 52);
            // 
            // uPDATEToolStripMenuItem
            // 
            uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            uPDATEToolStripMenuItem.Size = new Size(132, 24);
            uPDATEToolStripMenuItem.Text = "UPDATE";
            uPDATEToolStripMenuItem.Click += uPDATEToolStripMenuItem_Click;
            // 
            // dELETEToolStripMenuItem
            // 
            dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            dELETEToolStripMenuItem.Size = new Size(132, 24);
            dELETEToolStripMenuItem.Text = "DELETE";
            dELETEToolStripMenuItem.Click += dELETEToolStripMenuItem_Click_1;
            // 
            // nudCarbonhydrat
            // 
            nudCarbonhydrat.Location = new Point(156, 210);
            nudCarbonhydrat.Margin = new Padding(3, 4, 3, 4);
            nudCarbonhydrat.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudCarbonhydrat.Name = "nudCarbonhydrat";
            nudCarbonhydrat.Size = new Size(114, 26);
            nudCarbonhydrat.TabIndex = 14;
            // 
            // lblCarbonhydrat
            // 
            lblCarbonhydrat.AutoSize = true;
            lblCarbonhydrat.Font = new Font("Bahnschrift SemiBold", 10F);
            lblCarbonhydrat.ForeColor = Color.White;
            lblCarbonhydrat.Location = new Point(32, 210);
            lblCarbonhydrat.Name = "lblCarbonhydrat";
            lblCarbonhydrat.Size = new Size(112, 21);
            lblCarbonhydrat.TabIndex = 13;
            lblCarbonhydrat.Text = "Carbonhydrat";
            // 
            // nudFat
            // 
            nudFat.Location = new Point(157, 170);
            nudFat.Margin = new Padding(3, 4, 3, 4);
            nudFat.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudFat.Name = "nudFat";
            nudFat.Size = new Size(114, 26);
            nudFat.TabIndex = 12;
            // 
            // nudProtein
            // 
            nudProtein.Location = new Point(157, 136);
            nudProtein.Margin = new Padding(3, 4, 3, 4);
            nudProtein.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudProtein.Name = "nudProtein";
            nudProtein.Size = new Size(114, 26);
            nudProtein.TabIndex = 11;
            // 
            // nudCalories
            // 
            nudCalories.Location = new Point(157, 99);
            nudCalories.Margin = new Padding(3, 4, 3, 4);
            nudCalories.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudCalories.Name = "nudCalories";
            nudCalories.Size = new Size(114, 26);
            nudCalories.TabIndex = 10;
            // 
            // lblFat
            // 
            lblFat.AutoSize = true;
            lblFat.Font = new Font("Bahnschrift SemiBold", 10F);
            lblFat.ForeColor = Color.White;
            lblFat.Location = new Point(33, 170);
            lblFat.Name = "lblFat";
            lblFat.Size = new Size(35, 21);
            lblFat.TabIndex = 9;
            lblFat.Text = "Fat";
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.Location = new Point(176, 292);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(94, 29);
            btnUpdateFood.TabIndex = 7;
            btnUpdateFood.Text = "UPDATE";
            btnUpdateFood.UseVisualStyleBackColor = true;
            btnUpdateFood.Click += btnUpdateFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(33, 292);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 29);
            btnAddFood.TabIndex = 6;
            btnAddFood.Text = "ADD";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Font = new Font("Bahnschrift SemiBold", 10F);
            lblProtein.ForeColor = Color.White;
            lblProtein.Location = new Point(33, 136);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(65, 21);
            lblProtein.TabIndex = 5;
            lblProtein.Text = "Protein";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 99);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 3;
            label2.Text = "Calories / 100";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(156, 27);
            txtFoodName.Margin = new Padding(3, 4, 3, 4);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(114, 26);
            txtFoodName.TabIndex = 0;
            // 
            // gbCategory
            // 
            gbCategory.Controls.Add(rtbDescription);
            gbCategory.Controls.Add(lblDescription);
            gbCategory.Controls.Add(dgvCategoryList);
            gbCategory.Controls.Add(btnUpdateCategory);
            gbCategory.Controls.Add(lblCategoryName);
            gbCategory.Controls.Add(btnAddCategory);
            gbCategory.Controls.Add(txtCategoryName);
            gbCategory.Font = new Font("Bahnschrift SemiBold", 9F);
            gbCategory.Location = new Point(108, 432);
            gbCategory.Margin = new Padding(3, 4, 3, 4);
            gbCategory.Name = "gbCategory";
            gbCategory.Padding = new Padding(3, 4, 3, 4);
            gbCategory.Size = new Size(1143, 191);
            gbCategory.TabIndex = 2;
            gbCategory.TabStop = false;
            gbCategory.Text = "Category";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(167, 60);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(114, 46);
            rtbDescription.TabIndex = 18;
            rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Bahnschrift SemiBold", 10F);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(32, 70);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(95, 21);
            lblDescription.TabIndex = 17;
            lblDescription.Text = "Description";
            // 
            // dgvCategoryList
            // 
            dgvCategoryList.BorderStyle = BorderStyle.Fixed3D;
            dgvCategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoryList.ContextMenuStrip = cmsCategory;
            dgvCategoryList.Location = new Point(335, 37);
            dgvCategoryList.Margin = new Padding(3, 4, 3, 4);
            dgvCategoryList.MultiSelect = false;
            dgvCategoryList.Name = "dgvCategoryList";
            dgvCategoryList.ReadOnly = true;
            dgvCategoryList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dgvCategoryList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategoryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoryList.Size = new Size(775, 133);
            dgvCategoryList.TabIndex = 16;
            // 
            // cmsCategory
            // 
            cmsCategory.ImageScalingSize = new Size(20, 20);
            cmsCategory.Items.AddRange(new ToolStripItem[] { uPDATEToolStripMenuItem1, dELETEToolStripMenuItem1 });
            cmsCategory.Name = "cmsCategory";
            cmsCategory.Size = new Size(133, 52);
            // 
            // uPDATEToolStripMenuItem1
            // 
            uPDATEToolStripMenuItem1.Name = "uPDATEToolStripMenuItem1";
            uPDATEToolStripMenuItem1.Size = new Size(132, 24);
            uPDATEToolStripMenuItem1.Text = "UPDATE";
            uPDATEToolStripMenuItem1.Click += uPDATEToolStripMenuItem1_Click;
            // 
            // dELETEToolStripMenuItem1
            // 
            dELETEToolStripMenuItem1.Name = "dELETEToolStripMenuItem1";
            dELETEToolStripMenuItem1.Size = new Size(132, 24);
            dELETEToolStripMenuItem1.Text = "DELETE";
            dELETEToolStripMenuItem1.Click += dELETEToolStripMenuItem1_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(187, 127);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(94, 29);
            btnUpdateCategory.TabIndex = 9;
            btnUpdateCategory.Text = "UPDATE";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Bahnschrift SemiBold", 10F);
            lblCategoryName.ForeColor = Color.White;
            lblCategoryName.Location = new Point(26, 28);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(128, 21);
            lblCategoryName.TabIndex = 5;
            lblCategoryName.Text = "Category Name";
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(66, 127);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(94, 29);
            btnAddCategory.TabIndex = 8;
            btnAddCategory.Text = "ADD";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(167, 27);
            txtCategoryName.Margin = new Padding(3, 4, 3, 4);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(114, 26);
            txtCategoryName.TabIndex = 4;
            // 
            // gPortion
            // 
            gPortion.Controls.Add(nudPortionAmount);
            gPortion.Controls.Add(btnUpdatePortion);
            gPortion.Controls.Add(dgvPortionList);
            gPortion.Controls.Add(btnAddPortion);
            gPortion.Controls.Add(lblPortionType);
            gPortion.Controls.Add(txtPortionType);
            gPortion.Controls.Add(lblPortionAmount);
            gPortion.Font = new Font("Bahnschrift SemiBold", 9F);
            gPortion.Location = new Point(108, 631);
            gPortion.Margin = new Padding(3, 4, 3, 4);
            gPortion.Name = "gPortion";
            gPortion.Padding = new Padding(3, 4, 3, 4);
            gPortion.Size = new Size(1143, 191);
            gPortion.TabIndex = 3;
            gPortion.TabStop = false;
            gPortion.Text = "Portion";
            // 
            // nudPortionAmount
            // 
            nudPortionAmount.Location = new Point(167, 76);
            nudPortionAmount.Margin = new Padding(3, 5, 3, 5);
            nudPortionAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudPortionAmount.Name = "nudPortionAmount";
            nudPortionAmount.Size = new Size(114, 26);
            nudPortionAmount.TabIndex = 15;
            // 
            // btnUpdatePortion
            // 
            btnUpdatePortion.Location = new Point(159, 131);
            btnUpdatePortion.Name = "btnUpdatePortion";
            btnUpdatePortion.Size = new Size(94, 29);
            btnUpdatePortion.TabIndex = 11;
            btnUpdatePortion.Text = "UPDATE";
            btnUpdatePortion.UseVisualStyleBackColor = true;
            btnUpdatePortion.Click += btnUpdatePortion_Click;
            // 
            // dgvPortionList
            // 
            dgvPortionList.BorderStyle = BorderStyle.Fixed3D;
            dgvPortionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPortionList.ContextMenuStrip = cmsPortion;
            dgvPortionList.Location = new Point(335, 27);
            dgvPortionList.Margin = new Padding(3, 4, 3, 4);
            dgvPortionList.MultiSelect = false;
            dgvPortionList.Name = "dgvPortionList";
            dgvPortionList.ReadOnly = true;
            dgvPortionList.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dgvPortionList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPortionList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPortionList.Size = new Size(775, 133);
            dgvPortionList.TabIndex = 10;
            // 
            // cmsPortion
            // 
            cmsPortion.ImageScalingSize = new Size(20, 20);
            cmsPortion.Items.AddRange(new ToolStripItem[] { uPDATEToolStripMenuItem2, dELETEToolStripMenuItem2 });
            cmsPortion.Name = "cmsPortion";
            cmsPortion.Size = new Size(133, 52);
            // 
            // uPDATEToolStripMenuItem2
            // 
            uPDATEToolStripMenuItem2.Name = "uPDATEToolStripMenuItem2";
            uPDATEToolStripMenuItem2.Size = new Size(132, 24);
            uPDATEToolStripMenuItem2.Text = "UPDATE";
            uPDATEToolStripMenuItem2.Click += uPDATEToolStripMenuItem2_Click;
            // 
            // dELETEToolStripMenuItem2
            // 
            dELETEToolStripMenuItem2.Name = "dELETEToolStripMenuItem2";
            dELETEToolStripMenuItem2.Size = new Size(132, 24);
            dELETEToolStripMenuItem2.Text = "DELETE";
            dELETEToolStripMenuItem2.Click += dELETEToolStripMenuItem2_Click;
            // 
            // btnAddPortion
            // 
            btnAddPortion.Location = new Point(38, 131);
            btnAddPortion.Name = "btnAddPortion";
            btnAddPortion.Size = new Size(94, 29);
            btnAddPortion.TabIndex = 10;
            btnAddPortion.Text = "ADD";
            btnAddPortion.UseVisualStyleBackColor = true;
            btnAddPortion.Click += btnAddPortion_Click;
            // 
            // lblPortionType
            // 
            lblPortionType.AutoSize = true;
            lblPortionType.Font = new Font("Bahnschrift SemiBold", 10F);
            lblPortionType.ForeColor = Color.White;
            lblPortionType.Location = new Point(38, 37);
            lblPortionType.Name = "lblPortionType";
            lblPortionType.Size = new Size(102, 21);
            lblPortionType.TabIndex = 7;
            lblPortionType.Text = "Portion Type";
            // 
            // txtPortionType
            // 
            txtPortionType.Location = new Point(167, 37);
            txtPortionType.Margin = new Padding(3, 4, 3, 4);
            txtPortionType.Name = "txtPortionType";
            txtPortionType.Size = new Size(114, 26);
            txtPortionType.TabIndex = 6;
            // 
            // lblPortionAmount
            // 
            lblPortionAmount.AutoSize = true;
            lblPortionAmount.Font = new Font("Bahnschrift SemiBold", 10F);
            lblPortionAmount.ForeColor = Color.White;
            lblPortionAmount.Location = new Point(38, 76);
            lblPortionAmount.Name = "lblPortionAmount";
            lblPortionAmount.Size = new Size(69, 21);
            lblPortionAmount.TabIndex = 9;
            lblPortionAmount.Text = "Amount";
            // 
            // AdminMainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 900);
            Controls.Add(gPortion);
            Controls.Add(gbCategory);
            Controls.Add(gbFood);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainScreen";
            Load += AdminMainScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgQuit).EndInit();
            gbFood.ResumeLayout(false);
            gbFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).EndInit();
            cmsFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCarbonhydrat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProtein).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCalories).EndInit();
            gbCategory.ResumeLayout(false);
            gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryList).EndInit();
            cmsCategory.ResumeLayout(false);
            gPortion.ResumeLayout(false);
            gPortion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPortionAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPortionList).EndInit();
            cmsPortion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private GroupBox gbFood;
        private Label label2;
        private Label label1;
        private TextBox txtFoodName;
        private GroupBox gbCategory;
        private GroupBox gPortion;
        private Label lblProtein;
        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private Label lblPortionType;
        private TextBox txtPortionType;
        private Label lblPortionAmount;
        private TextBox textBox6;
        private DataGridView dgvFoods;
        private PictureBox imgQuit;
        private Button btnAddFood;
        private Button btnUpdateFood;
        private DataGridView dataGridView1;
        private Button btnUpdateCategory;
        private Button btnAddCategory;
        private NumericUpDown nudCarbonhydrat;
        private Label lblCarbonhydrat;
        private NumericUpDown nudFat;
        private NumericUpDown nudProtein;
        private NumericUpDown nudCalories;
        private Label lblFat;
        private Button btnUpdatePortion;
        private DataGridView dgvPortionList;
        private Button btnAddPortion;
        private NumericUpDown nudPortionAmount;
        private DataGridView dgvFoodList;
        private DataGridView dgvCategoryList;
        private Button btnSelectPicture;
        private Label label3;
        private Label lblFoodCategoryName;
        private ComboBox cbFoodCategories;
        private RichTextBox rtbDescription;
        private Label lblDescription;
        private ContextMenuStrip cmsFood;
        private ToolStripMenuItem uPDATEToolStripMenuItem;
        private ToolStripMenuItem dELETEToolStripMenuItem;
        private ContextMenuStrip cmsCategory;
        private ToolStripMenuItem uPDATEToolStripMenuItem1;
        private ToolStripMenuItem dELETEToolStripMenuItem1;
        private ContextMenuStrip cmsPortion;
        private ToolStripMenuItem uPDATEToolStripMenuItem2;
        private ToolStripMenuItem dELETEToolStripMenuItem2;
    }
}