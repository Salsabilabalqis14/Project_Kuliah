using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UAS_PV_No4
{
	public partial class MainForm : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
		
		Koneksi Konn = new Koneksi();
		
		public MainForm()
		{
			InitializeComponent();

		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			TampilData();
			Muncul_pilihan();
			Bersihkan();
			IdOtomatis();
		}
		
		void TampilData()
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from data_menu", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "data_menu");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "data_menu";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
			finally{
				conn.Close();
			}
		}
		
		void Bersihkan()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "0";
			textBox4.Text = "0";
			comboBox1.Text = "";
			comboBox2.Text = "";
			IdOtomatis();
		}
		
		
		void Muncul_pilihan()
		{
			comboBox1.Items.Add("Makanan");
			comboBox1.Items.Add("Minuman");
			comboBox1.Items.Add("Desert");
			
			comboBox2.Items.Add("Porsi");
			comboBox2.Items.Add("Gelas");
		}
		
		void IdOtomatis()
		{
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select id_menu from data_menu where id_menu in (select max (id_menu) from data_menu) order by id_menu desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if(rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["id_menu"].ToString().Length - 3, 3)) + 1;
				string kodeurutan = "000" + hitung;
				urutan = "A"+kodeurutan.Substring(kodeurutan.Length - 3, 3);
			} 
			else
			{
				urutan = "A001";
			}
			rd.Close();
			textBox1.Text = urutan;
			conn.Close();
		}
		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				textBox1.Text = row.Cells["id_menu"].Value.ToString();
				textBox2.Text = row.Cells["nama_menu"].Value.ToString();
				textBox3.Text = row.Cells["harga"].Value.ToString();
				textBox4.Text = row.Cells["stok"].Value.ToString();
				comboBox1.Text = row.Cells["jenis_menu"].Value.ToString();
				comboBox2.Text = row.Cells["satuan"].Value.ToString();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			/* Memeriksa apakah kolom teks kosong */  	
			
			if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || comboBox1.Text.Trim() == "" || comboBox2.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia!!!");
			}
			else
			{
				/* Simpan Data */  
				SqlConnection conn = Konn.GetConn();
				try
				{
					conn.Open();
					cmd = new SqlCommand("Insert into data_menu values ('"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox1.Text+"','"+comboBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')", conn);	
					cmd.ExecuteNonQuery();
					MessageBox.Show("Insert Data berhasil");
					TampilData();
					Bersihkan();
				}
				catch (Exception ex){
				MessageBox.Show(ex.ToString());
				}
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			/* Memeriksa apakah kolom teks kosong */  	
			
			if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || comboBox1.Text.Trim() == "" || comboBox2.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia!!!");
			}
			else
			{
				/* Update Data */  
				SqlConnection conn = Konn.GetConn();
				try
				{
					conn.Open();
					cmd = new SqlCommand("Update data_menu set nama_menu='"+textBox2.Text+"',jenis_menu='"+comboBox1.Text+"',satuan='"+comboBox2.Text+"',harga='"+textBox3.Text+"',stok='"+textBox4.Text+"' where id_menu='"+textBox1.Text+"'", conn);	
					cmd.ExecuteNonQuery();
					MessageBox.Show("Update Data berhasil");
					TampilData();
					Bersihkan();
				}
				catch (Exception ex){
				MessageBox.Show(ex.ToString());
				}
			}		
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if(MessageBox.Show(textBox2.Text+", Yakin ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				/* Hapus Data */  
				SqlConnection conn = Konn.GetConn();
					conn.Open();
					cmd = new SqlCommand("Delete data_menu where id_menu='"+textBox1.Text+"'", conn);	
					cmd.ExecuteNonQuery();
					MessageBox.Show("Hapus Data berhasil");
					TampilData();
					Bersihkan();
			}			
		}
		
		
		void CariMenu()
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from data_menu where id_menu like '%"+textBox5.Text+"%' or nama_menu like '%"+textBox5.Text+"%'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "data_menu");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "data_menu";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
			finally{
				conn.Close();
			}
		}
		
		void TextBox9TextChanged(object sender, EventArgs e)
		{
			CariMenu();
		}

		
		void Button4Click(object sender, EventArgs e)
		{
			Bersihkan();
		}
		
		
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void TextBox4KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
