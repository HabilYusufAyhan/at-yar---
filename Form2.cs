using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı
{
    //form 1 den gelen değeri tanımladık
    public partial class Form2 : Form
    {
        int atsayisi;
        public Form2(int a)
        {
            atsayisi = a;
            InitializeComponent();
            

        }

        
        
       
        //at sayısına göre gösterilecek atları belirliyoruz
        private void button5_Click(object sender, EventArgs e)
        {
           
            button1_212701005.Enabled = true;
            button2_212701005.Enabled = false;
            button3_212701005.Enabled = false;
            button4_212701005.Enabled = false;
            if (atsayisi == 2)
            {
                pictureBox1_212701005.Visible = true;
                pictureBox2_212701005.Visible = true;
                button1_212701005.Visible = true;
                button2_212701005.Visible = true;
            }
            else if (atsayisi == 3)
            {
                pictureBox1_212701005.Visible = true;
                pictureBox2_212701005.Visible = true;
                pictureBox3_212701005.Visible = true;
                button1_212701005.Visible = true;
                button2_212701005.Visible = true;
                button3_212701005.Visible = true;
            }
            else if (atsayisi == 4)
            {
                pictureBox1_212701005.Visible = true;
                pictureBox2_212701005.Visible = true;
                pictureBox3_212701005.Visible = true;
                pictureBox4_212701005.Visible = true;
                button1_212701005.Visible = true;
                button2_212701005.Visible = true;
                button3_212701005.Visible = true;
                button4_212701005.Visible = true;
            }
           

        }
        //random sayı üretiliyor
        Random rastgele = new Random();
       //buradaki her buton için atın hareketi ayarlanıyor ve istenilen kordinata gelince message box la kazanan at söyleniyor
        private void button1_Click(object sender, EventArgs e)
        {
           

            int at1 = rastgele.Next(30)+5;
            int varolan = pictureBox1_212701005.Location.X;
            pictureBox1_212701005.Location = new Point(varolan+at1, 171);
            varolan = varolan + at1;
            button1_212701005.Enabled = false;
            button2_212701005.Enabled = true;
            if(pictureBox1_212701005.Location.X >= 470)
            {
                DialogResult sonuc = MessageBox.Show("1.at kazandı!", "KAZANAN");
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int at2 = rastgele.Next(30)+5;
            int varolan1 = pictureBox2_212701005.Location.X;
            pictureBox2_212701005.Location = new Point(varolan1 + at2, 217);
            varolan1 = varolan1 + at2;
            if(atsayisi > 2) { 
            button2_212701005.Enabled = false;
            button3_212701005.Enabled = true;
            }
            else
            {
                button2_212701005.Enabled = false;
                button1_212701005.Enabled = true;
            }
            if (pictureBox2_212701005.Location.X >= 470)
            {
                DialogResult sonuc = MessageBox.Show("2.at kazandı!", "KAZANAN");
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int at3 = rastgele.Next(30)+5;
            int varolan2 = pictureBox3_212701005.Location.X;
            pictureBox3_212701005.Location = new Point(varolan2 + at3, 262);
            varolan2 = varolan2 + at3;
            if (atsayisi > 3)
            {
                button3_212701005.Enabled = false;
                button4_212701005.Enabled = true;
            }
            else
            {
                button3_212701005.Enabled = false;
                button1_212701005.Enabled = true;
            }
            if (pictureBox3_212701005.Location.X >= 470)
            {
                DialogResult sonuc = MessageBox.Show("3.at kazandı!", "KAZANAN");
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int at4 = rastgele.Next(30) + 5;
            int varolan3 = pictureBox4_212701005.Location.X;
            pictureBox4_212701005.Location = new Point(varolan3 + at4, 308);
            varolan3 = varolan3 + at4;
            button4_212701005.Enabled = false;
            button1_212701005.Enabled = true;
            if (pictureBox4_212701005.Location.X >= 470)
            {
                DialogResult sonuc = MessageBox.Show("4.at kazandı!", "KAZANAN");
                Application.Exit();
            }
        }
        // sıfırla butonuna basılırsa atların en baştaki konumlarına gönderiliyor
        private void button6212701005_Click(object sender, EventArgs e)
        {
            pictureBox1_212701005.Location = new Point(46, 171);
            pictureBox2_212701005.Location = new Point(46, 217);
            pictureBox3_212701005.Location = new Point(46, 262);
            pictureBox4_212701005.Location = new Point(46, 308);
            button1_212701005.Enabled = true;
            button2_212701005.Enabled = false;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
