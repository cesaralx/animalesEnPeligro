namespace AnimalesEnPeligro
{
    partial class ObservacionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObservacionesForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboObservador = new MetroFramework.Controls.MetroComboBox();
            this.txtIdObservador = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboEspecie = new MetroFramework.Controls.MetroComboBox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.metroDateFecha = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.richTexBoxDetalle = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(515, 53);
            this.bunifuGradientPanel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Observador";
            // 
            // comboObservador
            // 
            this.comboObservador.FormattingEnabled = true;
            this.comboObservador.ItemHeight = 23;
            this.comboObservador.Location = new System.Drawing.Point(252, 77);
            this.comboObservador.Name = "comboObservador";
            this.comboObservador.Size = new System.Drawing.Size(223, 29);
            this.comboObservador.TabIndex = 41;
            this.comboObservador.UseSelectable = true;
            // 
            // txtIdObservador
            // 
            this.txtIdObservador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdObservador.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdObservador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdObservador.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdObservador.HintText = "id Observación";
            this.txtIdObservador.isPassword = false;
            this.txtIdObservador.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtIdObservador.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIdObservador.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtIdObservador.LineThickness = 2;
            this.txtIdObservador.Location = new System.Drawing.Point(13, 73);
            this.txtIdObservador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdObservador.Name = "txtIdObservador";
            this.txtIdObservador.Size = new System.Drawing.Size(121, 33);
            this.txtIdObservador.TabIndex = 40;
            this.txtIdObservador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Especie";
            // 
            // comboEspecie
            // 
            this.comboEspecie.FormattingEnabled = true;
            this.comboEspecie.ItemHeight = 23;
            this.comboEspecie.Location = new System.Drawing.Point(84, 132);
            this.comboEspecie.Name = "comboEspecie";
            this.comboEspecie.Size = new System.Drawing.Size(230, 29);
            this.comboEspecie.TabIndex = 43;
            this.comboEspecie.UseSelectable = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidad.HintForeColor = System.Drawing.Color.Empty;
            this.txtCantidad.HintText = "Cantidad";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtCantidad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtCantidad.LineThickness = 2;
            this.txtCantidad.Location = new System.Drawing.Point(354, 128);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 33);
            this.txtCantidad.TabIndex = 45;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // metroDateFecha
            // 
            this.metroDateFecha.Location = new System.Drawing.Point(84, 186);
            this.metroDateFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateFecha.Name = "metroDateFecha";
            this.metroDateFecha.Size = new System.Drawing.Size(230, 29);
            this.metroDateFecha.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Fecha";
            // 
            // richTexBoxDetalle
            // 
            this.richTexBoxDetalle.Location = new System.Drawing.Point(12, 259);
            this.richTexBoxDetalle.Name = "richTexBoxDetalle";
            this.richTexBoxDetalle.Size = new System.Drawing.Size(463, 132);
            this.richTexBoxDetalle.TabIndex = 48;
            this.richTexBoxDetalle.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Detalle";
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Ok_28px;
            this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.Location = new System.Drawing.Point(141, 405);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(222, 33);
            this.btnAlta.TabIndex = 50;
            this.btnAlta.Text = "Aceptar";
            this.btnAlta.UseVisualStyleBackColor = false;
            // 
            // ObservacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTexBoxDetalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.metroDateFecha);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboEspecie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.comboObservador);
            this.Controls.Add(this.txtIdObservador);
            this.Name = "ObservacionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OservacionesForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtIdObservador;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlta;
        public MetroFramework.Controls.MetroComboBox comboObservador;
        public MetroFramework.Controls.MetroComboBox comboEspecie;
        public MetroFramework.Controls.MetroDateTime metroDateFecha;
        public System.Windows.Forms.RichTextBox richTexBoxDetalle;
    }
}