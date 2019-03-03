using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        database db = new database();
        hesapla kdv = new hesapla();
        toplam maliyet = new toplam();
        doviz kur = new doviz();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text =""+ db.getFiyat(comboBox1.SelectedIndex);
            label3.Text = "" + kdv.kdvhesapla(db.getFiyat(comboBox1.SelectedIndex));      
        }
        database toplam = new database();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 5; i++)
            {

                comboBox1.Items.Add(db.getAd(i));
                
            }

            
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(maliyet.kdvtoplamhesapla(kdv.kdvhesapla(db.getFiyat(comboBox1.SelectedIndex)), Convert.ToInt32(textBox1.Text)));
            label6.Text = "" + kur.maliyetdovizeuro(kdv.kdvhesapla(db.getFiyat(comboBox1.SelectedIndex)));
            label7.Text = "" + kur.maliyetdovizdolar(kdv.kdvhesapla(db.getFiyat(comboBox1.SelectedIndex)));
        }
    }
    }

