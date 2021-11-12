namespace BetaMartAnggun
{
    partial class Form1
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaJualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new BetaMartAnggun.AppData();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHargaBeli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStokBarang = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new BetaMartAnggun.AppDataTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(25, 156);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.stokBarangDataGridViewTextBoxColumn,
            this.jumlahDataGridViewTextBoxColumn,
            this.hargaBeliDataGridViewTextBoxColumn,
            this.hargaJualDataGridViewTextBoxColumn,
            this.imagesDataGridViewImageColumn});
            this.dataGridView.DataSource = this.employeesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(4, 230);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(572, 199);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // stokBarangDataGridViewTextBoxColumn
            // 
            this.stokBarangDataGridViewTextBoxColumn.DataPropertyName = "StokBarang";
            this.stokBarangDataGridViewTextBoxColumn.HeaderText = "StokBarang";
            this.stokBarangDataGridViewTextBoxColumn.Name = "stokBarangDataGridViewTextBoxColumn";
            this.stokBarangDataGridViewTextBoxColumn.Width = 110;
            // 
            // jumlahDataGridViewTextBoxColumn
            // 
            this.jumlahDataGridViewTextBoxColumn.DataPropertyName = "Jumlah";
            this.jumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            this.jumlahDataGridViewTextBoxColumn.Name = "jumlahDataGridViewTextBoxColumn";
            this.jumlahDataGridViewTextBoxColumn.Width = 90;
            // 
            // hargaBeliDataGridViewTextBoxColumn
            // 
            this.hargaBeliDataGridViewTextBoxColumn.DataPropertyName = "HargaBeli";
            this.hargaBeliDataGridViewTextBoxColumn.HeaderText = "HargaBeli";
            this.hargaBeliDataGridViewTextBoxColumn.Name = "hargaBeliDataGridViewTextBoxColumn";
            // 
            // hargaJualDataGridViewTextBoxColumn
            // 
            this.hargaJualDataGridViewTextBoxColumn.DataPropertyName = "HargaJual";
            this.hargaJualDataGridViewTextBoxColumn.HeaderText = "HargaJual";
            this.hargaJualDataGridViewTextBoxColumn.Name = "hargaJualDataGridViewTextBoxColumn";
            // 
            // imagesDataGridViewImageColumn
            // 
            this.imagesDataGridViewImageColumn.DataPropertyName = "Images";
            this.imagesDataGridViewImageColumn.HeaderText = "Images";
            this.imagesDataGridViewImageColumn.Name = "imagesDataGridViewImageColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stok Barang:";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Tan;
            this.panel.Controls.Add(this.txtHargaJual);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtHargaBeli);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtJumlah);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtStokBarang);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.btnBrowse);
            this.panel.Controls.Add(this.label1);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(660, 184);
            this.panel.TabIndex = 0;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "HargaJual", true));
            this.txtHargaJual.Location = new System.Drawing.Point(204, 113);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(240, 20);
            this.txtHargaJual.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Harga Jual:";
            // 
            // txtHargaBeli
            // 
            this.txtHargaBeli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "HargaBeli", true));
            this.txtHargaBeli.Location = new System.Drawing.Point(204, 77);
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.Size = new System.Drawing.Size(240, 20);
            this.txtHargaBeli.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Harga Beli:";
            // 
            // txtJumlah
            // 
            this.txtJumlah.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Jumlah", true));
            this.txtJumlah.Location = new System.Drawing.Point(204, 41);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(240, 20);
            this.txtJumlah.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jumlah:";
            // 
            // txtStokBarang
            // 
            this.txtStokBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "StokBarang", true));
            this.txtStokBarang.Location = new System.Drawing.Point(204, 6);
            this.txtStokBarang.Name = "txtStokBarang";
            this.txtStokBarang.Size = new System.Drawing.Size(240, 20);
            this.txtStokBarang.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesBindingSource, "Images", true));
            this.pictureBox.Location = new System.Drawing.Point(5, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(115, 146);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(55, 198);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(521, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Search:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(582, 230);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(82, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(582, 276);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(582, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(582, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(669, 434);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHargaBeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStokBarang;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private AppData appData;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private AppDataTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaJualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagesDataGridViewImageColumn;
    }
}

