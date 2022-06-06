using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace PV_Project2_RS
{
	public partial class data_dokter : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
		
		Koneksi Konn = new Koneksi();
		
		string imgLocation = "";
		
		public data_dokter()
		{
			InitializeComponent();
		}

		void Data_dokterLoad(object sender, EventArgs e)
		{
			TampilData();	
			Bersihkan();
			kodeDokterOtomatis();
		}
		
		void TampilData()
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from tbl_dataDokter", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "tbl_dataDokter");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "tbl_dataDokter";
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
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
			pictureBox1.Image = null;
			kodeDokterOtomatis();	
		}
		
		void kodeDokterOtomatis()
		{
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("Select id_dokter from tbl_dataDokter where id_dokter in (select max (id_dokter) from tbl_dataDokter) order by id_dokter desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if(rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["id_dokter"].ToString().Length - 3, 3)) + 1;
				string kodeurutan = "000" + hitung;
				urutan = "DKR"+kodeurutan.Substring(kodeurutan.Length - 3, 3);
			} 
			else
			{
				urutan = "DKR001";
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
				textBox1.Text = row.Cells["id_dokter"].Value.ToString();
				textBox2.Text = row.Cells["nama_dokter"].Value.ToString();
				textBox3.Text = row.Cells["spesialisasi"].Value.ToString();
				textBox4.Text = row.Cells["alamat"].Value.ToString();
				textBox5.Text = row.Cells["warga_negara"].Value.ToString();
				textBox6.Text = row.Cells["no_hp"].Value.ToString();
				textBox7.Text = row.Cells["email"].Value.ToString();
				MemoryStream ms = new MemoryStream((byte[])row.Cells["foto"].Value);
				pictureBox1.Image = Image.FromStream(ms);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				imgLocation = dialog.FileName.ToString();
				pictureBox1.ImageLocation = imgLocation;
			}			
		}
		
		// Insert Data
		void Button1Click(object sender, EventArgs e)
		{
			/* Memeriksa apakah kolom teks kosong */  	
			
			if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" || textBox7.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia!!!");
			}
			else
			{
				/* Simpan Data */  
				SqlConnection conn = Konn.GetConn();
				try
				{
					byte [] images = null;
					FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
					BinaryReader brs = new BinaryReader(streem); 
					images = brs.ReadBytes((int)streem.Length);
					conn.Open();
					cmd = new SqlCommand("Insert into tbl_dataDokter values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"',@images)", conn);	
					cmd.Parameters.Add(new SqlParameter("@images", images));
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
		
		// Update Data
		void Button2Click(object sender, EventArgs e)
		{
			/* Memeriksa apakah kolom teks kosong */  	
			if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" || textBox7.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia!!!");
			}
			else
			{
				/* Update Data */  
				SqlConnection conn = Konn.GetConn();
				try
				{
					MemoryStream ms = new MemoryStream();
					pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
					conn.Open();
					cmd = new SqlCommand("Update tbl_dataDokter set nama_dokter='"+textBox2.Text+"',spesialisasi='"+textBox3.Text+"', alamat='"+textBox4.Text+"',warga_negara='"+textBox5.Text+"',no_hp='"+textBox6.Text+"',email='"+textBox7.Text+"',foto=@images where id_dokter='"+textBox1.Text+"'", conn);	
					cmd.Parameters.AddWithValue("@images", ms.ToArray());
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
					cmd = new SqlCommand("Delete tbl_dataDokter where id_dokter='"+textBox1.Text+"'", conn);	
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
		
		void CariDokter()
		{
			SqlConnection conn = Konn.GetConn();
			try{
				conn.Open();
				cmd = new SqlCommand("Select * from tbl_dataDokter where id_dokter like '%"+textBox8.Text+"%' or nama_dokter like '%"+textBox8.Text+"%'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "tbl_dataDokter");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "tbl_dataDokter";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
			finally{
				conn.Close();
			}
		}
		
		void TextBox8TextChanged(object sender, EventArgs e)
		{
			CariDokter();
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
