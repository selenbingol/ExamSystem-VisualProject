using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Lgs_VisualProject.Database;

namespace Lgs_VisualProject
{
    public partial class GraphicsStudent : Form
    {
        
        private int _studentId;

        public GraphicsStudent(int studentId)
        {
            InitializeComponent();
            _studentId = studentId;
        }
        private void GraphicsStudent_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.DatabaseConnection.GetConnection())
            {
                conn.Open();

               
                SqlCommand allExamsCmd = new SqlCommand(@"
            SELECT 
                e.exam_date,
                r.math_net, r.science_net, r.turkish_net,
                r.history_net, r.religion_net, r.english_net,
                r.total_net
            FROM Exams e
            INNER JOIN Results r ON e.exam_id = r.exam_id
            WHERE e.student_id = @studentId
            ORDER BY e.exam_date DESC", conn);

                allExamsCmd.Parameters.AddWithValue("@studentId", _studentId);

                SqlDataAdapter adapter = new SqlDataAdapter(allExamsCmd);
                DataTable allResults = new DataTable();
                adapter.Fill(allResults);
                dataGridView.DataSource = allResults;

              
                SqlCommand lastTwoCmd = new SqlCommand(@"
            SELECT TOP 2 
                e.exam_date,
                r.math_net, r.science_net, r.turkish_net,
                r.history_net, r.religion_net, r.english_net
            FROM Exams e
            INNER JOIN Results r ON e.exam_id = r.exam_id
            WHERE e.student_id = @studentId
            ORDER BY e.exam_date DESC", conn);

                lastTwoCmd.Parameters.AddWithValue("@studentId", _studentId);

                SqlDataAdapter chartAdapter = new SqlDataAdapter(lastTwoCmd);
                DataTable chartResults = new DataTable();
                chartAdapter.Fill(chartResults);

                if (chartResults.Rows.Count >= 2)
                {
                    DataRow exam1 = chartResults.Rows[0];
                    DataRow exam2 = chartResults.Rows[1];

            
                    chart1.Series.Clear();
                    chart1.Series.Add("Son Sınav");
                    chart1.Series["Son Sınav"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                    chart1.Series["Son Sınav"].Points.AddXY("Mat", exam1["math_net"]);
                    chart1.Series["Son Sınav"].Points.AddXY("Fen", exam1["science_net"]);
                    chart1.Series["Son Sınav"].Points.AddXY("Türkçe", exam1["turkish_net"]);
                    chart1.Series["Son Sınav"].Points.AddXY("Tarih", exam1["history_net"]);
                    chart1.Series["Son Sınav"].Points.AddXY("Din", exam1["religion_net"]);
                    chart1.Series["Son Sınav"].Points.AddXY("İng", exam1["english_net"]);

             
                    chart2.Series.Clear();
                    chart2.Series.Add("Önceki Sınav");
                    chart2.Series["Önceki Sınav"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                    chart2.Series["Önceki Sınav"].Points.AddXY("Mat", exam2["math_net"]);
                    chart2.Series["Önceki Sınav"].Points.AddXY("Fen", exam2["science_net"]);
                    chart2.Series["Önceki Sınav"].Points.AddXY("Türkçe", exam2["turkish_net"]);
                    chart2.Series["Önceki Sınav"].Points.AddXY("Tarih", exam2["history_net"]);
                    chart2.Series["Önceki Sınav"].Points.AddXY("Din", exam2["religion_net"]);
                    chart2.Series["Önceki Sınav"].Points.AddXY("İng", exam2["english_net"]);
                }
            }
        }
       

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void pdfbutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF File|*.pdf",
                Title = "PDF Olarak Kaydet",
                FileName = "ExamResults.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                       
                        Paragraph title = new Paragraph("Exam Results:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                        title.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title);
                        doc.Add(new Paragraph("\n"));

                
                        using (SqlConnection conn = DatabaseConnection.GetConnection())
                        {
                            conn.Open();

                            SqlCommand cmd = new SqlCommand(@"
                        SELECT 
                            e.exam_name,
                            r.math_correct, r.math_wrong, r.math_net,
                            r.science_correct, r.science_wrong, r.science_net,
                            r.turkish_correct, r.turkish_wrong, r.turkish_net,
                            r.history_correct, r.history_wrong, r.history_net,
                            r.religion_correct, r.religion_wrong, r.religion_net,
                            r.english_correct, r.english_wrong, r.english_net,
                            r.total_net
                        FROM Exams e
                        INNER JOIN Results r ON e.exam_id = r.exam_id
                        WHERE e.student_id = @studentId
                        ORDER BY e.exam_date ASC", conn);

                            cmd.Parameters.AddWithValue("@studentId", _studentId);

                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                string examName = reader["exam_name"].ToString();

                                Paragraph examTitle = new Paragraph($"Exam: {examName}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                                examTitle.Alignment = Element.ALIGN_LEFT;
                                doc.Add(examTitle);
                                doc.Add(new Paragraph("\n"));

                                PdfPTable table = new PdfPTable(5);
                                table.WidthPercentage = 100;
                                table.AddCell("CLASS");
                                table.AddCell("CORRECT");
                                table.AddCell("WRONG");
                                table.AddCell("BLANK");
                                table.AddCell("NET");

                                string[] subjects = { "math", "science", "turkish", "history", "religion", "english" };
                                foreach (string subject in subjects)
                                {
                                    int correct = Convert.ToInt32(reader[$"{subject}_correct"]);
                                    int wrong = Convert.ToInt32(reader[$"{subject}_wrong"]);
                                    int blank = 30 - (correct + wrong);
                                    double net = Convert.ToDouble(reader[$"{subject}_net"]);

                                    table.AddCell(subject.ToUpper());
                                    table.AddCell(correct.ToString());
                                    table.AddCell(wrong.ToString());
                                    table.AddCell(blank.ToString());
                                    table.AddCell(net.ToString("0.##"));
                                }

                                table.AddCell("TOPLAM NET");
                                table.AddCell(""); table.AddCell(""); table.AddCell("");
                                table.AddCell(reader["total_net"].ToString());

                                doc.Add(table);
                                doc.Add(new Paragraph("\n\n"));
                            }

                            reader.Close();
                        }

                        // Grafik ekle
                        using (MemoryStream chartImageStream = new MemoryStream())
                        {
                            chart1.SaveImage(chartImageStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                            iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(chartImageStream.ToArray());
                            chartImage.ScaleToFit(600f, 300f);
                            chartImage.Alignment = Element.ALIGN_CENTER;
                            doc.Add(new Paragraph("Results Graphic", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
                            doc.Add(new Paragraph("\n"));
                            doc.Add(chartImage);
                        }

                        doc.Close();
                    }

                    MessageBox.Show("PDF başarıyla oluşturuldu.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
