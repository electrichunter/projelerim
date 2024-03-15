using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace krıpto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = true;

        }
  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // TextBox'tan metni al
            string metin = textBox1.Text;
            // Metnin karakter sayısını hesapla
            int karakterSayisi = metin.Length;

            // Karakter sayısını Label'a yaz
            label1.Text = $"Karakter Sayısı: {karakterSayisi}";

        }

        private void button_sıfre_Click(object sender, EventArgs e)
        {
            // TextBox'tan metni al
            string inputText = textBox1.Text;

            // Metnin karakter sayısını hesapla
            int karakterSayisi = inputText.Length;

            // Her karakterin ASCII kodunu karkter sayısı ile toplayarak yeni metni oluştur
            string sifreText = new string(inputText.Select(c => (char)(c + karakterSayisi)).ToArray());

            // Sonucu TextBox'a yaz
            textBox2.Text = sifreText;
        }

        private void button_sıfreyı_coz_Click(object sender, EventArgs e)
        {
            // TextBox'tan şifreli metni al
            string sifreliMetin = textBox4.Text;
            // Metnin karakter sayısını hesapla
            int karakterSayisi = sifreliMetin.Length;

            // Her karakterin ASCII kodundan karakter sayısını çıkartarak orijinal metni oluştur
            string cozulmusMetin = new string(sifreliMetin.Select(c => (char)(c - karakterSayisi)).ToArray());

            // Sonucu TextBox'a yaz
            textBox3.Text = $"Çözülen Metin: {cozulmusMetin}";
        }

        private void button_cık_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void sıl_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void button_kydet_Click(object sender, EventArgs e)
        {
            // TextBox'tan metni al
            string metin = textBox2.Text;

            // Metni panoya kopyala
            Clipboard.SetText(metin);
            

            // Opsiyonel: Kullanıcıya bilgi vermek için bir mesaj göster
            MessageBox.Show("Metin panoya kopyalandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }

        private void label1_Click(object sender, EventArgs e)
        {
            // TextBox'tan metni al
            string metin = textBox1.Text;

            // Metnin karakter sayısını hesapla
            int karakterSayisi = metin.Length;

            // Karakter sayısını Label'a yaz
            label1.Text = $"Karakter Sayısı: {karakterSayisi}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 bm = new Form2();
            bm.Show();
            this.Hide();
        }
    }
}
