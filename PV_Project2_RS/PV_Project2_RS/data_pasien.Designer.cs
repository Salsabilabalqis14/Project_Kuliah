/*
 * Created by SharpDevelop.
 * User: hp
 * Date: 28/05/2022
 * Time: 17:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_Project2_RS
{
	partial class data_pasien
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(207)))), ((int)(((byte)(236)))));
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1200, 69);
			this.panel1.TabIndex = 1;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(1084, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(104, 41);
			this.button5.TabIndex = 15;
			this.button5.Text = "Home";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label1.Location = new System.Drawing.Point(288, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(583, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "DATA PASIEN";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(207)))), ((int)(((byte)(236)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(60, 499);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1078, 179);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.SteelBlue;
			this.label2.Location = new System.Drawing.Point(141, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "No Rekam Medis";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.SteelBlue;
			this.label3.Location = new System.Drawing.Point(593, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tanggal Registrasi";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(327, 115);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(193, 30);
			this.textBox1.TabIndex = 5;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";
			this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(794, 114);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(234, 30);
			this.dateTimePicker1.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.textBox6);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.comboBox2);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.dateTimePicker2);
			this.panel2.Controls.Add(this.comboBox1);
			this.panel2.Controls.Add(this.textBox5);
			this.panel2.Controls.Add(this.textBox4);
			this.panel2.Controls.Add(this.textBox3);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(60, 202);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(742, 262);
			this.panel2.TabIndex = 7;
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(506, 168);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(192, 30);
			this.textBox6.TabIndex = 18;
			this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox6KeyPress);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(396, 171);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 17;
			this.label13.Text = "No HP";
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(506, 123);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(192, 30);
			this.comboBox2.TabIndex = 16;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(396, 126);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 27);
			this.label12.TabIndex = 15;
			this.label12.Text = "Agama";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(506, 82);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(192, 30);
			this.dateTimePicker2.TabIndex = 14;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(158, 167);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(192, 30);
			this.comboBox1.TabIndex = 13;
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(158, 212);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(192, 30);
			this.textBox5.TabIndex = 11;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(158, 123);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(192, 30);
			this.textBox4.TabIndex = 10;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(158, 79);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(192, 30);
			this.textBox3.TabIndex = 9;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(158, 38);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(192, 30);
			this.textBox2.TabIndex = 8;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2KeyPress);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(20, 215);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 6;
			this.label10.Text = "Alamat";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(20, 169);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 23);
			this.label8.TabIndex = 4;
			this.label8.Text = "Jenis Kelamin";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(396, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 3;
			this.label7.Text = "Tgl Lahir";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(20, 123);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Tmp Lahir";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "Nama";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "No Induk";
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.SteelBlue;
			this.label9.Location = new System.Drawing.Point(317, 187);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(186, 30);
			this.label9.TabIndex = 8;
			this.label9.Text = "Identitas Pasien";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gold;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(873, 341);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 45);
			this.button1.TabIndex = 9;
			this.button1.Text = "Insert";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(1020, 341);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 45);
			this.button2.TabIndex = 10;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Tomato;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(873, 404);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(118, 45);
			this.button3.TabIndex = 11;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(1020, 404);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(118, 45);
			this.button4.TabIndex = 12;
			this.button4.Text = "Refresh";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.textBox7);
			this.panel3.Location = new System.Drawing.Point(873, 217);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(265, 89);
			this.panel3.TabIndex = 13;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(14, 39);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(234, 26);
			this.textBox7.TabIndex = 19;
			this.textBox7.TextChanged += new System.EventHandler(this.TextBox7TextChanged);
			// 
			// label11
			// 
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.SteelBlue;
			this.label11.Location = new System.Drawing.Point(896, 202);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(145, 30);
			this.label11.TabIndex = 14;
			this.label11.Text = "Cari Pasien";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// data_pasien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1200, 700);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "data_pasien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "data_pasien";
			this.Load += new System.EventHandler(this.Data_pasienLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
