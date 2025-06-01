using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lgs_VisualProject.Database;

namespace Lgs_VisualProject
{
    public partial class AddMyTestForm : Form
    {
        private int currentStudentId = 1; // Giriş yapan öğrencinin ID'si burada tutulur

        
        private string _username;

        public AddMyTestForm(string username)
        {
            InitializeComponent();
            _username = username;
            LoadStudentExams();
        }


        private void LoadStudentExams()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
            SELECT e.exam_id, e.exam_date,
                   r.math_correct, r.math_wrong, r.math_net,
                   r.science_correct, r.science_wrong, r.science_net,
                   r.turkish_correct, r.turkish_wrong, r.turkish_net,
                   r.history_correct, r.history_wrong, r.history_net,
                   r.religion_correct, r.religion_wrong, r.religion_net,
                   r.english_correct, r.english_wrong, r.english_net,
                   r.total_net
            FROM Exams e
            INNER JOIN Results r ON e.exam_id = r.exam_id
            WHERE e.student_id = @studentId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@studentId", currentStudentId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                testsDataGridView.DataSource = dt;

               
                if (testsDataGridView.Columns.Contains("exam_id"))
                    testsDataGridView.Columns["exam_id"].Visible = false;
            }
        }


        private void addButton_Click(object sender, EventArgs e)
{
    try
    {
        using (SqlConnection conn = DatabaseConnection.GetConnection())
        {
            conn.Open();

            // Yeni sınavı Exams tablosuna ekle
            SqlCommand insertExam = new SqlCommand(
                "INSERT INTO Exams (student_id, exam_date) OUTPUT INSERTED.exam_id VALUES (@student_id, @date)", conn);
            insertExam.Parameters.AddWithValue("@student_id", currentStudentId);
            insertExam.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);  // Tarihi al
            int newExamId = (int)insertExam.ExecuteScalar();

                   
                    double GetNet(int correct, int wrong, int maxQuestion, string subjectName)
                    {
                        if (correct + wrong > maxQuestion)
                        {
                            MessageBox.Show($"{subjectName} alanında doğru + yanlış toplamı {maxQuestion} sorudan fazla olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            throw new Exception("Geçersiz veri");
                        }
                        return Math.Round(correct - (wrong / 4.0), 2);
                    }


                    int mathCorrect = Convert.ToInt32(mathCorrecttextBox.Text);
                    int mathWrong = Convert.ToInt32(mathWrongtextBox.Text);
                    double mathNet = GetNet(mathCorrect, mathWrong, 20, "Math");

                    int scienceCorrect = Convert.ToInt32(scienceCorrecttextBox.Text);
                    int scienceWrong = Convert.ToInt32(scienceWrongtextBox.Text);
                    double scienceNet = GetNet(scienceCorrect, scienceWrong, 20, "Science");

                    int turkishCorrect = Convert.ToInt32(turkishCorrecttextBox.Text);
                    int turkishWrong = Convert.ToInt32(turkishWrongtextBox.Text);
                    double turkishNet = GetNet(turkishCorrect, turkishWrong, 20, "Turkish");

                    int historyCorrect = Convert.ToInt32(historyCorrecttextBox.Text);
                    int historyWrong = Convert.ToInt32(historyWrongtextBox.Text);
                    double historyNet = GetNet(historyCorrect, historyWrong, 10, "History");

                    int religionCorrect = Convert.ToInt32(religionCorrecttextBox.Text);
                    int religionWrong = Convert.ToInt32(religionWrongtextBox.Text);
                    double religionNet = GetNet(religionCorrect, religionWrong, 10, "Religion");

                    int englishCorrect = Convert.ToInt32(englishCorrecttextBox.Text);
                    int englishWrong = Convert.ToInt32(englishWrongtextBox.Text);
                    double englishNet = GetNet(englishCorrect, englishWrong, 10, "English");

                    double totalNet = mathNet + scienceNet + turkishNet + historyNet + religionNet + englishNet;

            // Results tablosuna ekle
            SqlCommand insertResult = new SqlCommand(@"
                INSERT INTO Results (
                    exam_id,
                    math_correct, math_wrong, math_net,
                    science_correct, science_wrong, science_net,
                    turkish_correct, turkish_wrong, turkish_net,
                    history_correct, history_wrong, history_net,
                    religion_correct, religion_wrong, religion_net,
                    english_correct, english_wrong, english_net,
                    total_net
                ) VALUES (
                    @exam_id,
                    @math_correct, @math_wrong, @math_net,
                    @science_correct, @science_wrong, @science_net,
                    @turkish_correct, @turkish_wrong, @turkish_net,
                    @history_correct, @history_wrong, @history_net,
                    @religion_correct, @religion_wrong, @religion_net,
                    @english_correct, @english_wrong, @english_net,
                    @total_net
                )", conn);

            insertResult.Parameters.AddWithValue("@exam_id", newExamId);
            insertResult.Parameters.AddWithValue("@math_correct", mathCorrect);
            insertResult.Parameters.AddWithValue("@math_wrong", mathWrong);
            insertResult.Parameters.AddWithValue("@math_net", mathNet);
            insertResult.Parameters.AddWithValue("@science_correct", scienceCorrect);
            insertResult.Parameters.AddWithValue("@science_wrong", scienceWrong);
            insertResult.Parameters.AddWithValue("@science_net", scienceNet);
            insertResult.Parameters.AddWithValue("@turkish_correct", turkishCorrect);
            insertResult.Parameters.AddWithValue("@turkish_wrong", turkishWrong);
            insertResult.Parameters.AddWithValue("@turkish_net", turkishNet);
            insertResult.Parameters.AddWithValue("@history_correct", historyCorrect);
            insertResult.Parameters.AddWithValue("@history_wrong", historyWrong);
            insertResult.Parameters.AddWithValue("@history_net", historyNet);
            insertResult.Parameters.AddWithValue("@religion_correct", religionCorrect);
            insertResult.Parameters.AddWithValue("@religion_wrong", religionWrong);
            insertResult.Parameters.AddWithValue("@religion_net", religionNet);
            insertResult.Parameters.AddWithValue("@english_correct", englishCorrect);
            insertResult.Parameters.AddWithValue("@english_wrong", englishWrong);
            insertResult.Parameters.AddWithValue("@english_net", englishNet);
            insertResult.Parameters.AddWithValue("@total_net", totalNet);

            insertResult.ExecuteNonQuery();
        }

        LoadStudentExams();
        MessageBox.Show("Yeni sınav başarıyla eklendi.");

    
        mathCorrecttextBox.Clear();
        mathWrongtextBox.Clear();
        scienceCorrecttextBox.Clear();
        scienceWrongtextBox.Clear();
        turkishCorrecttextBox.Clear();
        turkishWrongtextBox.Clear();
        historyCorrecttextBox.Clear();
        historyWrongtextBox.Clear();
        religionCorrecttextBox.Clear();
        religionWrongtextBox.Clear();
        englishCorrecttextBox.Clear();
        englishWrongtextBox.Clear();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Hata oluştu: " + ex.Message);
    }
}



        private void testsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StudentHomeForm studentHome = new StudentHomeForm(_username);
            studentHome.Show();
            this.Close();
        }

        private void AddMyTestForm_Load(object sender, EventArgs e)
        {

        }

        private void examNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mathCorrecttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void graphicsbutton_Click(object sender, EventArgs e)
        {
            GraphicsStudent graphicsForm = new GraphicsStudent(currentStudentId);
            graphicsForm.Show();
            this.Close();
        }
    }
}
