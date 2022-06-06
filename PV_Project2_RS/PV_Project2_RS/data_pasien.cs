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
	public partial class data_pasien : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
		
		Koneksi Konn = new Koneksi();
		
		public data_pasien()
		{
			InitializeComponent();
		}

		
		void Data_pasienLoad(object sender, EventArgs e)
		{
			TampilData();	
			MunculPilihan();	
			Bersihkan();
			NoRekamMedisOtomatis();			
		}
		
		void TampilData()
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from tbl_dataPasien", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "tbl_dataPasien");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "tbl_dataPasien";
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
			comboBox1.Items.Add("Pria");
			comboBox1.Items.Add("Wanita");
			
			comboBox2.Items.Add("Islam");
			comboBox2.Items.Add("Kriten Protestan");
			comboBox2.Items.Add("Kriten Katolik");
			comboBox2.Items.Add("Hindu");
			comboBox2.Items.Add("Budha");
			comboBox2.Items.Add("Konghucu");
		}

		void Bersihkan()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			comboBox1.Text = "";
			comboBox2.Text = "";
			dateTimePicker1.Value = DateTime.Now;
			dateTimePicker2.Value = DateTime.Now;
			NoRekamMedisOtomatis();	
		}
		
		void NoRekamMedisOtomatis()
		{
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("Select no_rekamMedis from tbl_dataPasien where no_rekamMedis in (select max (no_rekamMedis) from tbl_dataPasien) order by no_rekammedis desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if(rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["no_rekamMedis"].ToString().Length - 3, 3)) + 1;
				string kodeurutan = "000" + hitung;
				urutan = "PSN"+kodeurutan.Substring(kodeurutan.Length - 3, 3);
			} 
			else
			{
				urutan = "PSN001";
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
				textBox1.Text = row.Cells["no_rekamMedis"].Value.ToString();
				textBox2.Text = row.Cells["no_induk"].Value.ToString();
				textBox3.Text = row.Cells["nama"].Value.ToString();
				textBox4.Text = row.Cells["tmp_lahir"].Value.ToString();
				textBox5.Text = row.Cells["alamat"].Value.ToString();
				textBox6.Text = row.Cells["no_hp"].Value.ToString();
				dateTimePicker1.Text = row.Cells["tgl_registrasi"].Value.ToString();
				dateTimePicker2.Text = row.Cells["tgl_lahir"].Value.ToString();
				comboBox1.Text = row.Cells["jenis_kl"].Value.ToString();
				comboBox2.Text = row.Cells["agama"].Value.ToString();
				
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
			
			if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" || comboBox1.Text.Trim() == "" || comboBox2.Text.Trim() == "")
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
					cmd = new SqlCommand("Insert into tbl_dataPasien values ('"+textBox1.Text+"','"+dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss")+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+dateTimePicker2.Value.ToString("yyyy-MM-dd")+"','"+comboBox1.Text+"','"+comboBox2.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')", conn);
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
			if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" || comboBox1.Text.Trim() == "" || comboBox2.Text.Trim() == "")
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
					cmd = new SqlCommand("Update tbl_dataPasien set tgl_registrasi='"+dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss")+"',no_induk='"+textBox2.Text+"', nama='"+textBox3.Text+"',tmp_lahir='"+textBox4.Text+"',tgl_lahir='"+dateTimePicker2.Value.ToString("yyyy-MM-dd")+"',jenis_kl='"+comboBox1.Text+"',agama='"+comboBox2.Text+"',alamat='"+textBox5.Text+"',no_hp='"+textBox6.Text+"' where no_rekamMedis='"+textBox1.Text+"'", conn);	
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
					cmd = new SqlCommand("Delete tbl_dataPasien where no_rekamMedis='"+textBox1.Text+"'", conn);	
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
		
		void CariPasien()
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from tbl_dataPasien where no_rekamMedis like '%"+textBox7.Text+"%' or no_induk like '%"+textBox7.Text+"%' or nama like '%"+textBox7.Text+"%'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "tbl_dataPasien");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "tbl_dataPasien";
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
			CariPasien();
		}
		
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void TextBox6KeyPress(object sender, KeyPressEventArgs e)
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
