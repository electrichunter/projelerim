namespace kriptolamak
{
    partial class sıfrecoz
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 74);
            this.button2.TabIndex = 7;
            this.button2.Text = "Şifreleme Sayfası";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "ANA MENÜ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(29, 39);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(169, 74);
            this.sifre.TabIndex = 4;
            this.sifre.Text = "Şifreyi Çöz";
            this.sifre.UseVisualStyleBackColor = true;
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(29, 151);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(169, 74);
            this.kaydet.TabIndex = 5;
            this.kaydet.Text = "Kopyala";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(230, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 408);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "ŞİFRESİNİ ÇÖZMEK İSTEDİGİNİZ METNİ GİRİNİZ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sıfrecoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kaydet);
            this.Name = "sıfrecoz";
            this.Text = "sıfrecoz";
            this.Load += new System.EventHandler(this.sıfrecoz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sifre;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.TextBox textBox1;
    }
}