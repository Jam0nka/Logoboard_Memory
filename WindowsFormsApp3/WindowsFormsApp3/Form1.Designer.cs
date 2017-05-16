
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{ 
    partial class Form1
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
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OMV = new System.Windows.Forms.ListBox();
            this.roundedButton1 = new RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.Zeichenfläche_2;
            this.pictureBox1.Location = new System.Drawing.Point(1585, -110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(502, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(921, 690);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OMV
            // 
            this.OMV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OMV.Font = new System.Drawing.Font("Helvetica", 19F);
            this.OMV.FormattingEnabled = true;
            this.OMV.ItemHeight = 28;
            this.OMV.Items.AddRange(new object[] {
            "LG",
            "",
            "Wien Energie ",
            "",
            "OMV ",
            "",
            "HESS ",
            "",
            "OTIS ",
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
            "IV ",
            "",
            "Essecca"});
            this.OMV.Location = new System.Drawing.Point(61, 153);
            this.OMV.Name = "OMV";
            this.OMV.Size = new System.Drawing.Size(341, 700);
            this.OMV.TabIndex = 4;
            this.OMV.SelectedIndexChanged += new System.EventHandler(this.OMV_SelectedIndexChanged);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Black;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(875, 942);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(137, 66);
            this.roundedButton1.TabIndex = 5;
            this.roundedButton1.Text = "Zurück";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(54)))), ((int)(((byte)(87)))));
            this.label1.Font = new System.Drawing.Font("Helvetica", 12F);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(917, 966);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zurück";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.OMV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private ListBox OMV;
        private RoundedButton roundedButton1;
        private Label label1;
    }
}

