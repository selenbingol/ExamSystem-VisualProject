using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lgs_VisualProject
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
            this.Text = "Admin Home Page";
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close(); // Admin form kapanması
        }

        private void manageTestsButton_Click(object sender, EventArgs e)
        {
            ManageTestsForm testsForm = new ManageTestsForm();
            testsForm.FormClosed += (s, args) => this.Show(); // kapanınca geri dönme
            testsForm.Show();
            this.Hide(); // Admin'i gizleme
        }


        private void manageStudentsButton_Click(object sender, EventArgs e)
        {
            ManageStudentForm studentForm = new ManageStudentForm();
            studentForm.ShowDialog();
        }
    }
}