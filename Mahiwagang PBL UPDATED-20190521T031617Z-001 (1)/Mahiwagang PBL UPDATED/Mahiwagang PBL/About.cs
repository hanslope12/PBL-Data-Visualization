using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahiwagang_PBL
{
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
			LBL_AboutContent.Text = "Detritwos shows you how extracurricular activities affect you\nphysically.It tells your stress level, number of hours spent on\nacademics and extracurricular activities, and the type of org\nand the relationships between the data.";
			
		}


		int value = 0;

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			switch (value)
			{
				case 0:
					LBL_AboutContent.Text = "Ang Detritwos ay kumukuha ng mga input ng gumagamit at\npinagsasama ito para ilabas sa tsart ang datos na nakuha.\nAng tsart ay nag-kukumpara ng datos base sa 'stress level',\n'hours for activities','type of activity',at 'main source of stress'.\n";
					LanguageButton.Image = Properties.Resources.FLAG_PH;
					value = 1;
					break;
				case 1:
					LBL_AboutContent.Text = "Detritwos shows you how extracurricular activities affect you\nphysically.It tells your stress level, number of hours spent on\nacademics and extracurricular activities, and the type of org\nand the relationships between the data.";
					LanguageButton.Image = Properties.Resources.FLAG_UK;
					value = 0;
					break;
			}
		}

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form form1 = new Charts();
            form1.Show();
            this.Hide();
        }
    }
}
