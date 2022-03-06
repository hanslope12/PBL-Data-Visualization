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
namespace Mahiwagang_PBL
{
	public partial class Input : Form
	{
		public Input()
		{
			InitializeComponent();
           
		}
        string org_type = "";

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            int j = 1;
            j += bunifuSlider1.Value;
            stressLevelIndicator.Text = j.ToString();

            if(1 <= j && j < 4)
            {
                bunifuSlider1.IndicatorColor = System.Drawing.Color.Lime;
                stressLevelIndicator.ForeColor = System.Drawing.Color.Lime;
            }
            else if (4 <= j && j < 8)
            {
                bunifuSlider1.IndicatorColor = System.Drawing.Color.GreenYellow;
                stressLevelIndicator.ForeColor = System.Drawing.Color.GreenYellow;
            }
            else
            {
                bunifuSlider1.IndicatorColor = System.Drawing.Color.Red;
                stressLevelIndicator.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            using (StreamWriter CSV = File.AppendText("D:\\Pbl_Name.txt"))
            {
                CSV.Write(NameBox.Text + ",");
                NameBox.Text = string.Empty;
                NameBox.Focus();

                CSV.Close();
            }

            using (StreamWriter H = File.AppendText("D:\\Pbl_Hour.txt"))
            {
               
                H.Write(HourBox.Text + ",");
                HourBox.Text = string.Empty;
              
                H.Close();
            }
            using (StreamWriter R = File.AppendText("D:\\Pbl_Reason.txt"))
            {
             
                R.Write(ReasonBox.Text + ",");
                ReasonBox.Text = string.Empty;
                R.Close();
            }
            using (StreamWriter S = File.AppendText("D:\\Pbl_Stress.txt"))
            {
                S.Write(bunifuSlider1.Value + 1 + ",");
                bunifuSlider1.Value = 0;
 
                S.Close();
            }

          /*    WebClient client = new WebClient();
              client.Credentials = new NetworkCredential("rumian", "Kirisame1");
              client.UploadFile("ftp://66.220.9.50/My Documents/Pbl_Name.txt", "C:\\Users\\2018SHA01229\\Pbl_Name.txt");
            client.UploadFile("ftp://66.220.9.50/My Documents/Pbl_Hour.txt", "C:\\Users\\2018SHA01229\\Pbl_Hour.txt");
            client.UploadFile("ftp://66.220.9.50/My Documents/Pbl_Reason.txt", "C:\\Users\\2018SHA01229\\Pbl_Reason.txt");
            client.UploadFile("ftp://66.220.9.50/My Documents/Pbl_Stress.txt", "C:\\Users\\2018SHA01229\\Pbl_Stress.txt");
            */




        }

        private void Input_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

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

     
        private void Non_Org_Click(object sender, EventArgs e)
        {
            org_type = "No Organization";
            Non_Org.ForeColor = System.Drawing.Color.Blue;
            Hobby.ForeColor = System.Drawing.Color.SeaGreen;
            Sport.ForeColor = System.Drawing.Color.SeaGreen;
        }

        private void Hobby_Click(object sender, EventArgs e)
        {
            org_type = "Hobby Organization";
            Hobby.ForeColor = System.Drawing.Color.Blue;
            Non_Org.ForeColor = System.Drawing.Color.SeaGreen;
            Sport.ForeColor = System.Drawing.Color.SeaGreen;
        }

        private void Sport_Click(object sender, EventArgs e)
        {
            org_type = "Sport Organization";
            Sport.ForeColor = System.Drawing.Color.Blue;
            Non_Org.ForeColor = System.Drawing.Color.SeaGreen;
            Hobby.ForeColor = System.Drawing.Color.SeaGreen;
        }
    }
}
