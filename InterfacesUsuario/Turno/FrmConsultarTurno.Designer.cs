namespace GuarderiaCanina.InterfacesUsuario
{
    partial class FrmConsultarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarTurno));
            this.LblTDCliente = new System.Windows.Forms.Label();
            this.TxtTurnoConsulta = new System.Windows.Forms.TextBox();
            this.BtnTConsultarTurno = new System.Windows.Forms.Button();
            this.BtnCVolver = new System.Windows.Forms.Button();
            this.DGVTurnocons = new System.Windows.Forms.DataGridView();
            this.id_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblCTurno = new System.Windows.Forms.Label();
            this.pnlTLogo = new System.Windows.Forms.Panel();
            this.BtnCCobrar = new System.Windows.Forms.Button();
            this.BtnCRecepcion = new System.Windows.Forms.Button();
            this.BtnCCancelar = new System.Windows.Forms.Button();
            this.BtnAct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTurnocons)).BeginInit();
            this.pnlTLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTDCliente
            // 
            this.LblTDCliente.AutoSize = true;
            this.LblTDCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.LblTDCliente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblTDCliente.Location = new System.Drawing.Point(34, 116);
            this.LblTDCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTDCliente.Name = "LblTDCliente";
            this.LblTDCliente.Size = new System.Drawing.Size(145, 21);
            this.LblTDCliente.TabIndex = 23;
            this.LblTDCliente.Text = "Numero de Turno";
            // 
            // TxtTurnoConsulta
            // 
            this.TxtTurnoConsulta.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTurnoConsulta.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.TxtTurnoConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTurnoConsulta.Location = new System.Drawing.Point(38, 142);
            this.TxtTurnoConsulta.Margin = new System.Windows.Forms.Padding(5);
            this.TxtTurnoConsulta.Name = "TxtTurnoConsulta";
            this.TxtTurnoConsulta.Size = new System.Drawing.Size(337, 23);
            this.TxtTurnoConsulta.TabIndex = 22;
            // 
            // BtnTConsultarTurno
            // 
            this.BtnTConsultarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnTConsultarTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTConsultarTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTConsultarTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTConsultarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTConsultarTurno.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnTConsultarTurno.ForeColor = System.Drawing.Color.White;
            this.BtnTConsultarTurno.Location = new System.Drawing.Point(400, 139);
            this.BtnTConsultarTurno.Margin = new System.Windows.Forms.Padding(5);
            this.BtnTConsultarTurno.Name = "BtnTConsultarTurno";
            this.BtnTConsultarTurno.Size = new System.Drawing.Size(134, 27);
            this.BtnTConsultarTurno.TabIndex = 24;
            this.BtnTConsultarTurno.Text = "Consultar Turno";
            this.BtnTConsultarTurno.UseVisualStyleBackColor = false;
            this.BtnTConsultarTurno.Click += new System.EventHandler(this.BtnTConsultarTurno_Click);
            // 
            // BtnCVolver
            // 
            this.BtnCVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnCVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCVolver.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold);
            this.BtnCVolver.ForeColor = System.Drawing.Color.White;
            this.BtnCVolver.Location = new System.Drawing.Point(17, 507);
            this.BtnCVolver.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCVolver.Name = "BtnCVolver";
            this.BtnCVolver.Size = new System.Drawing.Size(81, 40);
            this.BtnCVolver.TabIndex = 25;
            this.BtnCVolver.Text = "Volver";
            this.BtnCVolver.UseVisualStyleBackColor = false;
            this.BtnCVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGVTurnocons
            // 
            this.DGVTurnocons.AllowUserToAddRows = false;
            this.DGVTurnocons.AllowUserToDeleteRows = false;
            this.DGVTurnocons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTurnocons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_turno,
            this.fecha_desde,
            this.fecha_hasta,
            this.fecha_salida,
            this.id_cliente,
            this.id_mascota,
            this.id_empleado,
            this.Monto,
            this.Estado});
            this.DGVTurnocons.Location = new System.Drawing.Point(5, 195);
            this.DGVTurnocons.MultiSelect = false;
            this.DGVTurnocons.Name = "DGVTurnocons";
            this.DGVTurnocons.ReadOnly = true;
            this.DGVTurnocons.RowHeadersWidth = 5;
            this.DGVTurnocons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVTurnocons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTurnocons.Size = new System.Drawing.Size(687, 252);
            this.DGVTurnocons.TabIndex = 10;
            // 
            // id_turno
            // 
            this.id_turno.FillWeight = 50F;
            this.id_turno.HeaderText = "Nro Turno";
            this.id_turno.Name = "id_turno";
            this.id_turno.ReadOnly = true;
            this.id_turno.Width = 60;
            // 
            // fecha_desde
            // 
            this.fecha_desde.HeaderText = "Fecha Entrada";
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.ReadOnly = true;
            this.fecha_desde.Width = 80;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.HeaderText = "Fecha Salida Estimada";
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.ReadOnly = true;
            this.fecha_hasta.Width = 80;
            // 
            // fecha_salida
            // 
            this.fecha_salida.HeaderText = "Fecha Salida";
            this.fecha_salida.Name = "fecha_salida";
            this.fecha_salida.ReadOnly = true;
            this.fecha_salida.Width = 80;
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "Cliente";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Width = 75;
            // 
            // id_mascota
            // 
            this.id_mascota.HeaderText = "Mascota";
            this.id_mascota.Name = "id_mascota";
            this.id_mascota.ReadOnly = true;
            this.id_mascota.Width = 75;
            // 
            // id_empleado
            // 
            this.id_empleado.HeaderText = "Empleado";
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.ReadOnly = true;
            this.id_empleado.Width = 75;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 70;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // LblCTurno
            // 
            this.LblCTurno.AutoSize = true;
            this.LblCTurno.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.LblCTurno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCTurno.Location = new System.Drawing.Point(12, 22);
            this.LblCTurno.Name = "LblCTurno";
            this.LblCTurno.Size = new System.Drawing.Size(179, 30);
            this.LblCTurno.TabIndex = 9;
            this.LblCTurno.Text = "Consultar Turno";
            // 
            // pnlTLogo
            // 
            this.pnlTLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.pnlTLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTLogo.Controls.Add(this.LblCTurno);
            this.pnlTLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlTLogo.Name = "pnlTLogo";
            this.pnlTLogo.Size = new System.Drawing.Size(704, 74);
            this.pnlTLogo.TabIndex = 50;
            // 
            // BtnCCobrar
            // 
            this.BtnCCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnCCobrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCCobrar.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold);
            this.BtnCCobrar.ForeColor = System.Drawing.Color.White;
            this.BtnCCobrar.Location = new System.Drawing.Point(602, 507);
            this.BtnCCobrar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCCobrar.Name = "BtnCCobrar";
            this.BtnCCobrar.Size = new System.Drawing.Size(81, 40);
            this.BtnCCobrar.TabIndex = 51;
            this.BtnCCobrar.Text = "Cobrar Turno";
            this.BtnCCobrar.UseVisualStyleBackColor = false;
            this.BtnCCobrar.Click += new System.EventHandler(this.BtnCCobrar_Click);
            // 
            // BtnCRecepcion
            // 
            this.BtnCRecepcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCRecepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnCRecepcion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCRecepcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCRecepcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCRecepcion.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold);
            this.BtnCRecepcion.ForeColor = System.Drawing.Color.White;
            this.BtnCRecepcion.Location = new System.Drawing.Point(511, 507);
            this.BtnCRecepcion.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCRecepcion.Name = "BtnCRecepcion";
            this.BtnCRecepcion.Size = new System.Drawing.Size(81, 40);
            this.BtnCRecepcion.TabIndex = 52;
            this.BtnCRecepcion.Text = "Recepcion Mascota";
            this.BtnCRecepcion.UseVisualStyleBackColor = false;
            this.BtnCRecepcion.Click += new System.EventHandler(this.BtnCRecepcion_Click);
            // 
            // BtnCCancelar
            // 
            this.BtnCCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnCCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCCancelar.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold);
            this.BtnCCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCCancelar.Location = new System.Drawing.Point(420, 507);
            this.BtnCCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCCancelar.Name = "BtnCCancelar";
            this.BtnCCancelar.Size = new System.Drawing.Size(81, 40);
            this.BtnCCancelar.TabIndex = 53;
            this.BtnCCancelar.Text = "Cancelar Turno";
            this.BtnCCancelar.UseVisualStyleBackColor = false;
            this.BtnCCancelar.Click += new System.EventHandler(this.BtnCCancelar_Click);
            // 
            // BtnAct
            // 
            this.BtnAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnAct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnAct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnAct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAct.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold);
            this.BtnAct.ForeColor = System.Drawing.Color.White;
            this.BtnAct.Location = new System.Drawing.Point(544, 139);
            this.BtnAct.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAct.Name = "BtnAct";
            this.BtnAct.Size = new System.Drawing.Size(81, 27);
            this.BtnAct.TabIndex = 54;
            this.BtnAct.Text = "Actualizar";
            this.BtnAct.UseVisualStyleBackColor = false;
            this.BtnAct.Click += new System.EventHandler(this.BtnAct_Click);
            // 
            // FrmConsultarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.BtnAct);
            this.Controls.Add(this.BtnCCancelar);
            this.Controls.Add(this.BtnCRecepcion);
            this.Controls.Add(this.BtnCCobrar);
            this.Controls.Add(this.pnlTLogo);
            this.Controls.Add(this.DGVTurnocons);
            this.Controls.Add(this.BtnCVolver);
            this.Controls.Add(this.BtnTConsultarTurno);
            this.Controls.Add(this.LblTDCliente);
            this.Controls.Add(this.TxtTurnoConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultarTurno";
            this.Text = "FrmConsultarTurno";
            this.Load += new System.EventHandler(this.FrmConsultarTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTurnocons)).EndInit();
            this.pnlTLogo.ResumeLayout(false);
            this.pnlTLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTDCliente;
        private System.Windows.Forms.TextBox TxtTurnoConsulta;
        private System.Windows.Forms.Button BtnTConsultarTurno;
        private System.Windows.Forms.Button BtnCVolver;
        private System.Windows.Forms.Label LblCTurno;
        private System.Windows.Forms.Panel pnlTLogo;
        private System.Windows.Forms.DataGridView DGVTurnocons;
        private System.Windows.Forms.Button BtnCCobrar;
        private System.Windows.Forms.Button BtnCRecepcion;
        private System.Windows.Forms.Button BtnCCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button BtnAct;
    }
}