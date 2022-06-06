using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PV_Project2_RS
{
	public partial class data_obat : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
		
		Koneksi Konn = new Koneksi();
		
		public data_obat()
		{
			InitializeComponent();
		}
		
		void Data_obatLoad(object sender, EventArgs e)
		{
			TampilData();	
			MunculPilihan();	
			Bersihkan();
			kodeObatOtomatis();
		}
		
		void TampilData()
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from tbl_dataObat", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "tbl_dataObat");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "tbl_dataObat";
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
			finally{
				conn.Close();
			}
		}
		
		void MunculPilihan()
		{
			comboBox1.Items.Add("Pcs");
			comboBox1.Items.Add("Box");
			comboBox1.Items.Add("Botol");
		}

		void Bersihkan()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			comboBox1.Text = "";
			kodeObatOtomatis();	
		}
		
		void kodeObatOtomatis()
		{
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("Select kode_obat from tbl_dataObat where kode_obat in (select max (kode_obat) from tbl_dataObat) order by kode_obat desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if(rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_obat"].ToString().Length - 3, 3)) + 1;
				string kodeurutan = "000" + hitung;
				urutan = "OBT"+kodeurutan.Substring(kodeurutan.Length - 3, 3);
			} 
			else
			{
				urutan = "OBT001";
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
				textBox1.Text = row.Cells["kode_obat"].Value.ToString();
				textBox2.Text = row.Cells["nama_obat"].Value.ToString();
				textBox3.Text = row.Cells["harga_beli"].Value.ToString();
				textBox4.Text = row.Cells["harga_jual"].Value.ToString();
				textBox5.Text = row.Cells["stok"].Value.ToString();
				comboBox1.Text = row.Cells["satuan"].Value.ToString();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		// Insert Data
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
					cmd = new SqlCommand("Insert into tbl_dataObat values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+comboBox1.Text+"')", conn);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Insert Data berhasil");
					TampilData();
					Bersihkan();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		// Update Data
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
					cmd = new SqlCommand("Update tbl_dataObat set nama_obat='"+textBox2.Text+"',harga_beli='"+textBox3.Text+"', harga_jual='"+textBox4.Text+"',stok='"+textBox5.Text+"',satuan='"+comboBox1.Text+"' where kode_obat='"+textBox1.Text+"'", conn);	
					cmd.ExecuteNonQuery();
					MessageBox.Show("Update Data berhasil");
					TampilData();
					Bersihkan();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}	
		}
		
		// Delete Data
		void Button3Click(object sender, EventArgs e)
		{
			if(MessageBox.Show(textBox1.Text+", Yakin ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				/* Hapus Data */  
				SqlConnection conn = Konn.GetConn();
					conn.Open();
					cmd = new SqlCommand("Delete tbl_dataObat where kode_obat='"+textBox1.Text+"'", conn);	
					cmd.ExecuteNonQuery();
					MessageBox.Show("Hapus Data berhasil");
					TampilData();
					Bersihkan();
			}
		}
		
		// Refresh
		void Button4Click(object sender, EventArgs e)
		{
			Bersihkan();
		}
		
		void CariObat()
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from tbl_dataObat where kode_obat like '%"+textBox6.Text+"%' or nama_obat like '%"+textBox6.Text+"%'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "tbl_dataObat");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "tbl_dataObat";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
			finally{
				conn.Close();
			}
		}
		
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			CariObat();
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
		
		void Button5Click(object sender, EventArgs e)
		{
			this.Hide();
			Home n = new Home();
			n.Show();			
		}
	}
}
