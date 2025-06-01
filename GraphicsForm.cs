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
using System.Windows.Forms.DataVisualization.Charting;
using Lgs_VisualProject.Database;


namespace Lgs_VisualProject
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
            LoadStudentsToComboBox();
            
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
                while (reader.Read())
                {
                    studentscomboBox.Items.Add(reader["username"].ToString());
                }
            }
        }


        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadStudentExamCharts(string username)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT TOP 3 e.exam_name,
                   r.math_net, r.science_net, r.turkish_net,
                   r.history_net, r.religion_net, r.english_net
            FROM Results r
            JOIN Exams e ON r.exam_id = e.exam_id
            JOIN Students s ON e.student_id = s.student_id
            JOIN Users u ON s.user_id = u.user_id
            WHERE u.username = @username
            ORDER BY e.exam_date DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                // Grafik temizle
                chart1.Series.Clear();
                chart2.Series.Clear();
                chart3.Series.Clear();

                Chart[] charts = { chart1, chart2, chart3 };
                int index = 0;

                while (reader.Read() && index < 3)
                {
                    string examName = reader["exam_name"].ToString();

                    Series series = new Series(examName);
                    series.ChartType = SeriesChartType.Column;

                    series.Points.AddXY("Math", Convert.ToDouble(reader["math_net"]));
                    series.Points.AddXY("Science", Convert.ToDouble(reader["science_net"]));
                    series.Points.AddXY("Turkish", Convert.ToDouble(reader["turkish_net"]));
                    series.Points.AddXY("History", Convert.ToDouble(reader["history_net"]));
                    series.Points.AddXY("Religion", Convert.ToDouble(reader["religion_net"]));
                    series.Points.AddXY("English", Convert.ToDouble(reader["english_net"]));

                    charts[index].Series.Clear();
                    charts[index].Series.Add(series);
                    charts[index].ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                    charts[index].ChartAreas[0].AxisY.Title = "Net";

                    index++;
                }
            }
        }

        private void generateGraphicButton_Click(object sender, EventArgs e)
        {
            string selectedUsername = studentscomboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedUsername))
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            LoadStudentExamCharts(selectedUsername);
        }


        private void studentExamChart_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void GraphicsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void studentscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
