namespace NominaCSharp
{
    partial class frmConsultaNomina
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
            this.IDEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonoExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomina)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.IDEmpleado,
            this.NombreEmp,
            this.diasLab,
            this.SueldoDiario,
            this.BonoExtra,
            this.TotalPagar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNomina.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewNomina.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewNomina.Name = "dataGridViewNomina";
            this.dataGridViewNomina.ReadOnly = true;
            this.dataGridViewNomina.Size = new System.Drawing.Size(900, 406);
            this.dataGridViewNomina.TabIndex = 0;
            // 
            // IDEmpleado
            // 
            this.IDEmpleado.HeaderText = "ID Empleado";
            this.IDEmpleado.Name = "IDEmpleado";
            this.IDEmpleado.ReadOnly = true;
            this.IDEmpleado.Width = 120;
            // 
            // NombreEmp
            // 
            this.NombreEmp.HeaderText = "Nombre Empleado";
            this.NombreEmp.Name = "NombreEmp";
            this.NombreEmp.ReadOnly = true;
            this.NombreEmp.Width = 225;
            // 
            // diasLab
            // 
            this.diasLab.HeaderText = "Dias Laborados";
            this.diasLab.Name = "diasLab";
            this.diasLab.ReadOnly = true;
            this.diasLab.Width = 110;
            // 
            // SueldoDiario
            // 
            this.SueldoDiario.HeaderText = "Sueldo Diario";
            this.SueldoDiario.Name = "SueldoDiario";
            this.SueldoDiario.ReadOnly = true;
            this.SueldoDiario.Width = 130;
            // 
            // BonoExtra
            // 
            this.BonoExtra.HeaderText = "Bono Extra";
            this.BonoExtra.Name = "BonoExtra";
            this.BonoExtra.ReadOnly = true;
            this.BonoExtra.Width = 130;
            // 
            // TotalPagar
            // 
            this.TotalPagar.HeaderText = "Total a Pagar";
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.ReadOnly = true;
            this.TotalPagar.Width = 140;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 49);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTotal.Location = new System.Drawing.Point(748, 8);
            this.txtTotal.MaxLength = 8;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(140, 28);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(631, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(111, 21);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total a pagar";
            // 
            // frmConsultaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogNomina";
            this.Load += new System.EventHandler(this.frmConsultaNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomina)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNomina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonoExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPagar;
    }
}