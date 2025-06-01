namespace Lgs_VisualProject
{
    partial class ManageTestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTestsForm));
            this.testsDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testsLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.manageResultsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.studentcomboBox = new System.Windows.Forms.ComboBox();
            this.examNametextBox = new System.Windows.Forms.TextBox();
            this.examdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentlabel = new System.Windows.Forms.Label();
            this.examNamelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // testsDataGridView
            // 
            this.testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDataGridView.Location = new System.Drawing.Point(755, 119);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.RowHeadersWidth = 51;
            this.testsDataGridView.RowTemplate.Height = 24;
            this.testsDataGridView.Size = new System.Drawing.Size(585, 231);
            this.testsDataGridView.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // testsLabel
            // 
            this.testsLabel.AutoSize = true;
            this.testsLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.testsLabel.Location = new System.Drawing.Point(750, 21);
            this.testsLabel.Name = "testsLabel";
            this.testsLabel.Size = new System.Drawing.Size(188, 28);
            this.testsLabel.TabIndex = 2;
            this.testsLabel.Text = "Manage Tests";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(145, 416);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(317, 415);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 24);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(475, 417);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // manageResultsButton
            // 
            this.manageResultsButton.Location = new System.Drawing.Point(1346, 677);
            this.manageResultsButton.Name = "manageResultsButton";
            this.manageResultsButton.Size = new System.Drawing.Size(170, 29);
            this.manageResultsButton.TabIndex = 6;
            this.manageResultsButton.Text = "Manage Results";
            this.manageResultsButton.UseVisualStyleBackColor = true;
            this.manageResultsButton.Click += new System.EventHandler(this.manageResultsButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(46, 677);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(171, 26);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back to the home page";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // studentcomboBox
            // 
            this.studentcomboBox.FormattingEnabled = true;
            this.studentcomboBox.Location = new System.Drawing.Point(350, 190);
            this.studentcomboBox.Name = "studentcomboBox";
            this.studentcomboBox.Size = new System.Drawing.Size(121, 24);
            this.studentcomboBox.TabIndex = 8;
            this.studentcomboBox.SelectedIndexChanged += new System.EventHandler(this.studentcomboBox_SelectedIndexChanged);
            // 
            // examNametextBox
            // 
            this.examNametextBox.Location = new System.Drawing.Point(350, 246);
            this.examNametextBox.Name = "examNametextBox";
            this.examNametextBox.Size = new System.Drawing.Size(121, 22);
            this.examNametextBox.TabIndex = 9;
            this.examNametextBox.TextChanged += new System.EventHandler(this.examNametextBox_TextChanged);
            // 
            // examdateTimePicker
            // 
            this.examdateTimePicker.Location = new System.Drawing.Point(350, 299);
            this.examdateTimePicker.Name = "examdateTimePicker";
            this.examdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.examdateTimePicker.TabIndex = 10;
            this.examdateTimePicker.ValueChanged += new System.EventHandler(this.examdateTimePicker_ValueChanged);
            // 
            // studentlabel
            // 
            this.studentlabel.AutoSize = true;
            this.studentlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentlabel.Location = new System.Drawing.Point(140, 185);
            this.studentlabel.Name = "studentlabel";
            this.studentlabel.Size = new System.Drawing.Size(107, 25);
            this.studentlabel.TabIndex = 11;
            this.studentlabel.Text = "Student:";
            // 
            // examNamelabel
            // 
            this.examNamelabel.AutoSize = true;
            this.examNamelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.examNamelabel.Location = new System.Drawing.Point(140, 241);
            this.examNamelabel.Name = "examNamelabel";
            this.examNamelabel.Size = new System.Drawing.Size(152, 25);
            this.examNamelabel.TabIndex = 12;
            this.examNamelabel.Text = "Exam Name:";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datelabel.Location = new System.Drawing.Point(140, 299);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(140, 25);
            this.datelabel.TabIndex = 13;
            this.datelabel.Text = "Exam Date:";
            // 
            // ManageTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1575, 762);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.examNamelabel);
            this.Controls.Add(this.studentlabel);
            this.Controls.Add(this.examdateTimePicker);
            this.Controls.Add(this.examNametextBox);
            this.Controls.Add(this.studentcomboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.manageResultsButton);
            this.Controls.Add(this.testsDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.testsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageTestsForm";
            this.Text = "AddMyTestForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageTestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView testsDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label testsLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button manageResultsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox studentcomboBox;
        private System.Windows.Forms.TextBox examNametextBox;
        private System.Windows.Forms.DateTimePicker examdateTimePicker;
        private System.Windows.Forms.Label studentlabel;
        private System.Windows.Forms.Label examNamelabel;
        private System.Windows.Forms.Label datelabel;
    }
}