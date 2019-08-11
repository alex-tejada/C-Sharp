namespace AgenciaDeViajes
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtDestinos = new System.Windows.Forms.TextBox();
            this.txtAdultos = new System.Windows.Forms.TextBox();
            this.txtNinos = new System.Windows.Forms.TextBox();
            this.lbDestinos = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destinos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adultos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ninos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Agencia de viajes";
            // 
            // txtDestinos
            // 
            this.txtDestinos.Location = new System.Drawing.Point(41, 129);
            this.txtDestinos.Multiline = true;
            this.txtDestinos.Name = "txtDestinos";
            this.txtDestinos.Size = new System.Drawing.Size(131, 39);
            this.txtDestinos.TabIndex = 4;
            // 
            // txtAdultos
            // 
            this.txtAdultos.Location = new System.Drawing.Point(41, 174);
            this.txtAdultos.Multiline = true;
            this.txtAdultos.Name = "txtAdultos";
            this.txtAdultos.Size = new System.Drawing.Size(131, 39);
            this.txtAdultos.TabIndex = 5;
            // 
            // txtNinos
            // 
            this.txtNinos.Location = new System.Drawing.Point(41, 219);
            this.txtNinos.Multiline = true;
            this.txtNinos.Name = "txtNinos";
            this.txtNinos.Size = new System.Drawing.Size(131, 39);
            this.txtNinos.TabIndex = 6;
            // 
            // lbDestinos
            // 
            this.lbDestinos.FormattingEnabled = true;
            this.lbDestinos.Items.AddRange(new object[] {
            "Aguascalientes",
            "Guadalarajara",
            "Mexico"});
            this.lbDestinos.Location = new System.Drawing.Point(313, 129);
            this.lbDestinos.Name = "lbDestinos";
            this.lbDestinos.Size = new System.Drawing.Size(188, 147);
            this.lbDestinos.TabIndex = 7;
            this.lbDestinos.SelectedIndexChanged += new System.EventHandler(this.lbDestinos_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(598, 90);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(99, 63);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular importe";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(598, 159);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 63);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(598, 228);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 63);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(601, 413);
            this.txtImporte.Multiline = true;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbDestinos);
            this.Controls.Add(this.txtNinos);
            this.Controls.Add(this.txtAdultos);
            this.Controls.Add(this.txtDestinos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDestinos;
        private System.Windows.Forms.TextBox txtAdultos;
        private System.Windows.Forms.TextBox txtNinos;
        private System.Windows.Forms.ListBox lbDestinos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImporte;
    }
}

