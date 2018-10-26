namespace AnimalesEnPeligro
{
    partial class AsociacionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsociacionesForm));
            this.txtIdAsociacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbDomicilio = new System.Windows.Forms.Label();
            this.txtCalle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNoExterior = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNoInterior = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtColonia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCodigoPostal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMunicipio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdAsociacion
            // 
            this.txtIdAsociacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdAsociacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdAsociacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdAsociacion.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdAsociacion.HintText = "id Asociación";
            this.txtIdAsociacion.isPassword = false;
            this.txtIdAsociacion.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtIdAsociacion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIdAsociacion.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtIdAsociacion.LineThickness = 2;
            this.txtIdAsociacion.Location = new System.Drawing.Point(13, 69);
            this.txtIdAsociacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdAsociacion.Name = "txtIdAsociacion";
            this.txtIdAsociacion.Size = new System.Drawing.Size(121, 33);
            this.txtIdAsociacion.TabIndex = 1;
            this.txtIdAsociacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SlateGray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(579, 53);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asociaciones";
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "Nombre";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtNombre.LineThickness = 2;
            this.txtNombre.Location = new System.Drawing.Point(13, 119);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(323, 33);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefono.HintText = "Teléfono";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtTelefono.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtTelefono.LineThickness = 2;
            this.txtTelefono.Location = new System.Drawing.Point(370, 119);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(178, 33);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbDomicilio
            // 
            this.lbDomicilio.AutoSize = true;
            this.lbDomicilio.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDomicilio.Location = new System.Drawing.Point(12, 167);
            this.lbDomicilio.Name = "lbDomicilio";
            this.lbDomicilio.Size = new System.Drawing.Size(77, 19);
            this.lbDomicilio.TabIndex = 4;
            this.lbDomicilio.Text = "Domicilio";
            // 
            // txtCalle
            // 
            this.txtCalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCalle.HintForeColor = System.Drawing.Color.Empty;
            this.txtCalle.HintText = "Calle";
            this.txtCalle.isPassword = false;
            this.txtCalle.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtCalle.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCalle.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtCalle.LineThickness = 2;
            this.txtCalle.Location = new System.Drawing.Point(13, 190);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(191, 33);
            this.txtCalle.TabIndex = 5;
            this.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNoExterior
            // 
            this.txtNoExterior.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoExterior.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoExterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoExterior.HintForeColor = System.Drawing.Color.Empty;
            this.txtNoExterior.HintText = "No. Exterior";
            this.txtNoExterior.isPassword = false;
            this.txtNoExterior.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtNoExterior.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNoExterior.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtNoExterior.LineThickness = 2;
            this.txtNoExterior.Location = new System.Drawing.Point(230, 190);
            this.txtNoExterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoExterior.Name = "txtNoExterior";
            this.txtNoExterior.Size = new System.Drawing.Size(122, 33);
            this.txtNoExterior.TabIndex = 6;
            this.txtNoExterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNoInterior
            // 
            this.txtNoInterior.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoInterior.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoInterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoInterior.HintForeColor = System.Drawing.Color.Empty;
            this.txtNoInterior.HintText = "No. Interior";
            this.txtNoInterior.isPassword = false;
            this.txtNoInterior.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtNoInterior.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNoInterior.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtNoInterior.LineThickness = 2;
            this.txtNoInterior.Location = new System.Drawing.Point(370, 190);
            this.txtNoInterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoInterior.Name = "txtNoInterior";
            this.txtNoInterior.Size = new System.Drawing.Size(178, 33);
            this.txtNoInterior.TabIndex = 7;
            this.txtNoInterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtColonia
            // 
            this.txtColonia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColonia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtColonia.HintForeColor = System.Drawing.Color.Empty;
            this.txtColonia.HintText = "Colinia";
            this.txtColonia.isPassword = false;
            this.txtColonia.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtColonia.LineIdleColor = System.Drawing.Color.Gray;
            this.txtColonia.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtColonia.LineThickness = 2;
            this.txtColonia.Location = new System.Drawing.Point(13, 249);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(191, 33);
            this.txtColonia.TabIndex = 8;
            this.txtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoPostal.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigoPostal.HintText = "C.P.";
            this.txtCodigoPostal.isPassword = false;
            this.txtCodigoPostal.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtCodigoPostal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigoPostal.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtCodigoPostal.LineThickness = 2;
            this.txtCodigoPostal.Location = new System.Drawing.Point(230, 249);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(122, 33);
            this.txtCodigoPostal.TabIndex = 9;
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMunicipio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMunicipio.HintForeColor = System.Drawing.Color.Empty;
            this.txtMunicipio.HintText = "Municipio";
            this.txtMunicipio.isPassword = false;
            this.txtMunicipio.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtMunicipio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMunicipio.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtMunicipio.LineThickness = 2;
            this.txtMunicipio.Location = new System.Drawing.Point(370, 249);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(178, 33);
            this.txtMunicipio.TabIndex = 10;
            this.txtMunicipio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEstado
            // 
            this.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstado.HintForeColor = System.Drawing.Color.Empty;
            this.txtEstado.HintText = "Estado";
            this.txtEstado.isPassword = false;
            this.txtEstado.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtEstado.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEstado.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtEstado.LineThickness = 2;
            this.txtEstado.Location = new System.Drawing.Point(13, 302);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(178, 33);
            this.txtEstado.TabIndex = 11;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Ok_28px;
            this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.Location = new System.Drawing.Point(186, 373);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(222, 33);
            this.btnAlta.TabIndex = 24;
            this.btnAlta.Text = "Aceptar";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // AsociacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 444);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.txtNoInterior);
            this.Controls.Add(this.txtNoExterior);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lbDomicilio);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdAsociacion);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "AsociacionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsociacionesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AsociacionesForm_FormClosed);
            this.Load += new System.EventHandler(this.AsociacionesForm_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbDomicilio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNoInterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlta;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtColonia;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostal;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtMunicipio;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtEstado;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtIdAsociacion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCalle;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNoExterior;
    }
}