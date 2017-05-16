using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.DoEvents(); RoundedButton myButton = new RoundedButton();
            //this.Controls.Add(myButton);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void OMV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

class RoundedButton : Button
{
    GraphicsPath GetRoundPath(RectangleF Rect, int radius)
    {
        float r2 = radius / 2f;
        GraphicsPath GraphPath = new GraphicsPath();
        GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
        GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
        GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
        GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
        GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
        GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
        GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
        GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

        GraphPath.CloseFigure();
        return GraphPath;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        Color myColor;
        myColor = Color.FromArgb(21, 54, 87);
        base.OnPaint(e); RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
        GraphicsPath GraphPath = GetRoundPath(Rect, 30);
        this.Region = new Region(GraphPath);
        using (Pen pen = new Pen(myColor, 10.85f))
        {
            pen.Alignment = PenAlignment.Inset;
            e.Graphics.DrawPath(pen, GraphPath);
            e.Graphics.FillPath(new SolidBrush(myColor), GraphPath);
        }
    }
}
