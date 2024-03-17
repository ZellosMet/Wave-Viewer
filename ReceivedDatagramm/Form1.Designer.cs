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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.l_StattusConnect = new System.Windows.Forms.Label();
			this.b_Start = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.t_RefreshChart = new System.Windows.Forms.Timer(this.components);
			this.l_IPAddress = new System.Windows.Forms.Label();
			this.l_Port = new System.Windows.Forms.Label();
			this.nud_Port = new System.Windows.Forms.NumericUpDown();
			this.b_Connect = new System.Windows.Forms.Button();
			this.nud_Interval = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.l_ResultReceiving = new System.Windows.Forms.Label();
			this.b_Stop = new System.Windows.Forms.Button();
			this.iac_IPAddress = new ReceivedDatagramm.IPAddressControl();
			this.b_Disconnect = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Port)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Interval)).BeginInit();
			this.SuspendLayout();
			// 
			// l_StattusConnect
			// 
			this.l_StattusConnect.AutoSize = true;
			this.l_StattusConnect.Location = new System.Drawing.Point(597, 11);
			this.l_StattusConnect.Name = "l_StattusConnect";
			this.l_StattusConnect.Size = new System.Drawing.Size(96, 16);
			this.l_StattusConnect.TabIndex = 0;
			this.l_StattusConnect.Text = "Status Connect";
			// 
			// b_Start
			// 
			this.b_Start.Enabled = false;
			this.b_Start.Location = new System.Drawing.Point(370, 45);
			this.b_Start.Name = "b_Start";
			this.b_Start.Size = new System.Drawing.Size(108, 23);
			this.b_Start.TabIndex = 1;
			this.b_Start.Text = "Старт";
			this.b_Start.UseVisualStyleBackColor = true;
			this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
			legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(12, 81);
			this.chart1.Name = "chart1";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Legend = "Legend1";
			series3.Name = "Wave";
			series3.XValueMember = "0";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series4.Color = System.Drawing.Color.Black;
			series4.Legend = "Legend1";
			series4.Name = "Median";
			this.chart1.Series.Add(series3);
			this.chart1.Series.Add(series4);
			this.chart1.Size = new System.Drawing.Size(1379, 425);
			this.chart1.TabIndex = 2;
			this.chart1.Text = "chart1";
			// 
			// t_RefreshChart
			// 
			this.t_RefreshChart.Tick += new System.EventHandler(this.t_RefreshChart_Tick);
			// 
			// l_IPAddress
			// 
			this.l_IPAddress.AutoSize = true;
			this.l_IPAddress.Location = new System.Drawing.Point(12, 11);
			this.l_IPAddress.Name = "l_IPAddress";
			this.l_IPAddress.Size = new System.Drawing.Size(19, 16);
			this.l_IPAddress.TabIndex = 5;
			this.l_IPAddress.Text = "IP";
			// 
			// l_Port
			// 
			this.l_Port.AutoSize = true;
			this.l_Port.Location = new System.Drawing.Point(239, 11);
			this.l_Port.Name = "l_Port";
			this.l_Port.Size = new System.Drawing.Size(31, 16);
			this.l_Port.TabIndex = 6;
			this.l_Port.Text = "Port";
			// 
			// nud_Port
			// 
			this.nud_Port.Location = new System.Drawing.Point(288, 8);
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
			// 
			// b_Connect
			// 
			this.b_Connect.Location = new System.Drawing.Point(370, 7);
			this.b_Connect.Name = "b_Connect";
			this.b_Connect.Size = new System.Drawing.Size(108, 23);
			this.b_Connect.TabIndex = 9;
			this.b_Connect.Text = "Подключение";
			this.b_Connect.UseVisualStyleBackColor = true;
			this.b_Connect.Click += new System.EventHandler(this.b_Connect_Click);
			// 
			// nud_Interval
			// 
			this.nud_Interval.Location = new System.Drawing.Point(288, 46);
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
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Интервал получение данных";
			// 
			// l_ResultReceiving
			// 
			this.l_ResultReceiving.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.l_ResultReceiving.AutoSize = true;
			this.l_ResultReceiving.Location = new System.Drawing.Point(12, 515);
			this.l_ResultReceiving.Name = "l_ResultReceiving";
			this.l_ResultReceiving.Size = new System.Drawing.Size(109, 16);
			this.l_ResultReceiving.TabIndex = 12;
			this.l_ResultReceiving.Text = "Result Receiving";
			// 
			// b_Stop
			// 
			this.b_Stop.Enabled = false;
			this.b_Stop.Location = new System.Drawing.Point(484, 45);
			this.b_Stop.Name = "b_Stop";
			this.b_Stop.Size = new System.Drawing.Size(93, 23);
			this.b_Stop.TabIndex = 13;
			this.b_Stop.Text = "Стоп";
			this.b_Stop.UseVisualStyleBackColor = true;
			this.b_Stop.Click += new System.EventHandler(this.b_Stop_Click);
			// 
			// iac_IPAddress
			// 
			this.iac_IPAddress.BackColor = System.Drawing.SystemColors.Window;
			this.iac_IPAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.iac_IPAddress.FirstMax = 255;
			this.iac_IPAddress.FirstMin = 0;
			this.iac_IPAddress.FourdMax = 255;
			this.iac_IPAddress.FourdMin = 0;
			this.iac_IPAddress.Location = new System.Drawing.Point(43, 7);
			this.iac_IPAddress.Name = "iac_IPAddress";
			this.iac_IPAddress.SecondMax = 255;
			this.iac_IPAddress.SecondMin = 0;
			this.iac_IPAddress.Size = new System.Drawing.Size(180, 25);
			this.iac_IPAddress.TabIndex = 3;
			this.iac_IPAddress.TextIP = "127.0.0.1";
			this.iac_IPAddress.ThirdMax = 255;
			this.iac_IPAddress.ThirdMin = 0;
			// 
			// b_Disconnect
			// 
			this.b_Disconnect.Enabled = false;
			this.b_Disconnect.Location = new System.Drawing.Point(484, 7);
			this.b_Disconnect.Name = "b_Disconnect";
			this.b_Disconnect.Size = new System.Drawing.Size(93, 23);
			this.b_Disconnect.TabIndex = 14;
			this.b_Disconnect.Text = "Отключение";
			this.b_Disconnect.UseVisualStyleBackColor = true;
			this.b_Disconnect.Click += new System.EventHandler(this.b_Disconnect_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1403, 540);
			this.Controls.Add(this.b_Disconnect);
			this.Controls.Add(this.b_Stop);
			this.Controls.Add(this.l_ResultReceiving);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nud_Interval);
			this.Controls.Add(this.b_Connect);
			this.Controls.Add(this.nud_Port);
			this.Controls.Add(this.l_Port);
			this.Controls.Add(this.l_IPAddress);
			this.Controls.Add(this.iac_IPAddress);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.b_Start);
			this.Controls.Add(this.l_StattusConnect);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Port)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Interval)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label l_StattusConnect;
		private System.Windows.Forms.Button b_Start;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Timer t_RefreshChart;
		private IPAddressControl iac_IPAddress;
		private System.Windows.Forms.Label l_IPAddress;
		private System.Windows.Forms.Label l_Port;
		private System.Windows.Forms.NumericUpDown nud_Port;
		private System.Windows.Forms.Button b_Connect;
		private System.Windows.Forms.NumericUpDown nud_Interval;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label l_ResultReceiving;
		private System.Windows.Forms.Button b_Stop;
		private System.Windows.Forms.Button b_Disconnect;
	}
}

