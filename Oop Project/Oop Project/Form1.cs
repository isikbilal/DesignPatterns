using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deneme deneme = new Deneme();
            try {

                deneme.setA(textBox1.Text);
            }
            catch(Exception ex)
            {
            }
            label1.Text = deneme.mesaj;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
