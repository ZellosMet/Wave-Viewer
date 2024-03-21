using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Reflection;
using System.Collections;
using System.IO;

namespace ReceivedDatagramm
{
	public partial class Form1 : Form
	{
		Socket socket;
		IPEndPoint local_host;
		EndPoint remote_host;
		static int size_datagram = 8192;
		byte[] datagram = new byte[size_datagram];
		bool server_ready = false;
		string ip_address;
		int port;
		public Form1()
		{
			InitializeComponent();
		}
		Task PaintChatr()
		{
			short[] data = new short[size_datagram/2];
			int x = 0;
			try
			{
				short median = 0;
				short fmedian = 0;
				int result = socket.ReceiveFrom(datagram, ref remote_host);
				for (int i = 0, j = 0; i < datagram.Length-1; i+=2, j++)
					data[j] = (short)(datagram[i] << 8 | (datagram[i+1] ));

				short max = data.Max();
				short min = data.Min();
				//short avg = Avg(data);

				short[] filter_data = new short[data.Length];

				filter_data = MedianFilter(data);
				short fmax = filter_data.Max();
				short fmin = filter_data.Min();
				//short favg = Avg(filter_data);

				cht_Wave.Series[0].Points.Clear();
				cht_Wave.Series[1].Points.Clear();
				cht_Wave.Series[2].Points.Clear();
				while (x <= data.Length - 1)
				{
					if (chb_Wave.Checked)
					{ 
						cht_Wave.Series[0].Points.AddXY(x + 1, data[x]);
						cht_Wave.Series[0].Color = Color.Blue;
					}
					if (chb_Filter.Checked)
					{ 
						cht_Wave.Series[2].Points.AddXY(x + 1, filter_data[x]);
						cht_Wave.Series[0].Color = Color.RoyalBlue;
					}
					median = GetMedian(data);
					fmedian = GetMedian(filter_data);
					cht_Wave.Series[1].Points.AddXY(x + 1, median);
					x++;
				}
				l_ResultReceivingSignal.Text = $"Принята датаграмма. размер датаграммы {result}, Максимальное значение {max}, Минимальное значение {min}, Среднее значение {median}";
				if(chb_Filter.Checked)
					l_ResultReceivingSignal.Text += $"\nМаксимальное значение фильтра {fmax}, Минимальное значение фильтра {fmin}, Среднее значение фильтра {fmedian}";
			}
			catch (Exception ex)
			{
				l_ResultReceivingSignal.Text = $"Не удалось принять датаграмму {ex.Message}";
				return Task.FromResult(0);
			}
			return Task.FromResult(0);
		}

		short GetMedian(short[] data)
		{
			short median;
			short[] cdata = new short[data.Length];
			Array.Copy(data, cdata, data.Length);
			Array.Sort(cdata);
			median = cdata[cdata.Length / 2];
			return median;
		}
		//short Avg(short[] data)
		//{
		//	short avg = 0;
		//	for (int i = 0; i < data.Length; i++)
		//		avg += data[1];
		//	avg /= (short)data.Length;
		//	return avg;
		//}
		short[] MedianFilter(short[] data)
		{
			short[] filter_data = new short[data.Length];
			short median, a, b, c, i=0;
			for (; i < filter_data.Length-2; i++)
			{ 
				a = data[i];
				b = data[i + 1];
				c = data[i + 2];
				median = (Math.Max(a, b) == Math.Max(b, c)) ? Math.Max(a, c) : Math.Max(b, Math.Min(a, c));
				filter_data[i] = median;
				if(i == filter_data.Length - 3)
					filter_data[filter_data.Length-2] = filter_data[filter_data.Length-1] = median;
			}
			return filter_data;
		}
		private async void t_RefreshChart_Tick(object sender, EventArgs e)
		{
			await PaintChatr();
		}
		private void b_Connect_Click(object sender, EventArgs e)
		{
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			ip_address = iac_IPAddress.TextIP;
			port = (int)nud_Port.Value;
			local_host = new IPEndPoint(IPAddress.Parse(ip_address), port);
			remote_host = (EndPoint)local_host;
			try
			{
				socket.Bind(local_host);
				l_StattusConnect.Text = "UDP-сервер запущен!";
				b_Start.Enabled = true;
				server_ready = true;
				b_Disconnect.Enabled = true;
				b_Connect.Enabled = false;
			}
			catch (Exception ex)
			{
				l_StattusConnect.Text = $"Сервер не запущен! {ex.Message}";
				server_ready = false;
			}
		}
		private void b_Stop_Click(object sender, EventArgs e)
		{
			t_RefreshChart.Stop();
			//chart1.Series[0].Points.Clear();
			//chart1.Series[1].Points.Clear();
			//chart1.Series[2].Points.Clear();
			b_Start.Enabled = true;
			b_Stop.Enabled = false;
		}

		private void b_Disconnect_Click(object sender, EventArgs e)
		{
			t_RefreshChart.Stop();
			cht_Wave.Series[0].Points.Clear();
			cht_Wave.Series[1].Points.Clear();
			cht_Wave.Series[2].Points.Clear();
			b_Connect.Enabled = true;
			b_Disconnect.Enabled = false;
			b_Start.Enabled = false;
			b_Stop.Enabled = false;
			server_ready=false;
			socket.Close();
			l_StattusConnect.Text = "UDP-Сервер остановлен";
		}
		private void b_Start_Click(object sender, EventArgs e)
		{
			t_RefreshChart.Interval = (int)nud_Interval.Value;
			t_RefreshChart.Start();
			b_Start.Enabled = false;
			b_Stop.Enabled = true;
		}

		private void About_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}

		private void WaveViewer_Click(object sender, EventArgs e)
		{
			l_IPAddress.Visible = true;
			l_Port.Visible = true;
			l_ResultReceivingSignal.Visible = true;
			l_StattusConnect.Visible = true;
			l_Interval.Visible = true;
			b_Connect.Visible = true;
			b_Disconnect.Visible = true;
			b_Start.Visible = true;
			b_Stop.Visible = true;
			iac_IPAddress.Visible = true;
			nud_Interval.Visible = true;
			nud_Port.Visible = true;
			chb_Filter.Visible = true;
			chb_Wave.Visible = true;
			cht_Wave.Visible = true;
		}
	}
}
