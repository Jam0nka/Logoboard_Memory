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
    partial class After_Screen
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
            this.label1 = new System.Windows.Forms.Label();
            this.roundedButton1 = new RoundedButton();
            this.roundedButton2 = new RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(839, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 107);
            this.label1.TabIndex = 2;
            this.label1.Text = "Null";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.Location = new System.Drawing.Point(478, 691);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(151, 75);
            this.roundedButton1.TabIndex = 3;
            this.roundedButton1.Text = "roundedButton1";
            this.roundedButton1.UseVisualStyleBackColor = true;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.Location = new System.Drawing.Point(1307, 691);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(151, 75);
            this.roundedButton2.TabIndex = 4;
            this.roundedButton2.Text = "roundedButton2";
            this.roundedButton2.UseVisualStyleBackColor = true;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Helvetica", 10F);
            this.label2.Location = new System.Drawing.Point(522, 720);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nochmal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Helvetica", 10F);
            this.label3.Location = new System.Drawing.Point(1348, 720);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Beenden";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // After_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "After_Screen";
            this.Text = "After_Screen";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private Label label2;
        private Label label3;
    }
}