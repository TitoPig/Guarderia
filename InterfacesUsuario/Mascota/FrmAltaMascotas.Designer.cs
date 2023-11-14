namespace GuarderiaCanina.InterfacesUsuario
{
    partial class FrmAltaMascotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaMascotas));
            this.TxtMNombre = new System.Windows.Forms.TextBox();
            this.lblMEdad = new System.Windows.Forms.Label();
            this.lblMSexo = new System.Windows.Forms.Label();
            this.lblMPeso = new System.Windows.Forms.Label();
            this.CmbMSexo = new System.Windows.Forms.ComboBox();
            this.TxtMEdad = new System.Windows.Forms.NumericUpDown();
            this.NumMPeso = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblMMascota = new System.Windows.Forms.Label();
            this.lblMRaza = new System.Windows.Forms.Label();
            this.lblMNombre = new System.Windows.Forms.Label();
            this.TxtMRaza = new System.Windows.Forms.TextBox();
            this.btnMFinalizar = new System.Windows.Forms.Button();
            this.BtnECancelar = new System.Windows.Forms.Button();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMPeso)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtMNombre
            // 
            this.TxtMNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtMNombre.Location = new System.Drawing.Point(119, 198);
            this.TxtMNombre.Name = "TxtMNombre";
            this.TxtMNombre.Size = new System.Drawing.Size(199, 21);
            this.TxtMNombre.TabIndex = 4;
            // 
            // lblMEdad
            // 
            this.lblMEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMEdad.AutoSize = true;
            this.lblMEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblMEdad.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.lblMEdad.Location = new System.Drawing.Point(20, 268);
            this.lblMEdad.Name = "lblMEdad";
            this.lblMEdad.Size = new System.Drawing.Size(54, 21);
            this.lblMEdad.TabIndex = 6;
            this.lblMEdad.Text = "EDAD";
            // 
            // lblMSexo
            // 
            this.lblMSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMSexo.AutoSize = true;
            this.lblMSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblMSexo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.lblMSexo.Location = new System.Drawing.Point(20, 305);
            this.lblMSexo.Name = "lblMSexo";
            this.lblMSexo.Size = new System.Drawing.Size(50, 21);
            this.lblMSexo.TabIndex = 7;
            this.lblMSexo.Text = "SEXO";
            // 
            // lblMPeso
            // 
            this.lblMPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMPeso.AutoSize = true;
            this.lblMPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblMPeso.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.lblMPeso.Location = new System.Drawing.Point(20, 345);
            this.lblMPeso.Name = "lblMPeso";
            this.lblMPeso.Size = new System.Drawing.Size(50, 21);
            this.lblMPeso.TabIndex = 8;
            this.lblMPeso.Text = "PESO";
            // 
            // CmbMSexo
            // 
            this.CmbMSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbMSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmbMSexo.FormattingEnabled = true;
            this.CmbMSexo.Items.AddRange(new object[] {
            "M",
            "H"});
            this.CmbMSexo.Location = new System.Drawing.Point(119, 304);
            this.CmbMSexo.Name = "CmbMSexo";
            this.CmbMSexo.Size = new System.Drawing.Size(199, 23);
            this.CmbMSexo.TabIndex = 12;
            // 
            // TxtMEdad
            // 
            this.TxtMEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtMEdad.Location = new System.Drawing.Point(119, 268);
            this.TxtMEdad.Name = "TxtMEdad";
            this.TxtMEdad.Size = new System.Drawing.Size(199, 21);
            this.TxtMEdad.TabIndex = 13;
            // 
            // NumMPeso
            // 
            this.NumMPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumMPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NumMPeso.Location = new System.Drawing.Point(119, 344);
            this.NumMPeso.Name = "NumMPeso";
            this.NumMPeso.Size = new System.Drawing.Size(199, 21);
            this.NumMPeso.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Turnos";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogo.Controls.Add(this.lblMMascota);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(988, 74);
            this.pnlLogo.TabIndex = 16;
            // 
            // lblMMascota
            // 
            this.lblMMascota.AutoSize = true;
            this.lblMMascota.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.lblMMascota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMMascota.Location = new System.Drawing.Point(19, 23);
            this.lblMMascota.Name = "lblMMascota";
            this.lblMMascota.Size = new System.Drawing.Size(192, 30);
            this.lblMMascota.TabIndex = 9;
            this.lblMMascota.Text = "Agregar Mascota";
            // 
            // lblMRaza
            // 
            this.lblMRaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMRaza.AutoSize = true;
            this.lblMRaza.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.lblMRaza.Location = new System.Drawing.Point(22, 232);
            this.lblMRaza.Name = "lblMRaza";
            this.lblMRaza.Size = new System.Drawing.Size(52, 21);
            this.lblMRaza.TabIndex = 17;
            this.lblMRaza.Text = "RAZA";
            // 
            // lblMNombre
            // 
            this.lblMNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMNombre.AutoSize = true;
            this.lblMNombre.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.lblMNombre.Location = new System.Drawing.Point(20, 195);
            this.lblMNombre.Name = "lblMNombre";
            this.lblMNombre.Size = new System.Drawing.Size(79, 21);
            this.lblMNombre.TabIndex = 5;
            this.lblMNombre.Text = "NOMBRE";
            // 
            // TxtMRaza
            // 
            this.TxtMRaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtMRaza.Location = new System.Drawing.Point(119, 235);
            this.TxtMRaza.Name = "TxtMRaza";
            this.TxtMRaza.Size = new System.Drawing.Size(199, 21);
            this.TxtMRaza.TabIndex = 18;
            // 
            // btnMFinalizar
            // 
            this.btnMFinalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.btnMFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnMFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnMFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnMFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMFinalizar.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnMFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnMFinalizar.Location = new System.Drawing.Point(858, 599);
            this.btnMFinalizar.Name = "btnMFinalizar";
            this.btnMFinalizar.Size = new System.Drawing.Size(118, 36);
            this.btnMFinalizar.TabIndex = 19;
            this.btnMFinalizar.Text = "Registrar";
            this.btnMFinalizar.UseVisualStyleBackColor = false;
            this.btnMFinalizar.Click += new System.EventHandler(this.BtnMFinalizar_Click);

            // 
            // BtnECancelar
            // 
            this.BtnECancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnECancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.BtnECancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnECancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnECancelar.Font = new System.Drawing.Font("Ebrima", 8.75F, System.Drawing.FontStyle.Bold);
            this.BtnECancelar.ForeColor = System.Drawing.Color.White;
            this.BtnECancelar.Location = new System.Drawing.Point(721, 599);
            this.BtnECancelar.Name = "BtnECancelar";
            this.BtnECancelar.Size = new System.Drawing.Size(118, 36);
            this.BtnECancelar.TabIndex = 20;
            this.BtnECancelar.Text = "Cancelar";
            this.BtnECancelar.UseVisualStyleBackColor = false;
            this.BtnECancelar.Click += new System.EventHandler(this.BtnECancelar_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtCliente.Location = new System.Drawing.Point(403, 101);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(199, 21);
            this.TxtCliente.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(471, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "CLIENTE";
            // 
            // FrmAltaMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(988, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.BtnECancelar);
            this.Controls.Add(this.btnMFinalizar);
            this.Controls.Add(this.TxtMRaza);
            this.Controls.Add(this.lblMRaza);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumMPeso);
            this.Controls.Add(this.TxtMEdad);
            this.Controls.Add(this.CmbMSexo);
            this.Controls.Add(this.lblMPeso);
            this.Controls.Add(this.lblMSexo);
            this.Controls.Add(this.lblMEdad);
            this.Controls.Add(this.lblMNombre);
            this.Controls.Add(this.TxtMNombre);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAltaMascotas";
            this.Text = "FrmAMascotas";
            this.Load += new System.EventHandler(this.FrmAMascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMPeso)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMNombre;
        private System.Windows.Forms.Label lblMEdad;
        private System.Windows.Forms.Label lblMSexo;
        private System.Windows.Forms.Label lblMPeso;
        private System.Windows.Forms.ComboBox CmbMSexo;
        private System.Windows.Forms.NumericUpDown TxtMEdad;
        private System.Windows.Forms.NumericUpDown NumMPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblMMascota;
        private System.Windows.Forms.Label lblMRaza;
        private System.Windows.Forms.Label lblMNombre;
        private System.Windows.Forms.TextBox TxtMRaza;
        private System.Windows.Forms.Button btnMFinalizar;
        private System.Windows.Forms.Button BtnECancelar;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label label1;
    }
}