
namespace Examen.Elipgo.Presentation.Forms.Views
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblInventory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbtStore = new System.Windows.Forms.RadioButton();
            this.rbtName = new System.Windows.Forms.RadioButton();
            this.rbtId = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlHeader.Controls.Add(this.lblInventory);
            this.pnlHeader.Controls.Add(this.panel1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1002, 37);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.White;
            this.lblInventory.Location = new System.Drawing.Point(13, 6);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(87, 21);
            this.lblInventory.TabIndex = 1;
            this.lblInventory.Text = "Inventario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 5);
            this.panel1.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 155);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1002, 19);
            this.pnlTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(346, -2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(232, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Inventario de Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Examen.Elipgo.Presentation.Properties.Resources.chad_bg_4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbxFilter);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 174);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1002, 46);
            this.pnlSearch.TabIndex = 4;
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.btnEdit);
            this.gbxFilter.Controls.Add(this.btnGetAll);
            this.gbxFilter.Controls.Add(this.cbxStore);
            this.gbxFilter.Controls.Add(this.btnSearch);
            this.gbxFilter.Controls.Add(this.rbtStore);
            this.gbxFilter.Controls.Add(this.rbtName);
            this.gbxFilter.Controls.Add(this.rbtId);
            this.gbxFilter.Controls.Add(this.txtSearch);
            this.gbxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxFilter.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFilter.Location = new System.Drawing.Point(0, 0);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(1002, 46);
            this.gbxFilter.TabIndex = 0;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Bucar Producto";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(483, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 27);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbtStore
            // 
            this.rbtStore.AutoSize = true;
            this.rbtStore.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtStore.Location = new System.Drawing.Point(139, 17);
            this.rbtStore.Name = "rbtStore";
            this.rbtStore.Size = new System.Drawing.Size(67, 23);
            this.rbtStore.TabIndex = 6;
            this.rbtStore.Text = "Tienda";
            this.rbtStore.UseVisualStyleBackColor = true;
            this.rbtStore.MouseCaptureChanged += new System.EventHandler(this.rbtStore_MouseCaptureChanged);
            // 
            // rbtName
            // 
            this.rbtName.AutoSize = true;
            this.rbtName.Checked = true;
            this.rbtName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtName.Location = new System.Drawing.Point(55, 17);
            this.rbtName.Name = "rbtName";
            this.rbtName.Size = new System.Drawing.Size(78, 23);
            this.rbtName.TabIndex = 5;
            this.rbtName.TabStop = true;
            this.rbtName.Text = "Nombre";
            this.rbtName.UseVisualStyleBackColor = true;
            this.rbtName.MouseCaptureChanged += new System.EventHandler(this.rbtName_MouseCaptureChanged);
            // 
            // rbtId
            // 
            this.rbtId.AutoSize = true;
            this.rbtId.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtId.Location = new System.Drawing.Point(10, 17);
            this.rbtId.Name = "rbtId";
            this.rbtId.Size = new System.Drawing.Size(39, 23);
            this.rbtId.TabIndex = 4;
            this.rbtId.Text = "Id";
            this.rbtId.UseVisualStyleBackColor = true;
            this.rbtId.MouseCaptureChanged += new System.EventHandler(this.rbtId_MouseCaptureChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(222, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(255, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvArticles
            // 
            this.dgvArticles.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmName,
            this.clmQuantity,
            this.clmStore});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticles.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticles.Location = new System.Drawing.Point(0, 220);
            this.dgvArticles.MultiSelect = false;
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(1002, 437);
            this.dgvArticles.TabIndex = 5;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Width = 50;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.HeaderText = "Nombre";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            // 
            // clmStore
            // 
            this.clmStore.HeaderText = "Tienda";
            this.clmStore.Name = "clmStore";
            this.clmStore.ReadOnly = true;
            this.clmStore.Width = 200;
            // 
            // cbxStore
            // 
            this.cbxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(222, 14);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(255, 27);
            this.cbxStore.TabIndex = 22;
            this.cbxStore.Visible = false;
            // 
            // btnGetAll
            // 
            this.btnGetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnGetAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnGetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAll.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAll.ForeColor = System.Drawing.Color.White;
            this.btnGetAll.Location = new System.Drawing.Point(640, 14);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(152, 27);
            this.btnGetAll.TabIndex = 23;
            this.btnGetAll.Text = "Ver Todo";
            this.btnGetAll.UseVisualStyleBackColor = false;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(798, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 27);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 657);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.Resize += new System.EventHandler(this.Inventory_Resize);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.RadioButton rbtStore;
        private System.Windows.Forms.RadioButton rbtName;
        private System.Windows.Forms.RadioButton rbtId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStore;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnEdit;
    }
}