namespace ReceivedDatagramm
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.l_StattusConnect = new System.Windows.Forms.Label();
			this.b_Start = new System.Windows.Forms.Button();
			this.cht_Wave = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.t_RefreshChart = new System.Windows.Forms.Timer(this.components);
			this.l_IPAddress = new System.Windows.Forms.Label();
			this.l_Port = new System.Windows.Forms.Label();
			this.nud_Port = new System.Windows.Forms.NumericUpDown();
			this.b_Connect = new System.Windows.Forms.Button();
			this.nud_Interval = new System.Windows.Forms.NumericUpDown();
			this.l_Interval = new System.Windows.Forms.Label();
			this.l_ResultReceivingSignal = new System.Windows.Forms.Label();
			this.b_Stop = new System.Windows.Forms.Button();
			this.b_Disconnect = new System.Windows.Forms.Button();
			this.chb_Wave = new System.Windows.Forms.CheckBox();
			this.chb_Filter = new System.Windows.Forms.CheckBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsm_Tools = new System.Windows.Forms.ToolStripMenuItem();
			this.About = new System.Windows.Forms.ToolStripMenuItem();
			this.WaveViewer = new System.Windows.Forms.ToolStripMenuItem();
			this.iac_IPAddress = new ReceivedDatagramm.IPAddressControl();
			((System.ComponentModel.ISupportInitialize)(this.cht_Wave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Port)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Interval)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// l_StattusConnect
			// 
			this.l_StattusConnect.AutoSize = true;
			this.l_StattusConnect.Location = new System.Drawing.Point(597, 52);
			this.l_StattusConnect.Name = "l_StattusConnect";
			this.l_StattusConnect.Size = new System.Drawing.Size(96, 16);
			this.l_StattusConnect.TabIndex = 0;
			this.l_StattusConnect.Text = "Status Connect";
			this.l_StattusConnect.Visible = false;
			// 
			// b_Start
			// 
			this.b_Start.Enabled = false;
			this.b_Start.Location = new System.Drawing.Point(370, 86);
			this.b_Start.Name = "b_Start";
			this.b_Start.Size = new System.Drawing.Size(108, 23);
			this.b_Start.TabIndex = 1;
			this.b_Start.Text = "Старт";
			this.b_Start.UseVisualStyleBackColor = true;
			this.b_Start.Visible = false;
			this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
			// 
			// cht_Wave
			// 
			this.cht_Wave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.cht_Wave.ChartAreas.Add(chartArea1);
			legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Name = "Legend1";
			this.cht_Wave.Legends.Add(legend1);
			this.cht_Wave.Location = new System.Drawing.Point(12, 122);
			this.cht_Wave.Name = "cht_Wave";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Color = System.Drawing.Color.Blue;
			series1.LabelBorderWidth = 2;
			series1.Legend = "Legend1";
			series1.Name = "Wave";
			series1.XValueMember = "0";
			series2.BorderWidth = 2;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Color = System.Drawing.Color.Black;
			series2.Legend = "Legend1";
			series2.Name = "Median";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Color = System.Drawing.Color.Red;
			series3.Legend = "Legend1";
			series3.Name = "Filter";
			this.cht_Wave.Series.Add(series1);
			this.cht_Wave.Series.Add(series2);
			this.cht_Wave.Series.Add(series3);
			this.cht_Wave.Size = new System.Drawing.Size(1420, 425);
			this.cht_Wave.TabIndex = 2;
			this.cht_Wave.Text = "chart1";
			this.cht_Wave.Visible = false;
			// 
			// t_RefreshChart
			// 
			this.t_RefreshChart.Tick += new System.EventHandler(this.t_RefreshChart_Tick);
			// 
			// l_IPAddress
			// 
			this.l_IPAddress.AutoSize = true;
			this.l_IPAddress.Location = new System.Drawing.Point(12, 52);
			this.l_IPAddress.Name = "l_IPAddress";
			this.l_IPAddress.Size = new System.Drawing.Size(19, 16);
			this.l_IPAddress.TabIndex = 5;
			this.l_IPAddress.Text = "IP";
			this.l_IPAddress.Visible = false;
			// 
			// l_Port
			// 
			this.l_Port.AutoSize = true;
			this.l_Port.Location = new System.Drawing.Point(239, 52);
			this.l_Port.Name = "l_Port";
			this.l_Port.Size = new System.Drawing.Size(31, 16);
			this.l_Port.TabIndex = 6;
			this.l_Port.Text = "Port";
			this.l_Port.Visible = false;
			// 
			// nud_Port
			// 
			this.nud_Port.Location = new System.Drawing.Point(288, 49);
			this.nud_Port.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.nud_Port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_Port.Name = "nud_Port";
			this.nud_Port.Size = new System.Drawing.Size(76, 22);
			this.nud_Port.TabIndex = 7;
			this.nud_Port.Value = new decimal(new int[] {
            10002,
            0,
            0,
            0});
			this.nud_Port.Visible = false;
			// 
			// b_Connect
			// 
			this.b_Connect.Location = new System.Drawing.Point(370, 48);
			this.b_Connect.Name = "b_Connect";
			this.b_Connect.Size = new System.Drawing.Size(108, 23);
			this.b_Connect.TabIndex = 9;
			this.b_Connect.Text = "Подключение";
			this.b_Connect.UseVisualStyleBackColor = true;
			this.b_Connect.Visible = false;
			this.b_Connect.Click += new System.EventHandler(this.b_Connect_Click);
			// 
			// nud_Interval
			// 
			this.nud_Interval.Location = new System.Drawing.Point(288, 87);
			this.nud_Interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nud_Interval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nud_Interval.Name = "nud_Interval";
			this.nud_Interval.Size = new System.Drawing.Size(75, 22);
			this.nud_Interval.TabIndex = 10;
			this.nud_Interval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nud_Interval.Visible = false;
			// 
			// l_Interval
			// 
			this.l_Interval.AutoSize = true;
			this.l_Interval.Location = new System.Drawing.Point(12, 89);
			this.l_Interval.Name = "l_Interval";
			this.l_Interval.Size = new System.Drawing.Size(197, 16);
			this.l_Interval.TabIndex = 11;
			this.l_Interval.Text = "Интервал получение данных";
			this.l_Interval.Visible = false;
			// 
			// l_ResultReceivingSignal
			// 
			this.l_ResultReceivingSignal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.l_ResultReceivingSignal.AutoSize = true;
			this.l_ResultReceivingSignal.Location = new System.Drawing.Point(12, 554);
			this.l_ResultReceivingSignal.Name = "l_ResultReceivingSignal";
			this.l_ResultReceivingSignal.Size = new System.Drawing.Size(150, 16);
			this.l_ResultReceivingSignal.TabIndex = 12;
			this.l_ResultReceivingSignal.Text = "Result Receiving Signal";
			this.l_ResultReceivingSignal.Visible = false;
			// 
			// b_Stop
			// 
			this.b_Stop.Enabled = false;
			this.b_Stop.Location = new System.Drawing.Point(484, 86);
			this.b_Stop.Name = "b_Stop";
			this.b_Stop.Size = new System.Drawing.Size(93, 23);
			this.b_Stop.TabIndex = 13;
			this.b_Stop.Text = "Стоп";
			this.b_Stop.UseVisualStyleBackColor = true;
			this.b_Stop.Visible = false;
			this.b_Stop.Click += new System.EventHandler(this.b_Stop_Click);
			// 
			// b_Disconnect
			// 
			this.b_Disconnect.Enabled = false;
			this.b_Disconnect.Location = new System.Drawing.Point(484, 48);
			this.b_Disconnect.Name = "b_Disconnect";
			this.b_Disconnect.Size = new System.Drawing.Size(93, 23);
			this.b_Disconnect.TabIndex = 14;
			this.b_Disconnect.Text = "Отключение";
			this.b_Disconnect.UseVisualStyleBackColor = true;
			this.b_Disconnect.Visible = false;
			this.b_Disconnect.Click += new System.EventHandler(this.b_Disconnect_Click);
			// 
			// chb_Wave
			// 
			this.chb_Wave.AutoSize = true;
			this.chb_Wave.Checked = true;
			this.chb_Wave.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chb_Wave.Location = new System.Drawing.Point(600, 89);
			this.chb_Wave.Name = "chb_Wave";
			this.chb_Wave.Size = new System.Drawing.Size(76, 20);
			this.chb_Wave.TabIndex = 15;
			this.chb_Wave.Text = "Сигнал";
			this.chb_Wave.UseVisualStyleBackColor = true;
			this.chb_Wave.Visible = false;
			// 
			// chb_Filter
			// 
			this.chb_Filter.AutoSize = true;
			this.chb_Filter.Location = new System.Drawing.Point(682, 89);
			this.chb_Filter.Name = "chb_Filter";
			this.chb_Filter.Size = new System.Drawing.Size(78, 20);
			this.chb_Filter.TabIndex = 16;
			this.chb_Filter.Text = "Фильтр";
			this.chb_Filter.UseVisualStyleBackColor = true;
			this.chb_Filter.Visible = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Tools});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1444, 28);
			this.menuStrip1.TabIndex = 17;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsm_Tools
			// 
			this.tsm_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.WaveViewer});
			this.tsm_Tools.Name = "tsm_Tools";
			this.tsm_Tools.Size = new System.Drawing.Size(58, 24);
			this.tsm_Tools.Text = "Tools";
			// 
			// About
			// 
			this.About.Image = global::ReceivedDatagramm.Properties.Resources.about;
			this.About.Name = "About";
			this.About.Size = new System.Drawing.Size(177, 26);
			this.About.Text = "About";
			this.About.Click += new System.EventHandler(this.About_Click);
			// 
			// WaveViewer
			// 
			this.WaveViewer.Image = global::ReceivedDatagramm.Properties.Resources.wave;
			this.WaveViewer.Name = "WaveViewer";
			this.WaveViewer.Size = new System.Drawing.Size(177, 26);
			this.WaveViewer.Text = "Wave Viewer";
			this.WaveViewer.Click += new System.EventHandler(this.WaveViewer_Click);
			// 
			// iac_IPAddress
			// 
			this.iac_IPAddress.BackColor = System.Drawing.SystemColors.Window;
			this.iac_IPAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.iac_IPAddress.FirstMax = 255;
			this.iac_IPAddress.FirstMin = 0;
			this.iac_IPAddress.FourdMax = 255;
			this.iac_IPAddress.FourdMin = 0;
			this.iac_IPAddress.Location = new System.Drawing.Point(43, 48);
			this.iac_IPAddress.Name = "iac_IPAddress";
			this.iac_IPAddress.SecondMax = 255;
			this.iac_IPAddress.SecondMin = 0;
			this.iac_IPAddress.Size = new System.Drawing.Size(180, 25);
			this.iac_IPAddress.TabIndex = 3;
			this.iac_IPAddress.TextIP = "127.0.0.1";
			this.iac_IPAddress.ThirdMax = 255;
			this.iac_IPAddress.ThirdMin = 0;
			this.iac_IPAddress.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1444, 592);
			this.Controls.Add(this.chb_Filter);
			this.Controls.Add(this.chb_Wave);
			this.Controls.Add(this.b_Disconnect);
			this.Controls.Add(this.b_Stop);
			this.Controls.Add(this.l_ResultReceivingSignal);
			this.Controls.Add(this.l_Interval);
			this.Controls.Add(this.nud_Interval);
			this.Controls.Add(this.b_Connect);
			this.Controls.Add(this.nud_Port);
			this.Controls.Add(this.l_Port);
			this.Controls.Add(this.l_IPAddress);
			this.Controls.Add(this.iac_IPAddress);
			this.Controls.Add(this.cht_Wave);
			this.Controls.Add(this.b_Start);
			this.Controls.Add(this.l_StattusConnect);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Wave Viever";
			((System.ComponentModel.ISupportInitialize)(this.cht_Wave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Port)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Interval)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label l_StattusConnect;
		private System.Windows.Forms.Button b_Start;
		private System.Windows.Forms.DataVisualization.Charting.Chart cht_Wave;
		private System.Windows.Forms.Timer t_RefreshChart;
		private IPAddressControl iac_IPAddress;
		private System.Windows.Forms.Label l_IPAddress;
		private System.Windows.Forms.Label l_Port;
		private System.Windows.Forms.NumericUpDown nud_Port;
		private System.Windows.Forms.Button b_Connect;
		private System.Windows.Forms.NumericUpDown nud_Interval;
		private System.Windows.Forms.Label l_Interval;
		private System.Windows.Forms.Label l_ResultReceivingSignal;
		private System.Windows.Forms.Button b_Stop;
		private System.Windows.Forms.Button b_Disconnect;
		private System.Windows.Forms.CheckBox chb_Wave;
		private System.Windows.Forms.CheckBox chb_Filter;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsm_Tools;
		private System.Windows.Forms.ToolStripMenuItem About;
		private System.Windows.Forms.ToolStripMenuItem WaveViewer;
	}
}

