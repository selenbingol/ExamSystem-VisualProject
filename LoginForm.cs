using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Lgs_VisualProject.Database;


namespace Lgs_VisualProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
          
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("Admin");
                comboBox1.Items.Add("Student");
                comboBox1.SelectedIndex = 0; 
            }
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string selectedRole = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Lütfen kullanıcı adı, şifre ve rol seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password AND role = @role";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", selectedRole);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        if (selectedRole == "Admin")
                        {
                            AdminHomeForm adminHome = new AdminHomeForm();
                            adminHome.Show();
                            this.Hide();
                        }
                        else if (selectedRole == "Student")
                        {
                            StudentHomeForm studentHome = new StudentHomeForm(username);
                            studentHome.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı, şifre veya rol hatalı.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

