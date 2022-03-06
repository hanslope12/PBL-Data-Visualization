namespace Mahiwagang_PBL
{
	partial class Charts
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charts));
            this.CHART_StressLevel = new LiveCharts.WinForms.CartesianChart();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.Hours_Spent = new LiveCharts.WinForms.CartesianChart();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.Org_Type = new LiveCharts.WinForms.PieChart();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.Input = new Bunifu.Framework.UI.BunifuTileButton();
            this.About = new Bunifu.Framework.UI.BunifuTileButton();
            this.Help = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CHART_StressLevel
            // 
            this.CHART_StressLevel.BackColor = System.Drawing.Color.White;
            this.CHART_StressLevel.Location = new System.Drawing.Point(0, 7);
            this.CHART_StressLevel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CHART_StressLevel.Name = "CHART_StressLevel";
            this.CHART_StressLevel.Size = new System.Drawing.Size(678, 367);
            this.CHART_StressLevel.TabIndex = 0;
            this.CHART_StressLevel.Text = "cartesianChart1";
            this.CHART_StressLevel.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.CHART_StressLevel_ChildChanged);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Red;
            this.bunifuCards1.Controls.Add(this.CHART_StressLevel);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(14, 96);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(678, 374);
            this.bunifuCards1.TabIndex = 4;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "ThinButton";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(2965, 1744);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(516, 243);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.bunifuCards2.Controls.Add(this.Hours_Spent);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(708, 96);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(678, 374);
            this.bunifuCards2.TabIndex = 5;
            this.bunifuCards2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards2_Paint);
            // 
            // Hours_Spent
            // 
            this.Hours_Spent.BackColor = System.Drawing.Color.White;
            this.Hours_Spent.Location = new System.Drawing.Point(0, 7);
            this.Hours_Spent.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Hours_Spent.Name = "Hours_Spent";
            this.Hours_Spent.Size = new System.Drawing.Size(678, 367);
            this.Hours_Spent.TabIndex = 0;
            this.Hours_Spent.Text = "cartesianChart1";
            this.Hours_Spent.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.bunifuCards3.Controls.Add(this.Org_Type);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(14, 484);
            this.bunifuCards3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(678, 374);
            this.bunifuCards3.TabIndex = 6;
            this.bunifuCards3.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards3_Paint);
            // 
            // Org_Type
            // 
            this.Org_Type.Location = new System.Drawing.Point(0, 7);
            this.Org_Type.Name = "Org_Type";
            this.Org_Type.Size = new System.Drawing.Size(675, 364);
            this.Org_Type.TabIndex = 1;
            this.Org_Type.Text = "pieChart2";
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.bunifuCards4.Controls.Add(this.pieChart1);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(708, 484);
            this.bunifuCards4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(678, 374);
            this.bunifuCards4.TabIndex = 7;
            this.bunifuCards4.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards4_Paint);
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(0, 7);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(675, 367);
            this.pieChart1.TabIndex = 21;
            this.pieChart1.Text = "pieChart1";
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.SeaGreen;
            this.Input.color = System.Drawing.Color.SeaGreen;
            this.Input.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Input.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Input.ForeColor = System.Drawing.Color.White;
            this.Input.Image = ((System.Drawing.Image)(resources.GetObject("Input.Image")));
            this.Input.ImagePosition = 20;
            this.Input.ImageZoom = 50;
            this.Input.LabelPosition = 41;
            this.Input.LabelText = "Input";
            this.Input.Location = new System.Drawing.Point(561, 15);
            this.Input.Margin = new System.Windows.Forms.Padding(6);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(128, 58);
            this.Input.TabIndex = 20;
            this.Input.Click += new System.EventHandler(this.bunifuTileButton6_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.SeaGreen;
            this.About.color = System.Drawing.Color.SeaGreen;
            this.About.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Image = ((System.Drawing.Image)(resources.GetObject("About.Image")));
            this.About.ImagePosition = 20;
            this.About.ImageZoom = 50;
            this.About.LabelPosition = 41;
            this.About.LabelText = "About";
            this.About.Location = new System.Drawing.Point(92, 15);
            this.About.Margin = new System.Windows.Forms.Padding(6);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(128, 58);
            this.About.TabIndex = 18;
            this.About.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.SeaGreen;
            this.Help.color = System.Drawing.Color.SeaGreen;
            this.Help.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Help.ForeColor = System.Drawing.Color.White;
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.ImagePosition = 20;
            this.Help.ImageZoom = 50;
            this.Help.LabelPosition = 41;
            this.Help.LabelText = "Help";
            this.Help.Location = new System.Drawing.Point(1053, 25);
            this.Help.Margin = new System.Windows.Forms.Padding(6);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(128, 58);
            this.Help.TabIndex = 18;
            this.Help.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // Charts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.About);
            this.Controls.Add(this.bunifuCards4);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuCards1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Charts";
            this.Text = "Charts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards4.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private LiveCharts.WinForms.CartesianChart CHART_StressLevel;
		private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
	    private Bunifu.Framework.UI.BunifuCards bunifuCards2;
		private LiveCharts.WinForms.CartesianChart Hours_Spent;
		private Bunifu.Framework.UI.BunifuCards bunifuCards3;
		private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private Bunifu.Framework.UI.BunifuTileButton Input;
        private Bunifu.Framework.UI.BunifuTileButton About;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.PieChart Org_Type;
        private Bunifu.Framework.UI.BunifuTileButton Help;
    }
}

