using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void greetingButton1_Click(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.Now;
			showLabel.Text = dateTime.ToString("yyyy/MM/dd HH:mm:ss") + "  Greeting";
			MessageBox.Show(dateTime.ToString("yyyy/MM/dd HH:mm:ss"));
		}

		private void greetingButton2_Click(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.Now;
			showLabel.Text = dateTime.ToString("yyyy/MM/dd HH:mm:ss") + "\r\nGreeting";
		}
	}
}
