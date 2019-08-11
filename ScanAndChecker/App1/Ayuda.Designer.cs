namespace App1
{
    partial class Ayuda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_delphi = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delphi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox_delphi);
            this.panel1.Controls.Add(this.pictureBox_logo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 273);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_delphi
            // 
            this.pictureBox_delphi.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_delphi.Location = new System.Drawing.Point(194, 11);
            this.pictureBox_delphi.Name = "pictureBox_delphi";
            this.pictureBox_delphi.Size = new System.Drawing.Size(134, 65);
            this.pictureBox_delphi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_delphi.TabIndex = 3;
            this.pictureBox_delphi.TabStop = false;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Location = new System.Drawing.Point(32, 27);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(146, 36);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 2;
            this.pictureBox_logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.MaximumSize = new System.Drawing.Size(300, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scan and Checker fue desarrollado para Delphi DCS, su distribución y comercializa" +
    "ción fuera de la empresa se considerará un acto ilícito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacto: juliotejadanava@gmail.com";
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 277);
            this.Controls.Add(this.panel1);
            this.Name = "Ayuda";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delphi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_delphi;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}