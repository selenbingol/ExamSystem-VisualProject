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
    public partial class StudentHomeForm : Form
    {
        private string _username;

        public StudentHomeForm(string username)
        {
            InitializeComponent();
            _username = username;
            this.Text = $"Student Home - Welcome, {_username}";
        }

        private void addMyTestButton_Click(object sender, EventArgs e)
        {
            AddMyTestForm testForm = new AddMyTestForm(_username); 
            testForm.Show();
            this.Hide();
        }



        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Giriş sayfasına dön
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Bu sayfayı kapat
            this.Close();
        }

        private void StudentHomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}