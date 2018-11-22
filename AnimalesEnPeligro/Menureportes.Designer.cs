namespace AnimalesEnPeligro
{
    partial class Menureportes
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
            this.dt1 = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt2 = new MetroFramework.Controls.MetroDateTime();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "\"yyyy-MM-dd\"";
            this.dt1.Location = new System.Drawing.Point(25, 194);
            this.dt1.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(269, 29);
            this.dt1.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dt2);
            this.groupBox1.Controls.Add(this.btnReporte1);
            this.groupBox1.Controls.Add(this.dt1);
            this.groupBox1.Location = new System.Drawing.Point(14, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 320);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especies";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dt2
            // 
            this.dt2.CustomFormat = "\"yyyy-MM-dd\"";
            this.dt2.Location = new System.Drawing.Point(25, 257);
            this.dt2.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(269, 29);
            this.dt2.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(336, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 320);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observadores";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Binoculars_104px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(73, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 143);
            this.button1.TabIndex = 32;
            this.button1.Text = "Detalle observadores";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporte1
            // 
            this.btnReporte1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnReporte1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporte1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte1.ForeColor = System.Drawing.Color.White;
            this.btnReporte1.Image = global::AnimalesEnPeligro.Properties.Resources.icons8_Dinosaur_104px;
            this.btnReporte1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporte1.Location = new System.Drawing.Point(90, 21);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Size = new System.Drawing.Size(144, 143);
            this.btnReporte1.TabIndex = 32;
            this.btnReporte1.Text = "Detalle especies";
            this.btnReporte1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte1.UseVisualStyleBackColor = false;
            this.btnReporte1.Click += new System.EventHandler(this.btnReporte1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "A: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 58);
            this.panel1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(274, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reportes";
            // 
            // Menureportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menureportes";
            this.Size = new System.Drawing.Size(652, 514);
            this.Load += new System.EventHandler(this.Menureportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporte1;
        private MetroFramework.Controls.MetroDateTime dt1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime dt2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}
