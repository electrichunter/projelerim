namespace krıpto2
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
            this.button_sıfre = new System.Windows.Forms.Button();
            this.button_sıfreyı_coz = new System.Windows.Forms.Button();
            this.button_kydet = new System.Windows.Forms.Button();
            this.button_cık = new System.Windows.Forms.Button();
            this.sıl = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(22, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 125);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "şifrelenecek metin giriniz";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_sıfre
            // 
            this.button_sıfre.Location = new System.Drawing.Point(22, 351);
            this.button_sıfre.Name = "button_sıfre";
            this.button_sıfre.Size = new System.Drawing.Size(128, 124);
            this.button_sıfre.TabIndex = 1;
            this.button_sıfre.Text = "Şifrele";
            this.button_sıfre.UseVisualStyleBackColor = true;
            this.button_sıfre.Click += new System.EventHandler(this.button_sıfre_Click);
            // 
            // button_sıfreyı_coz
            // 
            this.button_sıfreyı_coz.Location = new System.Drawing.Point(182, 351);
            this.button_sıfreyı_coz.Name = "button_sıfreyı_coz";
            this.button_sıfreyı_coz.Size = new System.Drawing.Size(128, 124);
            this.button_sıfreyı_coz.TabIndex = 1;
            this.button_sıfreyı_coz.Text = "Şifreyi çöz";
            this.button_sıfreyı_coz.UseVisualStyleBackColor = true;
            this.button_sıfreyı_coz.Click += new System.EventHandler(this.button_sıfreyı_coz_Click);
            // 
            // button_kydet
            // 
            this.button_kydet.Location = new System.Drawing.Point(341, 351);
            this.button_kydet.Name = "button_kydet";
            this.button_kydet.Size = new System.Drawing.Size(128, 124);
            this.button_kydet.TabIndex = 1;
            this.button_kydet.Text = "ŞİFRELİ METNİ KOPYALA";
            this.button_kydet.UseVisualStyleBackColor = true;
            this.button_kydet.Click += new System.EventHandler(this.button_kydet_Click);
            // 
            // button_cık
            // 
            this.button_cık.Location = new System.Drawing.Point(794, 351);
            this.button_cık.Name = "button_cık";
            this.button_cık.Size = new System.Drawing.Size(128, 124);
            this.button_cık.TabIndex = 1;
            this.button_cık.Text = "Çık";
            this.button_cık.UseVisualStyleBackColor = true;
            this.button_cık.Click += new System.EventHandler(this.button_cık_Click);
            // 
            // sıl
            // 
            this.sıl.Cursor = System.Windows.Forms.Cursors.Default;
            this.sıl.Location = new System.Drawing.Point(497, 351);
            this.sıl.Name = "sıl";
            this.sıl.Size = new System.Drawing.Size(128, 124);
            this.sıl.TabIndex = 2;
            this.sıl.Text = "Metni sil";
            this.sıl.UseVisualStyleBackColor = true;
            this.sıl.Click += new System.EventHandler(this.sıl_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(600, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Karakter sayısıs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(435, 37);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 125);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "şifrelenen metin";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(435, 181);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(404, 125);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "şifresi çözülen metin";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(22, 181);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(404, 125);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "şifresi çözülecek metin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 124);
            this.button1.TabIndex = 8;
            this.button1.Text = "başka bir method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sıl);
            this.Controls.Add(this.button_cık);
            this.Controls.Add(this.button_kydet);
            this.Controls.Add(this.button_sıfreyı_coz);
            this.Controls.Add(this.button_sıfre);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_sıfre;
        private System.Windows.Forms.Button button_sıfreyı_coz;
        private System.Windows.Forms.Button button_kydet;
        private System.Windows.Forms.Button button_cık;
        private System.Windows.Forms.Button sıl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}

