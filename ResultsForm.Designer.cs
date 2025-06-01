namespace Lgs_VisualProject
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.manageResultsLabel = new System.Windows.Forms.Label();
            this.addButon = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.graphicsButton = new System.Windows.Forms.Button();
            this.studentcomboBox = new System.Windows.Forms.ComboBox();
            this.studentlabel = new System.Windows.Forms.Label();
            this.mathCorrectlabel = new System.Windows.Forms.Label();
            this.mathWronglabel = new System.Windows.Forms.Label();
            this.turkishCorrectlabel = new System.Windows.Forms.Label();
            this.turkishWronglabel = new System.Windows.Forms.Label();
            this.scienceCorrectlabel = new System.Windows.Forms.Label();
            this.mathCorrecttextBox = new System.Windows.Forms.TextBox();
            this.mathWrongtextBox = new System.Windows.Forms.TextBox();
            this.scienceCorrecttextBox = new System.Windows.Forms.TextBox();
            this.scienceWrongtextBox = new System.Windows.Forms.TextBox();
            this.scienceWronglabel = new System.Windows.Forms.Label();
            this.historyCorrectlabel = new System.Windows.Forms.Label();
            this.historyWronglabel = new System.Windows.Forms.Label();
            this.religionCorrectlabel = new System.Windows.Forms.Label();
            this.englishCorrectlabel = new System.Windows.Forms.Label();
            this.religionWronglabel = new System.Windows.Forms.Label();
            this.englishWronglabel = new System.Windows.Forms.Label();
            this.turkishtextBox = new System.Windows.Forms.TextBox();
            this.turkishWrongtextBox = new System.Windows.Forms.TextBox();
            this.historyWrongtextBox = new System.Windows.Forms.TextBox();
            this.religionCorrecttextBox = new System.Windows.Forms.TextBox();
            this.historyCorrecttextBox = new System.Windows.Forms.TextBox();
            this.religionWrongtextBox = new System.Windows.Forms.TextBox();
            this.englishWrongtextBox = new System.Windows.Forms.TextBox();
            this.englishCorrecttextBox = new System.Windows.Forms.TextBox();
            this.examNamelabel = new System.Windows.Forms.Label();
            this.examcomboBox = new System.Windows.Forms.ComboBox();
            this.pdfbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(808, 109);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersWidth = 51;
            this.resultsDataGridView.RowTemplate.Height = 24;
            this.resultsDataGridView.Size = new System.Drawing.Size(953, 300);
            this.resultsDataGridView.TabIndex = 0;
            this.resultsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsDataGridView_CellContentClick);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(167, 154);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // manageResultsLabel
            // 
            this.manageResultsLabel.AutoSize = true;
            this.manageResultsLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manageResultsLabel.Location = new System.Drawing.Point(708, 33);
            this.manageResultsLabel.Name = "manageResultsLabel";
            this.manageResultsLabel.Size = new System.Drawing.Size(214, 28);
            this.manageResultsLabel.TabIndex = 2;
            this.manageResultsLabel.Text = "Manage Results";
            // 
            // addButon
            // 
            this.addButon.Location = new System.Drawing.Point(351, 669);
            this.addButon.Name = "addButon";
            this.addButon.Size = new System.Drawing.Size(75, 23);
            this.addButon.TabIndex = 3;
            this.addButon.Text = "Add";
            this.addButon.UseVisualStyleBackColor = true;
            this.addButon.Click += new System.EventHandler(this.addButon_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(552, 669);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(730, 669);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(47, 698);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(225, 31);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back to the manage tests page";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // graphicsButton
            // 
            this.graphicsButton.Location = new System.Drawing.Point(1598, 669);
            this.graphicsButton.Name = "graphicsButton";
            this.graphicsButton.Size = new System.Drawing.Size(105, 42);
            this.graphicsButton.TabIndex = 7;
            this.graphicsButton.Text = "Graphics Page";
            this.graphicsButton.UseVisualStyleBackColor = true;
            this.graphicsButton.Click += new System.EventHandler(this.graphicsButton_Click);
            // 
            // studentcomboBox
            // 
            this.studentcomboBox.FormattingEnabled = true;
            this.studentcomboBox.Location = new System.Drawing.Point(609, 73);
            this.studentcomboBox.Name = "studentcomboBox";
            this.studentcomboBox.Size = new System.Drawing.Size(121, 24);
            this.studentcomboBox.TabIndex = 8;
            this.studentcomboBox.SelectedIndexChanged += new System.EventHandler(this.studentcomboBox_SelectedIndexChanged);
            // 
            // studentlabel
            // 
            this.studentlabel.AutoSize = true;
            this.studentlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentlabel.Location = new System.Drawing.Point(273, 73);
            this.studentlabel.Name = "studentlabel";
            this.studentlabel.Size = new System.Drawing.Size(121, 25);
            this.studentlabel.TabIndex = 9;
            this.studentlabel.Text = "Student : ";
            // 
            // mathCorrectlabel
            // 
            this.mathCorrectlabel.AutoSize = true;
            this.mathCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mathCorrectlabel.Location = new System.Drawing.Point(272, 152);
            this.mathCorrectlabel.Name = "mathCorrectlabel";
            this.mathCorrectlabel.Size = new System.Drawing.Size(282, 25);
            this.mathCorrectlabel.TabIndex = 10;
            this.mathCorrectlabel.Text = "Math Correct Answers : ";
            // 
            // mathWronglabel
            // 
            this.mathWronglabel.AutoSize = true;
            this.mathWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mathWronglabel.Location = new System.Drawing.Point(273, 183);
            this.mathWronglabel.Name = "mathWronglabel";
            this.mathWronglabel.Size = new System.Drawing.Size(275, 25);
            this.mathWronglabel.TabIndex = 11;
            this.mathWronglabel.Text = "Math Wrong Answers : ";
            // 
            // turkishCorrectlabel
            // 
            this.turkishCorrectlabel.AutoSize = true;
            this.turkishCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkishCorrectlabel.Location = new System.Drawing.Point(273, 317);
            this.turkishCorrectlabel.Name = "turkishCorrectlabel";
            this.turkishCorrectlabel.Size = new System.Drawing.Size(311, 25);
            this.turkishCorrectlabel.TabIndex = 12;
            this.turkishCorrectlabel.Text = "Turkish Correct Answers : ";
            // 
            // turkishWronglabel
            // 
            this.turkishWronglabel.AutoSize = true;
            this.turkishWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkishWronglabel.Location = new System.Drawing.Point(273, 351);
            this.turkishWronglabel.Name = "turkishWronglabel";
            this.turkishWronglabel.Size = new System.Drawing.Size(311, 25);
            this.turkishWronglabel.TabIndex = 13;
            this.turkishWronglabel.Text = "Turkish Wrong Answers  : ";
            this.turkishWronglabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // scienceCorrectlabel
            // 
            this.scienceCorrectlabel.AutoSize = true;
            this.scienceCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scienceCorrectlabel.Location = new System.Drawing.Point(272, 233);
            this.scienceCorrectlabel.Name = "scienceCorrectlabel";
            this.scienceCorrectlabel.Size = new System.Drawing.Size(312, 25);
            this.scienceCorrectlabel.TabIndex = 14;
            this.scienceCorrectlabel.Text = "Science Correct Answers : ";
            // 
            // mathCorrecttextBox
            // 
            this.mathCorrecttextBox.Location = new System.Drawing.Point(630, 152);
            this.mathCorrecttextBox.Name = "mathCorrecttextBox";
            this.mathCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.mathCorrecttextBox.TabIndex = 15;
            this.mathCorrecttextBox.TextChanged += new System.EventHandler(this.mathCorrecttextBox_TextChanged);
            // 
            // mathWrongtextBox
            // 
            this.mathWrongtextBox.Location = new System.Drawing.Point(630, 188);
            this.mathWrongtextBox.Name = "mathWrongtextBox";
            this.mathWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.mathWrongtextBox.TabIndex = 16;
            this.mathWrongtextBox.TextChanged += new System.EventHandler(this.mathWrongtextBox_TextChanged);
            // 
            // scienceCorrecttextBox
            // 
            this.scienceCorrecttextBox.Location = new System.Drawing.Point(630, 238);
            this.scienceCorrecttextBox.Name = "scienceCorrecttextBox";
            this.scienceCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.scienceCorrecttextBox.TabIndex = 17;
            // 
            // scienceWrongtextBox
            // 
            this.scienceWrongtextBox.Location = new System.Drawing.Point(630, 272);
            this.scienceWrongtextBox.Name = "scienceWrongtextBox";
            this.scienceWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.scienceWrongtextBox.TabIndex = 18;
            // 
            // scienceWronglabel
            // 
            this.scienceWronglabel.AutoSize = true;
            this.scienceWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scienceWronglabel.Location = new System.Drawing.Point(273, 267);
            this.scienceWronglabel.Name = "scienceWronglabel";
            this.scienceWronglabel.Size = new System.Drawing.Size(305, 25);
            this.scienceWronglabel.TabIndex = 19;
            this.scienceWronglabel.Text = "Science Wrong Answers : ";
            // 
            // historyCorrectlabel
            // 
            this.historyCorrectlabel.AutoSize = true;
            this.historyCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.historyCorrectlabel.Location = new System.Drawing.Point(271, 402);
            this.historyCorrectlabel.Name = "historyCorrectlabel";
            this.historyCorrectlabel.Size = new System.Drawing.Size(309, 25);
            this.historyCorrectlabel.TabIndex = 20;
            this.historyCorrectlabel.Text = "History Correct Answers : ";
            // 
            // historyWronglabel
            // 
            this.historyWronglabel.AutoSize = true;
            this.historyWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.historyWronglabel.Location = new System.Drawing.Point(273, 432);
            this.historyWronglabel.Name = "historyWronglabel";
            this.historyWronglabel.Size = new System.Drawing.Size(302, 25);
            this.historyWronglabel.TabIndex = 21;
            this.historyWronglabel.Text = "History Wrong Answers : ";
            // 
            // religionCorrectlabel
            // 
            this.religionCorrectlabel.AutoSize = true;
            this.religionCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.religionCorrectlabel.Location = new System.Drawing.Point(273, 487);
            this.religionCorrectlabel.Name = "religionCorrectlabel";
            this.religionCorrectlabel.Size = new System.Drawing.Size(312, 25);
            this.religionCorrectlabel.TabIndex = 22;
            this.religionCorrectlabel.Text = "Religion Correct Answers :";
            // 
            // englishCorrectlabel
            // 
            this.englishCorrectlabel.AutoSize = true;
            this.englishCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.englishCorrectlabel.Location = new System.Drawing.Point(273, 567);
            this.englishCorrectlabel.Name = "englishCorrectlabel";
            this.englishCorrectlabel.Size = new System.Drawing.Size(309, 25);
            this.englishCorrectlabel.TabIndex = 23;
            this.englishCorrectlabel.Text = "English Correct Answers : ";
            // 
            // religionWronglabel
            // 
            this.religionWronglabel.AutoSize = true;
            this.religionWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.religionWronglabel.Location = new System.Drawing.Point(273, 512);
            this.religionWronglabel.Name = "religionWronglabel";
            this.religionWronglabel.Size = new System.Drawing.Size(312, 25);
            this.religionWronglabel.TabIndex = 24;
            this.religionWronglabel.Text = "Religion Wrong Answers : ";
            // 
            // englishWronglabel
            // 
            this.englishWronglabel.AutoSize = true;
            this.englishWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.englishWronglabel.Location = new System.Drawing.Point(273, 592);
            this.englishWronglabel.Name = "englishWronglabel";
            this.englishWronglabel.Size = new System.Drawing.Size(302, 25);
            this.englishWronglabel.TabIndex = 25;
            this.englishWronglabel.Text = "English Wrong Answers : ";
            // 
            // turkishtextBox
            // 
            this.turkishtextBox.Location = new System.Drawing.Point(630, 317);
            this.turkishtextBox.Name = "turkishtextBox";
            this.turkishtextBox.Size = new System.Drawing.Size(100, 22);
            this.turkishtextBox.TabIndex = 26;
            // 
            // turkishWrongtextBox
            // 
            this.turkishWrongtextBox.Location = new System.Drawing.Point(630, 351);
            this.turkishWrongtextBox.Name = "turkishWrongtextBox";
            this.turkishWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.turkishWrongtextBox.TabIndex = 27;
            // 
            // historyWrongtextBox
            // 
            this.historyWrongtextBox.Location = new System.Drawing.Point(630, 432);
            this.historyWrongtextBox.Name = "historyWrongtextBox";
            this.historyWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.historyWrongtextBox.TabIndex = 28;
            // 
            // religionCorrecttextBox
            // 
            this.religionCorrecttextBox.Location = new System.Drawing.Point(630, 487);
            this.religionCorrecttextBox.Name = "religionCorrecttextBox";
            this.religionCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.religionCorrecttextBox.TabIndex = 29;
            // 
            // historyCorrecttextBox
            // 
            this.historyCorrecttextBox.Location = new System.Drawing.Point(630, 402);
            this.historyCorrecttextBox.Name = "historyCorrecttextBox";
            this.historyCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.historyCorrecttextBox.TabIndex = 30;
            // 
            // religionWrongtextBox
            // 
            this.religionWrongtextBox.Location = new System.Drawing.Point(630, 517);
            this.religionWrongtextBox.Name = "religionWrongtextBox";
            this.religionWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.religionWrongtextBox.TabIndex = 31;
            // 
            // englishWrongtextBox
            // 
            this.englishWrongtextBox.Location = new System.Drawing.Point(630, 597);
            this.englishWrongtextBox.Name = "englishWrongtextBox";
            this.englishWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.englishWrongtextBox.TabIndex = 32;
            // 
            // englishCorrecttextBox
            // 
            this.englishCorrecttextBox.Location = new System.Drawing.Point(630, 567);
            this.englishCorrecttextBox.Name = "englishCorrecttextBox";
            this.englishCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.englishCorrecttextBox.TabIndex = 33;
            // 
            // examNamelabel
            // 
            this.examNamelabel.AutoSize = true;
            this.examNamelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.examNamelabel.Location = new System.Drawing.Point(260, 108);
            this.examNamelabel.Name = "examNamelabel";
            this.examNamelabel.Size = new System.Drawing.Size(166, 25);
            this.examNamelabel.TabIndex = 34;
            this.examNamelabel.Text = " Exam Name :";
            // 
            // examcomboBox
            // 
            this.examcomboBox.FormattingEnabled = true;
            this.examcomboBox.Location = new System.Drawing.Point(609, 108);
            this.examcomboBox.Name = "examcomboBox";
            this.examcomboBox.Size = new System.Drawing.Size(121, 24);
            this.examcomboBox.TabIndex = 35;
            this.examcomboBox.SelectedIndexChanged += new System.EventHandler(this.examcomboBox_SelectedIndexChanged);
            // 
            // pdfbutton
            // 
            this.pdfbutton.Location = new System.Drawing.Point(808, 462);
            this.pdfbutton.Name = "pdfbutton";
            this.pdfbutton.Size = new System.Drawing.Size(91, 38);
            this.pdfbutton.TabIndex = 36;
            this.pdfbutton.Text = "PDF";
            this.pdfbutton.UseVisualStyleBackColor = true;
            this.pdfbutton.Click += new System.EventHandler(this.pdfbutton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1817, 783);
            this.Controls.Add(this.pdfbutton);
            this.Controls.Add(this.examcomboBox);
            this.Controls.Add(this.examNamelabel);
            this.Controls.Add(this.englishCorrecttextBox);
            this.Controls.Add(this.englishWrongtextBox);
            this.Controls.Add(this.religionWrongtextBox);
            this.Controls.Add(this.historyCorrecttextBox);
            this.Controls.Add(this.religionCorrecttextBox);
            this.Controls.Add(this.historyWrongtextBox);
            this.Controls.Add(this.turkishWrongtextBox);
            this.Controls.Add(this.turkishtextBox);
            this.Controls.Add(this.englishWronglabel);
            this.Controls.Add(this.religionWronglabel);
            this.Controls.Add(this.englishCorrectlabel);
            this.Controls.Add(this.religionCorrectlabel);
            this.Controls.Add(this.historyWronglabel);
            this.Controls.Add(this.historyCorrectlabel);
            this.Controls.Add(this.scienceWronglabel);
            this.Controls.Add(this.scienceWrongtextBox);
            this.Controls.Add(this.scienceCorrecttextBox);
            this.Controls.Add(this.mathWrongtextBox);
            this.Controls.Add(this.mathCorrecttextBox);
            this.Controls.Add(this.scienceCorrectlabel);
            this.Controls.Add(this.turkishWronglabel);
            this.Controls.Add(this.turkishCorrectlabel);
            this.Controls.Add(this.mathWronglabel);
            this.Controls.Add(this.mathCorrectlabel);
            this.Controls.Add(this.studentlabel);
            this.Controls.Add(this.studentcomboBox);
            this.Controls.Add(this.graphicsButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButon);
            this.Controls.Add(this.manageResultsLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.resultsDataGridView);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label manageResultsLabel;
        private System.Windows.Forms.Button addButon;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button graphicsButton;
        private System.Windows.Forms.ComboBox studentcomboBox;
        private System.Windows.Forms.Label studentlabel;
        private System.Windows.Forms.Label mathCorrectlabel;
        private System.Windows.Forms.Label mathWronglabel;
        private System.Windows.Forms.Label turkishCorrectlabel;
        private System.Windows.Forms.Label turkishWronglabel;
        private System.Windows.Forms.Label scienceCorrectlabel;
        private System.Windows.Forms.TextBox mathCorrecttextBox;
        private System.Windows.Forms.TextBox mathWrongtextBox;
        private System.Windows.Forms.TextBox scienceCorrecttextBox;
        private System.Windows.Forms.TextBox scienceWrongtextBox;
        private System.Windows.Forms.Label scienceWronglabel;
        private System.Windows.Forms.Label historyCorrectlabel;
        private System.Windows.Forms.Label historyWronglabel;
        private System.Windows.Forms.Label religionCorrectlabel;
        private System.Windows.Forms.Label englishCorrectlabel;
        private System.Windows.Forms.Label religionWronglabel;
        private System.Windows.Forms.Label englishWronglabel;
        private System.Windows.Forms.TextBox turkishtextBox;
        private System.Windows.Forms.TextBox turkishWrongtextBox;
        private System.Windows.Forms.TextBox historyWrongtextBox;
        private System.Windows.Forms.TextBox religionCorrecttextBox;
        private System.Windows.Forms.TextBox historyCorrecttextBox;
        private System.Windows.Forms.TextBox religionWrongtextBox;
        private System.Windows.Forms.TextBox englishWrongtextBox;
        private System.Windows.Forms.TextBox englishCorrecttextBox;
        private System.Windows.Forms.Label examNamelabel;
        private System.Windows.Forms.ComboBox examcomboBox;
        private System.Windows.Forms.Button pdfbutton;
    }
}