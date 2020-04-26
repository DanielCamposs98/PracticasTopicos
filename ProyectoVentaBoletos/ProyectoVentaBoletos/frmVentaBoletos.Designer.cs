namespace ProyectoVentaBoletos
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
            this.grpDestino = new System.Windows.Forms.GroupBox();
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblClaveDest = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.grpTipoBoleto = new System.Windows.Forms.GroupBox();
            this.rdEstudiante = new System.Windows.Forms.RadioButton();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.lblNumBoleto = new System.Windows.Forms.Label();
            this.lblNomPasajero = new System.Windows.Forms.Label();
            this.lblAsiento = new System.Windows.Forms.Label();
            this.txtNumBoleto = new System.Windows.Forms.TextBox();
            this.txtNomPasajero = new System.Windows.Forms.TextBox();
            this.numUpAsiento = new System.Windows.Forms.NumericUpDown();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.admDestinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpDestino.SuspendLayout();
            this.grpTipoBoleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpAsiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admDestinosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDestino
            // 
            this.grpDestino.Controls.Add(this.cmbDestinos);
            this.grpDestino.Controls.Add(this.txtDuracion);
            this.grpDestino.Controls.Add(this.txtCosto);
            this.grpDestino.Controls.Add(this.lblClaveDest);
            this.grpDestino.Controls.Add(this.lblDuracion);
            this.grpDestino.Controls.Add(this.lblCosto);
            this.grpDestino.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDestino.Location = new System.Drawing.Point(33, 70);
            this.grpDestino.Name = "grpDestino";
            this.grpDestino.Size = new System.Drawing.Size(386, 127);
            this.grpDestino.TabIndex = 0;
            this.grpDestino.TabStop = false;
            this.grpDestino.Text = "Destino";
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(21, 33);
            this.cmbDestinos.MaxDropDownItems = 10;
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(179, 23);
            this.cmbDestinos.TabIndex = 11;
            this.cmbDestinos.SelectedIndexChanged += new System.EventHandler(this.cmbDestinos_SelectedIndexChanged);
            // 
            // txtDuracion
            // 
            this.txtDuracion.Enabled = false;
            this.txtDuracion.Location = new System.Drawing.Point(271, 89);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 24);
            this.txtDuracion.TabIndex = 10;
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(78, 89);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 24);
            this.txtCosto.TabIndex = 9;
            // 
            // lblClaveDest
            // 
            this.lblClaveDest.AutoSize = true;
            this.lblClaveDest.Location = new System.Drawing.Point(268, 36);
            this.lblClaveDest.Name = "lblClaveDest";
            this.lblClaveDest.Size = new System.Drawing.Size(57, 17);
            this.lblClaveDest.TabIndex = 5;
            this.lblClaveDest.Text = "#######";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(208, 92);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(66, 17);
            this.lblDuracion.TabIndex = 4;
            this.lblDuracion.Text = "Duración :";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(18, 92);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(47, 17);
            this.lblCosto.TabIndex = 3;
            this.lblCosto.Text = "Costo :";
            // 
            // grpTipoBoleto
            // 
            this.grpTipoBoleto.Controls.Add(this.rdEstudiante);
            this.grpTipoBoleto.Controls.Add(this.rdNormal);
            this.grpTipoBoleto.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoBoleto.Location = new System.Drawing.Point(54, 289);
            this.grpTipoBoleto.Name = "grpTipoBoleto";
            this.grpTipoBoleto.Size = new System.Drawing.Size(350, 68);
            this.grpTipoBoleto.TabIndex = 1;
            this.grpTipoBoleto.TabStop = false;
            this.grpTipoBoleto.Text = "Tipo de Boleto";
            // 
            // rdEstudiante
            // 
            this.rdEstudiante.AutoSize = true;
            this.rdEstudiante.Location = new System.Drawing.Point(202, 29);
            this.rdEstudiante.Name = "rdEstudiante";
            this.rdEstudiante.Size = new System.Drawing.Size(86, 21);
            this.rdEstudiante.TabIndex = 1;
            this.rdEstudiante.Text = "Estudiante";
            this.rdEstudiante.UseVisualStyleBackColor = true;
            this.rdEstudiante.CheckedChanged += new System.EventHandler(this.rdEstudiante_CheckedChanged);
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Checked = true;
            this.rdNormal.Location = new System.Drawing.Point(57, 29);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(68, 21);
            this.rdNormal.TabIndex = 0;
            this.rdNormal.TabStop = true;
            this.rdNormal.Text = "Normal";
            this.rdNormal.UseVisualStyleBackColor = true;
            this.rdNormal.CheckedChanged += new System.EventHandler(this.rdNormal_CheckedChanged);
            // 
            // lblNumBoleto
            // 
            this.lblNumBoleto.AutoSize = true;
            this.lblNumBoleto.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBoleto.Location = new System.Drawing.Point(99, 30);
            this.lblNumBoleto.Name = "lblNumBoleto";
            this.lblNumBoleto.Size = new System.Drawing.Size(69, 17);
            this.lblNumBoleto.TabIndex = 2;
            this.lblNumBoleto.Text = "N° Boleto :";
            // 
            // lblNomPasajero
            // 
            this.lblNomPasajero.AutoSize = true;
            this.lblNomPasajero.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPasajero.Location = new System.Drawing.Point(51, 217);
            this.lblNomPasajero.Name = "lblNomPasajero";
            this.lblNomPasajero.Size = new System.Drawing.Size(112, 17);
            this.lblNomPasajero.TabIndex = 6;
            this.lblNomPasajero.Text = "Nombre Pasajero :";
            // 
            // lblAsiento
            // 
            this.lblAsiento.AutoSize = true;
            this.lblAsiento.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento.Location = new System.Drawing.Point(294, 217);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(57, 17);
            this.lblAsiento.TabIndex = 7;
            this.lblAsiento.Text = "Asiento :";
            // 
            // txtNumBoleto
            // 
            this.txtNumBoleto.Enabled = false;
            this.txtNumBoleto.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumBoleto.Location = new System.Drawing.Point(195, 26);
            this.txtNumBoleto.Name = "txtNumBoleto";
            this.txtNumBoleto.Size = new System.Drawing.Size(141, 24);
            this.txtNumBoleto.TabIndex = 8;
            // 
            // txtNomPasajero
            // 
            this.txtNomPasajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomPasajero.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPasajero.Location = new System.Drawing.Point(54, 247);
            this.txtNomPasajero.Name = "txtNomPasajero";
            this.txtNomPasajero.Size = new System.Drawing.Size(179, 24);
            this.txtNomPasajero.TabIndex = 9;
            this.txtNomPasajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomPasajero_KeyPress);
            // 
            // numUpAsiento
            // 
            this.numUpAsiento.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpAsiento.Location = new System.Drawing.Point(297, 247);
            this.numUpAsiento.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpAsiento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpAsiento.Name = "numUpAsiento";
            this.numUpAsiento.Size = new System.Drawing.Size(100, 24);
            this.numUpAsiento.TabIndex = 10;
            this.numUpAsiento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(54, 374);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 11;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(195, 374);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(329, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // admDestinosBindingSource
            // 
            this.admDestinosBindingSource.DataSource = typeof(ProyectoVentaBoletos.admDestinos);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 421);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.numUpAsiento);
            this.Controls.Add(this.txtNomPasajero);
            this.Controls.Add(this.txtNumBoleto);
            this.Controls.Add(this.lblAsiento);
            this.Controls.Add(this.lblNomPasajero);
            this.Controls.Add(this.lblNumBoleto);
            this.Controls.Add(this.grpTipoBoleto);
            this.Controls.Add(this.grpDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Venta de Boletos";
            this.grpDestino.ResumeLayout(false);
            this.grpDestino.PerformLayout();
            this.grpTipoBoleto.ResumeLayout(false);
            this.grpTipoBoleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpAsiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admDestinosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDestino;
        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblClaveDest;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.GroupBox grpTipoBoleto;
        private System.Windows.Forms.Label lblNumBoleto;
        private System.Windows.Forms.Label lblNomPasajero;
        private System.Windows.Forms.Label lblAsiento;
        private System.Windows.Forms.TextBox txtNumBoleto;
        private System.Windows.Forms.TextBox txtNomPasajero;
        private System.Windows.Forms.RadioButton rdEstudiante;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.NumericUpDown numUpAsiento;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource admDestinosBindingSource;
    }
}

