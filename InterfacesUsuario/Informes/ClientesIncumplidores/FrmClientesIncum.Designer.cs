namespace GuarderiaCanina.InterfacesUsuario.Informes.Clientes_por_demora
{
    partial class FrmClientesIncum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesIncum));
            this.LblFD = new System.Windows.Forms.Label();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.LblFH = new System.Windows.Forms.Label();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.LblCTurno = new System.Windows.Forms.Label();
            this.pnlTLogo = new System.Windows.Forms.Panel();
            this.btnCrearDT = new System.Windows.Forms.Button();
            this.RWClienteIncum = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlTLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFD
            // 
            this.LblFD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFD.AutoSize = true;
            this.LblFD.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold);
            this.LblFD.Location = new System.Drawing.Point(22, 83);
            this.LblFD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFD.Name = "LblFD";
            this.LblFD.Size = new System.Drawing.Size(96, 20);
            this.LblFD.TabIndex = 70;
            this.LblFD.Text = "Fecha Desde";
            // 
            // fechaDesde
            // 
            this.fechaDesde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fechaDesde.CustomFormat = "dd/MM/yyyy";
            this.fechaDesde.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDesde.Location = new System.Drawing.Point(126, 83);
            this.fechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.fechaDesde.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(140, 23);
            this.fechaDesde.TabIndex = 69;
            this.fechaDesde.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // LblFH
            // 
            this.LblFH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFH.AutoSize = true;
            this.LblFH.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold);
            this.LblFH.Location = new System.Drawing.Point(274, 85);
            this.LblFH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFH.Name = "LblFH";
            this.LblFH.Size = new System.Drawing.Size(93, 20);
            this.LblFH.TabIndex = 67;
            this.LblFH.Text = "Fecha Hasta";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fechaHasta.CustomFormat = "d/MM/yyyy";
            this.fechaHasta.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaHasta.Location = new System.Drawing.Point(375, 83);
            this.fechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.fechaHasta.MinDate = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(140, 23);
            this.fechaHasta.TabIndex = 66;
            this.fechaHasta.Value = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
            // 
            // LblCTurno
            // 
            this.LblCTurno.AutoSize = true;
            this.LblCTurno.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.LblCTurno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCTurno.Location = new System.Drawing.Point(10, 19);
            this.LblCTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCTurno.Name = "LblCTurno";
            this.LblCTurno.Size = new System.Drawing.Size(249, 30);
            this.LblCTurno.TabIndex = 9;
            this.LblCTurno.Text = "Clientes Incumplidores";
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
            this.pnlTLogo.TabIndex = 64;
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
            this.btnCrearDT.Location = new System.Drawing.Point(534, 81);
            this.btnCrearDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearDT.Name = "btnCrearDT";
            this.btnCrearDT.Size = new System.Drawing.Size(100, 25);
            this.btnCrearDT.TabIndex = 68;
            this.btnCrearDT.Text = "Consultar";
            this.btnCrearDT.UseVisualStyleBackColor = false;
            this.btnCrearDT.Click += new System.EventHandler(this.btnCrearDT_Click);
            // 
            // RWClienteIncum
            // 
            this.RWClienteIncum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RWClienteIncum.LocalReport.ReportEmbeddedResource = "GuarderiaCanina.InterfacesUsuario.Informes.ClientesIncumplidores.ClientesIncumpli" +
    "dores.rdlc";
            this.RWClienteIncum.Location = new System.Drawing.Point(0, 162);
            this.RWClienteIncum.Name = "RWClienteIncum";
            this.RWClienteIncum.ServerReport.BearerToken = null;
            this.RWClienteIncum.Size = new System.Drawing.Size(704, 401);
            this.RWClienteIncum.TabIndex = 71;
            // 
            // FrmClientesIncum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.RWClienteIncum);
            this.Controls.Add(this.LblFD);
            this.Controls.Add(this.fechaDesde);
            this.Controls.Add(this.btnCrearDT);
            this.Controls.Add(this.LblFH);
            this.Controls.Add(this.fechaHasta);
            this.Controls.Add(this.pnlTLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientesIncum";
            this.Text = "FrmClientesIncum";
            this.Load += new System.EventHandler(this.FrmClientesIncum_Load);
            this.pnlTLogo.ResumeLayout(false);
            this.pnlTLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFD;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Button btnCrearDT;
        private System.Windows.Forms.Label LblFH;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.Label LblCTurno;
        private System.Windows.Forms.Panel pnlTLogo;
        private Microsoft.Reporting.WinForms.ReportViewer RWClienteIncum;
    }
}