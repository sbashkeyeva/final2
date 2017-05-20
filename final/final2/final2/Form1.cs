using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final2
{
    public partial class Form1 : Form
    {
        Button[,] b = new Button[3, 3];
        int[] p = new int[11];
       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = p[1].ToString();
            button2.Text = p[2].ToString();
            button3.Text = p[3].ToString();
            button4.Text = p[4].ToString();
            button5.Text = p[5].ToString();
            button6.Text = p[6].ToString();
            button7.Text = p[7].ToString();
            button8.Text = p[8].ToString();
            button9.Text = p[9].ToString();
        }
        int q=0 ;

        private void button2_Click(object sender, EventArgs e)
        {
            p[2]++;
            if (p[2]==1)
            {
                p[10]++;
                textBox1.Text = p[10].ToString();
            }
            else
            {
                for (int u = 2; u < p[2]; u++)
                {
                    if (p[2] % u == 0)
                        q++;
                }
                if (q == 0)
                {
                    p[10]++;
                    textBox1.Text = p[10].ToString();
                }

            }
            
            
            button2.Text = p[2].ToString();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            p[1]++;
            button1.Text = p[1].ToString();
            if (p[2] % 2 == 0)
            {
                p[10]++;
                textBox1.Text = p[10].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p[3]++;
            button3.Text = p[3].ToString();
            if (p[2] % 2 == 0)
            {
                p[10]++;
                textBox1.Text = p[10].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p[4]++;
            button4.Text = p[4].ToString();
            if (p[2] % 2 == 0)
            {
                p[10]++;
                textBox1.Text = p[10].ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p[5]++;
            button5.Text = p[5].ToString();
            if (p[2] % 2 == 0)
            {
                p[10]++;
                textBox1.Text = p[10].ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p[6]++;
            button6.Text = p[6].ToString();
            if (p[2] % 2 == 0 )
            {
                p[10]++;
                textBox1.Text = p[10].ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            p[7]++;
            button7.Text = p[7].ToString();
            if (p[2] % 2 == 0)
            {
                p[10]++;
                textBox1.Text = p[10].ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            p[8]++;
            button8.Text = p[8].ToString();
            if (p[2] % 2 == 0)
            {
                p[10]++;
                textBox1.Text = p[10].ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            p[9]++;
            button9.Text = p[9].ToString();
            if (p[2] % 2 == 0 )
            {
                p[10]++;
                textBox1.Text = p[10].ToString();
            }
        }
    }
}
