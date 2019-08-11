namespace Gasolineria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstacion = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.rbMagna = new System.Windows.Forms.RadioButton();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarResultados = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Litros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Importe";
            // 
            // txtEstacion
            // 
            this.txtEstacion.Location = new System.Drawing.Point(257, 113);
            this.txtEstacion.Multiline = true;
            this.txtEstacion.Name = "txtEstacion";
            this.txtEstacion.Size = new System.Drawing.Size(112, 31);
            this.txtEstacion.TabIndex = 5;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(257, 163);
            this.txtLitros.Multiline = true;
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(112, 31);
            this.txtLitros.TabIndex = 6;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(257, 216);
            this.txtImporte.Multiline = true;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(112, 31);
            this.txtImporte.TabIndex = 7;
            // 
            // rbMagna
            // 
            this.rbMagna.AutoSize = true;
            this.rbMagna.Location = new System.Drawing.Point(42, 34);
            this.rbMagna.Name = "rbMagna";
            this.rbMagna.Size = new System.Drawing.Size(58, 17);
            this.rbMagna.TabIndex = 10;
            this.rbMagna.TabStop = true;
            this.rbMagna.Text = "Magna";
            this.rbMagna.UseVisualStyleBackColor = true;
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Location = new System.Drawing.Point(42, 69);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(65, 17);
            this.rbPremium.TabIndex = 11;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Gasolina";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(452, 111);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agragar Registro";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarResultados
            // 
            this.btnMostrarResultados.Location = new System.Drawing.Point(533, 111);
            this.btnMostrarResultados.Name = "btnMostrarResultados";
            this.btnMostrarResultados.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarResultados.TabIndex = 14;
            this.btnMostrarResultados.Text = "Resultado";
            this.btnMostrarResultados.UseVisualStyleBackColor = true;
            this.btnMostrarResultados.Click += new System.EventHandler(this.btnMostrarResultados_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(614, 111);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(695, 111);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gasolineria la estrella";
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.Location = new System.Drawing.Point(452, 158);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(318, 238);
            this.lbResultado.TabIndex = 18;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.rbMagna);
            this.gbOpciones.Controls.Add(this.rbPremium);
            this.gbOpciones.Location = new System.Drawing.Point(23, 113);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(151, 125);
            this.gbOpciones.TabIndex = 19;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMostrarResultados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtEstacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstacion;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.RadioButton rbMagna;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarResultados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.GroupBox gbOpciones;
    }
}

