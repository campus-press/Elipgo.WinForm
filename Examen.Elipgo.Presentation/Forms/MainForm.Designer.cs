
namespace Examen.Elipgo.Presentation.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlOptionsMenuLeft = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.lblUserId = new System.Windows.Forms.Label();
            this.pnlContentButtons = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnStores = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.pnlLogoSidebar = new System.Windows.Forms.Panel();
            this.pnlRole = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.pnlImageLogo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDealName = new System.Windows.Forms.Label();
            this.pbxMinimize = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlOptionsMenuLeft.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlContentButtons.SuspendLayout();
            this.pnlLogoSidebar.SuspendLayout();
            this.pnlRole.SuspendLayout();
            this.pnlImageLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlSidebar.Controls.Add(this.pnlOptionsMenuLeft);
            this.pnlSidebar.Controls.Add(this.pnlLogoSidebar);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 823);
            this.pnlSidebar.TabIndex = 3;
            // 
            // pnlOptionsMenuLeft
            // 
            this.pnlOptionsMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.pnlOptionsMenuLeft.Controls.Add(this.pnlButtons);
            this.pnlOptionsMenuLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptionsMenuLeft.Location = new System.Drawing.Point(0, 215);
            this.pnlOptionsMenuLeft.Name = "pnlOptionsMenuLeft";
            this.pnlOptionsMenuLeft.Size = new System.Drawing.Size(200, 608);
            this.pnlOptionsMenuLeft.TabIndex = 3;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlButtons.Controls.Add(this.lblUserId);
            this.pnlButtons.Controls.Add(this.pnlContentButtons);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(200, 608);
            this.pnlButtons.TabIndex = 3;
            // 
            // lblUserId
            // 
            this.lblUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserId.AutoSize = true;
            this.lblUserId.ForeColor = System.Drawing.Color.White;
            this.lblUserId.Location = new System.Drawing.Point(4, 592);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(83, 13);
            this.lblUserId.TabIndex = 8;
            this.lblUserId.Text = "Terminal: 00001";
            // 
            // pnlContentButtons
            // 
            this.pnlContentButtons.Controls.Add(this.btnConfig);
            this.pnlContentButtons.Controls.Add(this.btnStores);
            this.pnlContentButtons.Controls.Add(this.btnLogout);
            this.pnlContentButtons.Controls.Add(this.btnInventario);
            this.pnlContentButtons.Controls.Add(this.btnProducts);
            this.pnlContentButtons.Location = new System.Drawing.Point(1, 93);
            this.pnlContentButtons.Name = "pnlContentButtons";
            this.pnlContentButtons.Size = new System.Drawing.Size(199, 367);
            this.pnlContentButtons.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfig.Image = global::Examen.Elipgo.Presentation.Properties.Resources.ajustes;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(-1, 171);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(199, 50);
            this.btnConfig.TabIndex = 19;
            this.btnConfig.Text = "Configurar";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnStores
            // 
            this.btnStores.FlatAppearance.BorderSize = 0;
            this.btnStores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStores.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStores.Image = global::Examen.Elipgo.Presentation.Properties.Resources.supermercado;
            this.btnStores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStores.Location = new System.Drawing.Point(-1, 115);
            this.btnStores.Name = "btnStores";
            this.btnStores.Size = new System.Drawing.Size(199, 50);
            this.btnStores.TabIndex = 18;
            this.btnStores.Text = "Tiendas";
            this.btnStores.UseVisualStyleBackColor = true;
            this.btnStores.Click += new System.EventHandler(this.btnStores_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Image = global::Examen.Elipgo.Presentation.Properties.Resources.cerrar_sesion;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 227);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(199, 50);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Salir     ";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInventario.Image = global::Examen.Elipgo.Presentation.Properties.Resources.caja;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 59);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(199, 50);
            this.btnInventario.TabIndex = 16;
            this.btnInventario.Text = "     Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProducts.Image = global::Examen.Elipgo.Presentation.Properties.Resources.shoe;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(199, 50);
            this.btnProducts.TabIndex = 15;
            this.btnProducts.Text = "     Productos";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // pnlLogoSidebar
            // 
            this.pnlLogoSidebar.Controls.Add(this.pnlRole);
            this.pnlLogoSidebar.Controls.Add(this.pnlImageLogo);
            this.pnlLogoSidebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoSidebar.Name = "pnlLogoSidebar";
            this.pnlLogoSidebar.Size = new System.Drawing.Size(200, 215);
            this.pnlLogoSidebar.TabIndex = 0;
            // 
            // pnlRole
            // 
            this.pnlRole.Controls.Add(this.lblRole);
            this.pnlRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRole.Location = new System.Drawing.Point(0, 168);
            this.pnlRole.Name = "pnlRole";
            this.pnlRole.Size = new System.Drawing.Size(200, 24);
            this.pnlRole.TabIndex = 6;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(58, 3);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(92, 19);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role Name";
            // 
            // pnlImageLogo
            // 
            this.pnlImageLogo.Controls.Add(this.lblTitle);
            this.pnlImageLogo.Controls.Add(this.pictureBox1);
            this.pnlImageLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImageLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlImageLogo.Name = "pnlImageLogo";
            this.pnlImageLogo.Size = new System.Drawing.Size(200, 168);
            this.pnlImageLogo.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(42, 145);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 20);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Super Zapatos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examen.Elipgo.Presentation.Properties.Resources.Logo1_80opaco;
            this.pictureBox1.Location = new System.Drawing.Point(26, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblEmail);
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Controls.Add(this.lblDealName);
            this.pnlHeader.Controls.Add(this.pbxMinimize);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(920, 38);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblDealName
            // 
            this.lblDealName.AutoSize = true;
            this.lblDealName.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealName.Location = new System.Drawing.Point(373, 6);
            this.lblDealName.Name = "lblDealName";
            this.lblDealName.Size = new System.Drawing.Size(237, 27);
            this.lblDealName.TabIndex = 7;
            this.lblDealName.Text = "Control de Inventarios";
            // 
            // pbxMinimize
            // 
            this.pbxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMinimize.Image = global::Examen.Elipgo.Presentation.Properties.Resources.minimizar;
            this.pbxMinimize.Location = new System.Drawing.Point(892, 6);
            this.pbxMinimize.Name = "pbxMinimize";
            this.pbxMinimize.Size = new System.Drawing.Size(20, 20);
            this.pbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinimize.TabIndex = 6;
            this.pbxMinimize.TabStop = false;
            this.pbxMinimize.Click += new System.EventHandler(this.pbxMinimize_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pictureBox2);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 38);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(920, 785);
            this.pnlContent.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Examen.Elipgo.Presentation.Properties.Resources.Logo1_80opaco;
            this.pictureBox2.Location = new System.Drawing.Point(570, 435);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 350);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(738, 1);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 19);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User Name";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(740, 20);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 14);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 823);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlOptionsMenuLeft.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlContentButtons.ResumeLayout(false);
            this.pnlLogoSidebar.ResumeLayout(false);
            this.pnlRole.ResumeLayout(false);
            this.pnlRole.PerformLayout();
            this.pnlImageLogo.ResumeLayout(false);
            this.pnlImageLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbxMinimize;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLogoSidebar;
        private System.Windows.Forms.Panel pnlRole;
        private System.Windows.Forms.Panel pnlImageLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDealName;
        private System.Windows.Forms.Panel pnlOptionsMenuLeft;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlContentButtons;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStores;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUser;
    }
}