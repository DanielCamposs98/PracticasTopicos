namespace NominaCSharp
{
    partial class frmBtnCapturarDias
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
            this.lblBono = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlInternoRegDepto = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBono
            // 
            this.lblBono.AutoSize = true;
            this.lblBono.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBono.Location = new System.Drawing.Point(49, 240);
            this.lblBono.Name = "lblBono";
            this.lblBono.Size = new System.Drawing.Size(112, 20);
            this.lblBono.TabIndex = 42;
            this.lblBono.Text = "Días laborados:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(69, 176);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 41;
            this.lblId.Text = "ID:";
            // 
            // pnlInternoRegDepto
            // 
            this.pnlInternoRegDepto.BackgroundImage = global::NominaCSharp.Properties.Resources.images1;
            this.pnlInternoRegDepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlInternoRegDepto.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInternoRegDepto.Location = new System.Drawing.Point(545, 0);
            this.pnlInternoRegDepto.Name = "pnlInternoRegDepto";
            this.pnlInternoRegDepto.Size = new System.Drawing.Size(355, 510);
            this.pnlInternoRegDepto.TabIndex = 40;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(278, 318);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 34);
            this.btnLimpiar.TabIndex = 39;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(126, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 34);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtBono
            // 
            this.txtBono.BackColor = System.Drawing.SystemColors.Window;
            this.txtBono.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBono.Location = new System.Drawing.Point(193, 237);
            this.txtBono.MaxLength = 2;
            this.txtBono.Name = "txtBono";
            this.txtBono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBono.Size = new System.Drawing.Size(243, 27);
            this.txtBono.TabIndex = 37;
            this.txtBono.Text = "Días";
            this.txtBono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEnteros_KeyPress);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.Window;
            this.txtClave.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtClave.Location = new System.Drawing.Point(193, 169);
            this.txtClave.MaxLength = 4;
            this.txtClave.Name = "txtClave";
            this.txtClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClave.Size = new System.Drawing.Size(243, 27);
            this.txtClave.TabIndex = 36;
            this.txtClave.Text = "ID Empleado";
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEnteros_KeyPress);
            // 
            // frmBtnCapturarDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.lblBono);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pnlInternoRegDepto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBono);
            this.Controls.Add(this.txtClave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBtnCapturarDias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBono;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlInternoRegDepto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.TextBox txtClave;
    }
}