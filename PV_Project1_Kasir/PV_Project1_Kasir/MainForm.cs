using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PV_Project1_Kasir
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
			TampilBarang();
			Bersihkan();
			MunculSatuan();
			NoOtomatis();
		}
		
		void TampilBarang()
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from TBL_BARANG", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TBL_BARANG");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TBL_BARANG";
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
			textBox5.Text = "0";
			comboBox1.Text = "";
			textBox7.Text = "";
			NoOtomatis();
		}
		
		
		void MunculSatuan()
		{
			comboBox1.Items.Add("Unit");
			comboBox1.Items.Add("Pcs");
			comboBox1.Items.Add("Kg");
			comboBox1.Items.Add("gram");
			comboBox1.Items.Add(7000);
		}
		
		void NoOtomatis()
		{
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select KodeBarang from TBL_BARANG where KodeBarang in (select max (KodeBarang) from TBL_Barang) order by kodebarang desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if(rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3)) + 1;
				string kodeurutan = "000" + hitung;
				urutan = "BRG"+kodeurutan.Substring(kodeurutan.Length - 3, 3);
			} 
			else
			{
				urutan = "BRG001";
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
				textBox1.Text = row.Cells["KodeBarang"].Value.ToString();
				textBox2.Text = row.Cells["NamaBarang"].Value.ToString();
				textBox3.Text = row.Cells["HargaJual"].Value.ToString();
				textBox4.Text = row.Cells["HargaBeli"].Value.ToString();
				textBox5.Text = row.Cells["JumlahBarang"].Value.ToString();
				comboBox1.Text = row.Cells["SatuanBarang"].Value.ToString();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			/* Memeriksa apakah kolom teks kosong */  	
			
			if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
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
					cmd = new SqlCommand("Insert into TBL_BARANG values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+comboBox1.Text+"')", conn);	
					cmd.ExecuteNonQuery();
					MessageBox.Show("Insert Data berhasil");
					TampilBarang();
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
			
			if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
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
					cmd = new SqlCommand("Update TBL_BARANG set KodeBarang='"+textBox1.Text+"',NamaBarang='"+textBox2.Text+"',HargaJual='"+textBox3.Text+"',HargaBeli='"+textBox4.Text+"',JumlahBarang='"+textBox5.Text+"',SatuanBarang='"+comboBox1.Text+"' where KodeBarang='"+textBox1.Text+"'", conn);	
					cmd.ExecuteNonQuery();
					MessageBox.Show("Update Data berhasil");
					TampilBarang();
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
					cmd = new SqlCommand("Delete TBL_BARANG where KodeBarang='"+textBox1.Text+"'", conn);	
					cmd.ExecuteNonQuery();
					MessageBox.Show("Hapus Data berhasil");
					TampilBarang();
					Bersihkan();
			}			
		}
		
		
		void CariBarang()
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from TBL_BARANG where kodebarang like '%"+textBox7.Text+"%' or namabarang like '%"+textBox7.Text+"%'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TBL_BARANG");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TBL_BARANG";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
			finally{
				conn.Close();
			}
		}
		
		
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			CariBarang();
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
		
		void TextBox5KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
	}
}