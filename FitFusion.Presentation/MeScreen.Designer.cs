namespace FitSecretProject.Presentation
{
    partial class MeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeScreen));
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            lblMainname = new Label();
            pictureBox1 = new PictureBox();
            btnAddfood = new Button();
            btnContact = new Button();
            btnAnalyze = new Button();
            btnCompare = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblMessage = new Label();
            btnOk = new Button();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 611);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(86, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(lblMainname);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnAddfood);
            panel2.Controls.Add(btnContact);
            panel2.Controls.Add(btnAnalyze);
            panel2.Controls.Add(btnCompare);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 674);
            panel2.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(86, 185);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(73, 23);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 4);
            label1.Name = "label1";
            label1.Size = new Size(42, 14);
            label1.TabIndex = 10;
            label1.Text = "Profile";
            // 
            // lblMainname
            // 
            lblMainname.AutoSize = true;
            lblMainname.Font = new Font("Bahnschrift SemiBold", 9F);
            lblMainname.ForeColor = Color.White;
            lblMainname.Location = new Point(103, 226);
            lblMainname.Name = "lblMainname";
            lblMainname.Size = new Size(38, 14);
            lblMainname.TabIndex = 25;
            lblMainname.Text = "Guest";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FitFusion.Presentation.Properties.Resources.user__3_;
            pictureBox1.Location = new Point(44, 46);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // btnAddfood
            // 
            btnAddfood.FlatAppearance.BorderColor = Color.OliveDrab;
            btnAddfood.FlatStyle = FlatStyle.Popup;
            btnAddfood.Font = new Font("Bahnschrift SemiBold", 9F);
            btnAddfood.ForeColor = Color.White;
            btnAddfood.Location = new Point(34, 280);
            btnAddfood.Margin = new Padding(3, 2, 3, 2);
            btnAddfood.Name = "btnAddfood";
            btnAddfood.Size = new Size(202, 39);
            btnAddfood.TabIndex = 23;
            btnAddfood.Text = "ME";
            btnAddfood.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            btnContact.FlatStyle = FlatStyle.Popup;
            btnContact.Font = new Font("Bahnschrift SemiBold", 9F);
            btnContact.ForeColor = Color.White;
            btnContact.Location = new Point(34, 460);
            btnContact.Margin = new Padding(3, 2, 3, 2);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(202, 39);
            btnContact.TabIndex = 22;
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
            btnAnalyze.Location = new Point(34, 400);
            btnAnalyze.Margin = new Padding(3, 2, 3, 2);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(202, 39);
            btnAnalyze.TabIndex = 21;
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
            btnCompare.Location = new Point(34, 338);
            btnCompare.Margin = new Padding(3, 2, 3, 2);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(202, 39);
            btnCompare.TabIndex = 20;
            btnCompare.Text = "COMPARE";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(267, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 94);
            panel3.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(859, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 16);
            label2.Name = "label2";
            label2.Size = new Size(52, 33);
            label2.TabIndex = 0;
            label2.Text = "ME";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMessage);
            groupBox1.Controls.Add(btnOk);
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(txtWeight);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Bahnschrift SemiBold", 15F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(312, 134);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(674, 251);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Body Mass Index";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Bahnschrift SemiBold", 10F);
            lblMessage.ForeColor = Color.Black;
            lblMessage.Location = new Point(309, 48);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(39, 17);
            lblMessage.TabIndex = 5;
            lblMessage.Text = "label";
            lblMessage.Visible = false;
            // 
            // btnOk
            // 
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.Font = new Font("Bahnschrift SemiBold", 10F);
            btnOk.Location = new Point(153, 130);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(82, 22);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtHeight
            // 
            txtHeight.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtHeight.BorderStyle = BorderStyle.None;
            txtHeight.Font = new Font("Bahnschrift SemiBold", 10F);
            txtHeight.Location = new Point(126, 77);
            txtHeight.Margin = new Padding(3, 2, 3, 2);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(109, 17);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtWeight.BorderStyle = BorderStyle.None;
            txtWeight.Font = new Font("Bahnschrift SemiBold", 10F);
            txtWeight.Location = new Point(126, 48);
            txtWeight.Margin = new Padding(3, 2, 3, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(109, 17);
            txtWeight.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 75);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 1;
            label4.Text = "Height : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 48);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 0;
            label3.Text = "Weight :";
            // 
            // MeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 675);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MeScreen";
            Load += MeScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button btnAddfood;
        private Button btnContact;
        private Button btnAnalyze;
        private Button btnCompare;
        private Panel panel1;
        private Label label1;
        private Label lblMainname;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox txtWeight;
        private Label lblMessage;
        private Button btnOk;
        private TextBox txtHeight;
        private PictureBox pictureBox2;
    }
}