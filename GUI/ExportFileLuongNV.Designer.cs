namespace GUI
{
    partial class ExportFileLuongNV
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.quanLyNhanSuDataSet4 = new GUI.QuanLyNhanSuDataSet4();
            this.bangCongNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangCongNVTableAdapter = new GUI.QuanLyNhanSuDataSet4TableAdapters.BangCongNVTableAdapter();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyLuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioLamThemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangCongNVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPBDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.maLuongDataGridViewTextBoxColumn,
            this.lCBDataGridViewTextBoxColumn,
            this.phuCapDataGridViewTextBoxColumn,
            this.thuongDataGridViewTextBoxColumn,
            this.kyLuatDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.soGioLamThemDataGridViewTextBoxColumn,
            this.soNgayCongDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bangCongNVBindingSource;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1014, 434);
            this.dgv.TabIndex = 4;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(858, 440);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(132, 37);
            this.btnXuatFile.TabIndex = 5;
            this.btnXuatFile.Text = "Xuất file Excel";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // quanLyNhanSuDataSet4
            // 
            this.quanLyNhanSuDataSet4.DataSetName = "QuanLyNhanSuDataSet4";
            this.quanLyNhanSuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangCongNVBindingSource
            // 
            this.bangCongNVBindingSource.DataMember = "BangCongNV";
            this.bangCongNVBindingSource.DataSource = this.quanLyNhanSuDataSet4;
            // 
            // bangCongNVTableAdapter
            // 
            this.bangCongNVTableAdapter.ClearBeforeFill = true;
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "MaPB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "MaPB";
            this.maPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            this.maPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // maLuongDataGridViewTextBoxColumn
            // 
            this.maLuongDataGridViewTextBoxColumn.DataPropertyName = "MaLuong";
            this.maLuongDataGridViewTextBoxColumn.HeaderText = "MaLuong";
            this.maLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLuongDataGridViewTextBoxColumn.Name = "maLuongDataGridViewTextBoxColumn";
            this.maLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // lCBDataGridViewTextBoxColumn
            // 
            this.lCBDataGridViewTextBoxColumn.DataPropertyName = "LCB";
            this.lCBDataGridViewTextBoxColumn.HeaderText = "LCB";
            this.lCBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lCBDataGridViewTextBoxColumn.Name = "lCBDataGridViewTextBoxColumn";
            this.lCBDataGridViewTextBoxColumn.Width = 125;
            // 
            // phuCapDataGridViewTextBoxColumn
            // 
            this.phuCapDataGridViewTextBoxColumn.DataPropertyName = "PhuCap";
            this.phuCapDataGridViewTextBoxColumn.HeaderText = "PhuCap";
            this.phuCapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phuCapDataGridViewTextBoxColumn.Name = "phuCapDataGridViewTextBoxColumn";
            this.phuCapDataGridViewTextBoxColumn.Width = 125;
            // 
            // thuongDataGridViewTextBoxColumn
            // 
            this.thuongDataGridViewTextBoxColumn.DataPropertyName = "Thuong";
            this.thuongDataGridViewTextBoxColumn.HeaderText = "Thuong";
            this.thuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thuongDataGridViewTextBoxColumn.Name = "thuongDataGridViewTextBoxColumn";
            this.thuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // kyLuatDataGridViewTextBoxColumn
            // 
            this.kyLuatDataGridViewTextBoxColumn.DataPropertyName = "KyLuat";
            this.kyLuatDataGridViewTextBoxColumn.HeaderText = "KyLuat";
            this.kyLuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kyLuatDataGridViewTextBoxColumn.Name = "kyLuatDataGridViewTextBoxColumn";
            this.kyLuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "Thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Thang";
            this.thangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            this.thangDataGridViewTextBoxColumn.Width = 125;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Nam";
            this.namDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.Width = 125;
            // 
            // soGioLamThemDataGridViewTextBoxColumn
            // 
            this.soGioLamThemDataGridViewTextBoxColumn.DataPropertyName = "SoGioLamThem";
            this.soGioLamThemDataGridViewTextBoxColumn.HeaderText = "SoGioLamThem";
            this.soGioLamThemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soGioLamThemDataGridViewTextBoxColumn.Name = "soGioLamThemDataGridViewTextBoxColumn";
            this.soGioLamThemDataGridViewTextBoxColumn.Width = 125;
            // 
            // soNgayCongDataGridViewTextBoxColumn
            // 
            this.soNgayCongDataGridViewTextBoxColumn.DataPropertyName = "SoNgayCong";
            this.soNgayCongDataGridViewTextBoxColumn.HeaderText = "SoNgayCong";
            this.soNgayCongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soNgayCongDataGridViewTextBoxColumn.Name = "soNgayCongDataGridViewTextBoxColumn";
            this.soNgayCongDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongDataGridViewTextBoxColumn
            // 
            this.luongDataGridViewTextBoxColumn.DataPropertyName = "Luong";
            this.luongDataGridViewTextBoxColumn.HeaderText = "Luong";
            this.luongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongDataGridViewTextBoxColumn.Name = "luongDataGridViewTextBoxColumn";
            this.luongDataGridViewTextBoxColumn.Width = 125;
            // 
            // ExportFileLuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 501);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportFileLuongNV";
            this.Text = "ExportFileLuongNV";
            this.Load += new System.EventHandler(this.ExportFileLuongNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangCongNVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnXuatFile;
        private QuanLyNhanSuDataSet4 quanLyNhanSuDataSet4;
        private System.Windows.Forms.BindingSource bangCongNVBindingSource;
        private QuanLyNhanSuDataSet4TableAdapters.BangCongNVTableAdapter bangCongNVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyLuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioLamThemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
    }
}