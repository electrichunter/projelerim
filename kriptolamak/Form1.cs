using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kriptolamak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            şifrele ikinciForm = new şifrele();

            // İkinci formu gösterin
            ikinciForm.Show();

            // Eğer ikinci formu gösterdikten sonra, mevcut formu gizlemek istiyorsanız:
            this.Hide();
        
       
    }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
