using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModenUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fr.Show();
           
        }
        Form2 fr = new Form2();
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            textBox1.ForeColor = Color.FromArgb(0, 192, 192);

            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel3.BackColor = Color.White;
            textBox3.ForeColor = Color.White;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            textBox2.ForeColor = Color.FromArgb(0, 192, 192);

            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel3.BackColor = Color.White;
            textBox3.ForeColor = Color.White;
        }
        
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            textBox3.ForeColor = Color.FromArgb(0, 192, 192);

            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fr.Left += 10;
            if (fr.Left >= 1087)
            {
                timer1.Stop();
                this.TopMost = false;
                fr.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fr.Left -= 10;
            if(fr.Left <= 830)
            {
                timer2.Stop();
            }
        }
    }
}
