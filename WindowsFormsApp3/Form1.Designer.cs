using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    partial class Form1
    {
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 1042);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.HeroesPichur = new Bitmap("3.png");
            this.DujPanel = new Bitmap("22.png");
            this.DujPanel1 = new Bitmap("22.png");
            this.DujPanel2 = new Bitmap("22.png");
            this.DujPanel3 = new Bitmap("22.png");
            this.DujPanel4 = new Bitmap("22.png");
            this.DujPanel5 = new Bitmap("22.png");
            this.DujPanel6 = new Bitmap("22.png");
            this.DujPanel7 = new Bitmap("22.png");
            this.DujPanel8 = new Bitmap("22.png");
            this.DujPanel9 = new Bitmap("22.png");
            this.DujPanel10 = new Bitmap("22.png");
            this.DujPanel11 = new Bitmap("22.png");
            this.DujPanel12 = new Bitmap("22.png");

            this.Paint += Paint_on;
        }

   

       Bitmap HeroesPichur, DujPanel, DujPanel1, DujPanel2, DujPanel3, DujPanel4, DujPanel5, DujPanel6, DujPanel7, DujPanel8, DujPanel9, DujPanel10, DujPanel11, DujPanel12;
        #endregion
    }
}

