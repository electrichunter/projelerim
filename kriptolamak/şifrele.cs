﻿using System;
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
    public partial class şifrele : Form
    {
        // Harf-sayı eşleştirmesi için bir kitap
        private readonly Dictionary<char, int> harfSayiEsleme = new Dictionary<char, int>
        {{'0', 48},
{'1', 49},
{'2', 50},
{'3', 51},
{'4', 52},
{'5', 53},
{'6', 54},
{'7', 55},
{'8', 56},
{'9', 57},
{'a', 97},
{'b', 98},
{'c', 99},
{'d', 100},
{'e', 101},
{'f', 102},
{'g', 103},
{'h', 104},
{'i', 105},
{'j', 106},
{'k', 107},
{'l', 108},
{'m', 109},
{'n', 110},
{'o', 111},
{'p', 112},
{'q', 113},
{'r', 114},
{'s', 115},
{'t', 116},
{'u', 117},
{'v', 118},
{'w', 119},
{'x', 120},
{'y', 121},
{'z', 122},
{'A', 65},
{'B', 66},
{'C', 67},
{'D', 68},
{'E', 69},
{'F', 70},
{'G', 71},
{'H', 72},
{'I', 73},
{'J', 74},
{'K', 75},
{'L', 76},
{'M', 77},
{'N', 78},
{'O', 79},
{'P', 80},
{'Q', 81},
{'R', 82},
{'S', 83},
{'T', 84},
{'U', 85},
{'V', 86},
{'W', 87},
{'X', 88},
{'Y', 89},
{'Z', 90},
{'!', 33},
{'"', 34},
{'#', 35},
{'$', 36},
{'%', 37},
{'&', 38},
{'\'', 39},
{'(', 40},
{')', 41},
{'*', 42},
{'+', 43},
{',', 44},
{'-', 45},
{'.', 46},
{'/', 47},
{':', 58},
{';', 59},
{'<', 60},
{'=', 61},
{'>', 62},
{'?', 63},
{'@', 64},
{'[', 91},
{'\\', 92},
{']', 93},
{'^', 94},
{'_', 95},
{'`', 96},
{'{', 123},
{'|', 124},
{'}', 125},
{'~', 126},
{' ', 32},
{'\t', 9},
{'\n', 10},
{'\r', 13},
{'\u000B', 11},
{'\f', 12},



        };
       
        public şifrele()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            // TextBox1'deki veriyi al
            string textbox1Value = textBox1.Text;

            // Panoya kopyala
            Clipboard.SetText(textbox1Value);
            MessageBox.Show("Veri panoya kopyalandı.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anamenu = new Form1();

            // İkinci formu gösterin
            anamenu.Show();

            // Eğer ikinci formu gösterdikten sonra, mevcut formu gizlemek istiyorsanız:
            this.Hide();
        }

        private void sifre_Click(object sender, EventArgs e)
        {
            string girisMetni = textBox1.Text;

            // Metni şifrele
            StringBuilder sifreliMetin = new StringBuilder();
            foreach (char harf in girisMetni)
            {
                if (harfSayiEsleme.ContainsKey(char.ToUpper(harf)))
                {
                    // Harfe karşılık gelen sayı değerini al
                    int sayi = harfSayiEsleme[char.ToUpper(harf)];

                    // Şifrelenmiş harfi ekle
                    sifreliMetin.Append(sayi.ToString() + " ");
                }
             
                else
                {

                    // Harf sayı eşleştirmesi yapılmamışsa, aynı şekilde bırak (yoksa kayboluyor)
                    sifreliMetin.Append(harf);
                }
            }

            // Şifrelenmiş metni TextBox'a yazdır
            textBox1.Text = sifreliMetin.ToString();
        }

        private void şifrele_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sıfrecoz sıfrecoz = new sıfrecoz();

            // İkinci formu gösterin
            sıfrecoz.Show();

           
            this.Hide();
        }
    }
}
