using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMemory_v2
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Memory_Screen().Show();
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            new Memory_Screen().Show();
            Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            new Memory_Screen().Show();
            Close();
        }
    }
}


