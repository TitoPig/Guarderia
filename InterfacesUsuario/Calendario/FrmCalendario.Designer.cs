namespace GuarderiaCanina.InterfacesUsuario.Calendario
{
    partial class FrmCalendario
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
            this.pnlELogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnECancelar = new System.Windows.Forms.Button();
            this.DGVConsulta = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugaresDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugaresOcup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugaresRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlELogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlELogo
            // 
            this.pnlELogo.AutoSize = true;
            this.pnlELogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.pnlELogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlELogo.Controls.Add(this.label1);
            this.pnlELogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlELogo.Location = new System.Drawing.Point(0, 0);
            this.pnlELogo.Name = "pnlELogo";
            this.pnlELogo.Size = new System.Drawing.Size(988, 73);
            this.pnlELogo.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Administrar Calendario";
            // 
            // BtnECancelar
            // 
            this.BtnECancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnECancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnECancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnECancelar.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnECancelar.ForeColor = System.Drawing.Color.White;
            this.BtnECancelar.Location = new System.Drawing.Point(29, 622);
            this.BtnECancelar.Name = "BtnECancelar";
            this.BtnECancelar.Size = new System.Drawing.Size(145, 42);
            this.BtnECancelar.TabIndex = 54;
            this.BtnECancelar.Text = "Volver";
            this.BtnECancelar.UseVisualStyleBackColor = false;
            // 
            // DGVConsulta
            // 
            this.DGVConsulta.AllowUserToAddRows = false;
            this.DGVConsulta.AllowUserToDeleteRows = false;
            this.DGVConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.DGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.LugaresDisp,
            this.LugaresOcup,
            this.LugaresRest});
            this.DGVConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVConsulta.Location = new System.Drawing.Point(0, 73);
            this.DGVConsulta.MultiSelect = false;
            this.DGVConsulta.Name = "DGVConsulta";
            this.DGVConsulta.ReadOnly = true;
            this.DGVConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVConsulta.Size = new System.Drawing.Size(988, 585);
            this.DGVConsulta.TabIndex = 55;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha en Calendario";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // LugaresDisp
            // 
            this.LugaresDisp.HeaderText = "Lugares Disponibles";
            this.LugaresDisp.Name = "LugaresDisp";
            this.LugaresDisp.ReadOnly = true;
            // 
            // LugaresOcup
            // 
            this.LugaresOcup.HeaderText = "Lugares ocupados";
            this.LugaresOcup.Name = "LugaresOcup";
            this.LugaresOcup.ReadOnly = true;
            // 
            // LugaresRest
            // 
            this.LugaresRest.HeaderText = "Lugares Restantes";
            this.LugaresRest.Name = "LugaresRest";
            this.LugaresRest.ReadOnly = true;
            // 
            // FrmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 658);
            this.Controls.Add(this.DGVConsulta);
            this.Controls.Add(this.pnlELogo);
            this.Controls.Add(this.BtnECancelar);
            this.Name = "FrmCalendario";
            this.Text = "FrmCalendario";
            this.Load += new System.EventHandler(this.FrmCalendario_Load);
            this.pnlELogo.ResumeLayout(false);
            this.pnlELogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlELogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnECancelar;
        private System.Windows.Forms.DataGridView DGVConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugaresDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugaresOcup;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugaresRest;
    }
}