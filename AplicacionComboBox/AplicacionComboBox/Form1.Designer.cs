namespace AplicacionComboBox
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
            this.lblSelecciona = new System.Windows.Forms.Label();
            this.lblColores = new System.Windows.Forms.Label();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblDespColor = new System.Windows.Forms.Label();
            this.lblDespPos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelecciona
            // 
            this.lblSelecciona.AutoSize = true;
            this.lblSelecciona.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSelecciona.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecciona.ForeColor = System.Drawing.Color.Black;
            this.lblSelecciona.Location = new System.Drawing.Point(54, 47);
            this.lblSelecciona.Name = "lblSelecciona";
            this.lblSelecciona.Size = new System.Drawing.Size(177, 26);
            this.lblSelecciona.TabIndex = 0;
            this.lblSelecciona.Text = "Selecciona un color";
            // 
            // lblColores
            // 
            this.lblColores.AutoSize = true;
            this.lblColores.Location = new System.Drawing.Point(44, 113);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(42, 13);
            this.lblColores.TabIndex = 1;
            this.lblColores.Text = "Colores";
            // 
            // cmbColores
            // 
            this.cmbColores.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.IntegralHeight = false;
            this.cmbColores.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "White",
            "Green",
            "Black",
            "Cyan"});
            this.cmbColores.Location = new System.Drawing.Point(135, 105);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(121, 21);
            this.cmbColores.TabIndex = 2;
            this.cmbColores.SelectedIndexChanged += new System.EventHandler(this.cmbColores_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(44, 158);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 16);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(44, 197);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(68, 16);
            this.lblPosicion.TabIndex = 4;
            this.lblPosicion.Text = "Posición";
            // 
            // lblDespColor
            // 
            this.lblDespColor.AutoSize = true;
            this.lblDespColor.Location = new System.Drawing.Point(142, 158);
            this.lblDespColor.Name = "lblDespColor";
            this.lblDespColor.Size = new System.Drawing.Size(0, 13);
            this.lblDespColor.TabIndex = 5;
            // 
            // lblDespPos
            // 
            this.lblDespPos.AutoSize = true;
            this.lblDespPos.Location = new System.Drawing.Point(142, 197);
            this.lblDespPos.Name = "lblDespPos";
            this.lblDespPos.Size = new System.Drawing.Size(0, 13);
            this.lblDespPos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(302, 282);
            this.Controls.Add(this.lblDespPos);
            this.Controls.Add(this.lblDespColor);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbColores);
            this.Controls.Add(this.lblColores);
            this.Controls.Add(this.lblSelecciona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecciona;
        private System.Windows.Forms.Label lblColores;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblDespColor;
        private System.Windows.Forms.Label lblDespPos;
    }
}

