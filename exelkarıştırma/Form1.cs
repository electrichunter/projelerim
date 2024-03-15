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
using ClosedXML.Excel;


namespace exelkarıştırma
{
    public partial class Form1 : Form
    {
        DataTable originalDataTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Dosyaları|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Excel Dosyasını Seç";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dosyaYolu = openFileDialog.FileName;

                    try
                    {
                        string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dosyaYolu}; Extended Properties='Excel 12.0 xml;HDR=YES;'";
                        using (OleDbConnection baglanti = new OleDbConnection(connectionString))
                        {
                            baglanti.Open();
                            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Sayfa1$]", baglanti);
                            originalDataTable = new DataTable(); // originalDataTable'ı oluştur
                            da.Fill(originalDataTable);
                            dataGridView1.DataSource = originalDataTable.DefaultView;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Excel dosyasından veri okunurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        } 

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource == null)
            {
                MessageBox.Show("Lütfen verileri önce karıştırın.");
                return;
            }

            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Sayfa1");

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        ws.Cell(i + 1, j + 1).Value = dataGridView2.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Excel Dosyasını Kaydet";
                    saveFileDialog.FileName = "output.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        wb.SaveAs(filePath);
                        MessageBox.Show("Excel dosyası başarıyla kaydedildi.");
                    }
                }
            }

        }

        private void karıstır_Click(object sender, EventArgs e)
        {
            DataTable shuffledDataTable = originalDataTable.Clone(); // Orjinal veri tablosunu kopyala
            List<DataRow> rows = originalDataTable.AsEnumerable().ToList(); // Orjinal veri tablosundaki satırları bir liste olarak al

            Random random = new Random();
            while (rows.Count > 0)
            {
                int index = random.Next(rows.Count); // Rastgele bir index seç
                DataRow randomRow = rows[index]; // Rastgele seçilen satırı al
                shuffledDataTable.ImportRow(randomRow); // Rastgele seçilen satırı yeni tabloya ekle
                rows.RemoveAt(index); // Kopyalanan satırı listeden kaldır
            }

            dataGridView2.DataSource = shuffledDataTable.DefaultView; // Karıştırılmış verileri DataGridView'e yükle

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
