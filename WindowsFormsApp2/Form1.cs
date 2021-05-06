using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ad,soyad;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        public void button1_Click_1(object sender, EventArgs e)
        {
            if (this.button1.Text == "Geri al")
            {
                this.button1.Text = "Kaydet";
                this.progressBar1.Value = 0;
                this.label8.Text = "";
            }
            else
            {
                this.progressBar1.Value = 100;
                this.label8.BackColor = System.Drawing.Color.Transparent;
                this.label8.Text = "Kaydedildi";
                this.button1.Text = "Geri al";
               soyad = this.textBox2.Text ;
               ad= this.textBox1.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "isim gizle")
            {
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.button2.Text = "isim göster";
               
            }
            else
            {
                this.textBox3.Text = ad;
                this.textBox4.Text = soyad;
                this.button2.Text = "isim gizle";

            }
        }
    }
}
