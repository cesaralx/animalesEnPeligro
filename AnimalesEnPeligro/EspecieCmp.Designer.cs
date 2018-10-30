namespace AnimalesEnPeligro
{
    partial class EspecieCmp
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridEspecies = new System.Windows.Forms.DataGridView();
            this.txtIdEspecie = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombreCientifico = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombreVulgar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.comboEstatus = new MetroFramework.Controls.MetroComboBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnImagen = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtGenero = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bntClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(248, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Especies";
            // 
            // dataGridEspecies
            // 
            this.dataGridEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEspecies.Location = new System.Drawing.Point(23, 60);
            this.dataGridEspecies.Name = "dataGridEspecies";
            this.dataGridEspecies.Size = new System.Drawing.Size(266, 420);
            this.dataGridEspecies.TabIndex = 2;
            this.dataGridEspecies.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridEspecies_CellMouseClick);
            this.dataGridEspecies.Click += new System.EventHandler(this.dataGridEspecies_Click);
            // 
            // txtIdEspecie
            // 
            this.txtIdEspecie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdEspecie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdEspecie.ForeColor = System.Drawing.Color.Black;
            this.txtIdEspecie.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdEspecie.HintText = "IdEspecie";
            this.txtIdEspecie.isPassword = false;
            this.txtIdEspecie.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtIdEspecie.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIdEspecie.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtIdEspecie.LineThickness = 2;
            this.txtIdEspecie.Location = new System.Drawing.Point(312, 60);
            this.txtIdEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEspecie.Name = "txtIdEspecie";
            this.txtIdEspecie.Size = new System.Drawing.Size(134, 33);
            this.txtIdEspecie.TabIndex = 3;
            this.txtIdEspecie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdEspecie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEspecie_KeyPress);
            // 
            // txtNombreCientifico
            // 
            this.txtNombreCientifico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCientifico.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreCientifico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreCientifico.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombreCientifico.HintText = "Nombre cientifico";
            this.txtNombreCientifico.isPassword = false;
            this.txtNombreCientifico.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombreCientifico.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombreCientifico.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNombreCientifico.LineThickness = 2;
            this.txtNombreCientifico.Location = new System.Drawing.Point(312, 123);
            this.txtNombreCientifico.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCientifico.Name = "txtNombreCientifico";
            this.txtNombreCientifico.Size = new System.Drawing.Size(309, 33);
            this.txtNombreCientifico.TabIndex = 4;
            this.txtNombreCientifico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCientifico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCientifico_KeyPress);
            this.txtNombreCientifico.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreCientifico_Validating);
            // 
            // txtNombreVulgar
            // 
            this.txtNombreVulgar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreVulgar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreVulgar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreVulgar.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombreVulgar.HintText = "Nombre vulgar";
            this.txtNombreVulgar.isPassword = false;
            this.txtNombreVulgar.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombreVulgar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombreVulgar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNombreVulgar.LineThickness = 2;
            this.txtNombreVulgar.Location = new System.Drawing.Point(312, 176);
            this.txtNombreVulgar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreVulgar.Name = "txtNombreVulgar";
            this.txtNombreVulgar.Size = new System.Drawing.Size(309, 33);
            this.txtNombreVulgar.TabIndex = 5;
            this.txtNombreVulgar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreVulgar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreVulgar_KeyPress);
            this.txtNombreVulgar.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreVulgar_Validating);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.HintForeColor = System.Drawing.Color.Empty;
            this.txtDescripcion.HintText = "Descripción";
            this.txtDescripcion.isPassword = false;
            this.txtDescripcion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDescripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescripcion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDescripcion.LineThickness = 2;
            this.txtDescripcion.Location = new System.Drawing.Point(312, 233);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(309, 33);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcion_Validating);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboEstatus
            // 
            this.comboEstatus.FormattingEnabled = true;
            this.comboEstatus.ItemHeight = 23;
            this.comboEstatus.Location = new System.Drawing.Point(490, 295);
            this.comboEstatus.Name = "comboEstatus";
            this.comboEstatus.PromptText = "Estatus";
            this.comboEstatus.Size = new System.Drawing.Size(131, 29);
            this.comboEstatus.TabIndex = 10;
            this.comboEstatus.UseSelectable = true;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblFoto.Location = new System.Drawing.Point(312, 361);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(0, 17);
            this.lblFoto.TabIndex = 15;
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnImagen.BackgroundImage = global::AnimalesEnPeligro.Properties.Resources.icons8_Download_104px_1;
            this.btnImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImagen.Location = new System.Drawing.Point(312, 345);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(309, 46);
            this.btnImagen.Style = MetroFramework.MetroColorStyle.Black;
            this.btnImagen.TabIndex = 14;
            this.btnImagen.Text = "Imagen\r\nArastra y suelta";
            this.btnImagen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnImagen.UseSelectable = true;
            this.btnImagen.MouseHover += new System.EventHandler(this.btnImagen_MouseHover);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Available_Updates_28px_1;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(477, 413);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 33);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Ok_28px;
            this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.Location = new System.Drawing.Point(312, 413);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(144, 33);
            this.btnAlta.TabIndex = 12;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Search_28px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(477, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 33);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtGenero
            // 
            this.txtGenero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGenero.HintForeColor = System.Drawing.Color.Empty;
            this.txtGenero.HintText = "Clase o Clasificación";
            this.txtGenero.isPassword = false;
            this.txtGenero.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtGenero.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGenero.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtGenero.LineThickness = 2;
            this.txtGenero.Location = new System.Drawing.Point(312, 291);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(171, 33);
            this.txtGenero.TabIndex = 16;
            this.txtGenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenero_KeyPress);
            this.txtGenero.Validating += new System.ComponentModel.CancelEventHandler(this.txtGenero_Validating);
            // 
            // bntClear
            // 
            this.bntClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bntClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntClear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClear.ForeColor = System.Drawing.Color.White;
            this.bntClear.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Multiply_32px;
            this.bntClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntClear.Location = new System.Drawing.Point(395, 462);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(144, 33);
            this.bntClear.TabIndex = 17;
            this.bntClear.Text = "Limpiar";
            this.bntClear.UseVisualStyleBackColor = false;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // EspecieCmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboEstatus);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreVulgar);
            this.Controls.Add(this.txtNombreCientifico);
            this.Controls.Add(this.txtIdEspecie);
            this.Controls.Add(this.dataGridEspecies);
            this.Controls.Add(this.label1);
            this.Name = "EspecieCmp";
            this.Size = new System.Drawing.Size(652, 514);
            this.Load += new System.EventHandler(this.EspecieCmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridEspecies;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIdEspecie;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreCientifico;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreVulgar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescripcion;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private MetroFramework.Controls.MetroComboBox comboEstatus;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private MetroFramework.Controls.MetroButton btnImagen;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGenero;
        private System.Windows.Forms.Button bntClear;
    }
}
