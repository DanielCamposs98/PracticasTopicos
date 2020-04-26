namespace NominaCSharp
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnMenuConsultas = new System.Windows.Forms.Button();
            this.btnMenuReportes = new System.Windows.Forms.Button();
            this.btnMenuNomina = new System.Windows.Forms.Button();
            this.btnMenuRegistro = new System.Windows.Forms.Button();
            this.panelBarraTituloForm = new System.Windows.Forms.Panel();
           lblMenuTitulo = new System.Windows.Forms.Label();
            this.panelFormulario = new System.Windows.Forms.Panel();
            panelFormularios = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelBarraTituloForm.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.lblTitulo);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1100, 40);
            this.panelBarraTitulo.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1072, 13);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::NominaCSharp.Properties.Resources.minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(1050, 13);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(19, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(102, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nomina App v.2.0";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.btnAcercaDe);
            this.panelMenu.Controls.Add(this.btnMenuConsultas);
            this.panelMenu.Controls.Add(this.btnMenuReportes);
            this.panelMenu.Controls.Add(this.btnMenuNomina);
            this.panelMenu.Controls.Add(this.btnMenuRegistro);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 560);
            this.panelMenu.TabIndex = 1;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAcercaDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAcercaDe.Image = global::NominaCSharp.Properties.Resources.info;
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 519);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnAcercaDe.Size = new System.Drawing.Size(200, 40);
            this.btnAcercaDe.TabIndex = 4;
            this.btnAcercaDe.Text = "Acerca De";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnMenuConsultas
            // 
            this.btnMenuConsultas.FlatAppearance.BorderSize = 0;
            this.btnMenuConsultas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMenuConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMenuConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMenuConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuConsultas.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuConsultas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuConsultas.Image = global::NominaCSharp.Properties.Resources.emb;
            this.btnMenuConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuConsultas.Location = new System.Drawing.Point(0, 188);
            this.btnMenuConsultas.Name = "btnMenuConsultas";
            this.btnMenuConsultas.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnMenuConsultas.Size = new System.Drawing.Size(200, 40);
            this.btnMenuConsultas.TabIndex = 3;
            this.btnMenuConsultas.Text = "Consultas";
            this.btnMenuConsultas.UseVisualStyleBackColor = true;
            this.btnMenuConsultas.Click += new System.EventHandler(this.btnMenuConsultas_Click);
            // 
            // btnMenuReportes
            // 
            this.btnMenuReportes.FlatAppearance.BorderSize = 0;
            this.btnMenuReportes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMenuReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMenuReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMenuReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReportes.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReportes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuReportes.Image = global::NominaCSharp.Properties.Resources.form;
            this.btnMenuReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReportes.Location = new System.Drawing.Point(0, 142);
            this.btnMenuReportes.Name = "btnMenuReportes";
            this.btnMenuReportes.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnMenuReportes.Size = new System.Drawing.Size(200, 40);
            this.btnMenuReportes.TabIndex = 2;
            this.btnMenuReportes.Text = "Reportes";
            this.btnMenuReportes.UseVisualStyleBackColor = true;
            this.btnMenuReportes.Click += new System.EventHandler(this.btnMenuReportes_Click);
            // 
            // btnMenuNomina
            // 
            this.btnMenuNomina.FlatAppearance.BorderSize = 0;
            this.btnMenuNomina.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMenuNomina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMenuNomina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMenuNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuNomina.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuNomina.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuNomina.Image = global::NominaCSharp.Properties.Resources.pay;
            this.btnMenuNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuNomina.Location = new System.Drawing.Point(0, 96);
            this.btnMenuNomina.Name = "btnMenuNomina";
            this.btnMenuNomina.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnMenuNomina.Size = new System.Drawing.Size(200, 40);
            this.btnMenuNomina.TabIndex = 1;
            this.btnMenuNomina.Text = "Nómina";
            this.btnMenuNomina.UseVisualStyleBackColor = true;
            this.btnMenuNomina.Click += new System.EventHandler(this.btnMenuNomina_Click);
            // 
            // btnMenuRegistro
            // 
            this.btnMenuRegistro.FlatAppearance.BorderSize = 0;
            this.btnMenuRegistro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMenuRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMenuRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMenuRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRegistro.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRegistro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuRegistro.Image = global::NominaCSharp.Properties.Resources.Add;
            this.btnMenuRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRegistro.Location = new System.Drawing.Point(0, 50);
            this.btnMenuRegistro.Name = "btnMenuRegistro";
            this.btnMenuRegistro.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnMenuRegistro.Size = new System.Drawing.Size(200, 40);
            this.btnMenuRegistro.TabIndex = 0;
            this.btnMenuRegistro.Text = "Registros";
            this.btnMenuRegistro.UseVisualStyleBackColor = true;
            this.btnMenuRegistro.Click += new System.EventHandler(this.btnMenuRegistro_Click);
            // 
            // panelBarraTituloForm
            // 
            this.panelBarraTituloForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(131)))));
            this.panelBarraTituloForm.Controls.Add(lblMenuTitulo);
            this.panelBarraTituloForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTituloForm.Location = new System.Drawing.Point(200, 40);
            this.panelBarraTituloForm.Name = "panelBarraTituloForm";
            this.panelBarraTituloForm.Size = new System.Drawing.Size(900, 50);
            this.panelBarraTituloForm.TabIndex = 2;
            // 
            // lblMenuTitulo
            // 
           lblMenuTitulo.AutoSize = true;
           lblMenuTitulo.BackColor = System.Drawing.Color.Transparent;
           lblMenuTitulo.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           lblMenuTitulo.ForeColor = System.Drawing.SystemColors.Control;
           lblMenuTitulo.Location = new System.Drawing.Point(20, 13);
           lblMenuTitulo.Name = "lblMenuTitulo";
           lblMenuTitulo.Size = new System.Drawing.Size(52, 25);
           lblMenuTitulo.TabIndex = 1;
           lblMenuTitulo.Text = "Inicio";
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(panelFormularios);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(200, 90);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(900, 510);
            this.panelFormulario.TabIndex = 3;
            // 
            // panelFormularios
            // 
            panelFormularios.Controls.Add(this.pictureBox1);
            panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            panelFormularios.Location = new System.Drawing.Point(0, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new System.Drawing.Size(900, 510);
            panelFormularios.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelBarraTituloForm);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina App v.2.0";
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelBarraTituloForm.ResumeLayout(false);
            this.panelBarraTituloForm.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTituloForm;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMenuConsultas;
        private System.Windows.Forms.Button btnMenuReportes;
        private System.Windows.Forms.Button btnMenuNomina;
        private System.Windows.Forms.Button btnMenuRegistro;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        public static System.Windows.Forms.Label lblMenuTitulo;
        public static System.Windows.Forms.Panel panelFormularios;
    }
}

