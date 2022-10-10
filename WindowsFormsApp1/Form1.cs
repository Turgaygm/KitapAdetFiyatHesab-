using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double adet = Convert.ToDouble(textBox1.Text);
            double fiyat = Convert.ToDouble(textBox2.Text); ;
            double sonuc = 0;
            if (adet >= 1 && adet  <= 20 )
            {
                sonuc = ((adet * fiyat) - ((adet * fiyat) * 20 / 100));
                MessageBox.Show("Fiyat =" + sonuc);
            }
            else if (adet >= 21 && adet <= 40 )
            {
                sonuc = ((adet * fiyat) -((adet * fiyat) * 40 / 100));
                
                MessageBox.Show("Fiyat =" +  sonuc);
            }
            else if (adet >= 41)
            {
                sonuc = ((adet * fiyat) - ((adet * fiyat) * 50 / 100));
                MessageBox.Show("Fiyat =" + sonuc);
            }else
            {
                MessageBox.Show("pozitif bir kitap adeti giriniz ") ;
            }
        }
    }
}
