﻿namespace AnimalesEnPeligro
{
    partial class Menu
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.btnMenuDesplegable = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelSidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelReportes = new System.Windows.Forms.Panel();
            this.btnZonas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelZonas = new System.Windows.Forms.Panel();
            this.panelObservadores = new System.Windows.Forms.Panel();
            this.btnAsociaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelAsociaciones = new System.Windows.Forms.Panel();
            this.btnObservadores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelObservaciones = new System.Windows.Forms.Panel();
            this.panelEspecies = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEspecies = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnObservaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.zonasCmp1 = new AnimalesEnPeligro.ZonasCmp();
            this.especieCmp1 = new AnimalesEnPeligro.EspecieCmp();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuDesplegable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.btnMenuDesplegable);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 48);
            this.panel1.TabIndex = 8;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lbFecha, BunifuAnimatorNS.DecorationType.None);
            this.lbFecha.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(52, 12);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(43, 25);
            this.lbFecha.TabIndex = 18;
            this.lbFecha.Text = "text";
            // 
            // btnMenuDesplegable
            // 
            this.btnMenuDesplegable.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnMenuDesplegable, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuDesplegable.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Menu_32px_1;
            this.btnMenuDesplegable.ImageActive = null;
            this.btnMenuDesplegable.Location = new System.Drawing.Point(12, 5);
            this.btnMenuDesplegable.Name = "btnMenuDesplegable";
            this.btnMenuDesplegable.Size = new System.Drawing.Size(32, 32);
            this.btnMenuDesplegable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMenuDesplegable.TabIndex = 17;
            this.btnMenuDesplegable.TabStop = false;
            this.btnMenuDesplegable.Zoom = 10;
            this.btnMenuDesplegable.Click += new System.EventHandler(this.btnMenuDesplegable_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Minus_32px;
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(761, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 16;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizar.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Unchecked_Checkbox_32px_1;
            this.btnMaximizar.ImageActive = null;
            this.btnMaximizar.Location = new System.Drawing.Point(792, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 15;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animales en peligro de Extinción";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Multiply_32px;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(823, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSidebar.BackgroundImage")));
            this.panelSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSidebar.Controls.Add(this.bunifuFlatButton1);
            this.panelSidebar.Controls.Add(this.panelReportes);
            this.panelSidebar.Controls.Add(this.btnZonas);
            this.panelSidebar.Controls.Add(this.panelZonas);
            this.panelSidebar.Controls.Add(this.panelObservadores);
            this.panelSidebar.Controls.Add(this.btnAsociaciones);
            this.panelSidebar.Controls.Add(this.panelAsociaciones);
            this.panelSidebar.Controls.Add(this.btnObservadores);
            this.panelSidebar.Controls.Add(this.panelObservaciones);
            this.panelSidebar.Controls.Add(this.panelEspecies);
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Controls.Add(this.btnEspecies);
            this.panelSidebar.Controls.Add(this.btnSalir);
            this.panelSidebar.Controls.Add(this.btnObservaciones);
            this.bunifuTransition1.SetDecoration(this.panelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.panelSidebar.GradientBottomRight = System.Drawing.Color.MediumBlue;
            this.panelSidebar.GradientTopLeft = System.Drawing.Color.RoyalBlue;
            this.panelSidebar.GradientTopRight = System.Drawing.Color.Aqua;
            this.panelSidebar.Location = new System.Drawing.Point(0, 48);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Quality = 10;
            this.panelSidebar.Size = new System.Drawing.Size(211, 514);
            this.panelSidebar.TabIndex = 9;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Reportes";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::AnimalesEnPeligro.Properties.Resources.icons8_Combo_Chart_50px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 48D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(10, 401);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(211, 58);
            this.bunifuFlatButton1.TabIndex = 20;
            this.bunifuFlatButton1.Text = "Reportes";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelReportes
            // 
            this.panelReportes.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.panelReportes, BunifuAnimatorNS.DecorationType.None);
            this.panelReportes.Location = new System.Drawing.Point(0, 400);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(10, 60);
            this.panelReportes.TabIndex = 19;
            this.panelReportes.Visible = false;
            // 
            // btnZonas
            // 
            this.btnZonas.Activecolor = System.Drawing.Color.Teal;
            this.btnZonas.BackColor = System.Drawing.Color.Transparent;
            this.btnZonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZonas.BorderRadius = 0;
            this.btnZonas.ButtonText = "Zonas";
            this.btnZonas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnZonas, BunifuAnimatorNS.DecorationType.None);
            this.btnZonas.DisabledColor = System.Drawing.Color.Gray;
            this.btnZonas.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZonas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnZonas.Iconimage = global::AnimalesEnPeligro.Properties.Resources.icons8_Google_Maps_50px;
            this.btnZonas.Iconimage_right = null;
            this.btnZonas.Iconimage_right_Selected = null;
            this.btnZonas.Iconimage_Selected = null;
            this.btnZonas.IconMarginLeft = 0;
            this.btnZonas.IconMarginRight = 0;
            this.btnZonas.IconRightVisible = true;
            this.btnZonas.IconRightZoom = 0D;
            this.btnZonas.IconVisible = true;
            this.btnZonas.IconZoom = 48D;
            this.btnZonas.IsTab = false;
            this.btnZonas.Location = new System.Drawing.Point(10, 340);
            this.btnZonas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZonas.Name = "btnZonas";
            this.btnZonas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnZonas.OnHovercolor = System.Drawing.Color.Navy;
            this.btnZonas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnZonas.selected = false;
            this.btnZonas.Size = new System.Drawing.Size(211, 58);
            this.btnZonas.TabIndex = 19;
            this.btnZonas.Text = "Zonas";
            this.btnZonas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZonas.Textcolor = System.Drawing.Color.White;
            this.btnZonas.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZonas.Click += new System.EventHandler(this.btnZonas_Click);
            // 
            // panelZonas
            // 
            this.panelZonas.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.panelZonas, BunifuAnimatorNS.DecorationType.None);
            this.panelZonas.Location = new System.Drawing.Point(0, 340);
            this.panelZonas.Name = "panelZonas";
            this.panelZonas.Size = new System.Drawing.Size(10, 60);
            this.panelZonas.TabIndex = 18;
            this.panelZonas.Visible = false;
            // 
            // panelObservadores
            // 
            this.panelObservadores.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.panelObservadores, BunifuAnimatorNS.DecorationType.None);
            this.panelObservadores.Location = new System.Drawing.Point(0, 280);
            this.panelObservadores.Name = "panelObservadores";
            this.panelObservadores.Size = new System.Drawing.Size(10, 60);
            this.panelObservadores.TabIndex = 17;
            this.panelObservadores.Visible = false;
            // 
            // btnAsociaciones
            // 
            this.btnAsociaciones.Activecolor = System.Drawing.Color.Teal;
            this.btnAsociaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnAsociaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsociaciones.BorderRadius = 0;
            this.btnAsociaciones.ButtonText = "Asociaciones";
            this.btnAsociaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnAsociaciones, BunifuAnimatorNS.DecorationType.None);
            this.btnAsociaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnAsociaciones.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAsociaciones.Iconimage = global::AnimalesEnPeligro.Properties.Resources.icons8_Business_Building_50px_2;
            this.btnAsociaciones.Iconimage_right = null;
            this.btnAsociaciones.Iconimage_right_Selected = null;
            this.btnAsociaciones.Iconimage_Selected = null;
            this.btnAsociaciones.IconMarginLeft = 0;
            this.btnAsociaciones.IconMarginRight = 0;
            this.btnAsociaciones.IconRightVisible = true;
            this.btnAsociaciones.IconRightZoom = 0D;
            this.btnAsociaciones.IconVisible = true;
            this.btnAsociaciones.IconZoom = 48D;
            this.btnAsociaciones.IsTab = false;
            this.btnAsociaciones.Location = new System.Drawing.Point(10, 223);
            this.btnAsociaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsociaciones.Name = "btnAsociaciones";
            this.btnAsociaciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAsociaciones.OnHovercolor = System.Drawing.Color.Navy;
            this.btnAsociaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAsociaciones.selected = false;
            this.btnAsociaciones.Size = new System.Drawing.Size(201, 58);
            this.btnAsociaciones.TabIndex = 18;
            this.btnAsociaciones.Text = "Asociaciones";
            this.btnAsociaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAsociaciones.Textcolor = System.Drawing.Color.White;
            this.btnAsociaciones.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelAsociaciones
            // 
            this.panelAsociaciones.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.panelAsociaciones, BunifuAnimatorNS.DecorationType.None);
            this.panelAsociaciones.Location = new System.Drawing.Point(0, 221);
            this.panelAsociaciones.Name = "panelAsociaciones";
            this.panelAsociaciones.Size = new System.Drawing.Size(10, 60);
            this.panelAsociaciones.TabIndex = 16;
            this.panelAsociaciones.Visible = false;
            // 
            // btnObservadores
            // 
            this.btnObservadores.Activecolor = System.Drawing.Color.Teal;
            this.btnObservadores.BackColor = System.Drawing.Color.Transparent;
            this.btnObservadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObservadores.BorderRadius = 0;
            this.btnObservadores.ButtonText = "Observadores";
            this.btnObservadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnObservadores, BunifuAnimatorNS.DecorationType.None);
            this.btnObservadores.DisabledColor = System.Drawing.Color.Gray;
            this.btnObservadores.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObservadores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnObservadores.Iconimage = global::AnimalesEnPeligro.Properties.Resources.icons8_User_42px_1;
            this.btnObservadores.Iconimage_right = null;
            this.btnObservadores.Iconimage_right_Selected = null;
            this.btnObservadores.Iconimage_Selected = null;
            this.btnObservadores.IconMarginLeft = 0;
            this.btnObservadores.IconMarginRight = 0;
            this.btnObservadores.IconRightVisible = true;
            this.btnObservadores.IconRightZoom = 0D;
            this.btnObservadores.IconVisible = true;
            this.btnObservadores.IconZoom = 48D;
            this.btnObservadores.IsTab = false;
            this.btnObservadores.Location = new System.Drawing.Point(10, 282);
            this.btnObservadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnObservadores.Name = "btnObservadores";
            this.btnObservadores.Normalcolor = System.Drawing.Color.Transparent;
            this.btnObservadores.OnHovercolor = System.Drawing.Color.Navy;
            this.btnObservadores.OnHoverTextColor = System.Drawing.Color.White;
            this.btnObservadores.selected = false;
            this.btnObservadores.Size = new System.Drawing.Size(201, 58);
            this.btnObservadores.TabIndex = 17;
            this.btnObservadores.Text = "Observadores";
            this.btnObservadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnObservadores.Textcolor = System.Drawing.Color.White;
            this.btnObservadores.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelObservaciones
            // 
            this.panelObservaciones.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.panelObservaciones, BunifuAnimatorNS.DecorationType.None);
            this.panelObservaciones.Location = new System.Drawing.Point(-1, 161);
            this.panelObservaciones.Name = "panelObservaciones";
            this.panelObservaciones.Size = new System.Drawing.Size(10, 60);
            this.panelObservaciones.TabIndex = 15;
            this.panelObservaciones.Visible = false;
            // 
            // panelEspecies
            // 
            this.panelEspecies.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.panelEspecies, BunifuAnimatorNS.DecorationType.None);
            this.panelEspecies.Location = new System.Drawing.Point(-1, 102);
            this.panelEspecies.Name = "panelEspecies";
            this.panelEspecies.Size = new System.Drawing.Size(10, 60);
            this.panelEspecies.TabIndex = 14;
            this.panelEspecies.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Lion_100px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnEspecies
            // 
            this.btnEspecies.Activecolor = System.Drawing.Color.Teal;
            this.btnEspecies.BackColor = System.Drawing.Color.Transparent;
            this.btnEspecies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEspecies.BorderRadius = 0;
            this.btnEspecies.ButtonText = "Especies";
            this.btnEspecies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnEspecies, BunifuAnimatorNS.DecorationType.None);
            this.btnEspecies.DisabledColor = System.Drawing.Color.Gray;
            this.btnEspecies.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecies.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEspecies.Iconimage = global::AnimalesEnPeligro.Properties.Resources.icons8_Wild_Animals_Sign_50px;
            this.btnEspecies.Iconimage_right = null;
            this.btnEspecies.Iconimage_right_Selected = null;
            this.btnEspecies.Iconimage_Selected = null;
            this.btnEspecies.IconMarginLeft = 0;
            this.btnEspecies.IconMarginRight = 0;
            this.btnEspecies.IconRightVisible = true;
            this.btnEspecies.IconRightZoom = 0D;
            this.btnEspecies.IconVisible = true;
            this.btnEspecies.IconZoom = 48D;
            this.btnEspecies.IsTab = false;
            this.btnEspecies.Location = new System.Drawing.Point(10, 105);
            this.btnEspecies.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEspecies.Name = "btnEspecies";
            this.btnEspecies.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEspecies.OnHovercolor = System.Drawing.Color.Navy;
            this.btnEspecies.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEspecies.selected = false;
            this.btnEspecies.Size = new System.Drawing.Size(201, 56);
            this.btnEspecies.TabIndex = 4;
            this.btnEspecies.Text = "Especies";
            this.btnEspecies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEspecies.Textcolor = System.Drawing.Color.White;
            this.btnEspecies.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecies.Click += new System.EventHandler(this.btnEspecies_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Activecolor = System.Drawing.Color.Teal;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
            this.btnSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalir.Iconimage = null;
            this.btnSalir.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btnSalir.Iconimage_right")));
            this.btnSalir.Iconimage_right_Selected = null;
            this.btnSalir.Iconimage_Selected = null;
            this.btnSalir.IconMarginLeft = 0;
            this.btnSalir.IconMarginRight = 0;
            this.btnSalir.IconRightVisible = true;
            this.btnSalir.IconRightZoom = 0D;
            this.btnSalir.IconVisible = true;
            this.btnSalir.IconZoom = 48D;
            this.btnSalir.IsTab = false;
            this.btnSalir.Location = new System.Drawing.Point(-1, 462);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSalir.OnHovercolor = System.Drawing.Color.Navy;
            this.btnSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalir.selected = false;
            this.btnSalir.Size = new System.Drawing.Size(211, 52);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Textcolor = System.Drawing.Color.White;
            this.btnSalir.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnObservaciones
            // 
            this.btnObservaciones.Activecolor = System.Drawing.Color.Teal;
            this.btnObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnObservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObservaciones.BorderRadius = 0;
            this.btnObservaciones.ButtonText = "Observaciones";
            this.btnObservaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnObservaciones, BunifuAnimatorNS.DecorationType.None);
            this.btnObservaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnObservaciones.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObservaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnObservaciones.Iconimage = global::AnimalesEnPeligro.Properties.Resources.icons8_Opera_Glasses_52px_1;
            this.btnObservaciones.Iconimage_right = null;
            this.btnObservaciones.Iconimage_right_Selected = null;
            this.btnObservaciones.Iconimage_Selected = null;
            this.btnObservaciones.IconMarginLeft = 0;
            this.btnObservaciones.IconMarginRight = 0;
            this.btnObservaciones.IconRightVisible = true;
            this.btnObservaciones.IconRightZoom = 0D;
            this.btnObservaciones.IconVisible = true;
            this.btnObservaciones.IconZoom = 48D;
            this.btnObservaciones.IsTab = false;
            this.btnObservaciones.Location = new System.Drawing.Point(10, 167);
            this.btnObservaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnObservaciones.Name = "btnObservaciones";
            this.btnObservaciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btnObservaciones.OnHovercolor = System.Drawing.Color.Navy;
            this.btnObservaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnObservaciones.selected = false;
            this.btnObservaciones.Size = new System.Drawing.Size(201, 54);
            this.btnObservaciones.TabIndex = 1;
            this.btnObservaciones.Text = "Observaciones";
            this.btnObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnObservaciones.Textcolor = System.Drawing.Color.White;
            this.btnObservaciones.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.TimeStep = 0.03F;
            // 
            // zonasCmp1
            // 
            this.zonasCmp1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.zonasCmp1, BunifuAnimatorNS.DecorationType.None);
            this.zonasCmp1.Location = new System.Drawing.Point(208, 48);
            this.zonasCmp1.Name = "zonasCmp1";
            this.zonasCmp1.Size = new System.Drawing.Size(652, 514);
            this.zonasCmp1.TabIndex = 11;
            // 
            // especieCmp1
            // 
            this.especieCmp1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.especieCmp1, BunifuAnimatorNS.DecorationType.None);
            this.especieCmp1.Location = new System.Drawing.Point(208, 48);
            this.especieCmp1.Name = "especieCmp1";
            this.especieCmp1.Size = new System.Drawing.Size(652, 514);
            this.especieCmp1.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 562);
            this.Controls.Add(this.zonasCmp1);
            this.Controls.Add(this.especieCmp1);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuDesplegable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFecha;
        private Bunifu.Framework.UI.BunifuImageButton btnMenuDesplegable;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximizar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuGradientPanel panelSidebar;
        private System.Windows.Forms.Panel panelAsociaciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnObservadores;
        private System.Windows.Forms.Panel panelObservaciones;
        private System.Windows.Forms.Panel panelEspecies;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEspecies;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalir;
        private Bunifu.Framework.UI.BunifuFlatButton btnObservaciones;
        private System.Windows.Forms.Panel panelObservadores;
        private Bunifu.Framework.UI.BunifuFlatButton btnAsociaciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnZonas;
        private System.Windows.Forms.Panel panelZonas;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panelReportes;
        private ZonasCmp zonasCmp1;
        private EspecieCmp especieCmp1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}