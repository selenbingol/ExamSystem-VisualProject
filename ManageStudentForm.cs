using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lgs_VisualProject.Database;

namespace Lgs_VisualProject
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
        SELECT 
            s.student_id,
            u.username,
            u.password,
            s.phone_number,
            s.identity_number,
            s.gender,
            s.email,
            s.student_class
        FROM Students s
        INNER JOIN Users u ON s.user_id = u.user_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                manageStudentdataGridView.DataSource = dt;

                // ID kolonlarını gizle
                if (manageStudentdataGridView.Columns.Contains("student_id"))
                    manageStudentdataGridView.Columns["student_id"].Visible = false;
            }
        }




        private void manageStudentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string phone = phoneNumbermaskedTextBox.Text.Trim();
            string identity = identityNumbertextBox.Text.Trim();
            string gender = gendercomboBox.Text;
            string email = mailtextBox.Text.Trim();
            string studentClass = classcomboBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                SqlCommand checkUserCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE username = @username", conn);
                checkUserCmd.Parameters.AddWithValue("@username", username);
                int userCount = (int)checkUserCmd.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten mevcut. Lütfen başka bir kullanıcı adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

           
                SqlCommand insertUser = new SqlCommand(@"
    INSERT INTO Users (username, password, role)
    VALUES (@username, @password, 'Student');
    SELECT CAST(SCOPE_IDENTITY() AS INT);", conn);
                insertUser.Parameters.AddWithValue("@username", username);
                insertUser.Parameters.AddWithValue("@password", password);

                int userId = (int)insertUser.ExecuteScalar();


                SqlCommand insertStudent = new SqlCommand(@"
            INSERT INTO Students 
            (username, password, phone_number, identity_number, gender, email, student_class, user_id)
            VALUES 
            (@username, @password, @phone, @identity, @gender, @mail, @class, @user_id)", conn);

                insertStudent.Parameters.AddWithValue("@username", username);
                insertStudent.Parameters.AddWithValue("@password", password);
                insertStudent.Parameters.AddWithValue("@phone", phone);
                insertStudent.Parameters.AddWithValue("@identity", identity);
                insertStudent.Parameters.AddWithValue("@gender", gender);
                insertStudent.Parameters.AddWithValue("@mail", email);
                insertStudent.Parameters.AddWithValue("@class", studentClass);
                insertStudent.Parameters.AddWithValue("@user_id", userId);

                insertStudent.ExecuteNonQuery();
            }

            LoadStudents();
            MessageBox.Show("Yeni öğrenci başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            usernameTextBox.Clear();
            passwordTextBox.Clear();
            phoneNumbermaskedTextBox.Clear();
            identityNumbertextBox.Clear();
            mailtextBox.Clear();
            classcomboBox.SelectedIndex = -1;
            gendercomboBox.SelectedIndex = -1;
        }




        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            if (manageStudentdataGridView.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(manageStudentdataGridView.CurrentRow.Cells["student_id"].Value);

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Önce user_id'yi al
                    SqlCommand getUserIdCmd = new SqlCommand("SELECT user_id FROM Students WHERE student_id = @id", conn);
                    getUserIdCmd.Parameters.AddWithValue("@id", studentId);
                    object userIdObj = getUserIdCmd.ExecuteScalar();

                    if (userIdObj != null)
                    {
                        int userId = Convert.ToInt32(userIdObj);

                        
                        SqlCommand deleteStudent = new SqlCommand("DELETE FROM Students WHERE student_id = @id", conn);
                        deleteStudent.Parameters.AddWithValue("@id", studentId);
                        deleteStudent.ExecuteNonQuery();

                        
                        SqlCommand deleteUser = new SqlCommand("DELETE FROM Users WHERE user_id = @uid", conn);
                        deleteUser.Parameters.AddWithValue("@uid", userId);
                        deleteUser.ExecuteNonQuery();
                    }
                }

                LoadStudents();
                MessageBox.Show("Öğrenci ve ona bağlı kullanıcı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                // Öğrenci tablosundan tüm bilgileri alıyoruz
                SqlDataAdapter adapter = new SqlDataAdapter(@"
            SELECT student_id, username, password, phone_number, identity_number, gender, email, student_class 
            FROM Students", conn);

                // SQL komutları otomatik oluşturulacak
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                // Sadece yapılan değişiklikleri al
                DataTable changes = ((DataTable)manageStudentdataGridView.DataSource).GetChanges();

                // Değişiklik varsa güncelle
                if (changes != null)
                {
                    adapter.Update(changes);
                    MessageBox.Show("Güncellemeler başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents(); // Yeniden yükle
                }
                else
                {
                    MessageBox.Show("Hiçbir değişiklik yapılmadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void classtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void graphicbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
