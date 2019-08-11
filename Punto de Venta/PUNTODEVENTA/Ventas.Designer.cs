namespace PUNTODEVENTA
{
    partial class Ventas
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgVenta = new System.Windows.Forms.DataGridView();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtCantidadProductos = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.txtNumVenta = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUsertype = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(357, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 31);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Venta";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:  $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(337, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(444, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha:";
            // 
            // dtgVenta
            // 
            this.dtgVenta.AllowUserToDeleteRows = false;
            this.dtgVenta.AllowUserToOrderColumns = true;
            this.dtgVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProducto,
            this.Column1,
            this.clmPrecio,
            this.Column2});
            this.dtgVenta.Location = new System.Drawing.Point(32, 279);
            this.dtgVenta.Name = "dtgVenta";
            this.dtgVenta.ReadOnly = true;
            this.dtgVenta.Size = new System.Drawing.Size(564, 242);
            this.dtgVenta.TabIndex = 6;
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio Unitario";
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Subtotal";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(131, 154);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(137, 24);
            this.cmbProducto.TabIndex = 7;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.ForeColor = System.Drawing.Color.White;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(128, 191);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(39, 16);
            this.lblPrecioUnitario.TabIndex = 8;
            this.lblPrecioUnitario.Text = "00.00";
            // 
            // txtCantidadProductos
            // 
            this.txtCantidadProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProductos.Location = new System.Drawing.Point(131, 222);
            this.txtCantidadProductos.Name = "txtCantidadProductos";
            this.txtCantidadProductos.Size = new System.Drawing.Size(60, 22);
            this.txtCantidadProductos.TabIndex = 9;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.White;
            this.lblVendedor.Location = new System.Drawing.Point(423, 191);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(0, 16);
            this.lblVendedor.TabIndex = 10;
            // 
            // btnEntregar
            // 
            this.btnEntregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregar.ForeColor = System.Drawing.Color.White;
            this.btnEntregar.Location = new System.Drawing.Point(351, 580);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(121, 34);
            this.btnEntregar.TabIndex = 11;
            this.btnEntregar.Text = "Entregar Venta";
            this.btnEntregar.UseVisualStyleBackColor = false;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(167, 580);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar Venta";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.Color.White;
            this.lblFechaActual.Location = new System.Drawing.Point(497, 42);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(19, 15);
            this.lblFechaActual.TabIndex = 13;
            this.lblFechaActual.Text = "fff";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(448, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total:   $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(517, 541);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "00.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(291, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = " Numero de Venta:      #";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Location = new System.Drawing.Point(191, 42);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroVenta.TabIndex = 17;
            // 
            // txtNumVenta
            // 
            this.txtNumVenta.AutoSize = true;
            this.txtNumVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumVenta.ForeColor = System.Drawing.Color.White;
            this.txtNumVenta.Location = new System.Drawing.Point(436, 154);
            this.txtNumVenta.Name = "txtNumVenta";
            this.txtNumVenta.Size = new System.Drawing.Size(15, 16);
            this.txtNumVenta.TabIndex = 18;
            this.txtNumVenta.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(75, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 42);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ventas";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(29, 552);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(19, 13);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "....";
            this.lblUser.Visible = false;
            // 
            // lblUsertype
            // 
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.ForeColor = System.Drawing.Color.White;
            this.lblUsertype.Location = new System.Drawing.Point(32, 569);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(19, 13);
            this.lblUsertype.TabIndex = 22;
            this.lblUsertype.Text = "....";
            this.lblUsertype.Visible = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(623, 626);
            this.Controls.Add(this.lblUsertype);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumVenta);
            this.Controls.Add(this.lblNumeroVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtCantidadProductos);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.dtgVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgVenta;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtCantidadProductos;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Label txtNumVenta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUsertype;
    }
}