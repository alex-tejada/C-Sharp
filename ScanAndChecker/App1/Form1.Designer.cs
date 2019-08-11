namespace App1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credencialesDeBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_messageMaestro = new System.Windows.Forms.Label();
            this.button_setMaster = new System.Windows.Forms.Button();
            this.label_fecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_buscado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_borrar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_earnHours = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button_earnExcelFile = new System.Windows.Forms.Button();
            this.panel_addEmploye = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button_deleteEmployee = new System.Windows.Forms.Button();
            this.textBox_busqueda = new System.Windows.Forms.TextBox();
            this.button_addEmployee = new System.Windows.Forms.Button();
            this.comboBox_cuantifyEmployes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_addEmploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.cONFIGURACIONToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cONFIGURACIONToolStripMenuItem
            // 
            this.cONFIGURACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.credencialesDeBDToolStripMenuItem});
            this.cONFIGURACIONToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cONFIGURACIONToolStripMenuItem.Name = "cONFIGURACIONToolStripMenuItem";
            this.cONFIGURACIONToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.cONFIGURACIONToolStripMenuItem.Text = "Configuración";
            // 
            // credencialesDeBDToolStripMenuItem
            // 
            this.credencialesDeBDToolStripMenuItem.Name = "credencialesDeBDToolStripMenuItem";
            this.credencialesDeBDToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.credencialesDeBDToolStripMenuItem.Text = "Credenciales de BD";
            this.credencialesDeBDToolStripMenuItem.Click += new System.EventHandler(this.credencialesDeBDToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 574);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 571);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entradas y Salidas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label_messageMaestro);
            this.panel1.Controls.Add(this.button_setMaster);
            this.panel1.Controls.Add(this.label_fecha);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 539);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(551, 11);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 491);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(243, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label_messageMaestro
            // 
            this.label_messageMaestro.AutoSize = true;
            this.label_messageMaestro.ForeColor = System.Drawing.Color.White;
            this.label_messageMaestro.Location = new System.Drawing.Point(22, 74);
            this.label_messageMaestro.Name = "label_messageMaestro";
            this.label_messageMaestro.Size = new System.Drawing.Size(0, 13);
            this.label_messageMaestro.TabIndex = 16;
            // 
            // button_setMaster
            // 
            this.button_setMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_setMaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_setMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_setMaster.ForeColor = System.Drawing.Color.White;
            this.button_setMaster.Location = new System.Drawing.Point(7, 11);
            this.button_setMaster.Name = "button_setMaster";
            this.button_setMaster.Size = new System.Drawing.Size(86, 49);
            this.button_setMaster.TabIndex = 11;
            this.button_setMaster.Text = "Asignar Maestro";
            this.button_setMaster.UseVisualStyleBackColor = false;
            this.button_setMaster.Click += new System.EventHandler(this.button_setMaster_ClickAsync);
            // 
            // label_fecha
            // 
            this.label_fecha.Location = new System.Drawing.Point(257, 100);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(106, 16);
            this.label_fecha.TabIndex = 15;
            this.label_fecha.Text = "Fecha: 00/00/0000";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_buscado);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_hora);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(86, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 333);
            this.panel2.TabIndex = 14;
            // 
            // label_buscado
            // 
            this.label_buscado.AutoSize = true;
            this.label_buscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscado.ForeColor = System.Drawing.Color.White;
            this.label_buscado.Location = new System.Drawing.Point(137, 263);
            this.label_buscado.Name = "label_buscado";
            this.label_buscado.Size = new System.Drawing.Size(76, 16);
            this.label_buscado.TabIndex = 2;
            this.label_buscado.Text = "Búsqueda: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(173, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_hora
            // 
            this.label_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label_hora.Location = new System.Drawing.Point(62, 15);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(299, 50);
            this.label_hora.TabIndex = 0;
            this.label_hora.Text = "00:00";
            this.label_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Gafete:";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(243, 125);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(205, 26);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.button_borrar);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.button_earnHours);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button_earnExcelFile);
            this.tabPage2.Controls.Add(this.panel_addEmploye);
            this.tabPage2.Controls.Add(this.comboBox_cuantifyEmployes);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dateTimePicker_endDate);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dateTimePicker_startDate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recabado de horas";
            // 
            // button_borrar
            // 
            this.button_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar.Location = new System.Drawing.Point(579, 339);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(75, 37);
            this.button_borrar.TabIndex = 17;
            this.button_borrar.Text = "Limpiar";
            this.button_borrar.UseVisualStyleBackColor = false;
            this.button_borrar.Click += new System.EventHandler(this.button_borrar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(19, 382);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(752, 157);
            this.panel4.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(746, 148);
            this.dataGridView1.TabIndex = 6;
            // 
            // button_earnHours
            // 
            this.button_earnHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_earnHours.Enabled = false;
            this.button_earnHours.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_earnHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_earnHours.Location = new System.Drawing.Point(287, 44);
            this.button_earnHours.Name = "button_earnHours";
            this.button_earnHours.Size = new System.Drawing.Size(113, 31);
            this.button_earnHours.TabIndex = 13;
            this.button_earnHours.Text = "Generar Registro";
            this.button_earnHours.UseVisualStyleBackColor = false;
            this.button_earnHours.Click += new System.EventHandler(this.button_earnHours_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Vista previa:";
            // 
            // button_earnExcelFile
            // 
            this.button_earnExcelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_earnExcelFile.Enabled = false;
            this.button_earnExcelFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_earnExcelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_earnExcelFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_earnExcelFile.Location = new System.Drawing.Point(669, 339);
            this.button_earnExcelFile.Name = "button_earnExcelFile";
            this.button_earnExcelFile.Size = new System.Drawing.Size(77, 37);
            this.button_earnExcelFile.TabIndex = 9;
            this.button_earnExcelFile.Text = "Excel";
            this.button_earnExcelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_earnExcelFile.UseVisualStyleBackColor = false;
            this.button_earnExcelFile.Click += new System.EventHandler(this.button_earnExcelFile_Click);
            // 
            // panel_addEmploye
            // 
            this.panel_addEmploye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_addEmploye.Controls.Add(this.dataGridView2);
            this.panel_addEmploye.Controls.Add(this.label2);
            this.panel_addEmploye.Controls.Add(this.button_deleteEmployee);
            this.panel_addEmploye.Controls.Add(this.textBox_busqueda);
            this.panel_addEmploye.Controls.Add(this.button_addEmployee);
            this.panel_addEmploye.ForeColor = System.Drawing.Color.Black;
            this.panel_addEmploye.Location = new System.Drawing.Point(22, 78);
            this.panel_addEmploye.Name = "panel_addEmploye";
            this.panel_addEmploye.Size = new System.Drawing.Size(749, 256);
            this.panel_addEmploye.TabIndex = 7;
            this.panel_addEmploye.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView2.Location = new System.Drawing.Point(10, 40);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(724, 174);
            this.dataGridView2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buscar por nombre:";
            // 
            // button_deleteEmployee
            // 
            this.button_deleteEmployee.BackColor = System.Drawing.Color.Maroon;
            this.button_deleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deleteEmployee.ForeColor = System.Drawing.Color.White;
            this.button_deleteEmployee.Location = new System.Drawing.Point(10, 220);
            this.button_deleteEmployee.Name = "button_deleteEmployee";
            this.button_deleteEmployee.Size = new System.Drawing.Size(75, 31);
            this.button_deleteEmployee.TabIndex = 7;
            this.button_deleteEmployee.Text = "Remover";
            this.button_deleteEmployee.UseVisualStyleBackColor = false;
            this.button_deleteEmployee.Click += new System.EventHandler(this.button_deleteEmployee_Click);
            // 
            // textBox_busqueda
            // 
            this.textBox_busqueda.BackColor = System.Drawing.Color.Silver;
            this.textBox_busqueda.ForeColor = System.Drawing.Color.Black;
            this.textBox_busqueda.Location = new System.Drawing.Point(112, 9);
            this.textBox_busqueda.Name = "textBox_busqueda";
            this.textBox_busqueda.Size = new System.Drawing.Size(265, 20);
            this.textBox_busqueda.TabIndex = 9;
            this.textBox_busqueda.TextChanged += new System.EventHandler(this.textBox_busqueda_TextChanged);
            this.textBox_busqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_busqueda_KeyUp);
            // 
            // button_addEmployee
            // 
            this.button_addEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addEmployee.ForeColor = System.Drawing.Color.White;
            this.button_addEmployee.Location = new System.Drawing.Point(91, 220);
            this.button_addEmployee.Name = "button_addEmployee";
            this.button_addEmployee.Size = new System.Drawing.Size(75, 31);
            this.button_addEmployee.TabIndex = 4;
            this.button_addEmployee.Text = "Agregar";
            this.button_addEmployee.UseVisualStyleBackColor = false;
            this.button_addEmployee.Click += new System.EventHandler(this.button_addEmployee_Click);
            // 
            // comboBox_cuantifyEmployes
            // 
            this.comboBox_cuantifyEmployes.FormattingEnabled = true;
            this.comboBox_cuantifyEmployes.Items.AddRange(new object[] {
            "Todos",
            "Específico"});
            this.comboBox_cuantifyEmployes.Location = new System.Drawing.Point(133, 51);
            this.comboBox_cuantifyEmployes.Name = "comboBox_cuantifyEmployes";
            this.comboBox_cuantifyEmployes.Size = new System.Drawing.Size(139, 21);
            this.comboBox_cuantifyEmployes.TabIndex = 5;
            this.comboBox_cuantifyEmployes.SelectedIndexChanged += new System.EventHandler(this.comboBox_cuantifyEmployes_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Empleado(s):";
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(427, 15);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_endDate.TabIndex = 3;
            this.dateTimePicker_endDate.Value = new System.DateTime(2017, 10, 4, 0, 0, 0, 0);
            this.dateTimePicker_endDate.ValueChanged += new System.EventHandler(this.dateTimePicker_endDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha final:";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(133, 15);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_startDate.TabIndex = 1;
            this.dateTimePicker_startDate.Value = new System.DateTime(2017, 10, 4, 22, 40, 56, 0);
            this.dateTimePicker_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha inicial:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(814, 591);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(150, 150);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(830, 630);
            this.MinimumSize = new System.Drawing.Size(830, 630);
            this.Name = "Form1";
            this.Text = "Scan & Checker - Delphi DCS I";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_addEmploye.ResumeLayout(false);
            this.panel_addEmploye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credencialesDeBDToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_messageMaestro;
        private System.Windows.Forms.Button button_setMaster;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_buscado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_earnExcelFile;
        private System.Windows.Forms.Panel panel_addEmploye;
        private System.Windows.Forms.Button button_deleteEmployee;
        private System.Windows.Forms.Button button_addEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_cuantifyEmployes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_earnHours;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_busqueda;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

