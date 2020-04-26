namespace VentaBoletosSQL
{
    partial class ConsultaDestinosInd
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
            this.lblDestinos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDestinos
            // 
            this.lblDestinos.AutoSize = true;
            this.lblDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinos.Location = new System.Drawing.Point(67, 67);
            this.lblDestinos.Name = "lblDestinos";
            this.lblDestinos.Size = new System.Drawing.Size(67, 17);
            this.lblDestinos.TabIndex = 0;
            this.lblDestinos.Text = "Destinos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(67, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(67, 214);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(69, 17);
            this.lblDuracion.TabIndex = 2;
            this.lblDuracion.Text = "Duración:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(67, 171);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(48, 17);
            this.lblCosto.TabIndex = 3;
            this.lblCosto.Text = "Costo:";
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(179, 64);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(121, 21);
            this.cmbDestinos.TabIndex = 4;
            this.cmbDestinos.SelectedIndexChanged += new System.EventHandler(this.cmbDestinos_SelectedIndexChanged);
            // 
            // txtDuracion
            // 
            this.txtDuracion.Enabled = false;
            this.txtDuracion.Location = new System.Drawing.Point(179, 213);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(121, 20);
            this.txtDuracion.TabIndex = 6;
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(179, 164);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(121, 20);
            this.txtCosto.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(179, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Enabled = false;
            this.chkHabilitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHabilitado.Location = new System.Drawing.Point(142, 267);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(70, 17);
            this.chkHabilitado.TabIndex = 9;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // ConsultaDestinosInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 321);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.cmbDestinos);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDestinos);
            this.Name = "ConsultaDestinosInd";
            this.Text = "Consulta de Destinos Individuales";
            this.Load += new System.EventHandler(this.ConsultaDestinos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestinos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkHabilitado;
    }
}

