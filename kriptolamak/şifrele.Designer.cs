namespace kriptolamak
{
    partial class şifrele
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(200, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 390);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ŞİFRELEMK İSTEDİGİNİZ METNİ GİRİNİZ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(12, 122);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(169, 74);
            this.kaydet.TabIndex = 1;
            this.kaydet.Text = "Kopyala";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(12, 28);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(169, 74);
            this.sifre.TabIndex = 1;
            this.sifre.Text = "Şifrele";
            this.sifre.UseVisualStyleBackColor = true;
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "ANA MENÜ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 74);
            this.button2.TabIndex = 3;
            this.button2.Text = "Şifreyi Çözme Sayfası";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // şifrele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.textBox1);
            this.Name = "şifrele";
            this.Text = "şifrele";
            this.Load += new System.EventHandler(this.şifrele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button sifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}