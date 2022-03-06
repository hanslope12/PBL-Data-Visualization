using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;


namespace Mahiwagang_PBL
{
	public partial class Main_Menu : Form
	{
		public Main_Menu()
		{
			InitializeComponent();
		}

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form form1 = new About();
            form1.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form form1 = new Charts();
            form1.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form form1 = new Input();
            form1.Show();
            this.Hide();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            //Form nib = new Splash_Screen();
            //nib.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
