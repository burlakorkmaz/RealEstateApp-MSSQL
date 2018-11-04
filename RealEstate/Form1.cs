using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate
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

        private void button1_Click(object sender, EventArgs e)
        {
            ArsaBilgileri a = new ArsaBilgileri();
            a.Show();
            this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DaireBilgileri a = new DaireBilgileri();
            a.Show();
            this.Hide();
        }

        private void cikisButonu_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KonutBilgileri a = new KonutBilgileri();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApartmanBilgileri a = new ApartmanBilgileri();
            a.Show();
            this.Hide();
        }
    }
}
