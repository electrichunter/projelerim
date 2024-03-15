using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krıpto2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string sifre(string metin)
        {
            string tersMetin = "";
            for (int i = metin.Length - 1; i >= 0; i -= 2)
            {
                if (i >= 1)
                {
                    tersMetin += metin[i - 1];
                }
                tersMetin += metin[i];
            }
            return tersMetin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text; 
            string tersMetin = sifre(metin);
            textBox2.Text = tersMetin;
        }
   



public static string cozSifre(string sifreliMetin)
        {
            string orijinalMetin = "";

            for (int i = 0; i < sifreliMetin.Length; i += 2)
            {
                if (i + 1 < sifreliMetin.Length)
                {
                    orijinalMetin += sifreliMetin[i + 1];
                }
                orijinalMetin += sifreliMetin[i];
            }

            char[] tersDizi = orijinalMetin.ToCharArray();
            Array.Reverse(tersDizi);
            return new string(tersDizi);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string metin = textBox4.Text;
            string tersMetin = cozSifre(metin);
            textBox3.Text = tersMetin;
        }
    }
}
