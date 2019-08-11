namespace CalculadoraSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDato1 = new System.Windows.Forms.Label();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.BackColor = System.Drawing.Color.Black;
            this.lblDato1.ForeColor = System.Drawing.Color.White;
            this.lblDato1.Location = new System.Drawing.Point(63, 57);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(39, 13);
            this.lblDato1.TabIndex = 0;
            this.lblDato1.Text = "Dato 1";
            this.lblDato1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.BackColor = System.Drawing.Color.Black;
            this.lblDato2.ForeColor = System.Drawing.Color.White;
            this.lblDato2.Location = new System.Drawing.Point(63, 187);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(39, 13);
            this.lblDato2.TabIndex = 1;
            this.lblDato2.Text = "Dato 2";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(47, 299);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Resultado";
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(119, 54);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(100, 20);
            this.txtDato1.TabIndex = 3;
            // 
            // txtDato2
            // 
            this.txtDato2.Location = new System.Drawing.Point(119, 184);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(100, 20);
            this.txtDato2.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(119, 299);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(236, 51);
            this.txtResult.TabIndex = 5;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(144, 401);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 37);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(240, 401);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 37);
            this.btnResta.TabIndex = 7;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(340, 401);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 37);
            this.btnMult.TabIndex = 8;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(431, 401);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 37);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 37);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(524, 401);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 34);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDato2);
            this.Controls.Add(this.lblDato1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

