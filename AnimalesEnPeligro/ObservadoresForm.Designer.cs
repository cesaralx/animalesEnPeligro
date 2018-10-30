namespace AnimalesEnPeligro
{
    partial class ObservadoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObservadoresForm));
            this.txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMunicipio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCodigoPostal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtColonia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNoInterior = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNoExterior = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCalle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApellidos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIdObservador = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboAsociacion = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCurp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboZonas = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboEstatus = new MetroFramework.Controls.MetroComboBox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboPrivilegios = new MetroFramework.Controls.MetroComboBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.txtEstado.Location = new System.Drawing.Point(345, 66);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(178, 33);
            this.txtEstado.TabIndex = 36;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            this.txtEstado.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstado_Validating);
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
            this.txtMunicipio.Location = new System.Drawing.Point(148, 66);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(178, 33);
            this.txtMunicipio.TabIndex = 35;
            this.txtMunicipio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMunicipio_KeyPress);
            this.txtMunicipio.Validating += new System.ComponentModel.CancelEventHandler(this.txtMunicipio_Validating);
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
            this.txtCodigoPostal.Location = new System.Drawing.Point(7, 66);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(122, 33);
            this.txtCodigoPostal.TabIndex = 34;
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPostal_KeyPress);
            this.txtCodigoPostal.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoPostal_Validating);
            // 
            // txtColonia
            // 
            this.txtColonia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColonia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtColonia.HintForeColor = System.Drawing.Color.Empty;
            this.txtColonia.HintText = "Colonia";
            this.txtColonia.isPassword = false;
            this.txtColonia.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtColonia.LineIdleColor = System.Drawing.Color.Gray;
            this.txtColonia.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtColonia.LineThickness = 2;
            this.txtColonia.Location = new System.Drawing.Point(475, 25);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(165, 33);
            this.txtColonia.TabIndex = 33;
            this.txtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColonia_KeyPress);
            this.txtColonia.Validating += new System.ComponentModel.CancelEventHandler(this.txtColonia_Validating);
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
            this.txtNoInterior.Location = new System.Drawing.Point(330, 25);
            this.txtNoInterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoInterior.Name = "txtNoInterior";
            this.txtNoInterior.Size = new System.Drawing.Size(137, 33);
            this.txtNoInterior.TabIndex = 32;
            this.txtNoInterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNoInterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoInterior_KeyPress);
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
            this.txtNoExterior.Location = new System.Drawing.Point(189, 25);
            this.txtNoExterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoExterior.Name = "txtNoExterior";
            this.txtNoExterior.Size = new System.Drawing.Size(122, 33);
            this.txtNoExterior.TabIndex = 31;
            this.txtNoExterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNoExterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoExterior_KeyPress);
            this.txtNoExterior.Validating += new System.ComponentModel.CancelEventHandler(this.txtNoExterior_Validating);
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
            this.txtCalle.Location = new System.Drawing.Point(7, 25);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(174, 33);
            this.txtCalle.TabIndex = 30;
            this.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            this.txtCalle.Validating += new System.ComponentModel.CancelEventHandler(this.txtCalle_Validating);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidos.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellidos.HintText = "Apellidos";
            this.txtApellidos.isPassword = false;
            this.txtApellidos.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtApellidos.LineIdleColor = System.Drawing.Color.Gray;
            this.txtApellidos.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtApellidos.LineThickness = 2;
            this.txtApellidos.Location = new System.Drawing.Point(411, 110);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(239, 33);
            this.txtApellidos.TabIndex = 27;
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellidos.OnValueChanged += new System.EventHandler(this.txtApellidos_OnValueChanged);
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            this.txtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidos_Validating);
            // 
            // txtIdObservador
            // 
            this.txtIdObservador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdObservador.Enabled = false;
            this.txtIdObservador.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdObservador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdObservador.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdObservador.HintText = "id Observador";
            this.txtIdObservador.isPassword = false;
            this.txtIdObservador.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtIdObservador.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIdObservador.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtIdObservador.LineThickness = 2;
            this.txtIdObservador.Location = new System.Drawing.Point(16, 60);
            this.txtIdObservador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdObservador.Name = "txtIdObservador";
            this.txtIdObservador.Size = new System.Drawing.Size(118, 33);
            this.txtIdObservador.TabIndex = 26;
            this.txtIdObservador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdObservador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdObservador_KeyPress);
            // 
            // comboAsociacion
            // 
            this.comboAsociacion.FormattingEnabled = true;
            this.comboAsociacion.ItemHeight = 23;
            this.comboAsociacion.Location = new System.Drawing.Point(264, 64);
            this.comboAsociacion.Name = "comboAsociacion";
            this.comboAsociacion.Size = new System.Drawing.Size(223, 29);
            this.comboAsociacion.TabIndex = 38;
            this.comboAsociacion.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Asociacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "Nombre(s)";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtNombre.LineThickness = 2;
            this.txtNombre.Location = new System.Drawing.Point(153, 110);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 33);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigo.HintText = "Código";
            this.txtCodigo.isPassword = false;
            this.txtCodigo.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtCodigo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigo.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtCodigo.LineThickness = 2;
            this.txtCodigo.Location = new System.Drawing.Point(13, 110);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 33);
            this.txtCodigo.TabIndex = 41;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // txtCurp
            // 
            this.txtCurp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCurp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurp.HintForeColor = System.Drawing.Color.Empty;
            this.txtCurp.HintText = "CURP";
            this.txtCurp.isPassword = false;
            this.txtCurp.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtCurp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCurp.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtCurp.LineThickness = 2;
            this.txtCurp.Location = new System.Drawing.Point(13, 166);
            this.txtCurp.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(201, 33);
            this.txtCurp.TabIndex = 42;
            this.txtCurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurp_KeyPress);
            this.txtCurp.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurp_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Zona";
            // 
            // comboZonas
            // 
            this.comboZonas.FormattingEnabled = true;
            this.comboZonas.ItemHeight = 23;
            this.comboZonas.Location = new System.Drawing.Point(288, 170);
            this.comboZonas.Name = "comboZonas";
            this.comboZonas.Size = new System.Drawing.Size(156, 29);
            this.comboZonas.TabIndex = 43;
            this.comboZonas.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Estatus";
            // 
            // comboEstatus
            // 
            this.comboEstatus.FormattingEnabled = true;
            this.comboEstatus.ItemHeight = 23;
            this.comboEstatus.Location = new System.Drawing.Point(521, 170);
            this.comboEstatus.Name = "comboEstatus";
            this.comboEstatus.Size = new System.Drawing.Size(129, 29);
            this.comboEstatus.TabIndex = 45;
            this.comboEstatus.UseSelectable = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "Usuario";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtUsuario.LineThickness = 2;
            this.txtUsuario.Location = new System.Drawing.Point(7, 29);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(157, 33);
            this.txtUsuario.TabIndex = 48;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtPassword.LineThickness = 2;
            this.txtPassword.Location = new System.Drawing.Point(192, 29);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 33);
            this.txtPassword.TabIndex = 49;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Privilegios";
            // 
            // comboPrivilegios
            // 
            this.comboPrivilegios.FormattingEnabled = true;
            this.comboPrivilegios.ItemHeight = 23;
            this.comboPrivilegios.Location = new System.Drawing.Point(470, 33);
            this.comboPrivilegios.Name = "comboPrivilegios";
            this.comboPrivilegios.Size = new System.Drawing.Size(156, 29);
            this.comboPrivilegios.TabIndex = 51;
            this.comboPrivilegios.UseSelectable = true;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Ok_28px;
            this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.Location = new System.Drawing.Point(222, 435);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(222, 33);
            this.btnAlta.TabIndex = 37;
            this.btnAlta.Text = "Aceptar";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(673, 53);
            this.bunifuGradientPanel1.TabIndex = 25;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observadores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtColonia);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.txtCodigoPostal);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtNoExterior);
            this.groupBox1.Controls.Add(this.txtMunicipio);
            this.groupBox1.Controls.Add(this.txtNoInterior);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 108);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.comboPrivilegios);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 96);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ObservadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboEstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboZonas);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboAsociacion);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtIdObservador);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "ObservadoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObservadoresForm";
            this.Load += new System.EventHandler(this.ObservadoresForm_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtEstado;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtMunicipio;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostal;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtColonia;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNoExterior;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCalle;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidos;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtIdObservador;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCurp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnAlta;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNoInterior;
        public MetroFramework.Controls.MetroComboBox comboAsociacion;
        public MetroFramework.Controls.MetroComboBox comboZonas;
        public MetroFramework.Controls.MetroComboBox comboEstatus;
        public MetroFramework.Controls.MetroComboBox comboPrivilegios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}