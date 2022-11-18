using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1_212701005.Text == "")
            {
                label1_212701005.Visible = true;
            }
            else
            {
                int a = Convert.ToInt32(textBox1_212701005.Text);
                if (a != 2 && a != 3 && a != 4)
                {
                    label1_212701005.Visible = true;
                }
                else
                {
                    Form2 form2 = new Form2(a);
                  
                    this.Hide();
                    form2.Show();
                 
                    
                }
            }
            
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
