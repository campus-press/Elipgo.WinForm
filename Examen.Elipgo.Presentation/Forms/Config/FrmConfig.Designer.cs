
namespace Examen.Elipgo.Presentation.Forms.Config
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.pbxBanner = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUri = new System.Windows.Forms.Label();
            this.txtUri = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxBanner
            // 
            this.pbxBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxBanner.Image = global::Examen.Elipgo.Presentation.Properties.Resources.unnamed;
            this.pbxBanner.Location = new System.Drawing.Point(0, 0);
            this.pbxBanner.Name = "pbxBanner";
            this.pbxBanner.Size = new System.Drawing.Size(416, 97);
            this.pbxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBanner.TabIndex = 0;
            this.pbxBanner.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 97);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(416, 19);
            this.pnlTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(98, -2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configuración Inicial";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(172, 209);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 31);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(291, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 31);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblUri
            // 
            this.lblUri.AutoSize = true;
            this.lblUri.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUri.Location = new System.Drawing.Point(13, 135);
            this.lblUri.Name = "lblUri";
            this.lblUri.Size = new System.Drawing.Size(111, 19);
            this.lblUri.TabIndex = 24;
            this.lblUri.Text = "URL API Service ";
            // 
            // txtUri
            // 
            this.txtUri.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUri.Location = new System.Drawing.Point(17, 158);
            this.txtUri.Name = "txtUri";
            this.txtUri.Size = new System.Drawing.Size(387, 25);
            this.txtUri.TabIndex = 25;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Location = new System.Drawing.Point(17, 190);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(92, 23);
            this.btnTest.TabIndex = 26;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            this.btnTest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTest_MouseDown);
            this.btnTest.MouseEnter += new System.EventHandler(this.btnTest_MouseEnter);
            this.btnTest.MouseLeave += new System.EventHandler(this.btnTest_MouseLeave);
            this.btnTest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTest_MouseUp);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(14, 256);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(11, 13);
            this.lbl1.TabIndex = 27;
            this.lbl1.Text = "*";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(23, 253);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(0, 13);
            this.lblNote.TabIndex = 28;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 294);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtUri);
            this.Controls.Add(this.lblUri);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pbxBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración Inicial";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBanner;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUri;
        private System.Windows.Forms.TextBox txtUri;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblNote;
    }
}