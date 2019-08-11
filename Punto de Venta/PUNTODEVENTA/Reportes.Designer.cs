namespace PUNTODEVENTA
{
    partial class Reportes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdVendedor = new System.Windows.Forms.RadioButton();
            this.rdProducto = new System.Windows.Forms.RadioButton();
            this.rdVenta = new System.Windows.Forms.RadioButton();
            this.rdFecha = new System.Windows.Forms.RadioButton();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarDato = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUsertype = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.pnlResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdVendedor);
            this.groupBox1.Controls.Add(this.rdProducto);
            this.groupBox1.Controls.Add(this.rdVenta);
            this.groupBox1.Controls.Add(this.rdFecha);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar reporte por:";
            // 
            // rdVendedor
            // 
            this.rdVendedor.AutoSize = true;
            this.rdVendedor.Location = new System.Drawing.Point(21, 163);
            this.rdVendedor.Name = "rdVendedor";
            this.rdVendedor.Size = new System.Drawing.Size(73, 20);
            this.rdVendedor.TabIndex = 3;
            this.rdVendedor.TabStop = true;
            this.rdVendedor.Text = "Vendedor";
            this.rdVendedor.UseVisualStyleBackColor = true;
            this.rdVendedor.CheckedChanged += new System.EventHandler(this.rdVendedor_CheckedChanged);
            // 
            // rdProducto
            // 
            this.rdProducto.AutoSize = true;
            this.rdProducto.Location = new System.Drawing.Point(21, 117);
            this.rdProducto.Name = "rdProducto";
            this.rdProducto.Size = new System.Drawing.Size(68, 20);
            this.rdProducto.TabIndex = 2;
            this.rdProducto.TabStop = true;
            this.rdProducto.Text = "Producto";
            this.rdProducto.UseVisualStyleBackColor = true;
            this.rdProducto.CheckedChanged += new System.EventHandler(this.rdProducto_CheckedChanged);
            // 
            // rdVenta
            // 
            this.rdVenta.AutoSize = true;
            this.rdVenta.Location = new System.Drawing.Point(21, 75);
            this.rdVenta.Name = "rdVenta";
            this.rdVenta.Size = new System.Drawing.Size(109, 20);
            this.rdVenta.TabIndex = 1;
            this.rdVenta.TabStop = true;
            this.rdVenta.Text = "Numero de Venta";
            this.rdVenta.UseVisualStyleBackColor = true;
            this.rdVenta.CheckedChanged += new System.EventHandler(this.rdVenta_CheckedChanged);
            // 
            // rdFecha
            // 
            this.rdFecha.AutoSize = true;
            this.rdFecha.Location = new System.Drawing.Point(21, 36);
            this.rdFecha.Name = "rdFecha";
            this.rdFecha.Size = new System.Drawing.Size(56, 20);
            this.rdFecha.TabIndex = 0;
            this.rdFecha.TabStop = true;
            this.rdFecha.Text = "Fecha";
            this.rdFecha.UseVisualStyleBackColor = true;
            this.rdFecha.CheckedChanged += new System.EventHandler(this.rdFecha_CheckedChanged);
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.label6);
            this.pnlFecha.Controls.Add(this.label5);
            this.pnlFecha.Controls.Add(this.label4);
            this.pnlFecha.Controls.Add(this.label3);
            this.pnlFecha.Controls.Add(this.label2);
            this.pnlFecha.Controls.Add(this.label1);
            this.pnlFecha.Controls.Add(this.txtAnio);
            this.pnlFecha.Controls.Add(this.txtMes);
            this.pnlFecha.Controls.Add(this.txtDia);
            this.pnlFecha.Location = new System.Drawing.Point(227, 102);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(376, 71);
            this.pnlFecha.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(192, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(267, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(302, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar la Fecha:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(285, 15);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(66, 20);
            this.txtAnio.TabIndex = 2;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(210, 15);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(46, 20);
            this.txtMes.TabIndex = 1;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(141, 15);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(45, 20);
            this.txtDia.TabIndex = 0;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.txtBuscar);
            this.pnlDatos.Controls.Add(this.lblBuscarDato);
            this.pnlDatos.Enabled = false;
            this.pnlDatos.Location = new System.Drawing.Point(191, 179);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(412, 57);
            this.pnlDatos.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(165, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(224, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblBuscarDato
            // 
            this.lblBuscarDato.AutoSize = true;
            this.lblBuscarDato.ForeColor = System.Drawing.Color.White;
            this.lblBuscarDato.Location = new System.Drawing.Point(3, 21);
            this.lblBuscarDato.Name = "lblBuscarDato";
            this.lblBuscarDato.Size = new System.Drawing.Size(0, 13);
            this.lblBuscarDato.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(447, 253);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 32);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblResultados.Location = new System.Drawing.Point(331, 263);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(98, 19);
            this.lblResultados.TabIndex = 5;
            this.lblResultados.Text = "Sin Resultados";
            this.lblResultados.Visible = false;
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.AllowUserToOrderColumns = true;
            this.dgvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(12, 396);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.Size = new System.Drawing.Size(598, 207);
            this.dgvReporte.TabIndex = 6;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(445, 609);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(133, 37);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pnlResultados
            // 
            this.pnlResultados.Controls.Add(this.lblTotal);
            this.pnlResultados.Controls.Add(this.lblNumeroVenta);
            this.pnlResultados.Controls.Add(this.lblFecha);
            this.pnlResultados.Controls.Add(this.lblVendedor);
            this.pnlResultados.Controls.Add(this.label11);
            this.pnlResultados.Controls.Add(this.label10);
            this.pnlResultados.Controls.Add(this.label9);
            this.pnlResultados.Controls.Add(this.label8);
            this.pnlResultados.ForeColor = System.Drawing.Color.White;
            this.pnlResultados.Location = new System.Drawing.Point(34, 308);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(546, 82);
            this.pnlResultados.TabIndex = 8;
            this.pnlResultados.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(455, 54);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Location = new System.Drawing.Point(455, 16);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroVenta.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(71, 54);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 5;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(71, 16);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(0, 13);
            this.lblVendedor.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Monto total de ventas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Numero de Venta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vendedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(133, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 40);
            this.label7.TabIndex = 9;
            this.label7.Text = "Reportes";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(447, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(22, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = ".....";
            this.lblUser.Visible = false;
            // 
            // lblUsertype
            // 
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.ForeColor = System.Drawing.Color.White;
            this.lblUsertype.Location = new System.Drawing.Point(447, 66);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(22, 13);
            this.lblUsertype.TabIndex = 11;
            this.lblUsertype.Text = ".....";
            this.lblUsertype.Visible = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(622, 658);
            this.Controls.Add(this.lblUsertype);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlResultados);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.pnlResultados.ResumeLayout(false);
            this.pnlResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdVendedor;
        private System.Windows.Forms.RadioButton rdProducto;
        private System.Windows.Forms.RadioButton rdVenta;
        private System.Windows.Forms.RadioButton rdFecha;
        private System.Windows.Forms.Panel pnlFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscarDato;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUsertype;
    }
}