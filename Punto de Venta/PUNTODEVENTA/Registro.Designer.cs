namespace PUNTODEVENTA
{
    partial class Registro
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
            this.txtRegistrarNombre = new System.Windows.Forms.TextBox();
            this.txtRegistrarContra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistrarContraConfi = new System.Windows.Forms.TextBox();
            this.txtRegistrarUsertype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUsertype = new System.Windows.Forms.Label();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.lblErrorContra = new System.Windows.Forms.Label();
            this.lblErrorConfir = new System.Windows.Forms.Label();
            this.lblErrorUsertype = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRegistrarNombre
            // 
            this.txtRegistrarNombre.Location = new System.Drawing.Point(174, 136);
            this.txtRegistrarNombre.Name = "txtRegistrarNombre";
            this.txtRegistrarNombre.Size = new System.Drawing.Size(121, 20);
            this.txtRegistrarNombre.TabIndex = 1;
            // 
            // txtRegistrarContra
            // 
            this.txtRegistrarContra.Location = new System.Drawing.Point(174, 171);
            this.txtRegistrarContra.Name = "txtRegistrarContra";
            this.txtRegistrarContra.Size = new System.Drawing.Size(121, 20);
            this.txtRegistrarContra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(174, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar contraseña:";
            // 
            // txtRegistrarContraConfi
            // 
            this.txtRegistrarContraConfi.Location = new System.Drawing.Point(174, 202);
            this.txtRegistrarContraConfi.Name = "txtRegistrarContraConfi";
            this.txtRegistrarContraConfi.Size = new System.Drawing.Size(121, 20);
            this.txtRegistrarContraConfi.TabIndex = 7;
            // 
            // txtRegistrarUsertype
            // 
            this.txtRegistrarUsertype.Location = new System.Drawing.Point(174, 240);
            this.txtRegistrarUsertype.Name = "txtRegistrarUsertype";
            this.txtRegistrarUsertype.Size = new System.Drawing.Size(121, 20);
            this.txtRegistrarUsertype.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Usuario.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "( administrador / empleado )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(90, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "Registrar Usuario";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 12;
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
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(9, 326);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(25, 13);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "......";
            this.lblUser.Visible = false;
            // 
            // lblUsertype
            // 
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.ForeColor = System.Drawing.Color.White;
            this.lblUsertype.Location = new System.Drawing.Point(12, 358);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(22, 13);
            this.lblUsertype.TabIndex = 14;
            this.lblUsertype.Text = ".....";
            this.lblUsertype.Visible = false;
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.AutoSize = true;
            this.lblErrorUsuario.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblErrorUsuario.Location = new System.Drawing.Point(314, 139);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(13, 20);
            this.lblErrorUsuario.TabIndex = 15;
            this.lblErrorUsuario.Text = "!";
            this.lblErrorUsuario.Visible = false;
            // 
            // lblErrorContra
            // 
            this.lblErrorContra.AutoSize = true;
            this.lblErrorContra.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblErrorContra.Location = new System.Drawing.Point(314, 171);
            this.lblErrorContra.Name = "lblErrorContra";
            this.lblErrorContra.Size = new System.Drawing.Size(13, 20);
            this.lblErrorContra.TabIndex = 16;
            this.lblErrorContra.Text = "!";
            this.lblErrorContra.Visible = false;
            // 
            // lblErrorConfir
            // 
            this.lblErrorConfir.AutoSize = true;
            this.lblErrorConfir.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorConfir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblErrorConfir.Location = new System.Drawing.Point(314, 202);
            this.lblErrorConfir.Name = "lblErrorConfir";
            this.lblErrorConfir.Size = new System.Drawing.Size(13, 20);
            this.lblErrorConfir.TabIndex = 17;
            this.lblErrorConfir.Text = "!";
            this.lblErrorConfir.Visible = false;
            // 
            // lblErrorUsertype
            // 
            this.lblErrorUsertype.AutoSize = true;
            this.lblErrorUsertype.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUsertype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblErrorUsertype.Location = new System.Drawing.Point(314, 240);
            this.lblErrorUsertype.Name = "lblErrorUsertype";
            this.lblErrorUsertype.Size = new System.Drawing.Size(13, 20);
            this.lblErrorUsertype.TabIndex = 18;
            this.lblErrorUsertype.Text = "!";
            this.lblErrorUsertype.Visible = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(411, 380);
            this.Controls.Add(this.lblErrorUsertype);
            this.Controls.Add(this.lblErrorConfir);
            this.Controls.Add(this.lblErrorContra);
            this.Controls.Add(this.lblErrorUsuario);
            this.Controls.Add(this.lblUsertype);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegistrarUsertype);
            this.Controls.Add(this.txtRegistrarContraConfi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistrarContra);
            this.Controls.Add(this.txtRegistrarNombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Registro";
            this.Text = "Registro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRegistrarNombre;
        private System.Windows.Forms.TextBox txtRegistrarContra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegistrarContraConfi;
        private System.Windows.Forms.TextBox txtRegistrarUsertype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUsertype;
        private System.Windows.Forms.Label lblErrorUsuario;
        private System.Windows.Forms.Label lblErrorContra;
        private System.Windows.Forms.Label lblErrorConfir;
        private System.Windows.Forms.Label lblErrorUsertype;
    }
}