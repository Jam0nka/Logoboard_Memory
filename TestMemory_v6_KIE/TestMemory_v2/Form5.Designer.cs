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
    partial class Form5
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Color myColor;
            myColor = Color.FromArgb(21, 54, 87);
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Helvetica", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(502, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(921, 11);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Helvetica", 8.25F);
            this.textBox2.Location = new System.Drawing.Point(502, 163);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(921, 690);
            this.textBox2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestMemory_v2.Properties.Resources.Zeichenfläche_2;
            this.pictureBox1.Location = new System.Drawing.Point(1585, -110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(54)))), ((int)(((byte)(87)))));
            this.button1.Font = new System.Drawing.Font("Helvetica", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(875, 942);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Helvetica", 19F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "LG",
            "",
            "Wien Energie",
            "",
            "OMV",
            "",
            "HESS",
            "",
            "OTIS",
            "",
            "Löwenstein",
            "",
            "Aspern +",
            "",
            "Österreichische Lotterien",
            "",
            "UNIQA",
            "",
            "Doppelmayr",
            "",
            "Tripan",
            "",
            "IV",
            "",
            "Essecca"});
            this.listBox1.Location = new System.Drawing.Point(61, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 700);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label1.Location = new System.Drawing.Point(261, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "LG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label2.Location = new System.Drawing.Point(261, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wien Energie";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label3.Location = new System.Drawing.Point(261, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "OMV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label4.Location = new System.Drawing.Point(261, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "HESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label5.Location = new System.Drawing.Point(261, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "OTIS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label6.Location = new System.Drawing.Point(261, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Löwenstein";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label7.Location = new System.Drawing.Point(261, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Aspern +";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label8.Location = new System.Drawing.Point(391, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Österreichische Lotterien";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label9.Location = new System.Drawing.Point(261, 607);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "UNIQA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label10.Location = new System.Drawing.Point(261, 656);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Doppelmayr";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label11.Location = new System.Drawing.Point(261, 713);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 31);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tripan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label12.Location = new System.Drawing.Point(261, 775);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 31);
            this.label12.TabIndex = 20;
            this.label12.Text = "IV";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Helvetica", 19F);
            this.label13.Location = new System.Drawing.Point(261, 822);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 31);
            this.label13.TabIndex = 21;
            this.label13.Text = "Essecca";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}