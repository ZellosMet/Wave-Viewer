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

namespace ReceivedDatagramm
{
	public partial class Form1 : Form
	{
		Socket socket;
		IPEndPoint local_host;
		EndPoint remote_host;
		byte[] datagramm = new byte[8192];
		bool server_ready = false;
		string ip_address;
		int port;
		public Form1()
		{
			InitializeComponent();
		}

		private void b_Start_Click(object sender, EventArgs e)
		{
			t_RefreshChart.Interval = (int)nud_Interval.Value;
			t_RefreshChart.Start();
			b_Start.Enabled = false;
			b_Stop.Enabled = true;
		}
		Task PaintChatr()
		{
			int[] data = new int[4096];
			int x = 0;

			try
			{
				int result = socket.ReceiveFrom(datagramm, ref remote_host);
				for (int i = 0, j = 0; i < datagramm.Length; i = i + 2, j++)
					data[j] = BitConverter.ToUInt16(datagramm, i);
				int max = data.Max();
				int min = data.Min();
				int avg = (int)data.Average();

				l_ResultReceiving.Text = $"Принята датаграмма. размер датаграммы {result}, Максимальное значение {max}, Минимальное значение {min}, Среднее значение {avg}";

				chart1.Series[0].Points.Clear();
				chart1.Series[1].Points.Clear();
				while (x <= data.Length - 1)
				{
					chart1.Series[0].Points.AddXY(x + 1, data[x]);
					chart1.Series[1].Points.AddXY(x + 1, avg);
					x++;
				}

			}
			catch (Exception ex)
			{
				l_ResultReceiving.Text = $"Не удалось принять датаграмму {ex.Message}";
				return Task.FromResult(0);
			}
			return Task.FromResult(0);
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
			chart1.Series[0].Points.Clear();
			chart1.Series[1].Points.Clear();
			b_Start.Enabled = true;
			b_Stop.Enabled = false;
		}

		private void b_Disconnect_Click(object sender, EventArgs e)
		{
			t_RefreshChart.Stop();
			chart1.Series[0].Points.Clear();
			chart1.Series[1].Points.Clear();
			b_Connect.Enabled = true;
			b_Disconnect.Enabled = false;
			b_Start.Enabled = false;
			b_Stop.Enabled = false;
			server_ready=false;
			socket.Close();
			l_StattusConnect.Text = "UDP-Сервер остановлен";
		}
	}
}
