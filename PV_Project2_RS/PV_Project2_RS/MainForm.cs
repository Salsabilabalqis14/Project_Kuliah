using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PV_Project2_RS
{
	public partial class MainForm : Form
	{
		private SqlCommand cmd;
		private SqlDataAdapter da;
		
		Koneksi Konn = new Koneksi();
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from tbl_user where username = '"+textBox1.Text+"' and password = '"+textBox2.Text+"'", conn);
				da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				
				if(dt.Rows.Count > 0)
				{
					this.Hide();
					Home n = new Home();
					n.Show();
				}
				else
				{
					MessageBox.Show("Invalid Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception G){
				MessageBox.Show(G.ToString());
			}			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
