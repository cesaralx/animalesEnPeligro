namespace AnimalesEnPeligro
{
    partial class ZonasCmp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMunicipio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIdZona = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGriedZonas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaracteristicas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.txtMunicipio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMunicipio.LineThickness = 2;
            this.txtMunicipio.Location = new System.Drawing.Point(316, 248);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(247, 33);
            this.txtMunicipio.TabIndex = 19;
            this.txtMunicipio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMunicipio_KeyPress);
            this.txtMunicipio.Validating += new System.ComponentModel.CancelEventHandler(this.txtMunicipio_Validating);
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
            this.txtEstado.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEstado.LineThickness = 2;
            this.txtEstado.Location = new System.Drawing.Point(316, 192);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(247, 33);
            this.txtEstado.TabIndex = 18;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            this.txtEstado.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstado_Validating);
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
            this.txtNombre.Location = new System.Drawing.Point(316, 128);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 33);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtIdZona
            // 
            this.txtIdZona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdZona.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdZona.ForeColor = System.Drawing.Color.Black;
            this.txtIdZona.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdZona.HintText = "IdZona";
            this.txtIdZona.isPassword = false;
            this.txtIdZona.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtIdZona.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIdZona.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtIdZona.LineThickness = 2;
            this.txtIdZona.Location = new System.Drawing.Point(316, 72);
            this.txtIdZona.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdZona.Name = "txtIdZona";
            this.txtIdZona.Size = new System.Drawing.Size(134, 33);
            this.txtIdZona.TabIndex = 16;
            this.txtIdZona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdZona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdZona_KeyPress);
            // 
            // dataGriedZonas
            // 
            this.dataGriedZonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriedZonas.Location = new System.Drawing.Point(27, 61);
            this.dataGriedZonas.Name = "dataGriedZonas";
            this.dataGriedZonas.Size = new System.Drawing.Size(266, 420);
            this.dataGriedZonas.TabIndex = 15;
            this.dataGriedZonas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGriedZonas_CellMouseClick);
            this.dataGriedZonas.Click += new System.EventHandler(this.dataGriedZonas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(252, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Zonas";
            // 
            // txtCaracteristicas
            // 
            this.txtCaracteristicas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaracteristicas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCaracteristicas.HintForeColor = System.Drawing.Color.Empty;
            this.txtCaracteristicas.HintText = "Caracteristicas";
            this.txtCaracteristicas.isPassword = false;
            this.txtCaracteristicas.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtCaracteristicas.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCaracteristicas.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtCaracteristicas.LineThickness = 2;
            this.txtCaracteristicas.Location = new System.Drawing.Point(316, 313);
            this.txtCaracteristicas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaracteristicas.Name = "txtCaracteristicas";
            this.txtCaracteristicas.Size = new System.Drawing.Size(247, 33);
            this.txtCaracteristicas.TabIndex = 25;
            this.txtCaracteristicas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCaracteristicas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracteristicas_KeyPress);
            this.txtCaracteristicas.Validating += new System.ComponentModel.CancelEventHandler(this.txtCaracteristicas_Validating);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Available_Updates_28px_1;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(481, 400);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 33);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Ok_28px;
            this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.Location = new System.Drawing.Point(316, 400);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(144, 33);
            this.btnAlta.TabIndex = 23;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Search_28px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(481, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 33);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ZonasCmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtCaracteristicas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdZona);
            this.Controls.Add(this.dataGriedZonas);
            this.Controls.Add(this.label1);
            this.Name = "ZonasCmp";
            this.Size = new System.Drawing.Size(652, 514);
            this.Load += new System.EventHandler(this.ZonasCmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMunicipio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEstado;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIdZona;
        private System.Windows.Forms.DataGridView dataGriedZonas;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCaracteristicas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
