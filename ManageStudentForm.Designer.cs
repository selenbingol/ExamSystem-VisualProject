namespace Lgs_VisualProject
{
    partial class ManageStudentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudentForm));
            this.manageStudentlabel = new System.Windows.Forms.Label();
            this.manageStudentdataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.classlabel = new System.Windows.Forms.Label();
            this.maillabel = new System.Windows.Forms.Label();
            this.identityNumberlabel = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gendercomboBox = new System.Windows.Forms.ComboBox();
            this.mailtextBox = new System.Windows.Forms.TextBox();
            this.identityNumbertextBox = new System.Windows.Forms.TextBox();
            this.phoneNumbermaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberlabel = new System.Windows.Forms.Label();
            this.classcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.manageStudentdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // manageStudentlabel
            // 
            this.manageStudentlabel.AutoSize = true;
            this.manageStudentlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manageStudentlabel.Location = new System.Drawing.Point(638, 30);
            this.manageStudentlabel.Name = "manageStudentlabel";
            this.manageStudentlabel.Size = new System.Drawing.Size(257, 25);
            this.manageStudentlabel.TabIndex = 1;
            this.manageStudentlabel.Text = "Manage Student Form";
            // 
            // manageStudentdataGridView
            // 
            this.manageStudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageStudentdataGridView.Location = new System.Drawing.Point(768, 94);
            this.manageStudentdataGridView.Name = "manageStudentdataGridView";
            this.manageStudentdataGridView.RowHeadersWidth = 51;
            this.manageStudentdataGridView.RowTemplate.Height = 24;
            this.manageStudentdataGridView.Size = new System.Drawing.Size(745, 323);
            this.manageStudentdataGridView.TabIndex = 2;
            this.manageStudentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manageStudentdataGridView_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.Location = new System.Drawing.Point(505, 450);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 35);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.Location = new System.Drawing.Point(870, 447);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 38);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editButton.Location = new System.Drawing.Point(1217, 447);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 38);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(505, 126);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 22);
            this.usernameTextBox.TabIndex = 6;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(505, 162);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLabel.Location = new System.Drawing.Point(280, 121);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(132, 25);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLabel.Location = new System.Drawing.Point(282, 157);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(130, 25);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, -2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(172, 174);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 10;
            this.logoPictureBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(62, 612);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(213, 29);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back to the Admin Home Page";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // classlabel
            // 
            this.classlabel.AutoSize = true;
            this.classlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.classlabel.Location = new System.Drawing.Point(280, 192);
            this.classlabel.Name = "classlabel";
            this.classlabel.Size = new System.Drawing.Size(92, 25);
            this.classlabel.TabIndex = 12;
            this.classlabel.Text = "Class : ";
            // 
            // maillabel
            // 
            this.maillabel.AutoSize = true;
            this.maillabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maillabel.Location = new System.Drawing.Point(280, 226);
            this.maillabel.Name = "maillabel";
            this.maillabel.Size = new System.Drawing.Size(106, 25);
            this.maillabel.TabIndex = 13;
            this.maillabel.Text = "E-mail : ";
            // 
            // identityNumberlabel
            // 
            this.identityNumberlabel.AutoSize = true;
            this.identityNumberlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.identityNumberlabel.Location = new System.Drawing.Point(280, 263);
            this.identityNumberlabel.Name = "identityNumberlabel";
            this.identityNumberlabel.Size = new System.Drawing.Size(213, 25);
            this.identityNumberlabel.TabIndex = 14;
            this.identityNumberlabel.Text = "Identity Number :";
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genderlabel.Location = new System.Drawing.Point(282, 297);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(107, 25);
            this.genderlabel.TabIndex = 15;
            this.genderlabel.Text = "Gender :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gendercomboBox
            // 
            this.gendercomboBox.FormattingEnabled = true;
            this.gendercomboBox.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.gendercomboBox.Location = new System.Drawing.Point(505, 298);
            this.gendercomboBox.Name = "gendercomboBox";
            this.gendercomboBox.Size = new System.Drawing.Size(121, 24);
            this.gendercomboBox.TabIndex = 17;
            // 
            // mailtextBox
            // 
            this.mailtextBox.Location = new System.Drawing.Point(505, 229);
            this.mailtextBox.Name = "mailtextBox";
            this.mailtextBox.Size = new System.Drawing.Size(100, 22);
            this.mailtextBox.TabIndex = 19;
            // 
            // identityNumbertextBox
            // 
            this.identityNumbertextBox.Location = new System.Drawing.Point(505, 266);
            this.identityNumbertextBox.Name = "identityNumbertextBox";
            this.identityNumbertextBox.Size = new System.Drawing.Size(155, 22);
            this.identityNumbertextBox.TabIndex = 20;
            // 
            // phoneNumbermaskedTextBox
            // 
            this.phoneNumbermaskedTextBox.Location = new System.Drawing.Point(505, 337);
            this.phoneNumbermaskedTextBox.Name = "phoneNumbermaskedTextBox";
            this.phoneNumbermaskedTextBox.Size = new System.Drawing.Size(155, 22);
            this.phoneNumbermaskedTextBox.TabIndex = 21;
            // 
            // phoneNumberlabel
            // 
            this.phoneNumberlabel.AutoSize = true;
            this.phoneNumberlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNumberlabel.Location = new System.Drawing.Point(282, 332);
            this.phoneNumberlabel.Name = "phoneNumberlabel";
            this.phoneNumberlabel.Size = new System.Drawing.Size(200, 25);
            this.phoneNumberlabel.TabIndex = 22;
            this.phoneNumberlabel.Text = "Phone Number : ";
            // 
            // classcomboBox
            // 
            this.classcomboBox.FormattingEnabled = true;
            this.classcomboBox.Items.AddRange(new object[] {
            "Lise 1",
            "Lise 2",
            "Lise 3",
            "Lise 4"});
            this.classcomboBox.Location = new System.Drawing.Point(505, 193);
            this.classcomboBox.Name = "classcomboBox";
            this.classcomboBox.Size = new System.Drawing.Size(121, 24);
            this.classcomboBox.TabIndex = 23;
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1703, 861);
            this.Controls.Add(this.classcomboBox);
            this.Controls.Add(this.phoneNumberlabel);
            this.Controls.Add(this.phoneNumbermaskedTextBox);
            this.Controls.Add(this.identityNumbertextBox);
            this.Controls.Add(this.mailtextBox);
            this.Controls.Add(this.gendercomboBox);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.identityNumberlabel);
            this.Controls.Add(this.maillabel);
            this.Controls.Add(this.classlabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.manageStudentdataGridView);
            this.Controls.Add(this.manageStudentlabel);
            this.Name = "ManageStudentForm";
            this.Text = "ManageStudentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageStudentdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label manageStudentlabel;
        private System.Windows.Forms.DataGridView manageStudentdataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label classlabel;
        private System.Windows.Forms.Label maillabel;
        private System.Windows.Forms.Label identityNumberlabel;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox gendercomboBox;
        private System.Windows.Forms.TextBox mailtextBox;
        private System.Windows.Forms.TextBox identityNumbertextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumbermaskedTextBox;
        private System.Windows.Forms.Label phoneNumberlabel;
        private System.Windows.Forms.ComboBox classcomboBox;
    }
}