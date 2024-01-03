using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModenUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            textBox1.ForeColor = Color.FromArgb(0, 192, 192);

            textBox2.ForeColor = Color.White;
            panel2.BackColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.ForeColor = Color.FromArgb(0, 192, 192);
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            textBox1.ForeColor = Color.White;
            panel1.BackColor = Color.White;
        }
    }
}
