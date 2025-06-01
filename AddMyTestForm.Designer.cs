namespace Lgs_VisualProject
{
    partial class AddMyTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMyTestForm));
            this.testsLabel = new System.Windows.Forms.Label();
            this.testsDataGridView = new System.Windows.Forms.DataGridView();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.examNamelabel = new System.Windows.Forms.Label();
            this.mathCorrectlabel = new System.Windows.Forms.Label();
            this.mathWronglabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scienceCorrectlabel = new System.Windows.Forms.Label();
            this.scienceWronglabel = new System.Windows.Forms.Label();
            this.turkishCorrectlabel = new System.Windows.Forms.Label();
            this.turkishWronglabel = new System.Windows.Forms.Label();
            this.religionCorrectlabel = new System.Windows.Forms.Label();
            this.religionWronglabel = new System.Windows.Forms.Label();
            this.historyCorrectlabel = new System.Windows.Forms.Label();
            this.historyWronglabel = new System.Windows.Forms.Label();
            this.englishCorrectlabel = new System.Windows.Forms.Label();
            this.englishWronglabel = new System.Windows.Forms.Label();
            this.scienceWrongtextBox = new System.Windows.Forms.TextBox();
            this.turkishCorrecttextBox = new System.Windows.Forms.TextBox();
            this.turkishWrongtextBox = new System.Windows.Forms.TextBox();
            this.historyCorrecttextBox = new System.Windows.Forms.TextBox();
            this.historyWrongtextBox = new System.Windows.Forms.TextBox();
            this.religionCorrecttextBox = new System.Windows.Forms.TextBox();
            this.religionWrongtextBox = new System.Windows.Forms.TextBox();
            this.englishCorrecttextBox = new System.Windows.Forms.TextBox();
            this.englishWrongtextBox = new System.Windows.Forms.TextBox();
            this.mathWrongtextBox = new System.Windows.Forms.TextBox();
            this.mathCorrecttextBox = new System.Windows.Forms.TextBox();
            this.examNametextBox = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.scienceCorrecttextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datelabel = new System.Windows.Forms.Label();
            this.graphicsbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // testsLabel
            // 
            this.testsLabel.AutoSize = true;
            this.testsLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.testsLabel.Location = new System.Drawing.Point(719, 9);
            this.testsLabel.Name = "testsLabel";
            this.testsLabel.Size = new System.Drawing.Size(126, 28);
            this.testsLabel.TabIndex = 0;
            this.testsLabel.Text = "My Tests";
            // 
            // testsDataGridView
            // 
            this.testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDataGridView.Location = new System.Drawing.Point(765, 83);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.RowHeadersWidth = 51;
            this.testsDataGridView.RowTemplate.Height = 24;
            this.testsDataGridView.Size = new System.Drawing.Size(743, 313);
            this.testsDataGridView.TabIndex = 1;
            this.testsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testsDataGridView_CellContentClick);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(1, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(169, 159);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(555, 639);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 36);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(51, 689);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(216, 33);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back to the student home page";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // examNamelabel
            // 
            this.examNamelabel.AutoSize = true;
            this.examNamelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.examNamelabel.Location = new System.Drawing.Point(303, 78);
            this.examNamelabel.Name = "examNamelabel";
            this.examNamelabel.Size = new System.Drawing.Size(166, 25);
            this.examNamelabel.TabIndex = 5;
            this.examNamelabel.Text = "Exam Name : ";
            // 
            // mathCorrectlabel
            // 
            this.mathCorrectlabel.AutoSize = true;
            this.mathCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mathCorrectlabel.Location = new System.Drawing.Point(303, 126);
            this.mathCorrectlabel.Name = "mathCorrectlabel";
            this.mathCorrectlabel.Size = new System.Drawing.Size(171, 25);
            this.mathCorrectlabel.TabIndex = 6;
            this.mathCorrectlabel.Text = "Math Correct :";
            // 
            // mathWronglabel
            // 
            this.mathWronglabel.AutoSize = true;
            this.mathWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mathWronglabel.Location = new System.Drawing.Point(303, 151);
            this.mathWronglabel.Name = "mathWronglabel";
            this.mathWronglabel.Size = new System.Drawing.Size(164, 25);
            this.mathWronglabel.TabIndex = 7;
            this.mathWronglabel.Text = "Math Wrong :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 8;
            // 
            // scienceCorrectlabel
            // 
            this.scienceCorrectlabel.AutoSize = true;
            this.scienceCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scienceCorrectlabel.Location = new System.Drawing.Point(303, 197);
            this.scienceCorrectlabel.Name = "scienceCorrectlabel";
            this.scienceCorrectlabel.Size = new System.Drawing.Size(194, 25);
            this.scienceCorrectlabel.TabIndex = 9;
            this.scienceCorrectlabel.Text = "Science Correct:";
            // 
            // scienceWronglabel
            // 
            this.scienceWronglabel.AutoSize = true;
            this.scienceWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scienceWronglabel.Location = new System.Drawing.Point(300, 221);
            this.scienceWronglabel.Name = "scienceWronglabel";
            this.scienceWronglabel.Size = new System.Drawing.Size(201, 25);
            this.scienceWronglabel.TabIndex = 10;
            this.scienceWronglabel.Text = "Science Wrong : ";
            // 
            // turkishCorrectlabel
            // 
            this.turkishCorrectlabel.AutoSize = true;
            this.turkishCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkishCorrectlabel.Location = new System.Drawing.Point(303, 263);
            this.turkishCorrectlabel.Name = "turkishCorrectlabel";
            this.turkishCorrectlabel.Size = new System.Drawing.Size(200, 25);
            this.turkishCorrectlabel.TabIndex = 11;
            this.turkishCorrectlabel.Text = "Turkish Correct :";
            // 
            // turkishWronglabel
            // 
            this.turkishWronglabel.AutoSize = true;
            this.turkishWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkishWronglabel.Location = new System.Drawing.Point(303, 288);
            this.turkishWronglabel.Name = "turkishWronglabel";
            this.turkishWronglabel.Size = new System.Drawing.Size(200, 25);
            this.turkishWronglabel.TabIndex = 12;
            this.turkishWronglabel.Text = "Turkish Wrong : ";
            // 
            // religionCorrectlabel
            // 
            this.religionCorrectlabel.AutoSize = true;
            this.religionCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.religionCorrectlabel.Location = new System.Drawing.Point(303, 395);
            this.religionCorrectlabel.Name = "religionCorrectlabel";
            this.religionCorrectlabel.Size = new System.Drawing.Size(215, 25);
            this.religionCorrectlabel.TabIndex = 13;
            this.religionCorrectlabel.Text = "Religion Correct : ";
            // 
            // religionWronglabel
            // 
            this.religionWronglabel.AutoSize = true;
            this.religionWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.religionWronglabel.Location = new System.Drawing.Point(303, 420);
            this.religionWronglabel.Name = "religionWronglabel";
            this.religionWronglabel.Size = new System.Drawing.Size(208, 25);
            this.religionWronglabel.TabIndex = 14;
            this.religionWronglabel.Text = "Religion Wrong : ";
            // 
            // historyCorrectlabel
            // 
            this.historyCorrectlabel.AutoSize = true;
            this.historyCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.historyCorrectlabel.Location = new System.Drawing.Point(303, 328);
            this.historyCorrectlabel.Name = "historyCorrectlabel";
            this.historyCorrectlabel.Size = new System.Drawing.Size(205, 25);
            this.historyCorrectlabel.TabIndex = 15;
            this.historyCorrectlabel.Text = "History Correct : ";
            // 
            // historyWronglabel
            // 
            this.historyWronglabel.AutoSize = true;
            this.historyWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.historyWronglabel.Location = new System.Drawing.Point(303, 353);
            this.historyWronglabel.Name = "historyWronglabel";
            this.historyWronglabel.Size = new System.Drawing.Size(198, 25);
            this.historyWronglabel.TabIndex = 16;
            this.historyWronglabel.Text = "History Wrong : ";
            // 
            // englishCorrectlabel
            // 
            this.englishCorrectlabel.AutoSize = true;
            this.englishCorrectlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.englishCorrectlabel.Location = new System.Drawing.Point(303, 464);
            this.englishCorrectlabel.Name = "englishCorrectlabel";
            this.englishCorrectlabel.Size = new System.Drawing.Size(205, 25);
            this.englishCorrectlabel.TabIndex = 17;
            this.englishCorrectlabel.Text = "English Correct : ";
            // 
            // englishWronglabel
            // 
            this.englishWronglabel.AutoSize = true;
            this.englishWronglabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.englishWronglabel.Location = new System.Drawing.Point(305, 489);
            this.englishWronglabel.Name = "englishWronglabel";
            this.englishWronglabel.Size = new System.Drawing.Size(198, 25);
            this.englishWronglabel.TabIndex = 18;
            this.englishWronglabel.Text = "English Wrong : ";
            // 
            // scienceWrongtextBox
            // 
            this.scienceWrongtextBox.Location = new System.Drawing.Point(555, 228);
            this.scienceWrongtextBox.Name = "scienceWrongtextBox";
            this.scienceWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.scienceWrongtextBox.TabIndex = 19;
            // 
            // turkishCorrecttextBox
            // 
            this.turkishCorrecttextBox.Location = new System.Drawing.Point(555, 265);
            this.turkishCorrecttextBox.Name = "turkishCorrecttextBox";
            this.turkishCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.turkishCorrecttextBox.TabIndex = 20;
            // 
            // turkishWrongtextBox
            // 
            this.turkishWrongtextBox.Location = new System.Drawing.Point(555, 293);
            this.turkishWrongtextBox.Name = "turkishWrongtextBox";
            this.turkishWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.turkishWrongtextBox.TabIndex = 21;
            // 
            // historyCorrecttextBox
            // 
            this.historyCorrecttextBox.Location = new System.Drawing.Point(555, 328);
            this.historyCorrecttextBox.Name = "historyCorrecttextBox";
            this.historyCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.historyCorrecttextBox.TabIndex = 22;
            // 
            // historyWrongtextBox
            // 
            this.historyWrongtextBox.Location = new System.Drawing.Point(555, 356);
            this.historyWrongtextBox.Name = "historyWrongtextBox";
            this.historyWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.historyWrongtextBox.TabIndex = 23;
            // 
            // religionCorrecttextBox
            // 
            this.religionCorrecttextBox.Location = new System.Drawing.Point(555, 400);
            this.religionCorrecttextBox.Name = "religionCorrecttextBox";
            this.religionCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.religionCorrecttextBox.TabIndex = 24;
            // 
            // religionWrongtextBox
            // 
            this.religionWrongtextBox.Location = new System.Drawing.Point(555, 428);
            this.religionWrongtextBox.Name = "religionWrongtextBox";
            this.religionWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.religionWrongtextBox.TabIndex = 25;
            // 
            // englishCorrecttextBox
            // 
            this.englishCorrecttextBox.Location = new System.Drawing.Point(555, 466);
            this.englishCorrecttextBox.Name = "englishCorrecttextBox";
            this.englishCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.englishCorrecttextBox.TabIndex = 26;
            // 
            // englishWrongtextBox
            // 
            this.englishWrongtextBox.Location = new System.Drawing.Point(555, 494);
            this.englishWrongtextBox.Name = "englishWrongtextBox";
            this.englishWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.englishWrongtextBox.TabIndex = 27;
            // 
            // mathWrongtextBox
            // 
            this.mathWrongtextBox.Location = new System.Drawing.Point(555, 157);
            this.mathWrongtextBox.Name = "mathWrongtextBox";
            this.mathWrongtextBox.Size = new System.Drawing.Size(100, 22);
            this.mathWrongtextBox.TabIndex = 28;
            // 
            // mathCorrecttextBox
            // 
            this.mathCorrecttextBox.Location = new System.Drawing.Point(555, 129);
            this.mathCorrecttextBox.Name = "mathCorrecttextBox";
            this.mathCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.mathCorrecttextBox.TabIndex = 29;
            this.mathCorrecttextBox.TextChanged += new System.EventHandler(this.mathCorrecttextBox_TextChanged);
            // 
            // examNametextBox
            // 
            this.examNametextBox.Location = new System.Drawing.Point(555, 83);
            this.examNametextBox.Name = "examNametextBox";
            this.examNametextBox.Size = new System.Drawing.Size(100, 22);
            this.examNametextBox.TabIndex = 30;
            this.examNametextBox.TextChanged += new System.EventHandler(this.examNametextBox_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(0, 0);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 31;
            // 
            // scienceCorrecttextBox
            // 
            this.scienceCorrecttextBox.Location = new System.Drawing.Point(555, 200);
            this.scienceCorrecttextBox.Name = "scienceCorrecttextBox";
            this.scienceCorrecttextBox.Size = new System.Drawing.Size(100, 22);
            this.scienceCorrecttextBox.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(555, 556);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datelabel.Location = new System.Drawing.Point(363, 553);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(86, 25);
            this.datelabel.TabIndex = 34;
            this.datelabel.Text = "Date : ";
            // 
            // graphicsbutton
            // 
            this.graphicsbutton.Location = new System.Drawing.Point(1337, 666);
            this.graphicsbutton.Name = "graphicsbutton";
            this.graphicsbutton.Size = new System.Drawing.Size(128, 46);
            this.graphicsbutton.TabIndex = 35;
            this.graphicsbutton.Text = "Grahics Page";
            this.graphicsbutton.UseVisualStyleBackColor = true;
            this.graphicsbutton.Click += new System.EventHandler(this.graphicsbutton_Click);
            // 
            // AddMyTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1563, 778);
            this.Controls.Add(this.graphicsbutton);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.scienceCorrecttextBox);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.examNametextBox);
            this.Controls.Add(this.mathCorrecttextBox);
            this.Controls.Add(this.mathWrongtextBox);
            this.Controls.Add(this.englishWrongtextBox);
            this.Controls.Add(this.englishCorrecttextBox);
            this.Controls.Add(this.religionWrongtextBox);
            this.Controls.Add(this.religionCorrecttextBox);
            this.Controls.Add(this.historyWrongtextBox);
            this.Controls.Add(this.historyCorrecttextBox);
            this.Controls.Add(this.turkishWrongtextBox);
            this.Controls.Add(this.turkishCorrecttextBox);
            this.Controls.Add(this.scienceWrongtextBox);
            this.Controls.Add(this.englishWronglabel);
            this.Controls.Add(this.englishCorrectlabel);
            this.Controls.Add(this.historyWronglabel);
            this.Controls.Add(this.historyCorrectlabel);
            this.Controls.Add(this.religionWronglabel);
            this.Controls.Add(this.religionCorrectlabel);
            this.Controls.Add(this.turkishWronglabel);
            this.Controls.Add(this.turkishCorrectlabel);
            this.Controls.Add(this.scienceWronglabel);
            this.Controls.Add(this.scienceCorrectlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mathWronglabel);
            this.Controls.Add(this.mathCorrectlabel);
            this.Controls.Add(this.examNamelabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.testsDataGridView);
            this.Controls.Add(this.testsLabel);
            this.Name = "AddMyTestForm";
            this.Text = "AddMyTestForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddMyTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testsLabel;
        private System.Windows.Forms.DataGridView testsDataGridView;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label examNamelabel;
        private System.Windows.Forms.Label mathCorrectlabel;
        private System.Windows.Forms.Label mathWronglabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label scienceCorrectlabel;
        private System.Windows.Forms.Label scienceWronglabel;
        private System.Windows.Forms.Label turkishCorrectlabel;
        private System.Windows.Forms.Label turkishWronglabel;
        private System.Windows.Forms.Label religionCorrectlabel;
        private System.Windows.Forms.Label religionWronglabel;
        private System.Windows.Forms.Label historyCorrectlabel;
        private System.Windows.Forms.Label historyWronglabel;
        private System.Windows.Forms.Label englishCorrectlabel;
        private System.Windows.Forms.Label englishWronglabel;
        private System.Windows.Forms.TextBox scienceWrongtextBox;
        private System.Windows.Forms.TextBox turkishCorrecttextBox;
        private System.Windows.Forms.TextBox turkishWrongtextBox;
        private System.Windows.Forms.TextBox historyCorrecttextBox;
        private System.Windows.Forms.TextBox historyWrongtextBox;
        private System.Windows.Forms.TextBox religionCorrecttextBox;
        private System.Windows.Forms.TextBox religionWrongtextBox;
        private System.Windows.Forms.TextBox englishCorrecttextBox;
        private System.Windows.Forms.TextBox englishWrongtextBox;
        private System.Windows.Forms.TextBox mathWrongtextBox;
        private System.Windows.Forms.TextBox mathCorrecttextBox;
        private System.Windows.Forms.TextBox examNametextBox;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox scienceCorrecttextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Button graphicsbutton;
    }
}