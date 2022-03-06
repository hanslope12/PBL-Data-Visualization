using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using LiveCharts;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;

namespace Mahiwagang_PBL
{

    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
            /*  WebClient client = new WebClient();
              client.Credentials = new NetworkCredential("rumian", "kirisame1");
             client.DownloadFile("ftp://66.220.9.50/My Documents/Pbl_Name.txt", "D:\\Pbl_Name.txt");
             client.DownloadFile("ftp://66.220.9.50/My Documents/Pbl_Hour.txt", "D:\\Pbl_Hour.txt");
             client.DownloadFile("ftp://66.220.9.50/My Documents/Pbl_Stress.txt", "D:\\Pbl_Stress.txt");
             client.DownloadFile("ftp://66.220.9.50/My Documents/Pbl_Reason.txt", "D:\\Pbl_Reason.txt");*/
            StreamReader n = new StreamReader("D:\\Pbl_Name.txt");
            StreamReader h = new StreamReader("D:\\Pbl_Hour.txt");
            StreamReader s = new StreamReader("D:\\Pbl_Stress.txt");
            StreamReader r = new StreamReader("D:\\Pbl_Reason.txt");
            string lines = n.ReadToEnd();
            string[] allLines = lines.Split(',');

            for (int i = 0; i <= allLines.Length; i += 2)
            {
                try
                {
                    int count = 0;
                    int j = i + 1;
                    int y = int.Parse(allLines[j]);
                    int x = int.Parse(allLines[i]);
                    
                    // MessageBox.Show(x.ToString());
                    //MessageBox.Show(b.ToString());
                    count++;
                }
                catch
                {

                }
              
            }

                MessageBox.Show("SUCCESSFULLY DOWNLOADED.");
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                Load_Charts();
            }

            private void Load_Charts()
            {
                //STRESS LEVEL TYPES
                CHART_StressLevel.AxisX.Add(new Axis
                {
                    Title = "Stress Level",
                    Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }

                });


                //PER STRESS LEVEL NUMBER
                System.Drawing.Color c = ColorTranslator.FromHtml("#FFFFFF");
                System.Windows.Media.Color color = System.Windows.Media.Color.FromRgb(c.R, c.G, c.B);


                CHART_StressLevel.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "# Of Respondents",
                    Values = new ChartValues< int> {},
                    Stroke = new System.Windows.Media.SolidColorBrush(color),
                    Fill = Brushes.Red

                }
            };


            }

            private void bunifuThinButton21_Click(object sender, EventArgs e)
            {
                Form form1 = new Input();
                form1.Show();
                this.Hide();
            }

            private void bunifuThinButton22_Click(object sender, EventArgs e)
            {
                Form form1 = new Main_Menu();
                form1.Show();
                this.Hide();
            }

            private void bunifuThinButton23_Click(object sender, EventArgs e)
            {
                Form form1 = new Input();
                form1.Show();
                this.Hide();
            }

            private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
            {

            }

            private void bunifuCards2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void cartesianChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
            {

            }

            private void bunifuCards3_Paint(object sender, PaintEventArgs e)
            {

            }

            private void cartesianChart3_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
            {

            }

            private void bunifuCards4_Paint(object sender, PaintEventArgs e)
            {

            }

            private void bunifuCards1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void CHART_StressLevel_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
            {

            }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Form form1 = new Main_Menu();
            form1.Show();
            this.Hide();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Form form1 = new About();
            form1.Show();
            this.Hide();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            Form form1 = new Charts();
            form1.Show();
            this.Hide();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            Form form1 = new Input();
            form1.Show();
            this.Hide();
        }
    }
    }



