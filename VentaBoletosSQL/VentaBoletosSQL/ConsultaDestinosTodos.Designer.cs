namespace VentaBoletosSQL
{
    partial class ConsultaDestinosTodos
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
            this.dtaGridDestinos = new System.Windows.Forms.DataGridView();
            this.ClaveDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDestinos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridDestinos
            // 
            this.dtaGridDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridDestinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveDest,
            this.NombreDest,
            this.Costo,
            this.Duracion,
            this.Habilitado});
            this.dtaGridDestinos.Location = new System.Drawing.Point(28, 14);
            this.dtaGridDestinos.Name = "dtaGridDestinos";
            this.dtaGridDestinos.Size = new System.Drawing.Size(544, 262);
            this.dtaGridDestinos.TabIndex = 1;
            // 
            // ClaveDest
            // 
            this.ClaveDest.HeaderText = "Clave Destino";
            this.ClaveDest.Name = "ClaveDest";
            // 
            // NombreDest
            // 
            this.NombreDest.HeaderText = "Nombre Destino";
            this.NombreDest.Name = "NombreDest";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            // 
            // Habilitado
            // 
            this.Habilitado.HeaderText = "Habilitado";
            this.Habilitado.Name = "Habilitado";
            // 
            // ConsultaDestinosTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 290);
            this.Controls.Add(this.dtaGridDestinos);
            this.Name = "ConsultaDestinosTodos";
            this.Text = "Consulta General de Destinos";
            this.Load += new System.EventHandler(this.ConsultaDestinosTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDestinos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridDestinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilitado;
    }
}