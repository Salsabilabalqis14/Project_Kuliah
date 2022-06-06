/*
 * Created by SharpDevelop.
 * User: hp
 * Date: 11/05/2022
 * Time: 14:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_Project1_Kasir
{
	partial class MainForm
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(225, 221);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(196, 28);
			this.comboBox1.TabIndex = 36;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(878, 214);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 45);
			this.button4.TabIndex = 35;
			this.button4.Text = "Refresh";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Location = new System.Drawing.Point(477, 116);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(422, 64);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pencarian Kode Barang";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(9, 25);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(407, 26);
			this.textBox7.TabIndex = 0;
			this.textBox7.TextChanged += new System.EventHandler(this.TextBox7TextChanged);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(745, 215);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 45);
			this.button3.TabIndex = 33;
			this.button3.Text = "Hapus";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(614, 215);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 45);
			this.button2.TabIndex = 32;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(486, 215);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 45);
			this.button1.TabIndex = 31;
			this.button1.Text = "Simpan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(225, 181);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(196, 26);
			this.textBox5.TabIndex = 29;
			this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox5KeyPress);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(225, 143);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(196, 26);
			this.textBox4.TabIndex = 27;
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4KeyPress);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(225, 104);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(196, 26);
			this.textBox3.TabIndex = 24;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3KeyPress);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(225, 61);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(674, 26);
			this.textBox2.TabIndex = 22;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(225, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(196, 26);
			this.textBox1.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(57, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(316, 23);
			this.label6.TabIndex = 30;
			this.label6.Text = "Satuan";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(57, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(316, 23);
			this.label5.TabIndex = 28;
			this.label5.Text = "Jumlah";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(57, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(316, 23);
			this.label4.TabIndex = 26;
			this.label4.Text = "Harga Beli";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(57, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(316, 23);
			this.label3.TabIndex = 25;
			this.label3.Text = "Harga Jual";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(57, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(316, 23);
			this.label2.TabIndex = 23;
			this.label2.Text = "Nama Barang";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(57, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(316, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "Kode Barang";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(57, 295);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(934, 326);
			this.dataGridView1.TabIndex = 19;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1048, 641);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "PV_Project1_Kasir";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
