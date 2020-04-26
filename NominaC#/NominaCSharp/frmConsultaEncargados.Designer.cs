namespace NominaCSharp
{
    partial class frmConsultaEncargados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewNomina = new System.Windows.Forms.DataGridView();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargardo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInternoRegDepto = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNomina
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewNomina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNomina.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewNomina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNomina.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewNomina.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.nombre,
            this.encargardo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNomina.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewNomina.Location = new System.Drawing.Point(2, 55);
            this.dataGridViewNomina.Name = "dataGridViewNomina";
            this.dataGridViewNomina.ReadOnly = true;
            this.dataGridViewNomina.Size = new System.Drawing.Size(540, 414);
            this.dataGridViewNomina.TabIndex = 34;
            this.dataGridViewNomina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNomina_CellContentClick);
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Width = 80;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 230;
            // 
            // encargardo
            // 
            this.encargardo.HeaderText = "Encargado";
            this.encargardo.Name = "encargardo";
            this.encargardo.ReadOnly = true;
            this.encargardo.Width = 180;
            // 
            // pnlInternoRegDepto
            // 
            this.pnlInternoRegDepto.BackgroundImage = global::NominaCSharp.Properties.Resources.images1;
            this.pnlInternoRegDepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlInternoRegDepto.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInternoRegDepto.Location = new System.Drawing.Point(545, 0);
            this.pnlInternoRegDepto.Name = "pnlInternoRegDepto";
            this.pnlInternoRegDepto.Size = new System.Drawing.Size(355, 510);
            this.pnlInternoRegDepto.TabIndex = 35;
            // 
            // frmConsultaEncargados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.pnlInternoRegDepto);
            this.Controls.Add(this.dataGridViewNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaEncargados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarEncargados";
            this.Load += new System.EventHandler(this.frmConsultaEncargados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargardo;
        private System.Windows.Forms.Panel pnlInternoRegDepto;
    }
}