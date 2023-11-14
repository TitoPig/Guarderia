using System;

namespace GuarderiaCanina.InterfacesUsuario
{
    partial class FrmAltaTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaTurno));
            this.BtnTCrearTurno = new System.Windows.Forms.Button();
            this.BtnTVolverMenu = new System.Windows.Forms.Button();
            this.BtnTCrearCliente = new System.Windows.Forms.Button();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.LblTFechaDesde = new System.Windows.Forms.Label();
            this.LblTFechaHasta = new System.Windows.Forms.Label();
            this.idCliente = new System.Windows.Forms.TextBox();
            this.LblTNombreMasc = new System.Windows.Forms.Label();
            this.LblTDCliente = new System.Windows.Forms.Label();
            this.BtnCrearMascota = new System.Windows.Forms.Button();
            this.LblTEmpleado = new System.Windows.Forms.Label();
            this.lblEEmpleado = new System.Windows.Forms.Label();
            this.pnlTLogo = new System.Windows.Forms.Panel();
            this.CmbTEmpleado = new System.Windows.Forms.ComboBox();
            this.CmbIdPerro = new System.Windows.Forms.ComboBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.LblTDatCliente = new System.Windows.Forms.Label();
            this.LblTCliente = new System.Windows.Forms.Label();
            this.LblTMascota = new System.Windows.Forms.Label();
            this.LblTDivisor = new System.Windows.Forms.Label();
            this.LblTServicios = new System.Windows.Forms.Label();
            this.DGVCliente = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVDT = new System.Windows.Forms.DataGridView();
            this.nombreServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxServicios = new System.Windows.Forms.ComboBox();
            this.numericServicios = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearDT = new System.Windows.Forms.Button();
            this.BtnQuitarServicio = new System.Windows.Forms.Button();
            this.pnlTLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTCrearTurno
            // 
            this.BtnTCrearTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTCrearTurno.AutoSize = true;
            this.BtnTCrearTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnTCrearTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTCrearTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTCrearTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTCrearTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTCrearTurno.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnTCrearTurno.ForeColor = System.Drawing.Color.White;
            this.BtnTCrearTurno.Location = new System.Drawing.Point(826, 602);
            this.BtnTCrearTurno.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTCrearTurno.Name = "BtnTCrearTurno";
            this.BtnTCrearTurno.Size = new System.Drawing.Size(148, 37);
            this.BtnTCrearTurno.TabIndex = 4;
            this.BtnTCrearTurno.Text = "Crear Turno";
            this.BtnTCrearTurno.UseVisualStyleBackColor = false;
            this.BtnTCrearTurno.Click += new System.EventHandler(this.BtnTCrearTurno_Click);
            // 
            // BtnTVolverMenu
            // 
            this.BtnTVolverMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTVolverMenu.AutoSize = true;
            this.BtnTVolverMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnTVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTVolverMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTVolverMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTVolverMenu.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnTVolverMenu.ForeColor = System.Drawing.Color.White;
            this.BtnTVolverMenu.Location = new System.Drawing.Point(13, 602);
            this.BtnTVolverMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTVolverMenu.Name = "BtnTVolverMenu";
            this.BtnTVolverMenu.Size = new System.Drawing.Size(112, 37);
            this.BtnTVolverMenu.TabIndex = 5;
            this.BtnTVolverMenu.Text = "<- Volver";
            this.BtnTVolverMenu.UseVisualStyleBackColor = false;
            this.BtnTVolverMenu.Click += new System.EventHandler(this.BtnTVolverMenu_Click);
            // 
            // BtnTCrearCliente
            // 
            this.BtnTCrearCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTCrearCliente.AutoSize = true;
            this.BtnTCrearCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnTCrearCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTCrearCliente.BackgroundImage")));
            this.BtnTCrearCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTCrearCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTCrearCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnTCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTCrearCliente.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnTCrearCliente.ForeColor = System.Drawing.Color.White;
            this.BtnTCrearCliente.Location = new System.Drawing.Point(677, 103);
            this.BtnTCrearCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTCrearCliente.Name = "BtnTCrearCliente";
            this.BtnTCrearCliente.Size = new System.Drawing.Size(140, 27);
            this.BtnTCrearCliente.TabIndex = 9;
            this.BtnTCrearCliente.Text = "Crear Cliente";
            this.BtnTCrearCliente.UseVisualStyleBackColor = false;
            this.BtnTCrearCliente.Click += new System.EventHandler(this.BtnTCrearCliente_Click);
            // 
            // fechaDesde
            // 
            this.fechaDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaDesde.CustomFormat = "dd/MM/yyyy";
            this.fechaDesde.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDesde.Location = new System.Drawing.Point(303, 315);
            this.fechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.fechaDesde.MaxDate = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.fechaDesde.MinDate = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(140, 23);
            this.fechaDesde.TabIndex = 12;
            this.fechaDesde.Value = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            this.fechaDesde.ValueChanged += new System.EventHandler(this.fechaDesde_ValueChanged);
            // 
            // fechaHasta
            // 
            this.fechaHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaHasta.CustomFormat = "d/MM/yyyy";
            this.fechaHasta.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaHasta.Location = new System.Drawing.Point(303, 352);
            this.fechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.fechaHasta.MaxDate = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.fechaHasta.MinDate = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(140, 23);
            this.fechaHasta.TabIndex = 12;
            this.fechaHasta.Value = new System.DateTime(2022, 11, 11, 0, 0, 0, 0);
            this.fechaHasta.ValueChanged += new System.EventHandler(this.fechaHasta_ValueChanged);
            // 
            // LblTFechaDesde
            // 
            this.LblTFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTFechaDesde.AutoSize = true;
            this.LblTFechaDesde.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold);
            this.LblTFechaDesde.Location = new System.Drawing.Point(157, 318);
            this.LblTFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTFechaDesde.Name = "LblTFechaDesde";
            this.LblTFechaDesde.Size = new System.Drawing.Size(96, 20);
            this.LblTFechaDesde.TabIndex = 13;
            this.LblTFechaDesde.Text = "Fecha Desde";
            // 
            // LblTFechaHasta
            // 
            this.LblTFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTFechaHasta.AutoSize = true;
            this.LblTFechaHasta.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold);
            this.LblTFechaHasta.Location = new System.Drawing.Point(158, 355);
            this.LblTFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTFechaHasta.Name = "LblTFechaHasta";
            this.LblTFechaHasta.Size = new System.Drawing.Size(93, 20);
            this.LblTFechaHasta.TabIndex = 15;
            this.LblTFechaHasta.Text = "Fecha Hasta";
            // 
            // idCliente
            // 
            this.idCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idCliente.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.idCliente.Location = new System.Drawing.Point(162, 103);
            this.idCliente.Margin = new System.Windows.Forms.Padding(4);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(304, 23);
            this.idCliente.TabIndex = 19;
            this.idCliente.Text = "0";
            this.idCliente.TextChanged += new System.EventHandler(this.idCliente_TextChanged);
            // 
            // LblTNombreMasc
            // 
            this.LblTNombreMasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTNombreMasc.AutoSize = true;
            this.LblTNombreMasc.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold);
            this.LblTNombreMasc.Location = new System.Drawing.Point(157, 252);
            this.LblTNombreMasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTNombreMasc.Name = "LblTNombreMasc";
            this.LblTNombreMasc.Size = new System.Drawing.Size(127, 20);
            this.LblTNombreMasc.TabIndex = 20;
            this.LblTNombreMasc.Text = "Mascota a elegir:";
            // 
            // LblTDCliente
            // 
            this.LblTDCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTDCliente.AutoSize = true;
            this.LblTDCliente.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold);
            this.LblTDCliente.Location = new System.Drawing.Point(158, 79);
            this.LblTDCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTDCliente.Name = "LblTDCliente";
            this.LblTDCliente.Size = new System.Drawing.Size(112, 20);
            this.LblTDCliente.TabIndex = 21;
            this.LblTDCliente.Text = "DNI del cliente";
            // 
            // BtnCrearMascota
            // 
            this.BtnCrearMascota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCrearMascota.AutoSize = true;
            this.BtnCrearMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnCrearMascota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCrearMascota.BackgroundImage")));
            this.BtnCrearMascota.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCrearMascota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCrearMascota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCrearMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearMascota.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnCrearMascota.ForeColor = System.Drawing.Color.White;
            this.BtnCrearMascota.Location = new System.Drawing.Point(677, 240);
            this.BtnCrearMascota.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCrearMascota.Name = "BtnCrearMascota";
            this.BtnCrearMascota.Size = new System.Drawing.Size(140, 27);
            this.BtnCrearMascota.TabIndex = 27;
            this.BtnCrearMascota.Text = "Crear Mascota";
            this.BtnCrearMascota.UseVisualStyleBackColor = false;
            this.BtnCrearMascota.Click += new System.EventHandler(this.BtnTCrearMascota_Click_1);
            // 
            // LblTEmpleado
            // 
            this.LblTEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTEmpleado.AutoSize = true;
            this.LblTEmpleado.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold);
            this.LblTEmpleado.Location = new System.Drawing.Point(158, 385);
            this.LblTEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTEmpleado.Name = "LblTEmpleado";
            this.LblTEmpleado.Size = new System.Drawing.Size(138, 20);
            this.LblTEmpleado.TabIndex = 30;
            this.LblTEmpleado.Text = "Empleado A Cargo";
            // 
            // lblEEmpleado
            // 
            this.lblEEmpleado.AutoSize = true;
            this.lblEEmpleado.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.lblEEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEEmpleado.Location = new System.Drawing.Point(17, 19);
            this.lblEEmpleado.Name = "lblEEmpleado";
            this.lblEEmpleado.Size = new System.Drawing.Size(170, 30);
            this.lblEEmpleado.TabIndex = 9;
            this.lblEEmpleado.Text = "Reservar Turno";
            // 
            // pnlTLogo
            // 
            this.pnlTLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.pnlTLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTLogo.Controls.Add(this.lblEEmpleado);
            this.pnlTLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlTLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTLogo.Name = "pnlTLogo";
            this.pnlTLogo.Size = new System.Drawing.Size(993, 62);
            this.pnlTLogo.TabIndex = 28;
            // 
            // CmbTEmpleado
            // 
            this.CmbTEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbTEmpleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmbTEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTEmpleado.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.CmbTEmpleado.FormattingEnabled = true;
            this.CmbTEmpleado.Location = new System.Drawing.Point(303, 384);
            this.CmbTEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbTEmpleado.Name = "CmbTEmpleado";
            this.CmbTEmpleado.Size = new System.Drawing.Size(140, 25);
            this.CmbTEmpleado.TabIndex = 1;
            this.CmbTEmpleado.SelectedIndexChanged += new System.EventHandler(this.CmbTEmpleado_SelectedIndexChanged);
            this.CmbTEmpleado.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbTEmpleado_Format);
            // 
            // CmbIdPerro
            // 
            this.CmbIdPerro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbIdPerro.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.CmbIdPerro.FormattingEnabled = true;
            this.CmbIdPerro.Location = new System.Drawing.Point(303, 250);
            this.CmbIdPerro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbIdPerro.Name = "CmbIdPerro";
            this.CmbIdPerro.Size = new System.Drawing.Size(308, 25);
            this.CmbIdPerro.TabIndex = 0;
            this.CmbIdPerro.Text = "Seleccionar";
            this.CmbIdPerro.SelectedIndexChanged += new System.EventHandler(this.CmbIdPerro_SelectedIndexChanged);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCheck.AutoSize = true;
            this.BtnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCheck.BackgroundImage")));
            this.BtnCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheck.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnCheck.ForeColor = System.Drawing.Color.White;
            this.BtnCheck.Location = new System.Drawing.Point(484, 103);
            this.BtnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(116, 27);
            this.BtnCheck.TabIndex = 31;
            this.BtnCheck.Text = "Chequear Datos";
            this.BtnCheck.UseVisualStyleBackColor = false;
            this.BtnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblTDatCliente
            // 
            this.LblTDatCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTDatCliente.AutoSize = true;
            this.LblTDatCliente.Font = new System.Drawing.Font("Ebrima", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblTDatCliente.Location = new System.Drawing.Point(158, 139);
            this.LblTDatCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTDatCliente.Name = "LblTDatCliente";
            this.LblTDatCliente.Size = new System.Drawing.Size(129, 20);
            this.LblTDatCliente.TabIndex = 32;
            this.LblTDatCliente.Text = "Datos Del Cliente";
            // 
            // LblTCliente
            // 
            this.LblTCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTCliente.AutoSize = true;
            this.LblTCliente.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.LblTCliente.Location = new System.Drawing.Point(676, 80);
            this.LblTCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTCliente.Name = "LblTCliente";
            this.LblTCliente.Size = new System.Drawing.Size(141, 19);
            this.LblTCliente.TabIndex = 36;
            this.LblTCliente.Text = "No Existe el cliente?";
            // 
            // LblTMascota
            // 
            this.LblTMascota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTMascota.AutoSize = true;
            this.LblTMascota.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.LblTMascota.Location = new System.Drawing.Point(673, 217);
            this.LblTMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTMascota.Name = "LblTMascota";
            this.LblTMascota.Size = new System.Drawing.Size(153, 19);
            this.LblTMascota.TabIndex = 37;
            this.LblTMascota.Text = "No Existe la mascota?";
            // 
            // LblTDivisor
            // 
            this.LblTDivisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTDivisor.AutoSize = true;
            this.LblTDivisor.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.LblTDivisor.Location = new System.Drawing.Point(140, 283);
            this.LblTDivisor.Name = "LblTDivisor";
            this.LblTDivisor.Size = new System.Drawing.Size(735, 19);
            this.LblTDivisor.TabIndex = 38;
            this.LblTDivisor.Text = "_________________________________________________________________________________" +
    "________________________________________";
            // 
            // LblTServicios
            // 
            this.LblTServicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTServicios.AutoSize = true;
            this.LblTServicios.Font = new System.Drawing.Font("Ebrima", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblTServicios.Location = new System.Drawing.Point(480, 355);
            this.LblTServicios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTServicios.Name = "LblTServicios";
            this.LblTServicios.Size = new System.Drawing.Size(70, 20);
            this.LblTServicios.TabIndex = 39;
            this.LblTServicios.Text = "Servicios";
            // 
            // DGVCliente
            // 
            this.DGVCliente.AllowUserToAddRows = false;
            this.DGVCliente.AllowUserToDeleteRows = false;
            this.DGVCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Direccion});
            this.DGVCliente.Location = new System.Drawing.Point(161, 174);
            this.DGVCliente.Name = "DGVCliente";
            this.DGVCliente.Size = new System.Drawing.Size(450, 62);
            this.DGVCliente.TabIndex = 44;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
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
            // DGVDT
            // 
            this.DGVDT.AllowUserToAddRows = false;
            this.DGVDT.AllowUserToDeleteRows = false;
            this.DGVDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreServicio,
            this.cantidad,
            this.preciounid,
            this.precioTotal,
            this.IdServicio});
            this.DGVDT.Location = new System.Drawing.Point(150, 476);
            this.DGVDT.Name = "DGVDT";
            this.DGVDT.ReadOnly = true;
            this.DGVDT.Size = new System.Drawing.Size(667, 150);
            this.DGVDT.TabIndex = 45;
            // 
            // nombreServicio
            // 
            this.nombreServicio.HeaderText = "Nombre";
            this.nombreServicio.Name = "nombreServicio";
            this.nombreServicio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // preciounid
            // 
            this.preciounid.HeaderText = "precio Unitario";
            this.preciounid.Name = "preciounid";
            this.preciounid.ReadOnly = true;
            // 
            // precioTotal
            // 
            this.precioTotal.HeaderText = "Precio Total";
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.ReadOnly = true;
            // 
            // IdServicio
            // 
            this.IdServicio.HeaderText = "Id del servicio";
            this.IdServicio.Name = "IdServicio";
            this.IdServicio.ReadOnly = true;
            this.IdServicio.Visible = false;
            // 
            // comboBoxServicios
            // 
            this.comboBoxServicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServicios.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxServicios.FormattingEnabled = true;
            this.comboBoxServicios.Items.AddRange(new object[] {
            "Banio",
            "Paseo",
            "Veterinario",
            "Comida"});
            this.comboBoxServicios.Location = new System.Drawing.Point(484, 379);
            this.comboBoxServicios.Name = "comboBoxServicios";
            this.comboBoxServicios.Size = new System.Drawing.Size(145, 25);
            this.comboBoxServicios.TabIndex = 46;
            this.comboBoxServicios.SelectedIndexChanged += new System.EventHandler(this.comboBoxServicios_SelectedIndexChanged);
            // 
            // numericServicios
            // 
            this.numericServicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericServicios.Location = new System.Drawing.Point(648, 378);
            this.numericServicios.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericServicios.Name = "numericServicios";
            this.numericServicios.Size = new System.Drawing.Size(40, 24);
            this.numericServicios.TabIndex = 47;
            this.numericServicios.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(146, 442);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Servicios del Turno";
            // 
            // btnCrearDT
            // 
            this.btnCrearDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearDT.AutoSize = true;
            this.btnCrearDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.btnCrearDT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearDT.BackgroundImage")));
            this.btnCrearDT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCrearDT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCrearDT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCrearDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearDT.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnCrearDT.ForeColor = System.Drawing.Color.White;
            this.btnCrearDT.Location = new System.Drawing.Point(695, 378);
            this.btnCrearDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearDT.Name = "btnCrearDT";
            this.btnCrearDT.Size = new System.Drawing.Size(140, 27);
            this.btnCrearDT.TabIndex = 50;
            this.btnCrearDT.Text = "Agregar Servicio";
            this.btnCrearDT.UseVisualStyleBackColor = false;
            this.btnCrearDT.Click += new System.EventHandler(this.btnCrearDT_Click);
            // 
            // BtnQuitarServicio
            // 
            this.BtnQuitarServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnQuitarServicio.AutoSize = true;
            this.BtnQuitarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnQuitarServicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnQuitarServicio.BackgroundImage")));
            this.BtnQuitarServicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnQuitarServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnQuitarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnQuitarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitarServicio.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnQuitarServicio.ForeColor = System.Drawing.Color.White;
            this.BtnQuitarServicio.Location = new System.Drawing.Point(303, 440);
            this.BtnQuitarServicio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnQuitarServicio.Name = "BtnQuitarServicio";
            this.BtnQuitarServicio.Size = new System.Drawing.Size(140, 27);
            this.BtnQuitarServicio.TabIndex = 51;
            this.BtnQuitarServicio.Text = "Quitar Servicio";
            this.BtnQuitarServicio.UseVisualStyleBackColor = false;
            this.BtnQuitarServicio.Click += new System.EventHandler(this.BtnQuitarServicio_Click);
            // 
            // FrmAltaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BackgroundImage = global::GuarderiaCanina.Properties.Resources.ImagenFondoOscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(988, 658);
            this.Controls.Add(this.BtnQuitarServicio);
            this.Controls.Add(this.btnCrearDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericServicios);
            this.Controls.Add(this.comboBoxServicios);
            this.Controls.Add(this.DGVDT);
            this.Controls.Add(this.DGVCliente);
            this.Controls.Add(this.LblTServicios);
            this.Controls.Add(this.LblTMascota);
            this.Controls.Add(this.LblTCliente);
            this.Controls.Add(this.LblTDatCliente);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.pnlTLogo);
            this.Controls.Add(this.LblTEmpleado);
            this.Controls.Add(this.BtnCrearMascota);
            this.Controls.Add(this.LblTDCliente);
            this.Controls.Add(this.LblTNombreMasc);
            this.Controls.Add(this.idCliente);
            this.Controls.Add(this.CmbTEmpleado);
            this.Controls.Add(this.CmbIdPerro);
            this.Controls.Add(this.LblTFechaHasta);
            this.Controls.Add(this.LblTFechaDesde);
            this.Controls.Add(this.fechaHasta);
            this.Controls.Add(this.fechaDesde);
            this.Controls.Add(this.BtnTCrearCliente);
            this.Controls.Add(this.BtnTVolverMenu);
            this.Controls.Add(this.BtnTCrearTurno);
            this.Controls.Add(this.LblTDivisor);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAltaTurno";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.FrmATurno_Load);
            this.pnlTLogo.ResumeLayout(false);
            this.pnlTLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button BtnTCrearTurno;
        private System.Windows.Forms.Button BtnTVolverMenu;
        private System.Windows.Forms.Button BtnTCrearCliente;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.Label LblTFechaDesde;
        private System.Windows.Forms.Label LblTFechaHasta;
        private System.Windows.Forms.TextBox idCliente;
        private System.Windows.Forms.Label LblTNombreMasc;
        private System.Windows.Forms.Label LblTDCliente;
        private System.Windows.Forms.Button BtnCrearMascota;
        private System.Windows.Forms.Label LblTEmpleado;
        private System.Windows.Forms.Label lblEEmpleado;
        private System.Windows.Forms.Panel pnlTLogo;
        private System.Windows.Forms.ComboBox CmbIdPerro;
        private System.Windows.Forms.ComboBox CmbTEmpleado;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Label LblTDatCliente;
        private System.Windows.Forms.Label LblTCliente;
        private System.Windows.Forms.Label LblTMascota;
        private System.Windows.Forms.Label LblTDivisor;
        private System.Windows.Forms.Label LblTServicios;
        private System.Windows.Forms.DataGridView DGVCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridView DGVDT;
        private System.Windows.Forms.ComboBox comboBoxServicios;
        private System.Windows.Forms.NumericUpDown numericServicios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounid;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
        private System.Windows.Forms.Button BtnQuitarServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdServicio;
    }
}