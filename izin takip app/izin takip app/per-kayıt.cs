using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace izin_takip_app
{
    public partial class per_kayıt : Form
    {
        public per_kayıt()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel-izin.accdb");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void per_kayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bağlantıyı aç
            baglanti.Open();

            // TextBox'lardan verileri al
            string ad = textBox1.Text;
            string soyad = textBox2.Text;

            // Veritabanına ekleme sorgusu
            string eklemeSorgusu = "INSERT INTO Personel (Ad, Soyad) VALUES (@Ad, @Soyad)";

            // OleDbCommand nesnesini oluştur
            OleDbCommand cmd = new OleDbCommand(eklemeSorgusu, baglanti);

            // Parametreleri ekle
            cmd.Parameters.AddWithValue("@Ad", ad);
            cmd.Parameters.AddWithValue("@Soyad", soyad);

            // Sorguyu çalıştır
            cmd.ExecuteNonQuery();

            MessageBox.Show("Veri başarıyla eklendi.");
        }
          
}
    }

