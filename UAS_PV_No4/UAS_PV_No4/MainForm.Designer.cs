/*
 * Created by SharpDevelop.
 * User: hp
 * Date: 09/06/2022
 * Time: 12:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS_PV_No4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label39 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label42 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel9 = new System.Windows.Forms.Panel();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1143, 60);
			this.panel1.TabIndex = 0;
			// 
			// button5
			// 
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(207)))), ((int)(((byte)(236)))));
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(207)))), ((int)(((byte)(236)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(1054, 5);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(66, 49);
			this.button5.TabIndex = 94;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(295, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(559, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "DATA MENU RESTAURAN FOODIES";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label38
			// 
			this.label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label38.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label38.ForeColor = System.Drawing.Color.SteelBlue;
			this.label38.Location = new System.Drawing.Point(807, 179);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(186, 30);
			this.label38.TabIndex = 91;
			this.label38.Text = "Cari Menu";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label43
			// 
			this.label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label43.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label43.ForeColor = System.Drawing.Color.SteelBlue;
			this.label43.Location = new System.Drawing.Point(260, 89);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(186, 30);
			this.label43.TabIndex = 87;
			this.label43.Text = "Data Menu";
			this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.comboBox2);
			this.panel6.Controls.Add(this.textBox3);
			this.panel6.Controls.Add(this.label25);
			this.panel6.Controls.Add(this.label24);
			this.panel6.Controls.Add(this.textBox4);
			this.panel6.Controls.Add(this.comboBox1);
			this.panel6.Controls.Add(this.label27);
			this.panel6.Controls.Add(this.label28);
			this.panel6.Controls.Add(this.label32);
			this.panel6.Controls.Add(this.label33);
			this.panel6.Controls.Add(this.label35);
			this.panel6.Controls.Add(this.label36);
			this.panel6.Controls.Add(this.textBox2);
			this.panel6.Controls.Add(this.label39);
			this.panel6.Controls.Add(this.label40);
			this.panel6.Controls.Add(this.label41);
			this.panel6.Controls.Add(this.textBox1);
			this.panel6.Controls.Add(this.label42);
			this.panel6.Location = new System.Drawing.Point(62, 111);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(591, 430);
			this.panel6.TabIndex = 86;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(203, 258);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(335, 28);
			this.comboBox2.TabIndex = 72;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(203, 303);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(335, 30);
			this.textBox3.TabIndex = 71;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3KeyPress);
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(149, 306);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(20, 23);
			this.label25.TabIndex = 70;
			this.label25.Text = ":";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(32, 306);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(109, 35);
			this.label24.TabIndex = 69;
			this.label24.Text = "Harga";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(203, 353);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(335, 30);
			this.textBox4.TabIndex = 68;
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4KeyPress);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(203, 202);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(335, 28);
			this.comboBox1.TabIndex = 67;
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(149, 353);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(20, 23);
			this.label27.TabIndex = 63;
			this.label27.Text = ":";
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(149, 258);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(20, 23);
			this.label28.TabIndex = 62;
			this.label28.Text = ":";
			// 
			// label32
			// 
			this.label32.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label32.Location = new System.Drawing.Point(34, 353);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(111, 29);
			this.label32.TabIndex = 58;
			this.label32.Text = "Stok";
			// 
			// label33
			// 
			this.label33.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label33.Location = new System.Drawing.Point(32, 258);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(111, 29);
			this.label33.TabIndex = 57;
			this.label33.Text = "Satuan";
			// 
			// label35
			// 
			this.label35.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Location = new System.Drawing.Point(149, 202);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(20, 23);
			this.label35.TabIndex = 54;
			this.label35.Text = ":";
			// 
			// label36
			// 
			this.label36.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(34, 199);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(109, 57);
			this.label36.TabIndex = 53;
			this.label36.Text = "Jenis Menu";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(203, 83);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(335, 97);
			this.textBox2.TabIndex = 49;
			// 
			// label39
			// 
			this.label39.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label39.Location = new System.Drawing.Point(155, 86);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(20, 23);
			this.label39.TabIndex = 48;
			this.label39.Text = ":";
			// 
			// label40
			// 
			this.label40.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label40.Location = new System.Drawing.Point(32, 86);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(111, 29);
			this.label40.TabIndex = 47;
			this.label40.Text = "Nama Menu";
			// 
			// label41
			// 
			this.label41.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label41.Location = new System.Drawing.Point(155, 37);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(20, 23);
			this.label41.TabIndex = 2;
			this.label41.Text = ":";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(203, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(335, 30);
			this.textBox1.TabIndex = 1;
			// 
			// label42
			// 
			this.label42.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label42.Location = new System.Drawing.Point(32, 37);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(109, 23);
			this.label42.TabIndex = 0;
			this.label42.Text = "Id Menu";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gold;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(754, 337);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 46);
			this.button1.TabIndex = 77;
			this.button1.Text = "Insert";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Aquamarine;
			this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(925, 337);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(140, 46);
			this.button2.TabIndex = 78;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Tomato;
			this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(754, 405);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(140, 46);
			this.button3.TabIndex = 79;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// panel9
			// 
			this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel9.Controls.Add(this.textBox5);
			this.panel9.Location = new System.Drawing.Point(723, 193);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(365, 87);
			this.panel9.TabIndex = 90;
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(30, 35);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(311, 30);
			this.textBox5.TabIndex = 73;
			this.textBox5.TextChanged += new System.EventHandler(this.TextBox9TextChanged);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(925, 405);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(140, 46);
			this.button4.TabIndex = 92;
			this.button4.Text = "Refresh";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(63, 575);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1025, 240);
			this.dataGridView1.TabIndex = 93;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1143, 868);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label38);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label43);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel9);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UAS_PV_No4";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
