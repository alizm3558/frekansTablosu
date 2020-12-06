namespace Frekans
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listSiralama = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.listBox12 = new System.Windows.Forms.ListBox();
            this.listBox13 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox14 = new System.Windows.Forms.ListBox();
            this.listBox15 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.ortalama = new System.Windows.Forms.Label();
            this.varyans = new System.Windows.Forms.Label();
            this.standart = new System.Windows.Forms.Label();
            this.oms = new System.Windows.Forms.Label();
            this.q1 = new System.Windows.Forms.Label();
            this.q3 = new System.Windows.Forms.Label();
            this.carpiklik = new System.Windows.Forms.Label();
            this.sivri = new System.Windows.Forms.Label();
            this.katsayi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(421, 91);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 228);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(16, 40);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(111, 36);
            this.listBox2.TabIndex = 2;
            this.listBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(552, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veriler enter ile girilir! Verileri girebilirsiniz..";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(643, 337);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Seçiliyi sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(416, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "==";
            this.label2.Visible = false;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(16, 450);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(97, 276);
            this.listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(221, 450);
            this.listBox4.Margin = new System.Windows.Forms.Padding(4);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(97, 276);
            this.listBox4.TabIndex = 8;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(431, 450);
            this.listBox5.Margin = new System.Windows.Forms.Padding(4);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(132, 276);
            this.listBox5.TabIndex = 9;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Location = new System.Drawing.Point(572, 450);
            this.listBox6.Margin = new System.Windows.Forms.Padding(4);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(132, 276);
            this.listBox6.TabIndex = 10;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 16;
            this.listBox7.Location = new System.Drawing.Point(713, 450);
            this.listBox7.Margin = new System.Windows.Forms.Padding(4);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(132, 276);
            this.listBox7.TabIndex = 11;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 16;
            this.listBox8.Location = new System.Drawing.Point(855, 450);
            this.listBox8.Margin = new System.Windows.Forms.Padding(4);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(132, 276);
            this.listBox8.TabIndex = 12;
            // 
            // listBox9
            // 
            this.listBox9.FormattingEnabled = true;
            this.listBox9.ItemHeight = 16;
            this.listBox9.Location = new System.Drawing.Point(1008, 450);
            this.listBox9.Margin = new System.Windows.Forms.Padding(4);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(132, 276);
            this.listBox9.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(735, 91);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 26);
            this.button3.TabIndex = 14;
            this.button3.Text = "Frekans serisi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listSiralama
            // 
            this.listSiralama.FormattingEnabled = true;
            this.listSiralama.ItemHeight = 16;
            this.listSiralama.Location = new System.Drawing.Point(291, 123);
            this.listSiralama.Margin = new System.Windows.Forms.Padding(4);
            this.listSiralama.Name = "listSiralama";
            this.listSiralama.Size = new System.Drawing.Size(124, 196);
            this.listSiralama.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sıralama";
            // 
            // listBox10
            // 
            this.listBox10.FormattingEnabled = true;
            this.listBox10.ItemHeight = 16;
            this.listBox10.Location = new System.Drawing.Point(735, 123);
            this.listBox10.Margin = new System.Windows.Forms.Padding(4);
            this.listBox10.Name = "listBox10";
            this.listBox10.Size = new System.Drawing.Size(124, 196);
            this.listBox10.TabIndex = 17;
            this.listBox10.Visible = false;
            // 
            // listBox11
            // 
            this.listBox11.Enabled = false;
            this.listBox11.FormattingEnabled = true;
            this.listBox11.ItemHeight = 16;
            this.listBox11.Location = new System.Drawing.Point(16, 84);
            this.listBox11.Margin = new System.Windows.Forms.Padding(4);
            this.listBox11.Name = "listBox11";
            this.listBox11.Size = new System.Drawing.Size(97, 20);
            this.listBox11.TabIndex = 18;
            this.listBox11.Visible = false;
            // 
            // listBox12
            // 
            this.listBox12.Enabled = false;
            this.listBox12.FormattingEnabled = true;
            this.listBox12.ItemHeight = 16;
            this.listBox12.Location = new System.Drawing.Point(146, 40);
            this.listBox12.Margin = new System.Windows.Forms.Padding(4);
            this.listBox12.Name = "listBox12";
            this.listBox12.Size = new System.Drawing.Size(102, 36);
            this.listBox12.TabIndex = 19;
            this.listBox12.Visible = false;
            // 
            // listBox13
            // 
            this.listBox13.FormattingEnabled = true;
            this.listBox13.ItemHeight = 16;
            this.listBox13.Location = new System.Drawing.Point(451, 379);
            this.listBox13.Margin = new System.Windows.Forms.Padding(4);
            this.listBox13.Name = "listBox13";
            this.listBox13.Size = new System.Drawing.Size(244, 20);
            this.listBox13.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Alt<= Sınıf limitleri =>Üst";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 425);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Alt<= Sınıf sınırları =>Üst";
            // 
            // listBox14
            // 
            this.listBox14.FormattingEnabled = true;
            this.listBox14.ItemHeight = 16;
            this.listBox14.Location = new System.Drawing.Point(116, 450);
            this.listBox14.Margin = new System.Windows.Forms.Padding(4);
            this.listBox14.Name = "listBox14";
            this.listBox14.Size = new System.Drawing.Size(97, 276);
            this.listBox14.TabIndex = 25;
            // 
            // listBox15
            // 
            this.listBox15.FormattingEnabled = true;
            this.listBox15.ItemHeight = 16;
            this.listBox15.Location = new System.Drawing.Point(321, 450);
            this.listBox15.Margin = new System.Windows.Forms.Padding(4);
            this.listBox15.Name = "listBox15";
            this.listBox15.Size = new System.Drawing.Size(97, 276);
            this.listBox15.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(577, 425);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sınıf Orta Noktası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 425);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sınıf frekansı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 425);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Oransal frekans";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(53, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(982, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tanrı, iradesini hâkim kılmak için yeryüzündeki iyi insanları kullanır; yeryüzünd" +
    "eki kötü insanlar ise kendi iradelerini hâkim kılmak için Tanrı\'yı kullanırlar.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1039, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Giordano Bruno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(727, 425);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Eklenik frekans";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1018, 425);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Oransal eklenik";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(881, 91);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 26);
            this.button4.TabIndex = 34;
            this.button4.Text = " Ölçüler";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ortalama
            // 
            this.ortalama.AutoSize = true;
            this.ortalama.Location = new System.Drawing.Point(882, 132);
            this.ortalama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ortalama.Name = "ortalama";
            this.ortalama.Size = new System.Drawing.Size(70, 17);
            this.ortalama.TabIndex = 35;
            this.ortalama.Text = "Ortalama:";
            this.ortalama.Visible = false;
            // 
            // varyans
            // 
            this.varyans.AutoSize = true;
            this.varyans.Location = new System.Drawing.Point(867, 153);
            this.varyans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.varyans.Name = "varyans";
            this.varyans.Size = new System.Drawing.Size(84, 17);
            this.varyans.TabIndex = 36;
            this.varyans.Text = "Ö. varyansı:";
            this.varyans.Visible = false;
            // 
            // standart
            // 
            this.standart.AutoSize = true;
            this.standart.Location = new System.Drawing.Point(878, 179);
            this.standart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.standart.Name = "standart";
            this.standart.Size = new System.Drawing.Size(71, 17);
            this.standart.TabIndex = 37;
            this.standart.Text = "S. sapma:";
            this.standart.Visible = false;
            // 
            // oms
            // 
            this.oms.AutoSize = true;
            this.oms.Location = new System.Drawing.Point(906, 206);
            this.oms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oms.Name = "oms";
            this.oms.Size = new System.Drawing.Size(43, 17);
            this.oms.TabIndex = 38;
            this.oms.Text = "OMS:";
            this.oms.Visible = false;
            // 
            // q1
            // 
            this.q1.AutoSize = true;
            this.q1.Location = new System.Drawing.Point(918, 228);
            this.q1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(31, 17);
            this.q1.TabIndex = 39;
            this.q1.Text = "Q1:";
            this.q1.Visible = false;
            // 
            // q3
            // 
            this.q3.AutoSize = true;
            this.q3.Location = new System.Drawing.Point(918, 258);
            this.q3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(31, 17);
            this.q3.TabIndex = 40;
            this.q3.Text = "Q3:";
            this.q3.Visible = false;
            // 
            // carpiklik
            // 
            this.carpiklik.AutoSize = true;
            this.carpiklik.Location = new System.Drawing.Point(880, 302);
            this.carpiklik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carpiklik.Name = "carpiklik";
            this.carpiklik.Size = new System.Drawing.Size(71, 17);
            this.carpiklik.TabIndex = 41;
            this.carpiklik.Text = "Ç. ölçütü: ";
            this.carpiklik.Visible = false;
            // 
            // sivri
            // 
            this.sivri.AutoSize = true;
            this.sivri.Location = new System.Drawing.Point(878, 324);
            this.sivri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sivri.Name = "sivri";
            this.sivri.Size = new System.Drawing.Size(67, 17);
            this.sivri.TabIndex = 42;
            this.sivri.Text = "S. ölçütü:";
            this.sivri.Visible = false;
            // 
            // katsayi
            // 
            this.katsayi.AutoSize = true;
            this.katsayi.Location = new System.Drawing.Point(861, 346);
            this.katsayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.katsayi.Name = "katsayi";
            this.katsayi.Size = new System.Drawing.Size(84, 17);
            this.katsayi.TabIndex = 43;
            this.katsayi.Text = "D. katsayısı:";
            this.katsayi.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1186, 742);
            this.Controls.Add(this.katsayi);
            this.Controls.Add(this.sivri);
            this.Controls.Add(this.carpiklik);
            this.Controls.Add(this.q3);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.oms);
            this.Controls.Add(this.standart);
            this.Controls.Add(this.varyans);
            this.Controls.Add(this.ortalama);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox15);
            this.Controls.Add(this.listBox14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox13);
            this.Controls.Add(this.listBox12);
            this.Controls.Add(this.listBox11);
            this.Controls.Add(this.listBox10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listSiralama);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox9);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Frekans Tablosu ve Serisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listSiralama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox10;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.ListBox listBox12;
        private System.Windows.Forms.ListBox listBox13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox14;
        private System.Windows.Forms.ListBox listBox15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label ortalama;
        private System.Windows.Forms.Label varyans;
        private System.Windows.Forms.Label standart;
        private System.Windows.Forms.Label oms;
        private System.Windows.Forms.Label q1;
        private System.Windows.Forms.Label q3;
        private System.Windows.Forms.Label carpiklik;
        private System.Windows.Forms.Label sivri;
        private System.Windows.Forms.Label katsayi;
    }
}

