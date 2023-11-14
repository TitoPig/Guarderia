
namespace GuarderiaCanina.InterfacesUsuario
{
    partial class FrmConsultaCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCobro));
            this.pnlELogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TxtIdConsulta = new System.Windows.Forms.TextBox();
            this.LblENdoc = new System.Windows.Forms.Label();
            this.DGVcobroConsulta = new System.Windows.Forms.DataGridView();
            this.id_cobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_cobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlELogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcobroConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlELogo
            // 
            this.pnlELogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.pnlELogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlELogo.Controls.Add(this.label1);
            this.pnlELogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlELogo.Location = new System.Drawing.Point(0, 0);
            this.pnlELogo.Name = "pnlELogo";
            this.pnlELogo.Size = new System.Drawing.Size(954, 74);
            this.pnlELogo.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consulta de cobro";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(798, 505);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(90, 30);
            this.BtnVolver.TabIndex = 49;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnConsultar.ForeColor = System.Drawing.Color.White;
            this.BtnConsultar.Location = new System.Drawing.Point(798, 146);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(90, 30);
            this.BtnConsultar.TabIndex = 42;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TxtIdConsulta
            // 
            this.TxtIdConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtIdConsulta.Location = new System.Drawing.Point(367, 149);
            this.TxtIdConsulta.Name = "TxtIdConsulta";
            this.TxtIdConsulta.Size = new System.Drawing.Size(221, 20);
            this.TxtIdConsulta.TabIndex = 50;
            // 
            // LblENdoc
            // 
            this.LblENdoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblENdoc.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblENdoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblENdoc.Location = new System.Drawing.Point(204, 146);
            this.LblENdoc.Name = "LblENdoc";
            this.LblENdoc.Size = new System.Drawing.Size(157, 30);
            this.LblENdoc.TabIndex = 51;
            this.LblENdoc.Text = "Numero de turno ";
            // 
            // DGVcobroConsulta
            // 
            this.DGVcobroConsulta.AllowUserToAddRows = false;
            this.DGVcobroConsulta.AllowUserToDeleteRows = false;
            this.DGVcobroConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.DGVcobroConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcobroConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cobro,
            this.id_empleado,
            this.id_turno,
            this.id,
            this.id_mascota,
            this.fecha_desde,
            this.fecha_hasta,
            this.fecha_cobro,
            this.monto});
            this.DGVcobroConsulta.Location = new System.Drawing.Point(64, 224);
            this.DGVcobroConsulta.Name = "DGVcobroConsulta";
            this.DGVcobroConsulta.ReadOnly = true;
            this.DGVcobroConsulta.Size = new System.Drawing.Size(824, 248);
            this.DGVcobroConsulta.TabIndex = 52;
            // 
            // id_cobro
            // 
            this.id_cobro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_cobro.HeaderText = "ID cobro";
            this.id_cobro.Name = "id_cobro";
            this.id_cobro.ReadOnly = true;
            this.id_cobro.Width = 73;
            // 
            // id_empleado
            // 
            this.id_empleado.HeaderText = "Empleado";
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.ReadOnly = true;
            // 
            // id_turno
            // 
            this.id_turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_turno.HeaderText = "ID Turno";
            this.id_turno.Name = "id_turno";
            this.id_turno.ReadOnly = true;
            this.id_turno.Width = 74;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID Cliente";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 78;
            // 
            // id_mascota
            // 
            this.id_mascota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_mascota.HeaderText = "ID Mascota";
            this.id_mascota.Name = "id_mascota";
            this.id_mascota.ReadOnly = true;
            this.id_mascota.Width = 87;
            // 
            // fecha_desde
            // 
            this.fecha_desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha_desde.HeaderText = "Inicio Turno";
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.ReadOnly = true;
            this.fecha_desde.Width = 88;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha_hasta.HeaderText = "Fin Turno";
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.ReadOnly = true;
            this.fecha_hasta.Width = 77;
            // 
            // fecha_cobro
            // 
            this.fecha_cobro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha_cobro.HeaderText = "Fecha Cobro";
            this.fecha_cobro.Name = "fecha_cobro";
            this.fecha_cobro.ReadOnly = true;
            this.fecha_cobro.Width = 93;
            // 
            // monto
            // 
            this.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 62;
            // 
            // FrmConsultaCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.DGVcobroConsulta);
            this.Controls.Add(this.LblENdoc);
            this.Controls.Add(this.TxtIdConsulta);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.pnlELogo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaCobro";
            this.Text = "FrmCobroConsulta";
            this.Load += new System.EventHandler(this.FrmCobroConsulta_Load);
            this.pnlELogo.ResumeLayout(false);
            this.pnlELogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcobroConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlELogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox TxtIdConsulta;
        private System.Windows.Forms.Label LblENdoc;
        private System.Windows.Forms.DataGridView DGVcobroConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_cobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
    }
}