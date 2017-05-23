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

namespace TestMemory_v2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Application.DoEvents(); RoundedButton myButton = new RoundedButton();
            //this.Controls.Add(myButton);
        }

        public static Bitmap RotateImg(Bitmap bmp, float angle)
        {
            int w = bmp.Width + 160;
            int h = bmp.Height + 160;
            Bitmap tempImg = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(tempImg);
            g.DrawImageUnscaled(bmp, 1, 1);
            g.Dispose();
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, w, h));
            Matrix mtrx = new Matrix();
            mtrx.Rotate(angle);
            RectangleF rct = path.GetBounds(mtrx);
            Bitmap newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height));
            g = Graphics.FromImage(newImg);
            g.TranslateTransform(-rct.X, -rct.Y);
            g.RotateTransform(angle);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(tempImg, 0, 0);
            g.Dispose();
            tempImg.Dispose();
            return newImg;
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            pictureBox1.Image = (Image)(RotateImg(bitmap, -45.0f));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Color myColor;
            myColor = Color.FromArgb(255, 255, 255);
            base.OnPaint(e);
            Graphics g = e.Graphics;
            using (Pen selPen = new Pen(myColor))
            {
                g.TranslateTransform(20.0F, 20.0F);
                g.RotateTransform(-45.0F);
                g.DrawRectangle(selPen, -800, 550, 1600, 100);
                g.FillRectangle(new SolidBrush(myColor), new Rectangle(-800, 550, 1600, 100));
            }

            Color myColor2;
            myColor2 = Color.FromArgb(142, 171, 197);
            using (Pen twoPen = new Pen(myColor2))
            {
                g.DrawRectangle(twoPen, -800, 460, 1500, 80);
                g.FillRectangle(new SolidBrush(myColor2), new Rectangle(-800, 460, 1500, 80));
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            Hide();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            Hide();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
        myColor = Color.FromArgb(255, 255, 255);
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
