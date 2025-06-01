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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace Lgs_VisualProject
{

    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
            LoadResults();
            LoadStudentsToComboBox();
            LoadExamsToComboBox();
         
        }
        

        private void LoadStudentsToComboBox()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
            SELECT u.username
            FROM Users u
            INNER JOIN Students s ON u.user_id = s.user_id
            WHERE u.role = 'Student'", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                studentcomboBox.Items.Clear();
                while (reader.Read())
                {
                    studentcomboBox.Items.Add(reader["username"].ToString());
                }
            }
        }
        private void LoadExamsToComboBox()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT exam_name FROM Exams WHERE exam_name IS NOT NULL", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                examcomboBox.Items.Clear();
                while (reader.Read())
                {
                    examcomboBox.Items.Add(reader["exam_name"].ToString());
                }
            }
        }

        private void studentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUsername = studentcomboBox.SelectedItem.ToString();
            LoadResultsForStudent(selectedUsername);
        }

        private void LoadResultsForStudent(string username)
        {

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                            SELECT r.result_id, r.exam_id, u.username, e.exam_name,
                       r.math_correct, r.math_wrong, r.math_net,
                       r.science_correct, r.science_wrong, r.science_net,
                       r.turkish_correct, r.turkish_wrong, r.turkish_net,
                       r.history_correct, r.history_wrong, r.history_net,
                       r.religion_correct, r.religion_wrong, r.religion_net,
                       r.english_correct, r.english_wrong, r.english_net,
                       r.total_net
                FROM Results r
                JOIN Exams e ON r.exam_id = e.exam_id
                JOIN Students s ON e.student_id = s.student_id
                JOIN Users u ON s.user_id = u.user_id
                WHERE u.username = @username

";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@username", username);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                resultsDataGridView.DataSource = dt;
                resultsDataGridView.Columns["result_id"].Visible = false;
                resultsDataGridView.Columns["exam_id"].Visible = false;

                


            }
        }


        private void LoadResults()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
            SELECT r.result_id, r.exam_id, u.username, e.exam_name,
                   r.math_correct, r.math_wrong, r.math_net,
                   r.science_correct, r.science_wrong, r.science_net,
                   r.turkish_correct, r.turkish_wrong, r.turkish_net,
                   r.history_correct, r.history_wrong, r.history_net,
                   r.religion_correct, r.religion_wrong, r.religion_net,
                   r.english_correct, r.english_wrong, r.english_net,
                   r.total_net
            FROM Results r
            JOIN Exams e ON r.exam_id = e.exam_id
            JOIN Students s ON e.student_id = s.student_id
            JOIN Users u ON s.user_id = u.user_id
        ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                resultsDataGridView.DataSource = dt;

                resultsDataGridView.Columns["result_id"].Visible = false;
                resultsDataGridView.Columns["exam_id"].Visible = false;
                


            }
        }



        private double GetNet(string correct, string wrong, string subject)
        {
            int c = int.TryParse(correct, out var cc) ? cc : 0;
            int w = int.TryParse(wrong, out var ww) ? ww : 0;

            // Ders bazlı maksimum soru limiti
            Dictionary<string, int> subjectLimits = new Dictionary<string, int>()
    {
        { "Math", 20 }, { "Science", 20 },
        { "Turkish", 20 }, { "History", 10 },
        { "Religion", 10 }, { "English", 10 }
    };

            int maxLimit = subjectLimits.ContainsKey(subject) ? subjectLimits[subject] : 30;

            if (c + w > maxLimit)
            {
                MessageBox.Show($"{subject}: Correct + Wrong cannot exceed {maxLimit}.");
                throw new Exception("Validation failed");
            }

            return Math.Round(c - w / 4.0, 2);
        }


        private void addButon_Click(object sender, EventArgs e)
        {
            string username = studentcomboBox.SelectedItem?.ToString();
            string examName = examcomboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(examName))
            {
                MessageBox.Show("Please select both student and exam.");
                return;
            }

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                // Get student_id
                SqlCommand getUserIdCmd = new SqlCommand("SELECT user_id FROM Users WHERE username = @username", conn);
                getUserIdCmd.Parameters.AddWithValue("@username", username);
                int userId = Convert.ToInt32(getUserIdCmd.ExecuteScalar());

                SqlCommand getStudentIdCmd = new SqlCommand("SELECT student_id FROM Students WHERE user_id = @userId", conn);
                getStudentIdCmd.Parameters.AddWithValue("@userId", userId);
                int studentId = Convert.ToInt32(getStudentIdCmd.ExecuteScalar());

                // Check if exam already exists for this student
                SqlCommand checkExamCmd = new SqlCommand(@"
            SELECT exam_id FROM Exams 
            WHERE student_id = @sid AND exam_name = @exam_name", conn);
                checkExamCmd.Parameters.AddWithValue("@sid", studentId);
                checkExamCmd.Parameters.AddWithValue("@exam_name", examName);

                object existingExamIdObj = checkExamCmd.ExecuteScalar();
                int examId;

                if (existingExamIdObj != null)
                {
                    examId = Convert.ToInt32(existingExamIdObj);
                }
                else
                {
                    // Insert new exam
                    SqlCommand insertExam = new SqlCommand(@"
                INSERT INTO Exams (student_id, exam_date, exam_name) 
                OUTPUT INSERTED.exam_id 
                VALUES (@sid, @date, @exam_name)", conn);
                    insertExam.Parameters.AddWithValue("@sid", studentId);
                    insertExam.Parameters.AddWithValue("@date", DateTime.Now);
                    insertExam.Parameters.AddWithValue("@exam_name", examName);
                    examId = (int)insertExam.ExecuteScalar();
                }

                try
                {
                    // Get values
                    int mathCorrect = int.Parse(mathCorrecttextBox.Text);
                    int mathWrong = int.Parse(mathWrongtextBox.Text);
                    double mathNet = GetNet(mathCorrecttextBox.Text, mathWrongtextBox.Text, "Math");

                    int scienceCorrect = int.Parse(scienceCorrecttextBox.Text);
                    int scienceWrong = int.Parse(scienceWrongtextBox.Text);
                    double scienceNet = GetNet(scienceCorrecttextBox.Text, scienceWrongtextBox.Text, "Science");

                    int turkishCorrect = int.Parse(turkishtextBox.Text);
                    int turkishWrong = int.Parse(turkishWrongtextBox.Text);
                    double turkishNet = GetNet(turkishtextBox.Text, turkishWrongtextBox.Text, "Turkish");

                    int historyCorrect = int.Parse(historyCorrecttextBox.Text);
                    int historyWrong = int.Parse(historyWrongtextBox.Text);
                    double historyNet = GetNet(historyCorrecttextBox.Text, historyWrongtextBox.Text, "History");

                    int religionCorrect = int.Parse(religionCorrecttextBox.Text);
                    int religionWrong = int.Parse(religionWrongtextBox.Text);
                    double religionNet = GetNet(religionCorrecttextBox.Text, religionWrongtextBox.Text, "Religion");

                    int englishCorrect = int.Parse(englishCorrecttextBox.Text);
                    int englishWrong = int.Parse(englishWrongtextBox.Text);
                    double englishNet = GetNet(englishCorrecttextBox.Text, englishWrongtextBox.Text, "English");

                    double totalNet = mathNet + scienceNet + turkishNet + historyNet + religionNet + englishNet;

                    // Insert Result
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
                )
                VALUES (
                    @exam_id,
                    @math_correct, @math_wrong, @math_net,
                    @science_correct, @science_wrong, @science_net,
                    @turkish_correct, @turkish_wrong, @turkish_net,
                    @history_correct, @history_wrong, @history_net,
                    @religion_correct, @religion_wrong, @religion_net,
                    @english_correct, @english_wrong, @english_net,
                    @total_net
                )", conn);

                    insertResult.Parameters.AddWithValue("@exam_id", examId);
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

                    LoadResultsForStudent(username);
                    MessageBox.Show("Added new result.");
                }
                catch
                {
                    
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"
            SELECT r.result_id, r.exam_id,
                   r.math_correct, r.math_wrong, r.math_net,
                   r.science_correct, r.science_wrong, r.science_net,
                   r.turkish_correct, r.turkish_wrong, r.turkish_net,
                   r.history_correct, r.history_wrong, r.history_net,
                   r.religion_correct, r.religion_wrong, r.religion_net,
                   r.english_correct, r.english_wrong, r.english_net,
                   r.total_net
            FROM Results r", conn);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataTable changes = ((DataTable)resultsDataGridView.DataSource).GetChanges();

                if (changes != null)
                {
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.Update(changes);
                    MessageBox.Show("Updated.");

                    
                    string selectedUsername = studentcomboBox.SelectedItem?.ToString();
                    if (!string.IsNullOrEmpty(selectedUsername))
                        LoadResultsForStudent(selectedUsername);
                }
            }
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (resultsDataGridView.CurrentRow != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this exam and its result?",
                                    "Confirm Delete",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);

                if (confirmResult != DialogResult.Yes)
                    return;

                int examId = Convert.ToInt32(resultsDataGridView.CurrentRow.Cells["exam_id"].Value);

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    SqlCommand deleteResults = new SqlCommand("DELETE FROM Results WHERE exam_id = @id", conn);
                    deleteResults.Parameters.AddWithValue("@id", examId);
                    deleteResults.ExecuteNonQuery();

                    SqlCommand deleteExam = new SqlCommand("DELETE FROM Exams WHERE exam_id = @id", conn);
                    deleteExam.Parameters.AddWithValue("@id", examId);
                    deleteExam.ExecuteNonQuery();
                }

                string selectedUsername = studentcomboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedUsername))
                    LoadResultsForStudent(selectedUsername);

                MessageBox.Show("Exam and results are deleted.");
            }
        }




        private void resultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void graphicsButton_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            GraphicsForm graphicsForm = new GraphicsForm();
            graphicsForm.FormClosed += (s, args) => this.Show(); 
            graphicsForm.Show();

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void mathCorrecttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mathWrongtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void examcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pdfbutton_Click(object sender, EventArgs e)
        {
            if (resultsDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF File|*.pdf",
                Title = "Save Result PDF",
                FileName = "StudentResults.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
                        PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        string studentName = studentcomboBox.SelectedItem?.ToString() ?? "Student";
                        var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                        Paragraph title = new Paragraph($"Student: {studentName}", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title);
                        doc.Add(new Paragraph("\n"));

                        foreach (DataGridViewRow row in resultsDataGridView.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string examName = row.Cells["exam_name"].Value?.ToString() ?? "Exam";
                            Paragraph examTitle = new Paragraph($"Exam: {examName}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                            examTitle.Alignment = Element.ALIGN_LEFT;
                            doc.Add(examTitle);
                            doc.Add(new Paragraph("\n"));

                            PdfPTable table = new PdfPTable(5); 
                            table.WidthPercentage = 100;

                            table.AddCell("SUBJECT");
                            table.AddCell("CORRECT");
                            table.AddCell("WRONG");
                            table.AddCell("BLANK");
                            table.AddCell("NET");

                            string[] subjects = { "Turkish", "History", "Religion", "English", "Math", "Science" };
                            foreach (string subject in subjects)
                            {
                                string lower = subject.ToLower();
                                int correct = Convert.ToInt32(row.Cells[$"{lower}_correct"].Value ?? 0);
                                int wrong = Convert.ToInt32(row.Cells[$"{lower}_wrong"].Value ?? 0);
                                int blank = 30 - (correct + wrong);
                                double net = Convert.ToDouble(row.Cells[$"{lower}_net"].Value ?? 0);

                                table.AddCell(subject.ToUpper());
                                table.AddCell(correct.ToString());
                                table.AddCell(wrong.ToString());
                                table.AddCell(blank.ToString());
                                table.AddCell(net.ToString("0.##"));
                            }

                            table.AddCell("TOTAL NET");
                            table.AddCell(""); table.AddCell(""); table.AddCell("");
                            table.AddCell(row.Cells["total_net"].Value?.ToString() ?? "0");

                            doc.Add(table);
                            doc.Add(new Paragraph("\n\n"));
                        }

                        doc.Close();
                    }

                    MessageBox.Show("PDF exported successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting PDF: " + ex.Message);
                }
            }
        }




    }
}
