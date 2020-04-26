namespace ProyectoVentaBoletos
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStpDestinos = new System.Windows.Forms.ToolStripMenuItem();
            this.registraDestinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderBoletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarBoletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStpDestinos,
            this.boletosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuStpDestinos
            // 
            this.mnuStpDestinos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registraDestinosToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.mnuStpDestinos.Name = "mnuStpDestinos";
            this.mnuStpDestinos.Size = new System.Drawing.Size(64, 20);
            this.mnuStpDestinos.Text = "Destinos";
            // 
            // registraDestinosToolStripMenuItem
            // 
            this.registraDestinosToolStripMenuItem.Name = "registraDestinosToolStripMenuItem";
            this.registraDestinosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registraDestinosToolStripMenuItem.Text = "Agregar";
            this.registraDestinosToolStripMenuItem.Click += new System.EventHandler(this.registraDestinosToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // boletosToolStripMenuItem
            // 
            this.boletosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderBoletoToolStripMenuItem,
            this.consultarBoletosToolStripMenuItem});
            this.boletosToolStripMenuItem.Name = "boletosToolStripMenuItem";
            this.boletosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.boletosToolStripMenuItem.Text = "Boletos";
            // 
            // venderBoletoToolStripMenuItem
            // 
            this.venderBoletoToolStripMenuItem.Name = "venderBoletoToolStripMenuItem";
            this.venderBoletoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.venderBoletoToolStripMenuItem.Text = "Vender Boleto";
            this.venderBoletoToolStripMenuItem.Click += new System.EventHandler(this.venderBoletoToolStripMenuItem_Click);
            // 
            // consultarBoletosToolStripMenuItem
            // 
            this.consultarBoletosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem1});
            this.consultarBoletosToolStripMenuItem.Name = "consultarBoletosToolStripMenuItem";
            this.consultarBoletosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarBoletosToolStripMenuItem.Text = "Consultar Boletos";
            // 
            // individualToolStripMenuItem1
            // 
            this.individualToolStripMenuItem1.Name = "individualToolStripMenuItem1";
            this.individualToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.individualToolStripMenuItem1.Text = "Por Destino";
            this.individualToolStripMenuItem1.Click += new System.EventHandler(this.individualToolStripMenuItem1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 321);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "TravelMX";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStpDestinos;
        private System.Windows.Forms.ToolStripMenuItem registraDestinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderBoletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarBoletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem1;
    }
}