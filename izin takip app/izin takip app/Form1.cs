using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izin_takip_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Geçmek istediğiniz formun nesnesini oluşturun
            per_kayıt per = new per_kayıt();

            // İkinci formu gösterin
            per.Show();

            // Eğer ikinci formu gösterdikten sonra, mevcut formu gizlemek istiyorsanız:
            this.Hide();
        }
    }
    }
}
