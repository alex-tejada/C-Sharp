namespace PUNTODEVENTA
{
    partial class Inventario
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
            this.button2 = new System.Windows.Forms.Button();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAgregarCantidad = new System.Windows.Forms.TextBox();
            this.txtAgregarPrecio = new System.Windows.Forms.TextBox();
            this.txtAgregarProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgInventario = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUsertype = new System.Windows.Forms.Label();
            this.pnlAgregar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(76, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.label4);
            this.pnlAgregar.Controls.Add(this.txtAgregarCantidad);
            this.pnlAgregar.Controls.Add(this.txtAgregarPrecio);
            this.pnlAgregar.Controls.Add(this.txtAgregarProducto);
            this.pnlAgregar.Controls.Add(this.label3);
            this.pnlAgregar.Controls.Add(this.label2);
            this.pnlAgregar.Controls.Add(this.label1);
            this.pnlAgregar.Controls.Add(this.button2);
            this.pnlAgregar.Location = new System.Drawing.Point(468, 199);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(229, 273);
            this.pnlAgregar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nuevo Producto";
            // 
            // txtAgregarCantidad
            // 
            this.txtAgregarCantidad.Location = new System.Drawing.Point(78, 169);
            this.txtAgregarCantidad.Name = "txtAgregarCantidad";
            this.txtAgregarCantidad.Size = new System.Drawing.Size(143, 20);
            this.txtAgregarCantidad.TabIndex = 8;
            // 
            // txtAgregarPrecio
            // 
            this.txtAgregarPrecio.Location = new System.Drawing.Point(78, 126);
            this.txtAgregarPrecio.Name = "txtAgregarPrecio";
            this.txtAgregarPrecio.Size = new System.Drawing.Size(143, 20);
            this.txtAgregarPrecio.TabIndex = 7;
            // 
            // txtAgregarProducto
            // 
            this.txtAgregarProducto.Location = new System.Drawing.Point(78, 77);
            this.txtAgregarProducto.Name = "txtAgregarProducto";
            this.txtAgregarProducto.Size = new System.Drawing.Size(143, 20);
            this.txtAgregarProducto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(479, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Refrescar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(293, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 42);
            this.label7.TabIndex = 10;
            this.label7.Text = "Inventario";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 11;
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
            // dtgInventario
            // 
            this.dtgInventario.AllowUserToAddRows = false;
            this.dtgInventario.AllowUserToDeleteRows = false;
            this.dtgInventario.AllowUserToOrderColumns = true;
            this.dtgInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgInventario.Location = new System.Drawing.Point(12, 156);
            this.dtgInventario.MultiSelect = false;
            this.dtgInventario.Name = "dtgInventario";
            this.dtgInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInventario.Size = new System.Drawing.Size(447, 353);
            this.dtgInventario.TabIndex = 12;
            this.dtgInventario.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInventario_CellValueChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(567, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(22, 13);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = ".....";
            this.lblUser.Visible = false;
            // 
            // lblUsertype
            // 
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.ForeColor = System.Drawing.Color.White;
            this.lblUsertype.Location = new System.Drawing.Point(570, 55);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(25, 13);
            this.lblUsertype.TabIndex = 14;
            this.lblUsertype.Text = "......";
            this.lblUsertype.Visible = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(709, 521);
            this.Controls.Add(this.lblUsertype);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dtgInventario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pnlAgregar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgregarCantidad;
        private System.Windows.Forms.TextBox txtAgregarPrecio;
        private System.Windows.Forms.TextBox txtAgregarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgInventario;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUsertype;
    }
}