namespace NominaCSharp
{
    partial class frmMenuNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuNomina));
            this.btnBorraEmpleado = new System.Windows.Forms.Button();
            this.btnReiniciaNomina = new System.Windows.Forms.Button();
            this.btnConsultaNomina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorraEmpleado
            // 
            this.btnBorraEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorraEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBorraEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorraEmpleado.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnBorraEmpleado.Image")));
            this.btnBorraEmpleado.Location = new System.Drawing.Point(606, 49);
            this.btnBorraEmpleado.Name = "btnBorraEmpleado";
            this.btnBorraEmpleado.Size = new System.Drawing.Size(194, 193);
            this.btnBorraEmpleado.TabIndex = 7;
            this.btnBorraEmpleado.Text = "Borrar Empleado";
            this.btnBorraEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorraEmpleado.UseVisualStyleBackColor = true;
            this.btnBorraEmpleado.Click += new System.EventHandler(this.btnBorraEmpleado_Click);
            // 
            // btnReiniciaNomina
            // 
            this.btnReiniciaNomina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciaNomina.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReiniciaNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciaNomina.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciaNomina.Image = ((System.Drawing.Image)(resources.GetObject("btnReiniciaNomina.Image")));
            this.btnReiniciaNomina.Location = new System.Drawing.Point(363, 49);
            this.btnReiniciaNomina.Name = "btnReiniciaNomina";
            this.btnReiniciaNomina.Size = new System.Drawing.Size(194, 193);
            this.btnReiniciaNomina.TabIndex = 6;
            this.btnReiniciaNomina.Text = "Reinicia Nomina";
            this.btnReiniciaNomina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReiniciaNomina.UseVisualStyleBackColor = true;
            this.btnReiniciaNomina.Click += new System.EventHandler(this.btnReiniciaNomina_Click);
            // 
            // btnConsultaNomina
            // 
            this.btnConsultaNomina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaNomina.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultaNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaNomina.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaNomina.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaNomina.Image")));
            this.btnConsultaNomina.Location = new System.Drawing.Point(101, 49);
            this.btnConsultaNomina.Name = "btnConsultaNomina";
            this.btnConsultaNomina.Size = new System.Drawing.Size(194, 193);
            this.btnConsultaNomina.TabIndex = 5;
            this.btnConsultaNomina.Text = "Consulta Nómina";
            this.btnConsultaNomina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaNomina.UseVisualStyleBackColor = true;
            this.btnConsultaNomina.Click += new System.EventHandler(this.btnConsultaNomina_Click);
            // 
            // frmMenuNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.btnBorraEmpleado);
            this.Controls.Add(this.btnReiniciaNomina);
            this.Controls.Add(this.btnConsultaNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuNomina";
            this.Text = "frmMenuNomina";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBorraEmpleado;
        private System.Windows.Forms.Button btnReiniciaNomina;
        private System.Windows.Forms.Button btnConsultaNomina;
    }
}