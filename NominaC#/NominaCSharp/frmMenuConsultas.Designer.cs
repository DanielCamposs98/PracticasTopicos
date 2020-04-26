namespace NominaCSharp
{
    partial class frmMenuConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuConsultas));
            this.btnConsultaBonos = new System.Windows.Forms.Button();
            this.btnConsultaDias = new System.Windows.Forms.Button();
            this.btnConsultaEncDepto = new System.Windows.Forms.Button();
            this.btnConsultaDepto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaBonos
            // 
            this.btnConsultaBonos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaBonos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultaBonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaBonos.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaBonos.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaBonos.Image")));
            this.btnConsultaBonos.Location = new System.Drawing.Point(101, 268);
            this.btnConsultaBonos.Name = "btnConsultaBonos";
            this.btnConsultaBonos.Size = new System.Drawing.Size(194, 193);
            this.btnConsultaBonos.TabIndex = 8;
            this.btnConsultaBonos.Text = "Consulta Bonos Extra";
            this.btnConsultaBonos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaBonos.UseVisualStyleBackColor = true;
            this.btnConsultaBonos.Click += new System.EventHandler(this.btnConsultaBonos_Click);
            // 
            // btnConsultaDias
            // 
            this.btnConsultaDias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaDias.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultaDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaDias.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaDias.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaDias.Image")));
            this.btnConsultaDias.Location = new System.Drawing.Point(606, 49);
            this.btnConsultaDias.Name = "btnConsultaDias";
            this.btnConsultaDias.Size = new System.Drawing.Size(194, 193);
            this.btnConsultaDias.TabIndex = 7;
            this.btnConsultaDias.Text = "Consulta Días Laborados";
            this.btnConsultaDias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaDias.UseVisualStyleBackColor = true;
            this.btnConsultaDias.Click += new System.EventHandler(this.btnConsultaDias_Click);
            // 
            // btnConsultaEncDepto
            // 
            this.btnConsultaEncDepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaEncDepto.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultaEncDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEncDepto.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaEncDepto.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaEncDepto.Image")));
            this.btnConsultaEncDepto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultaEncDepto.Location = new System.Drawing.Point(363, 49);
            this.btnConsultaEncDepto.Name = "btnConsultaEncDepto";
            this.btnConsultaEncDepto.Size = new System.Drawing.Size(194, 193);
            this.btnConsultaEncDepto.TabIndex = 6;
            this.btnConsultaEncDepto.Text = "Consulta de Encargados por Depto";
            this.btnConsultaEncDepto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaEncDepto.UseVisualStyleBackColor = true;
            this.btnConsultaEncDepto.Click += new System.EventHandler(this.btnConsultaEncDepto_Click);
            // 
            // btnConsultaDepto
            // 
            this.btnConsultaDepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaDepto.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultaDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaDepto.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaDepto.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaDepto.Image")));
            this.btnConsultaDepto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultaDepto.Location = new System.Drawing.Point(101, 49);
            this.btnConsultaDepto.Name = "btnConsultaDepto";
            this.btnConsultaDepto.Size = new System.Drawing.Size(194, 193);
            this.btnConsultaDepto.TabIndex = 5;
            this.btnConsultaDepto.Text = "Consulta Por Departamento";
            this.btnConsultaDepto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaDepto.UseVisualStyleBackColor = true;
            this.btnConsultaDepto.Click += new System.EventHandler(this.btnConsultaDepto_Click);
            // 
            // frmMenuConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.btnConsultaBonos);
            this.Controls.Add(this.btnConsultaDias);
            this.Controls.Add(this.btnConsultaEncDepto);
            this.Controls.Add(this.btnConsultaDepto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuConsultas";
            this.Text = "frmMenuConsultas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaBonos;
        private System.Windows.Forms.Button btnConsultaDias;
        private System.Windows.Forms.Button btnConsultaEncDepto;
        private System.Windows.Forms.Button btnConsultaDepto;
    }
}