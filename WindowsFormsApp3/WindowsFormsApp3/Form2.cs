using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Application.DoEvents(); RoundedButton2 myButton2 = new RoundedButton2();
            //this.Controls.Add(myButton2);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

class RoundedButton2 : Button
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
        Color myColor2;
        myColor2 = Color.FromArgb(255, 255, 255);
        base.OnPaint(e); RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
        GraphicsPath GraphPath = GetRoundPath(Rect, 30);
        this.Region = new Region(GraphPath);
        using (Pen pen = new Pen(myColor2, 10.85f))
        {
            pen.Alignment = PenAlignment.Inset;
            e.Graphics.DrawPath(pen, GraphPath);
            e.Graphics.FillPath(new SolidBrush(myColor2), GraphPath);
        }
    }
}
