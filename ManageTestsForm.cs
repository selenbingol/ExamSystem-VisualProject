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
    public partial class ManageTestsForm : Form
    {
        public ManageTestsForm()
        {
            InitializeComponent();
        }

        private void ManageTestsForm_Load(object sender, EventArgs e)
        {
            LoadExams();
            LoadStudentsToComboBox();
        }

        private void LoadStudentsToComboBox()
        {
            studentcomboBox.Items.Clear(); // önceki öğeleri temizle

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
            SELECT u.username
            FROM Students s
            INNER JOIN Users u ON s.user_id = u.user_id
            WHERE u.role = 'Student'", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    studentcomboBox.Items.Add(reader["username"].ToString());
                }
            }
        }



        private void LoadExams()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
            SELECT 
                e.exam_id,
                e.student_id,
                u.username,
                e.exam_date,
                e.exam_name
            FROM Exams e
            INNER JOIN Students s ON e.student_id = s.student_id
            INNER JOIN Users u ON s.user_id = u.user_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                testsDataGridView.DataSource = dt;

                
                testsDataGridView.Columns["exam_id"].Visible = false;
                testsDataGridView.Columns["student_id"].Visible = false;
            }
        }





        private void addButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string selectedUsername = studentcomboBox.Text.Trim();
                string examName = examNametextBox.Text.Trim();
                DateTime examDate = examdateTimePicker.Value;

                if (string.IsNullOrEmpty(selectedUsername) || string.IsNullOrEmpty(examName))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                // Öğrencinin ID'sini al
                SqlCommand getStudentIdCmd = new SqlCommand(@"
            SELECT s.student_id
            FROM Students s
            INNER JOIN Users u ON s.user_id = u.user_id
            WHERE u.username = @username", conn);
                getStudentIdCmd.Parameters.AddWithValue("@username", selectedUsername);

                object result = getStudentIdCmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Seçilen kullanıcı sistemde bulunamadı.");
                    return;
                }

                int studentId = Convert.ToInt32(result);

                // Exams tablosuna ekle
                SqlCommand insertExam = new SqlCommand(
                    "INSERT INTO Exams (student_id, exam_date, exam_name) VALUES (@sid, @date, @name)", conn);
                insertExam.Parameters.AddWithValue("@sid", studentId);
                insertExam.Parameters.AddWithValue("@date", examDate);
                insertExam.Parameters.AddWithValue("@name", examName);
                insertExam.ExecuteNonQuery();

                MessageBox.Show("Sınav başarıyla eklendi.");
                LoadExams();
            }
        }



        private void updateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT exam_id, student_id, exam_date FROM Exams", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                DataTable changes = ((DataTable)testsDataGridView.DataSource).GetChanges();

                if (changes != null)
                {
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.Update(changes);
                    MessageBox.Show("Güncelleme tamamlandı.");
                    LoadExams();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (testsDataGridView.CurrentRow != null)
            {
                int examId = Convert.ToInt32(testsDataGridView.CurrentRow.Cells["exam_id"].Value);

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Önce bağlı olan Results kaydını sil
                    SqlCommand deleteResult = new SqlCommand("DELETE FROM Results WHERE exam_id = @id", conn);
                    deleteResult.Parameters.AddWithValue("@id", examId);
                    deleteResult.ExecuteNonQuery();

                    // Sonra Exams kaydını sil
                    SqlCommand deleteExam = new SqlCommand("DELETE FROM Exams WHERE exam_id = @id", conn);
                    deleteExam.Parameters.AddWithValue("@id", examId);
                    deleteExam.ExecuteNonQuery();
                }

                LoadExams();
                MessageBox.Show("Sınav başarıyla silindi.");
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void manageResultsButton_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.FormClosed += (s, args) => this.Show(); 
            resultsForm.Show();
        }



        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void studentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUsername = studentcomboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedUsername))
                return;

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
        SELECT 
            e.exam_id,
            e.student_id,
            u.username,
            e.exam_date,
            e.exam_name
        FROM Exams e
        INNER JOIN Students s ON e.student_id = s.student_id
        INNER JOIN Users u ON s.user_id = u.user_id
        WHERE u.username = @username";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@username", selectedUsername);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                testsDataGridView.DataSource = dt;

                testsDataGridView.Columns["exam_id"].Visible = false;
                testsDataGridView.Columns["student_id"].Visible = false;
            }
        }


        private void examNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void examdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
