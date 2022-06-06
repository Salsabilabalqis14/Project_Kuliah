using System;
using System.Drawing;
using System.Windows.Forms;

namespace PV_Project2_RS
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Hide();
			data_pasien n = new data_pasien();
			n.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
			data_dokter n = new data_dokter();
			n.Show();	
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.Hide();
			data_obat n = new data_obat();
			n.Show();		
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm n = new MainForm();
			n.Show();		
		}
		
	}
}
