using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataTurleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sayi1 = textBox1.Text;
                string sayi2 = textBox2.Text;
                int s1 = Convert.ToInt32(sayi1);
                int s2 = Convert.ToInt32(sayi2);
                int toplam = s1 + s2;
                textBox3.Text = toplam.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message+ "Sayi Girmelisiniz");

            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message+ "Daha kucuk bir sayi giriniz");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                toplam += i;
                
            }
            textBox3.Text = toplam.ToString();
        }
    }
}
