namespace GuarderiaCanina.InterfacesUsuario
{
    partial class FrmConsultaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaEmpleado));
            this.pnlELogo = new System.Windows.Forms.Panel();
            this.lblEEmpleadoConsulta = new System.Windows.Forms.Label();
            this.LblENdoc = new System.Windows.Forms.Label();
            this.TxtDNIConsulta = new System.Windows.Forms.TextBox();
            this.BtnECancelar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.DGVConsulta = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlELogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlELogo
            // 
            this.pnlELogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.pnlELogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlELogo.Controls.Add(this.lblEEmpleadoConsulta);
            this.pnlELogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlELogo.Location = new System.Drawing.Point(0, 0);
            this.pnlELogo.Name = "pnlELogo";
            this.pnlELogo.Size = new System.Drawing.Size(704, 74);
            this.pnlELogo.TabIndex = 25;
            this.pnlELogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlELogo_Paint);
            // 
            // lblEEmpleadoConsulta
            // 
            this.lblEEmpleadoConsulta.AutoSize = true;
            this.lblEEmpleadoConsulta.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.lblEEmpleadoConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEEmpleadoConsulta.Location = new System.Drawing.Point(12, 22);
            this.lblEEmpleadoConsulta.Name = "lblEEmpleadoConsulta";
            this.lblEEmpleadoConsulta.Size = new System.Drawing.Size(221, 30);
            this.lblEEmpleadoConsulta.TabIndex = 9;
            this.lblEEmpleadoConsulta.Text = "Consultar Empleado";
            this.lblEEmpleadoConsulta.Click += new System.EventHandler(this.lblEEmpleadoConsulta_Click);
            // 
            // LblENdoc
            // 
            this.LblENdoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblENdoc.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblENdoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblENdoc.Location = new System.Drawing.Point(59, 175);
            this.LblENdoc.Name = "LblENdoc";
            this.LblENdoc.Size = new System.Drawing.Size(135, 30);
            this.LblENdoc.TabIndex = 33;
            this.LblENdoc.Text = "Nro Documento";
            // 
            // TxtDNIConsulta
            // 
            this.TxtDNIConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtDNIConsulta.Location = new System.Drawing.Point(201, 178);
            this.TxtDNIConsulta.Name = "TxtDNIConsulta";
            this.TxtDNIConsulta.Size = new System.Drawing.Size(158, 20);
            this.TxtDNIConsulta.TabIndex = 28;
            this.TxtDNIConsulta.TextChanged += new System.EventHandler(this.TxtDNIConsulta_TextChanged);
            // 
            // BtnECancelar
            // 
            this.BtnECancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnECancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnECancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnECancelar.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnECancelar.ForeColor = System.Drawing.Color.White;
            this.BtnECancelar.Location = new System.Drawing.Point(527, 452);
            this.BtnECancelar.Name = "BtnECancelar";
            this.BtnECancelar.Size = new System.Drawing.Size(90, 30);
            this.BtnECancelar.TabIndex = 35;
            this.BtnECancelar.Text = "Volver";
            this.BtnECancelar.UseVisualStyleBackColor = false;
            this.BtnECancelar.Click += new System.EventHandler(this.BtnECancelar_Click);
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
            this.BtnConsultar.Location = new System.Drawing.Point(527, 178);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(90, 30);
            this.BtnConsultar.TabIndex = 34;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // DGVConsulta
            // 
            this.DGVConsulta.AllowUserToAddRows = false;
            this.DGVConsulta.AllowUserToDeleteRows = false;
            this.DGVConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.DGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Rol,
            this.Telefono,
            this.Direccion});
            this.DGVConsulta.Location = new System.Drawing.Point(63, 273);
            this.DGVConsulta.MultiSelect = false;
            this.DGVConsulta.Name = "DGVConsulta";
            this.DGVConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVConsulta.Size = new System.Drawing.Size(583, 106);
            this.DGVConsulta.TabIndex = 36;
            this.DGVConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVConsulta_CellContentClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(413, 452);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(90, 30);
            this.BtnEliminar.TabIndex = 38;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Dni
            // 
            this.Dni.HeaderText = "DNI";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // FrmConsultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.DGVConsulta);
            this.Controls.Add(this.BtnECancelar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.LblENdoc);
            this.Controls.Add(this.TxtDNIConsulta);
            this.Controls.Add(this.pnlELogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaEmpleado";
            this.Text = "FrmAEmpleadoConsulta";
            this.Load += new System.EventHandler(this.FrmAEmpleadoConsulta_Load);
            this.pnlELogo.ResumeLayout(false);
            this.pnlELogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlELogo;
        private System.Windows.Forms.Label lblEEmpleadoConsulta;
        private System.Windows.Forms.Label LblENdoc;
        private System.Windows.Forms.TextBox TxtDNIConsulta;
        private System.Windows.Forms.Button BtnECancelar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridView DGVConsulta;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}