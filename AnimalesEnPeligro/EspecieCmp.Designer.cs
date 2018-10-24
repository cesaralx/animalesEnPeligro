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
            this.comboGenero = new MetroFramework.Controls.MetroComboBox();
            this.comboEstatus = new MetroFramework.Controls.MetroComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecies)).BeginInit();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridEspecies
            // 
            this.dataGridEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEspecies.Location = new System.Drawing.Point(23, 60);
            this.dataGridEspecies.Name = "dataGridEspecies";
            this.dataGridEspecies.Size = new System.Drawing.Size(266, 420);
            this.dataGridEspecies.TabIndex = 2;
            this.dataGridEspecies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.txtIdEspecie.Location = new System.Drawing.Point(312, 71);
            this.txtIdEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEspecie.Name = "txtIdEspecie";
            this.txtIdEspecie.Size = new System.Drawing.Size(134, 33);
            this.txtIdEspecie.TabIndex = 3;
            this.txtIdEspecie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdEspecie.OnValueChanged += new System.EventHandler(this.txtIdEspecie_OnValueChanged);
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
            this.txtNombreCientifico.Location = new System.Drawing.Point(312, 127);
            this.txtNombreCientifico.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCientifico.Name = "txtNombreCientifico";
            this.txtNombreCientifico.Size = new System.Drawing.Size(247, 33);
            this.txtNombreCientifico.TabIndex = 4;
            this.txtNombreCientifico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCientifico.OnValueChanged += new System.EventHandler(this.txtNombreCientifico_OnValueChanged);
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
            this.txtNombreVulgar.Location = new System.Drawing.Point(312, 194);
            this.txtNombreVulgar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreVulgar.Name = "txtNombreVulgar";
            this.txtNombreVulgar.Size = new System.Drawing.Size(247, 33);
            this.txtNombreVulgar.TabIndex = 5;
            this.txtNombreVulgar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreVulgar.OnValueChanged += new System.EventHandler(this.txtNombreVulgar_OnValueChanged);
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
            this.txtDescripcion.Location = new System.Drawing.Point(312, 251);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(247, 33);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.OnValueChanged += new System.EventHandler(this.txtDescripcion_OnValueChanged);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboGenero
            // 
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.ItemHeight = 23;
            this.comboGenero.Location = new System.Drawing.Point(312, 310);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(247, 29);
            this.comboGenero.TabIndex = 9;
            this.comboGenero.UseSelectable = true;
            this.comboGenero.SelectedIndexChanged += new System.EventHandler(this.comboGenero_SelectedIndexChanged);
            // 
            // comboEstatus
            // 
            this.comboEstatus.FormattingEnabled = true;
            this.comboEstatus.ItemHeight = 23;
            this.comboEstatus.Location = new System.Drawing.Point(312, 368);
            this.comboEstatus.Name = "comboEstatus";
            this.comboEstatus.Size = new System.Drawing.Size(247, 29);
            this.comboEstatus.TabIndex = 10;
            this.comboEstatus.UseSelectable = true;
            this.comboEstatus.SelectedIndexChanged += new System.EventHandler(this.comboEstatus_SelectedIndexChanged);
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
            this.btnModificar.Location = new System.Drawing.Point(477, 429);
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
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Ok_28px;
            this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.Location = new System.Drawing.Point(312, 429);
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
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Search_28px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(477, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 33);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // EspecieCmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboEstatus);
            this.Controls.Add(this.comboGenero);
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
        private MetroFramework.Controls.MetroComboBox comboGenero;
        private MetroFramework.Controls.MetroComboBox comboEstatus;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
    }
}
