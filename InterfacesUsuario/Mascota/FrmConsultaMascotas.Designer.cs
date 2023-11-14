namespace GuarderiaCanina.InterfacesUsuario.Mascota
{
    partial class FrmConsultaMascotas
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
            this.components = new System.ComponentModel.Container();
            this.FrmContConsulta = new System.Windows.Forms.Panel();
            this.DGVConsulta = new System.Windows.Forms.DataGridView();
            this.id_mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_duenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreDuenio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblENMas = new System.Windows.Forms.Label();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.BtnMod = new System.Windows.Forms.Button();
            this.BtnECancelar = new System.Windows.Forms.Button();
            this.pAV_3K2_2022_4 = new GuarderiaCanina.PAV_3K2_2022_4();
            this.mascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotasTableAdapter = new GuarderiaCanina.PAV_3K2_2022_4TableAdapters.MascotasTableAdapter();
            this.FrmContConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmContConsulta
            // 
            this.FrmContConsulta.AutoSize = true;
            this.FrmContConsulta.BackColor = System.Drawing.SystemColors.Control;
            this.FrmContConsulta.Controls.Add(this.panel2);
            this.FrmContConsulta.Controls.Add(this.DGVConsulta);
            this.FrmContConsulta.Controls.Add(this.lblNombreDuenio);
            this.FrmContConsulta.Controls.Add(this.label3);
            this.FrmContConsulta.Controls.Add(this.btnSiguiente);
            this.FrmContConsulta.Controls.Add(this.BtnConsultar);
            this.FrmContConsulta.Controls.Add(this.btn_Crear);
            this.FrmContConsulta.Controls.Add(this.label4);
            this.FrmContConsulta.Controls.Add(this.BtnEliminar);
            this.FrmContConsulta.Controls.Add(this.LblENMas);
            this.FrmContConsulta.Controls.Add(this.TxtConsulta);
            this.FrmContConsulta.Controls.Add(this.BtnMod);
            this.FrmContConsulta.Controls.Add(this.BtnECancelar);
            this.FrmContConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmContConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FrmContConsulta.Location = new System.Drawing.Point(0, 0);
            this.FrmContConsulta.Name = "FrmContConsulta";
            this.FrmContConsulta.Size = new System.Drawing.Size(988, 658);
            this.FrmContConsulta.TabIndex = 49;
            // 
            // DGVConsulta
            // 
            this.DGVConsulta.AllowUserToAddRows = false;
            this.DGVConsulta.AllowUserToDeleteRows = false;
            this.DGVConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVConsulta.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_mascota,
            this.nombre,
            this.Edad,
            this.Sexo,
            this.Raza,
            this.Peso,
            this.id_duenio});
            this.DGVConsulta.Location = new System.Drawing.Point(30, 151);
            this.DGVConsulta.Name = "DGVConsulta";
            this.DGVConsulta.ReadOnly = true;
            this.DGVConsulta.Size = new System.Drawing.Size(810, 150);
            this.DGVConsulta.TabIndex = 52;
            // 
            // id_mascota
            // 
            this.id_mascota.HeaderText = "id_mascota";
            this.id_mascota.Name = "id_mascota";
            this.id_mascota.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // id_duenio
            // 
            this.id_duenio.HeaderText = "DNI del Dueño";
            this.id_duenio.Name = "id_duenio";
            this.id_duenio.ReadOnly = true;
            // 
            // lblNombreDuenio
            // 
            this.lblNombreDuenio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreDuenio.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombreDuenio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombreDuenio.Location = new System.Drawing.Point(645, 92);
            this.lblNombreDuenio.Name = "lblNombreDuenio";
            this.lblNombreDuenio.Size = new System.Drawing.Size(331, 30);
            this.lblNombreDuenio.TabIndex = 51;
            this.lblNombreDuenio.Text = "Mostrando mascotas de: {nombre cliente}";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 89);
            this.panel2.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::GuarderiaCanina.Properties.Resources.Perro_Color;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(17, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(79, 61);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(816, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar Mascota";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(856, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Selecciono la mascota?";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(831, 604);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(145, 42);
            this.btnSiguiente.TabIndex = 49;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
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
            this.BtnConsultar.Location = new System.Drawing.Point(461, 105);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(90, 30);
            this.BtnConsultar.TabIndex = 41;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.btn_Crear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.btn_Crear.ForeColor = System.Drawing.Color.White;
            this.btn_Crear.Location = new System.Drawing.Point(140, 326);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(90, 30);
            this.btn_Crear.TabIndex = 48;
            this.btn_Crear.Text = "Crear Mascota";
            this.btn_Crear.UseVisualStyleBackColor = false;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "No existe la mascota";
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
            this.BtnEliminar.Location = new System.Drawing.Point(877, 213);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(90, 30);
            this.BtnEliminar.TabIndex = 45;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // LblENMas
            // 
            this.LblENMas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblENMas.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.LblENMas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblENMas.Location = new System.Drawing.Point(68, 108);
            this.LblENMas.Name = "LblENMas";
            this.LblENMas.Size = new System.Drawing.Size(185, 30);
            this.LblENMas.TabIndex = 40;
            this.LblENMas.Text = "Nombre de la Mascota";
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtConsulta.Location = new System.Drawing.Point(274, 108);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(158, 20);
            this.TxtConsulta.TabIndex = 39;
            this.TxtConsulta.TextChanged += new System.EventHandler(this.TxtConsulta_TextChanged);
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
            this.BtnMod.Location = new System.Drawing.Point(877, 177);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(90, 30);
            this.BtnMod.TabIndex = 44;
            this.BtnMod.Text = "Modificar";
            this.BtnMod.UseVisualStyleBackColor = false;
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
            // pAV_3K2_2022_4
            // 
            this.pAV_3K2_2022_4.DataSetName = "PAV_3K2_2022_4";
            this.pAV_3K2_2022_4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mascotasBindingSource
            // 
            this.mascotasBindingSource.DataMember = "Mascotas";
            this.mascotasBindingSource.DataSource = this.pAV_3K2_2022_4;
            // 
            // mascotasTableAdapter
            // 
            this.mascotasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsultaMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 658);
            this.Controls.Add(this.FrmContConsulta);
            this.Name = "FrmConsultaMascotas";
            this.Text = "FrmConsultaMascotas";
            this.Load += new System.EventHandler(this.FrmConsultaMascotas_Load);
            this.FrmContConsulta.ResumeLayout(false);
            this.FrmContConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel FrmContConsulta;
        private System.Windows.Forms.Label lblNombreDuenio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblENMas;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.Button BtnECancelar;
        private System.Windows.Forms.DataGridView DGVConsulta;
        private PAV_3K2_2022_4 pAV_3K2_2022_4;
        private System.Windows.Forms.BindingSource mascotasBindingSource;
        private PAV_3K2_2022_4TableAdapters.MascotasTableAdapter mascotasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_duenio;
    }
}