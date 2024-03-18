using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceivedDatagramm
{
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
			l_Info.Text = $@"
							Wave Viever
							Версия: 0.2
							Wave Viever - программа представляет из себя сервер по приёму
							сигнала с удалённого клиента. Есть возможность включения 
							медиального фильтра.
							Разработчик: User1
							";
		}
	}
}
