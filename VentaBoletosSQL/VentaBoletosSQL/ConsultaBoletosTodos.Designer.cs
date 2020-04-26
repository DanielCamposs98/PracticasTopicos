namespace VentaBoletosSQL
{
    partial class ConsultaBoletosTodos
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
            this.dtaGridBoletos = new System.Windows.Forms.DataGridView();
            this.NumBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoBoleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridBoletos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridBoletos
            // 
            this.dtaGridBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridBoletos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumBoleto,
            this.ClaveDest,
            this.NombrePasajero,
            this.Asiento,
            this.TipoBoleto,
            this.Costo});
            this.dtaGridBoletos.Location = new System.Drawing.Point(8, 14);
            this.dtaGridBoletos.Name = "dtaGridBoletos";
            this.dtaGridBoletos.Size = new System.Drawing.Size(787, 294);
            this.dtaGridBoletos.TabIndex = 0;
            // 
            // NumBoleto
            // 
            this.NumBoleto.HeaderText = "N° Boleto";
            this.NumBoleto.Name = "NumBoleto";
            this.NumBoleto.Width = 120;
            // 
            // ClaveDest
            // 
            this.ClaveDest.HeaderText = "Clave Destino";
            this.ClaveDest.Name = "ClaveDest";
            // 
            // NombrePasajero
            // 
            this.NombrePasajero.HeaderText = "Nombre Pasajero";
            this.NombrePasajero.Name = "NombrePasajero";
            this.NombrePasajero.Width = 150;
            // 
            // Asiento
            // 
            this.Asiento.HeaderText = "Asiento";
            this.Asiento.Name = "Asiento";
            this.Asiento.Width = 120;
            // 
            // TipoBoleto
            // 
            this.TipoBoleto.HeaderText = "Tipo de Boleto";
            this.TipoBoleto.Name = "TipoBoleto";
            this.TipoBoleto.Width = 150;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // ConsultaBoletosTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 323);
            this.Controls.Add(this.dtaGridBoletos);
            this.Name = "ConsultaBoletosTodos";
            this.Text = "Consulta General de Boletos";
            this.Load += new System.EventHandler(this.ConsultaBoletosTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridBoletos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridBoletos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}