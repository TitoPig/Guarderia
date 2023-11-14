namespace GuarderiaCanina.InterfacesUsuario
{
    partial class FrmAltaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaEmpleado));
            this.BtnECancelar = new System.Windows.Forms.Button();
            this.BtnEGuardar = new System.Windows.Forms.Button();
            this.TxtEApellido = new System.Windows.Forms.TextBox();
            this.TxtENombre = new System.Windows.Forms.TextBox();
            this.TxtENDoc = new System.Windows.Forms.TextBox();
            this.TxtETelefono = new System.Windows.Forms.TextBox();
            this.TxtEDir = new System.Windows.Forms.TextBox();
            this.LblEApellido = new System.Windows.Forms.Label();
            this.LblENombre = new System.Windows.Forms.Label();
            this.LblETelefono = new System.Windows.Forms.Label();
            this.LblENdoc = new System.Windows.Forms.Label();
            this.LblEDireccion = new System.Windows.Forms.Label();
            this.lblEEmpleado = new System.Windows.Forms.Label();
            this.pnlELogo = new System.Windows.Forms.Panel();
            this.lblrol = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.CMBRol = new System.Windows.Forms.ComboBox();
            this.pnlELogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnECancelar
            // 
            this.BtnECancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnECancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnECancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnECancelar.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnECancelar.ForeColor = System.Drawing.Color.White;
            this.BtnECancelar.Location = new System.Drawing.Point(495, 519);
            this.BtnECancelar.Name = "BtnECancelar";
            this.BtnECancelar.Size = new System.Drawing.Size(90, 30);
            this.BtnECancelar.TabIndex = 4;
            this.BtnECancelar.Text = "Cancelar";
            this.BtnECancelar.UseVisualStyleBackColor = false;
            this.BtnECancelar.Click += new System.EventHandler(this.BtnECancelar_Click);
            // 
            // BtnEGuardar
            // 
            this.BtnEGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnEGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnEGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnEGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnEGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEGuardar.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnEGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnEGuardar.Location = new System.Drawing.Point(602, 519);
            this.BtnEGuardar.Name = "BtnEGuardar";
            this.BtnEGuardar.Size = new System.Drawing.Size(90, 30);
            this.BtnEGuardar.TabIndex = 3;
            this.BtnEGuardar.Text = "Guardar";
            this.BtnEGuardar.UseVisualStyleBackColor = false;
            this.BtnEGuardar.Click += new System.EventHandler(this.BtnEGuardar_Click);
            // 
            // TxtEApellido
            // 
            this.TxtEApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEApellido.Location = new System.Drawing.Point(504, 168);
            this.TxtEApellido.Name = "TxtEApellido";
            this.TxtEApellido.Size = new System.Drawing.Size(133, 20);
            this.TxtEApellido.TabIndex = 11;
            // 
            // TxtENombre
            // 
            this.TxtENombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtENombre.Location = new System.Drawing.Point(232, 168);
            this.TxtENombre.Name = "TxtENombre";
            this.TxtENombre.Size = new System.Drawing.Size(157, 20);
            this.TxtENombre.TabIndex = 12;
            // 
            // TxtENDoc
            // 
            this.TxtENDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtENDoc.Location = new System.Drawing.Point(232, 212);
            this.TxtENDoc.Name = "TxtENDoc";
            this.TxtENDoc.Size = new System.Drawing.Size(158, 20);
            this.TxtENDoc.TabIndex = 13;
            // 
            // TxtETelefono
            // 
            this.TxtETelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtETelefono.Location = new System.Drawing.Point(504, 212);
            this.TxtETelefono.Name = "TxtETelefono";
            this.TxtETelefono.Size = new System.Drawing.Size(133, 20);
            this.TxtETelefono.TabIndex = 14;
            // 
            // TxtEDir
            // 
            this.TxtEDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEDir.Location = new System.Drawing.Point(232, 294);
            this.TxtEDir.Multiline = true;
            this.TxtEDir.Name = "TxtEDir";
            this.TxtEDir.Size = new System.Drawing.Size(405, 65);
            this.TxtEDir.TabIndex = 15;
            // 
            // LblEApellido
            // 
            this.LblEApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblEApellido.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblEApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblEApellido.Location = new System.Drawing.Point(395, 168);
            this.LblEApellido.Name = "LblEApellido";
            this.LblEApellido.Size = new System.Drawing.Size(77, 20);
            this.LblEApellido.TabIndex = 19;
            this.LblEApellido.Text = "Apellido";
            // 
            // LblENombre
            // 
            this.LblENombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblENombre.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblENombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblENombre.Location = new System.Drawing.Point(91, 168);
            this.LblENombre.Name = "LblENombre";
            this.LblENombre.Size = new System.Drawing.Size(75, 20);
            this.LblENombre.TabIndex = 20;
            this.LblENombre.Text = "Nombre";
            // 
            // LblETelefono
            // 
            this.LblETelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblETelefono.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblETelefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblETelefono.Location = new System.Drawing.Point(396, 212);
            this.LblETelefono.Name = "LblETelefono";
            this.LblETelefono.Size = new System.Drawing.Size(85, 20);
            this.LblETelefono.TabIndex = 21;
            this.LblETelefono.Text = "Telefono";
            // 
            // LblENdoc
            // 
            this.LblENdoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblENdoc.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblENdoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblENdoc.Location = new System.Drawing.Point(91, 212);
            this.LblENdoc.Name = "LblENdoc";
            this.LblENdoc.Size = new System.Drawing.Size(135, 30);
            this.LblENdoc.TabIndex = 22;
            this.LblENdoc.Text = "Nro Documento";
            // 
            // LblEDireccion
            // 
            this.LblEDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblEDireccion.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblEDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblEDireccion.Location = new System.Drawing.Point(91, 294);
            this.LblEDireccion.Name = "LblEDireccion";
            this.LblEDireccion.Size = new System.Drawing.Size(84, 25);
            this.LblEDireccion.TabIndex = 23;
            this.LblEDireccion.Text = "Direccion";
            // 
            // lblEEmpleado
            // 
            this.lblEEmpleado.AutoSize = true;
            this.lblEEmpleado.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.lblEEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEEmpleado.Location = new System.Drawing.Point(19, 23);
            this.lblEEmpleado.Name = "lblEEmpleado";
            this.lblEEmpleado.Size = new System.Drawing.Size(207, 30);
            this.lblEEmpleado.TabIndex = 9;
            this.lblEEmpleado.Text = "Agregar Empleado";
            // 
            // pnlELogo
            // 
            this.pnlELogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.pnlELogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlELogo.Controls.Add(this.lblEEmpleado);
            this.pnlELogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlELogo.Location = new System.Drawing.Point(0, 0);
            this.pnlELogo.Name = "pnlELogo";
            this.pnlELogo.Size = new System.Drawing.Size(704, 74);
            this.pnlELogo.TabIndex = 24;
            // 
            // lblrol
            // 
            this.lblrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblrol.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.lblrol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblrol.Location = new System.Drawing.Point(91, 254);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(135, 30);
            this.lblrol.TabIndex = 28;
            this.lblrol.Text = "Rol: ";
            // 
            // LblContraseña
            // 
            this.LblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblContraseña.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblContraseña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblContraseña.Location = new System.Drawing.Point(396, 254);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(102, 20);
            this.LblContraseña.TabIndex = 27;
            this.LblContraseña.Text = "Contraseña: ";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtContraseña.Location = new System.Drawing.Point(504, 254);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(133, 20);
            this.TxtContraseña.TabIndex = 26;
            // 
            // CMBRol
            // 
            this.CMBRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CMBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBRol.FormattingEnabled = true;
            this.CMBRol.Items.AddRange(new object[] {
            "administrador",
            "empleado"});
            this.CMBRol.Location = new System.Drawing.Point(233, 254);
            this.CMBRol.Name = "CMBRol";
            this.CMBRol.Size = new System.Drawing.Size(156, 21);
            this.CMBRol.TabIndex = 29;
            this.CMBRol.SelectedIndexChanged += new System.EventHandler(this.CMBRol_SelectedIndexChanged);
            // 
            // FrmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.CMBRol);
            this.Controls.Add(this.lblrol);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.pnlELogo);
            this.Controls.Add(this.LblEDireccion);
            this.Controls.Add(this.LblENdoc);
            this.Controls.Add(this.LblETelefono);
            this.Controls.Add(this.LblENombre);
            this.Controls.Add(this.LblEApellido);
            this.Controls.Add(this.TxtEDir);
            this.Controls.Add(this.TxtETelefono);
            this.Controls.Add(this.TxtENDoc);
            this.Controls.Add(this.TxtENombre);
            this.Controls.Add(this.TxtEApellido);
            this.Controls.Add(this.BtnECancelar);
            this.Controls.Add(this.BtnEGuardar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FrmAEmpleado_Load);
            this.pnlELogo.ResumeLayout(false);
            this.pnlELogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnECancelar;
        private System.Windows.Forms.Button BtnEGuardar;
        private System.Windows.Forms.TextBox TxtEApellido;
        private System.Windows.Forms.TextBox TxtENombre;
        private System.Windows.Forms.TextBox TxtENDoc;
        private System.Windows.Forms.TextBox TxtETelefono;
        private System.Windows.Forms.TextBox TxtEDir;
        private System.Windows.Forms.Label LblEApellido;
        private System.Windows.Forms.Label LblENombre;
        private System.Windows.Forms.Label LblETelefono;
        private System.Windows.Forms.Label LblENdoc;
        private System.Windows.Forms.Label LblEDireccion;
        private System.Windows.Forms.Label lblEEmpleado;
        private System.Windows.Forms.Panel pnlELogo;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.ComboBox CMBRol;
    }
}