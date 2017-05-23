using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMemory_v2
{
    partial class Form6
    {
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
                g.DrawRectangle(selPen, -115, 33, 230, 40);
                g.FillRectangle(new SolidBrush(myColor), new Rectangle(-115, 33, 230, 40));
            }

            Color myColor2;
            myColor2 = Color.FromArgb(142, 171, 197);
            using (Pen twoPen = new Pen(myColor2))
            {
                g.DrawRectangle(twoPen, -90, 0, 160, 30);
                g.FillRectangle(new SolidBrush(myColor2), new Rectangle(-90, 0, 160, 30));
            }

        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(54)))), ((int)(((byte)(87)))));
            this.textBox1.Location = new System.Drawing.Point(502, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(921, 690);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(875, 942);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(54)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Helvetica", 8.25F);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}