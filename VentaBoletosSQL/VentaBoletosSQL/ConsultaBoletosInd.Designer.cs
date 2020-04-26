namespace VentaBoletosSQL
{
    partial class ConsultaBoletosInd
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
            this.txtNomPasajero = new System.Windows.Forms.TextBox();
            this.lblAsiento = new System.Windows.Forms.Label();
            this.lblNomPasajero = new System.Windows.Forms.Label();
            this.lblNumBoleto = new System.Windows.Forms.Label();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveDestino = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomPasajero
            // 
            this.txtNomPasajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomPasajero.Enabled = false;
            this.txtNomPasajero.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPasajero.Location = new System.Drawing.Point(162, 130);
            this.txtNomPasajero.Name = "txtNomPasajero";
            this.txtNomPasajero.Size = new System.Drawing.Size(179, 24);
            this.txtNomPasajero.TabIndex = 25;
            // 
            // lblAsiento
            // 
            this.lblAsiento.AutoSize = true;
            this.lblAsiento.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento.Location = new System.Drawing.Point(34, 188);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(57, 17);
            this.lblAsiento.TabIndex = 23;
            this.lblAsiento.Text = "Asiento :";
            // 
            // lblNomPasajero
            // 
            this.lblNomPasajero.AutoSize = true;
            this.lblNomPasajero.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPasajero.Location = new System.Drawing.Point(32, 133);
            this.lblNomPasajero.Name = "lblNomPasajero";
            this.lblNomPasajero.Size = new System.Drawing.Size(112, 17);
            this.lblNomPasajero.TabIndex = 22;
            this.lblNomPasajero.Text = "Nombre Pasajero :";
            // 
            // lblNumBoleto
            // 
            this.lblNumBoleto.AutoSize = true;
            this.lblNumBoleto.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBoleto.Location = new System.Drawing.Point(75, 38);
            this.lblNumBoleto.Name = "lblNumBoleto";
            this.lblNumBoleto.Size = new System.Drawing.Size(69, 17);
            this.lblNumBoleto.TabIndex = 21;
            this.lblNumBoleto.Text = "N° Boleto :";
            // 
            // txtAsiento
            // 
            this.txtAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsiento.Enabled = false;
            this.txtAsiento.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsiento.Location = new System.Drawing.Point(108, 185);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(64, 24);
            this.txtAsiento.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Clave Destino:";
            // 
            // txtClaveDestino
            // 
            this.txtClaveDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveDestino.Enabled = false;
            this.txtClaveDestino.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveDestino.Location = new System.Drawing.Point(162, 79);
            this.txtClaveDestino.Name = "txtClaveDestino";
            this.txtClaveDestino.Size = new System.Drawing.Size(179, 24);
            this.txtClaveDestino.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // txtTipo
            // 
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(277, 185);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(64, 24);
            this.txtTipo.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tipo de Boleto:";
            // 
            // txtCosto
            // 
            this.txtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(207, 229);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(64, 24);
            this.txtCosto.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Costo:";
            // 
            // ConsultaBoletosInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 287);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtClaveDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAsiento);
            this.Controls.Add(this.txtNomPasajero);
            this.Controls.Add(this.lblAsiento);
            this.Controls.Add(this.lblNomPasajero);
            this.Controls.Add(this.lblNumBoleto);
            this.Name = "ConsultaBoletosInd";
            this.Text = "Consulta de Boletos Ind";
            this.Load += new System.EventHandler(this.ConsultaBoletosInd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomPasajero;
        private System.Windows.Forms.Label lblAsiento;
        private System.Windows.Forms.Label lblNomPasajero;
        private System.Windows.Forms.Label lblNumBoleto;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveDestino;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label3;
    }
}