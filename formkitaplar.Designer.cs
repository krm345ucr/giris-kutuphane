namespace WinFormsApp16
{
	partial class formkitaplar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			textBoxyazarsoyadı = new TextBox();
			label15 = new Label();
			button2 = new Button();
			button1 = new Button();
			textBoxyazaradi = new TextBox();
			textBoxkitapturkodu = new TextBox();
			textBoxısen = new TextBox();
			textBoxkitapadi = new TextBox();
			label9 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			button5 = new Button();
			dateTimePicker1 = new DateTimePicker();
			textBox3 = new TextBox();
			label11 = new Label();
			label10 = new Label();
			groupBox3 = new GroupBox();
			button4 = new Button();
			label14 = new Label();
			label13 = new Label();
			button3 = new Button();
			label12 = new Label();
			groupBox4 = new GroupBox();
			dataGridView1 = new DataGridView();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(textBoxyazarsoyadı);
			groupBox1.Controls.Add(label15);
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(textBoxyazaradi);
			groupBox1.Controls.Add(textBoxkitapturkodu);
			groupBox1.Controls.Add(textBoxısen);
			groupBox1.Controls.Add(textBoxkitapadi);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new Font("Segoe UI", 9F);
			groupBox1.Location = new Point(12, -3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(359, 420);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "KİTAP KAYIT VE GÜNCELLEME";
			groupBox1.Enter += groupBox1_Enter;
			// 
			// textBoxyazarsoyadı
			// 
			textBoxyazarsoyadı.Location = new Point(164, 129);
			textBoxyazarsoyadı.Name = "textBoxyazarsoyadı";
			textBoxyazarsoyadı.Size = new Size(125, 27);
			textBoxyazarsoyadı.TabIndex = 26;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(24, 136);
			label15.Name = "label15";
			label15.Size = new Size(58, 20);
			label15.TabIndex = 25;
			label15.Text = "label15";
			// 
			// button2
			// 
			button2.Location = new Point(6, 383);
			button2.Name = "button2";
			button2.Size = new Size(150, 37);
			button2.TabIndex = 22;
			button2.Text = "kitap bilgi güncelle";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(205, 366);
			button1.Name = "button1";
			button1.Size = new Size(116, 37);
			button1.TabIndex = 21;
			button1.Text = "yeni kitap ekle";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBoxyazaradi
			// 
			textBoxyazaradi.Location = new Point(164, 96);
			textBoxyazaradi.Name = "textBoxyazaradi";
			textBoxyazaradi.Size = new Size(125, 27);
			textBoxyazaradi.TabIndex = 20;
			// 
			// textBoxkitapturkodu
			// 
			textBoxkitapturkodu.Location = new Point(164, 231);
			textBoxkitapturkodu.Name = "textBoxkitapturkodu";
			textBoxkitapturkodu.Size = new Size(125, 27);
			textBoxkitapturkodu.TabIndex = 19;
			// 
			// textBoxısen
			// 
			textBoxısen.Location = new Point(164, 157);
			textBoxısen.Name = "textBoxısen";
			textBoxısen.Size = new Size(125, 27);
			textBoxısen.TabIndex = 15;
			// 
			// textBoxkitapadi
			// 
			textBoxkitapadi.Location = new Point(164, 61);
			textBoxkitapadi.Name = "textBoxkitapadi";
			textBoxkitapadi.Size = new Size(125, 27);
			textBoxkitapadi.TabIndex = 13;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 13.8F);
			label9.Location = new Point(8, 225);
			label9.Name = "label9";
			label9.Size = new Size(150, 31);
			label9.TabIndex = 8;
			label9.Text = "kitapturkodu:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 13.8F);
			label5.Location = new Point(24, 158);
			label5.Name = "label5";
			label5.Size = new Size(62, 31);
			label5.TabIndex = 4;
			label5.Text = "ısbn:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 13.8F);
			label4.Location = new Point(18, 90);
			label4.Name = "label4";
			label4.Size = new Size(110, 31);
			label4.TabIndex = 3;
			label4.Text = "yazar adı:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13.8F);
			label3.Location = new Point(18, 59);
			label3.Name = "label3";
			label3.Size = new Size(108, 31);
			label3.TabIndex = 2;
			label3.Text = "kitap adı:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(190, 37);
			label2.Name = "label2";
			label2.Size = new Size(15, 20);
			label2.TabIndex = 1;
			label2.Text = "-";
			label2.Click += label2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F);
			label1.Location = new Point(18, 28);
			label1.Name = "label1";
			label1.Size = new Size(98, 31);
			label1.TabIndex = 0;
			label1.Text = "Kitap Id:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(button5);
			groupBox2.Controls.Add(dateTimePicker1);
			groupBox2.Controls.Add(textBox3);
			groupBox2.Controls.Add(label11);
			groupBox2.Controls.Add(label10);
			groupBox2.Location = new Point(377, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(225, 303);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "KİTAP ÖDÜNÇ ALMA";
			// 
			// button5
			// 
			button5.Location = new Point(62, 147);
			button5.Name = "button5";
			button5.Size = new Size(122, 45);
			button5.TabIndex = 5;
			button5.Text = "KİTABI ÖDÜÇ VER";
			button5.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(89, 86);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(136, 27);
			dateTimePicker1.TabIndex = 4;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(117, 53);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(108, 27);
			textBox3.TabIndex = 3;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(6, 91);
			label11.Name = "label11";
			label11.Size = new Size(53, 20);
			label11.TabIndex = 1;
			label11.Text = "TARİH:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(6, 56);
			label10.Name = "label10";
			label10.Size = new Size(106, 20);
			label10.TabIndex = 0;
			label10.Text = "ÖDÜNÇ ALAN:";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(button4);
			groupBox3.Controls.Add(label14);
			groupBox3.Controls.Add(label13);
			groupBox3.Controls.Add(button3);
			groupBox3.Controls.Add(label12);
			groupBox3.Location = new Point(608, 24);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(247, 291);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "KİTAP İADE";
			// 
			// button4
			// 
			button4.Location = new Point(31, 133);
			button4.Name = "button4";
			button4.Size = new Size(145, 49);
			button4.TabIndex = 4;
			button4.Text = "KİTABI İADE ET";
			button4.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(177, 41);
			label14.Name = "label14";
			label14.Size = new Size(24, 20);
			label14.TabIndex = 3;
			label14.Text = "TL";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(136, 41);
			label13.Name = "label13";
			label13.Size = new Size(17, 20);
			label13.TabIndex = 2;
			label13.Text = "0";
			// 
			// button3
			// 
			button3.Location = new Point(31, 75);
			button3.Name = "button3";
			button3.Size = new Size(145, 49);
			button3.TabIndex = 1;
			button3.Text = "GECİKME BEDELİ HESAPLA";
			button3.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(6, 41);
			label12.Name = "label12";
			label12.Size = new Size(124, 20);
			label12.TabIndex = 0;
			label12.Text = "GECİKME BEDELİ:";
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(dataGridView1);
			groupBox4.Location = new Point(12, 416);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(772, 153);
			groupBox4.TabIndex = 3;
			groupBox4.TabStop = false;
			groupBox4.Text = "groupBox4";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(6, 26);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(837, 178);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// formkitaplar
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(867, 581);
			Controls.Add(groupBox4);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "formkitaplar";
			Text = "by kitaplar";
			Load += formkitaplar_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Label label1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private Label label10;
		private Label label9;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private TextBox textBox2;
		private TextBox textBoxkitapadi;
		private TextBox textBoxkitapturkodu;
		private TextBox textBoxısen;
		private TextBox textBoxyazaradi;
		private GroupBox groupBox4;
		private Button button2;
		private Button button1;
		private DataGridView dataGridView1;
		private Label label11;
		private TextBox textBox3;
		private DateTimePicker dateTimePicker1;
		private Button button4;
		private Label label14;
		private Label label13;
		private Button button3;
		private Label label12;
		private Button button5;
		private TextBox textBoxyazarsoyadı;
		private Label label15;
	}
}