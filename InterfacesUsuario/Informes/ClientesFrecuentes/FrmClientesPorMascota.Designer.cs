namespace GuarderiaCanina.InterfacesUsuario.Informes.ClientesFrecuentes
{
    partial class FrmClientesPorMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesPorMascota));
            this.pnlTLogo = new System.Windows.Forms.Panel();
            this.LblCTurno = new System.Windows.Forms.Label();
            this.RWClienteFrec = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblFechaH = new System.Windows.Forms.Label();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnCrearDT = new System.Windows.Forms.Button();
            this.LblFechaD = new System.Windows.Forms.Label();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.pnlTLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTLogo
            // 
            this.pnlTLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.pnlTLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTLogo.Controls.Add(this.LblCTurno);
            this.pnlTLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlTLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlTLogo.Name = "pnlTLogo";
            this.pnlTLogo.Size = new System.Drawing.Size(704, 63);
            this.pnlTLogo.TabIndex = 55;
            // 
            // LblCTurno
            // 
            this.LblCTurno.AutoSize = true;
            this.LblCTurno.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.LblCTurno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCTurno.Location = new System.Drawing.Point(10, 19);
            this.LblCTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCTurno.Name = "LblCTurno";
            this.LblCTurno.Size = new System.Drawing.Size(262, 30);
            this.LblCTurno.TabIndex = 9;
            this.LblCTurno.Text = "Clientes Mas Frecuentes";
            // 
            // RWClienteFrec
            // 
            this.RWClienteFrec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RWClienteFrec.LocalReport.ReportEmbeddedResource = "GuarderiaCanina.InterfacesUsuario.Informes.ClientesFrecuentes.ClientesFrecuentes." +
    "rdlc";
            this.RWClienteFrec.Location = new System.Drawing.Point(0, 192);
            this.RWClienteFrec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RWClienteFrec.Name = "RWClienteFrec";
            this.RWClienteFrec.ServerReport.BearerToken = null;
            this.RWClienteFrec.Size = new System.Drawing.Size(704, 369);
            this.RWClienteFrec.TabIndex = 56;
            // 
            // LblFechaH
            // 
            this.LblFechaH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFechaH.AutoSize = true;
            this.LblFechaH.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold);
            this.LblFechaH.Location = new System.Drawing.Point(263, 86);
            this.LblFechaH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFechaH.Name = "LblFechaH";
            this.LblFechaH.Size = new System.Drawing.Size(93, 20);
            this.LblFechaH.TabIndex = 60;
            this.LblFechaH.Text = "Fecha Hasta";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fechaHasta.CustomFormat = "d/MM/yyyy";
            this.fechaHasta.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaHasta.Location = new System.Drawing.Point(364, 83);
            this.fechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.fechaHasta.MinDate = new System.DateTime(2022, 10, 12, 0, 0, 0, 0);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(140, 23);
            this.fechaHasta.TabIndex = 57;
            this.fechaHasta.Value = new System.DateTime(2022, 10, 12, 0, 0, 0, 0);
            // 
            // btnCrearDT
            // 
            this.btnCrearDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCrearDT.AutoSize = true;
            this.btnCrearDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.btnCrearDT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearDT.BackgroundImage")));
            this.btnCrearDT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCrearDT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCrearDT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCrearDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearDT.Font = new System.Drawing.Font("Ebrima", 7.75F, System.Drawing.FontStyle.Bold);
            this.btnCrearDT.ForeColor = System.Drawing.Color.White;
            this.btnCrearDT.Location = new System.Drawing.Point(528, 83);
            this.btnCrearDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearDT.Name = "btnCrearDT";
            this.btnCrearDT.Size = new System.Drawing.Size(100, 25);
            this.btnCrearDT.TabIndex = 61;
            this.btnCrearDT.Text = "Consultar";
            this.btnCrearDT.UseVisualStyleBackColor = false;
            this.btnCrearDT.Click += new System.EventHandler(this.btnCrearDT_Click);
            // 
            // LblFechaD
            // 
            this.LblFechaD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFechaD.AutoSize = true;
            this.LblFechaD.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold);
            this.LblFechaD.Location = new System.Drawing.Point(14, 87);
            this.LblFechaD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFechaD.Name = "LblFechaD";
            this.LblFechaD.Size = new System.Drawing.Size(96, 20);
            this.LblFechaD.TabIndex = 63;
            this.LblFechaD.Text = "Fecha Desde";
            // 
            // fechaDesde
            // 
            this.fechaDesde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fechaDesde.CustomFormat = "dd/MM/yyyy";
            this.fechaDesde.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDesde.Location = new System.Drawing.Point(115, 84);
            this.fechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.fechaDesde.MinDate = new System.DateTime(2022, 5, 12, 0, 0, 0, 0);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(140, 23);
            this.fechaDesde.TabIndex = 62;
            this.fechaDesde.Value = new System.DateTime(2022, 5, 12, 0, 0, 0, 0);
            // 
            // FrmClientesPorMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.LblFechaD);
            this.Controls.Add(this.fechaDesde);
            this.Controls.Add(this.btnCrearDT);
            this.Controls.Add(this.LblFechaH);
            this.Controls.Add(this.fechaHasta);
            this.Controls.Add(this.RWClienteFrec);
            this.Controls.Add(this.pnlTLogo);
            this.Font = new System.Drawing.Font("Ebrima", 6F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmClientesPorMascota";
            this.Text = "FrmClientesPorMascota";
            this.Load += new System.EventHandler(this.FrmClientesPorMascota_Load);
            this.pnlTLogo.ResumeLayout(false);
            this.pnlTLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTLogo;
        private System.Windows.Forms.Label LblCTurno;
        private Microsoft.Reporting.WinForms.ReportViewer RWClienteFrec;
        private System.Windows.Forms.Label LblFechaH;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.Button btnCrearDT;
        private System.Windows.Forms.Label LblFechaD;
        private System.Windows.Forms.DateTimePicker fechaDesde;
    }
}