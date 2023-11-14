namespace GuarderiaCanina.InterfacesUsuario
{
    partial class FrmConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCliente));
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.DGVConsulta = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnECancelar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.LblENdoc = new System.Windows.Forms.Label();
            this.TxtDNIConsulta = new System.Windows.Forms.TextBox();
            this.pnlELogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FrmContConsulta = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CrearCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).BeginInit();
            this.pnlELogo.SuspendLayout();
            this.FrmContConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(886, 213);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(90, 30);
            this.BtnEliminar.TabIndex = 45;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMod.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnMod.ForeColor = System.Drawing.Color.White;
            this.BtnMod.Location = new System.Drawing.Point(886, 177);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(90, 30);
            this.BtnMod.TabIndex = 44;
            this.BtnMod.Text = "Modificar";
            this.BtnMod.UseVisualStyleBackColor = false;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
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
            this.Telefono,
            this.Direccion});
            this.DGVConsulta.Location = new System.Drawing.Point(17, 151);
            this.DGVConsulta.MultiSelect = false;
            this.DGVConsulta.Name = "DGVConsulta";
            this.DGVConsulta.ReadOnly = true;
            this.DGVConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVConsulta.Size = new System.Drawing.Size(827, 260);
            this.DGVConsulta.TabIndex = 43;
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
            this.BtnECancelar.Location = new System.Drawing.Point(17, 604);
            this.BtnECancelar.Name = "BtnECancelar";
            this.BtnECancelar.Size = new System.Drawing.Size(145, 42);
            this.BtnECancelar.TabIndex = 42;
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
            this.BtnConsultar.Location = new System.Drawing.Point(491, 105);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(90, 30);
            this.BtnConsultar.TabIndex = 41;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // LblENdoc
            // 
            this.LblENdoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblENdoc.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblENdoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblENdoc.Location = new System.Drawing.Point(185, 105);
            this.LblENdoc.Name = "LblENdoc";
            this.LblENdoc.Size = new System.Drawing.Size(135, 30);
            this.LblENdoc.TabIndex = 40;
            this.LblENdoc.Text = "Nro Documento";
            // 
            // TxtDNIConsulta
            // 
            this.TxtDNIConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtDNIConsulta.Location = new System.Drawing.Point(327, 108);
            this.TxtDNIConsulta.Name = "TxtDNIConsulta";
            this.TxtDNIConsulta.Size = new System.Drawing.Size(158, 20);
            this.TxtDNIConsulta.TabIndex = 39;
            // 
            // pnlELogo
            // 
            this.pnlELogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlELogo.AutoSize = true;
            this.pnlELogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.pnlELogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlELogo.Controls.Add(this.panel1);
            this.pnlELogo.Controls.Add(this.label1);
            this.pnlELogo.Location = new System.Drawing.Point(0, 0);
            this.pnlELogo.Name = "pnlELogo";
            this.pnlELogo.Size = new System.Drawing.Size(988, 89);
            this.pnlELogo.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GuarderiaCanina.Properties.Resources.Perro_Color;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 61);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(816, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar Cliente";
            // 
            // FrmContConsulta
            // 
            this.FrmContConsulta.AutoSize = true;
            this.FrmContConsulta.BackColor = System.Drawing.SystemColors.Control;
            this.FrmContConsulta.Controls.Add(this.BtnActualizar);
            this.FrmContConsulta.Controls.Add(this.pnlELogo);
            this.FrmContConsulta.Controls.Add(this.label2);
            this.FrmContConsulta.Controls.Add(this.BtnConsultar);
            this.FrmContConsulta.Controls.Add(this.btn_CrearCliente);
            this.FrmContConsulta.Controls.Add(this.label3);
            this.FrmContConsulta.Controls.Add(this.BtnEliminar);
            this.FrmContConsulta.Controls.Add(this.LblENdoc);
            this.FrmContConsulta.Controls.Add(this.TxtDNIConsulta);
            this.FrmContConsulta.Controls.Add(this.BtnMod);
            this.FrmContConsulta.Controls.Add(this.BtnECancelar);
            this.FrmContConsulta.Controls.Add(this.DGVConsulta);
            this.FrmContConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmContConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FrmContConsulta.Location = new System.Drawing.Point(0, 0);
            this.FrmContConsulta.Name = "FrmContConsulta";
            this.FrmContConsulta.Size = new System.Drawing.Size(988, 658);
            this.FrmContConsulta.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(865, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Selecciono el cliente?";
            // 
            // btn_CrearCliente
            // 
            this.btn_CrearCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.btn_CrearCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_CrearCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_CrearCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_CrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearCliente.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.btn_CrearCliente.ForeColor = System.Drawing.Color.White;
            this.btn_CrearCliente.Location = new System.Drawing.Point(122, 418);
            this.btn_CrearCliente.Name = "btn_CrearCliente";
            this.btn_CrearCliente.Size = new System.Drawing.Size(90, 30);
            this.btn_CrearCliente.TabIndex = 48;
            this.btn_CrearCliente.Text = "Crear Cliente";
            this.btn_CrearCliente.UseVisualStyleBackColor = false;
            this.btn_CrearCliente.Click += new System.EventHandler(this.btn_CrearCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "No existe el cliente?";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(596, 105);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(90, 30);
            this.BtnActualizar.TabIndex = 51;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 658);
            this.Controls.Add(this.FrmContConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaCliente";
            this.Text = "FrmClienteConsulta";
            this.Load += new System.EventHandler(this.FrmClienteConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).EndInit();
            this.pnlELogo.ResumeLayout(false);
            this.pnlELogo.PerformLayout();
            this.FrmContConsulta.ResumeLayout(false);
            this.FrmContConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.DataGridView DGVConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Button BtnECancelar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label LblENdoc;
        private System.Windows.Forms.TextBox TxtDNIConsulta;
        private System.Windows.Forms.Panel pnlELogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CrearCliente;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel FrmContConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnActualizar;
    }
}