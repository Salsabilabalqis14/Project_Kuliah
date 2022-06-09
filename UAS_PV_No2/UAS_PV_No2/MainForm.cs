using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UAS_PV_No2
{
	public partial class MainForm : Form
	{
		double harga, total_bayar, jumlah_pesan;
		double persen_diskon, Diskon, pajak;
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			Menu();
		}
		
		void Menu()
		{
			comboBox1.Items.Add("Nasi Goreng");
			comboBox1.Items.Add("Bakso Spesial");
			comboBox1.Items.Add("Bakso Biasa");
			comboBox1.Items.Add("Ayam Geprek");
			comboBox1.Items.Add("Ayam Bakar");
		}
		
		void Harga()
		{
			if (comboBox1.Text == "Nasi Goreng")
			{
				harga = 12000;
			}
			else if (comboBox1.Text == "Bakso Spesial")
			{
				harga = 18000;
			}
			else if (comboBox1.Text == "Bakso Biasa")
			{
				harga = 10000;
			}
			else if (comboBox1.Text == "Ayam Geprek")
			{
				harga = 20000;
			}
			else if (comboBox1.Text == "Ayam Bakar")
			{
				harga = 25000;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Harga();
			
			jumlah_pesan = Int16.Parse(numericUpDown1.Text); 
			
			total_bayar = harga * jumlah_pesan;
			
			if (checkBox1.Checked)
			{
				persen_diskon = 0.05;
				Diskon = harga * jumlah_pesan * persen_diskon;
				total_bayar = (harga * jumlah_pesan) - Diskon;
			}
			
			if (radioButton1.Checked)
			{
				pajak = 0;
			}
			else if (radioButton2.Checked)
			{
				pajak = 5000;
			}
			
			total_bayar = total_bayar - pajak;
			
			total.Text = total_bayar.ToString();
			
		}
		
	}
}
