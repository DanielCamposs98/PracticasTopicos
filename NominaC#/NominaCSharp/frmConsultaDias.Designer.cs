namespace NominaCSharp
{
    partial class frmConsultaDias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewNomina = new System.Windows.Forms.DataGridView();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dpto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNomina
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewNomina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewNomina.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewNomina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNomina.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewNomina.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.nombre,
            this.APPat,
            this.ApMat,
            this.Dpto,
            this.Dias});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNomina.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewNomina.Location = new System.Drawing.Point(-1, 48);
            this.dataGridViewNomina.Name = "dataGridViewNomina";
            this.dataGridViewNomina.ReadOnly = true;
            this.dataGridViewNomina.Size = new System.Drawing.Size(901, 414);
            this.dataGridViewNomina.TabIndex = 36;
            this.dataGridViewNomina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNomina_CellContentClick);
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // APPat
            // 
            this.APPat.HeaderText = "AP Paterno";
            this.APPat.Name = "APPat";
            this.APPat.ReadOnly = true;
            this.APPat.Width = 150;
            // 
            // ApMat
            // 
            this.ApMat.HeaderText = "AP Materno";
            this.ApMat.Name = "ApMat";
            this.ApMat.ReadOnly = true;
            this.ApMat.Width = 150;
            // 
            // Dpto
            // 
            this.Dpto.HeaderText = "Departamento";
            this.Dpto.Name = "Dpto";
            this.Dpto.ReadOnly = true;
            this.Dpto.Width = 170;
            // 
            // Dias
            // 
            this.Dias.HeaderText = "Dias Laborados";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            this.Dias.Width = 88;
            // 
            // frmConsultaDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.dataGridViewNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaDias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaDias";
            this.Load += new System.EventHandler(this.frmConsultaDias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dpto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
    }
}