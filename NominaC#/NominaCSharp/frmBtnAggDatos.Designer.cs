namespace NominaCSharp
{
    partial class frmBtnAggDatos
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
            this.txtBono = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.btnDias = new System.Windows.Forms.Button();
            this.btnBono = new System.Windows.Forms.Button();
            this.pnlInternoRegDepto = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBono
            // 
            this.txtBono.BackColor = System.Drawing.SystemColors.Window;
            this.txtBono.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBono.Location = new System.Drawing.Point(149, 264);
            this.txtBono.MaxLength = 8;
            this.txtBono.Name = "txtBono";
            this.txtBono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBono.Size = new System.Drawing.Size(243, 27);
            this.txtBono.TabIndex = 4;
            this.txtBono.Text = "Bono Asignado";
            this.txtBono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDouble_KeyPress);
            // 
            // txtDias
            // 
            this.txtDias.BackColor = System.Drawing.SystemColors.Window;
            this.txtDias.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDias.Location = new System.Drawing.Point(149, 204);
            this.txtDias.MaxLength = 2;
            this.txtDias.Name = "txtDias";
            this.txtDias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDias.Size = new System.Drawing.Size(243, 27);
            this.txtDias.TabIndex = 2;
            this.txtDias.Text = "Dias Laborados";
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEnteros_KeyPress);
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamentos.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(149, 143);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(243, 28);
            this.cmbDepartamentos.TabIndex = 1;
            // 
            // btnDias
            // 
            this.btnDias.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDias.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDias.Location = new System.Drawing.Point(425, 201);
            this.btnDias.Name = "btnDias";
            this.btnDias.Size = new System.Drawing.Size(102, 34);
            this.btnDias.TabIndex = 3;
            this.btnDias.Text = "Agregar Dias";
            this.btnDias.UseVisualStyleBackColor = false;
            // 
            // btnBono
            // 
            this.btnBono.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBono.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBono.Location = new System.Drawing.Point(425, 261);
            this.btnBono.Name = "btnBono";
            this.btnBono.Size = new System.Drawing.Size(102, 34);
            this.btnBono.TabIndex = 5;
            this.btnBono.Text = "Agregar Bono";
            this.btnBono.UseVisualStyleBackColor = false;
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
            this.btnLimpiar.Location = new System.Drawing.Point(220, 327);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 34);
            this.btnLimpiar.TabIndex = 39;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Días Laborados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Bono Extra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Empleado:";
            // 
            // frmBtnAggDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlInternoRegDepto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBono);
            this.Controls.Add(this.btnDias);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.txtBono);
            this.Controls.Add(this.txtDias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBtnAggDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogAgDatosEmp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.Button btnDias;
        private System.Windows.Forms.Button btnBono;
        private System.Windows.Forms.Panel pnlInternoRegDepto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}