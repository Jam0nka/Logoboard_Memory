using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMemory_v2
{
    public partial class After_Screen : Form
    {

        String zeit;
        public After_Screen(String z)
        {
            InitializeComponent();
            zeit = z;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            label1.Text = zeit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Memory_Screen().Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Memory_Screen().Show();
            Close();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            Hide();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            new Memory_Screen().Show();
            Close();
        }
    }
}
