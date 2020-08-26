namespace GUI
{
    partial class exportFileNV
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
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.quanLyNhanSuDataSet = new GUI.QuanLyNhanSuDataSet();
            this.quanLyNhanSuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhanSuDataSet1 = new GUI.QuanLyNhanSuDataSet1();
            this.quanLyNhanSuDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv = new System.Windows.Forms.DataGridView();
            this.quanLyNhanSuDataSet2 = new GUI.QuanLyNhanSuDataSet2();
            this.tTNVCoBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTNVCoBanTableAdapter = new GUI.QuanLyNhanSuDataSet2TableAdapters.TTNVCoBanTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMTNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianLamViecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTNVCoBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(855, 455);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(132, 37);
            this.btnXuatFile.TabIndex = 1;
            this.btnXuatFile.Text = "Xuất file Excel";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // quanLyNhanSuDataSet
            // 
            this.quanLyNhanSuDataSet.DataSetName = "QuanLyNhanSuDataSet";
            this.quanLyNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyNhanSuDataSetBindingSource
            // 
            this.quanLyNhanSuDataSetBindingSource.DataSource = this.quanLyNhanSuDataSet;
            this.quanLyNhanSuDataSetBindingSource.Position = 0;
            // 
            // quanLyNhanSuDataSet1
            // 
            this.quanLyNhanSuDataSet1.DataSetName = "QuanLyNhanSuDataSet1";
            this.quanLyNhanSuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyNhanSuDataSet1BindingSource
            // 
            this.quanLyNhanSuDataSet1BindingSource.DataSource = this.quanLyNhanSuDataSet1;
            this.quanLyNhanSuDataSet1BindingSource.Position = 0;
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.maPBDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.maLuongDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.cMTNDDataGridViewTextBoxColumn,
            this.ngayCapDataGridViewTextBoxColumn,
            this.noiCapDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.thoiGianLamViecDataGridViewTextBoxColumn,
            this.ngayKyDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.tinhTrangHDDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.tTNVCoBanBindingSource;
            this.dgv.Location = new System.Drawing.Point(1, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1011, 449);
            this.dgv.TabIndex = 2;
            // 
            // quanLyNhanSuDataSet2
            // 
            this.quanLyNhanSuDataSet2.DataSetName = "QuanLyNhanSuDataSet2";
            this.quanLyNhanSuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTNVCoBanBindingSource
            // 
            this.tTNVCoBanBindingSource.DataMember = "TTNVCoBan";
            this.tTNVCoBanBindingSource.DataSource = this.quanLyNhanSuDataSet2;
            // 
            // tTNVCoBanTableAdapter
            // 
            this.tTNVCoBanTableAdapter.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 68;
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "MaPB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "MaPB";
            this.maPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            this.maPBDataGridViewTextBoxColumn.Width = 69;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 68;
            // 
            // maLuongDataGridViewTextBoxColumn
            // 
            this.maLuongDataGridViewTextBoxColumn.DataPropertyName = "MaLuong";
            this.maLuongDataGridViewTextBoxColumn.HeaderText = "MaLuong";
            this.maLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLuongDataGridViewTextBoxColumn.Name = "maLuongDataGridViewTextBoxColumn";
            this.maLuongDataGridViewTextBoxColumn.Width = 69;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 68;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 69;
            // 
            // cMTNDDataGridViewTextBoxColumn
            // 
            this.cMTNDDataGridViewTextBoxColumn.DataPropertyName = "CMTND";
            this.cMTNDDataGridViewTextBoxColumn.HeaderText = "CMTND";
            this.cMTNDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cMTNDDataGridViewTextBoxColumn.Name = "cMTNDDataGridViewTextBoxColumn";
            this.cMTNDDataGridViewTextBoxColumn.Width = 68;
            // 
            // ngayCapDataGridViewTextBoxColumn
            // 
            this.ngayCapDataGridViewTextBoxColumn.DataPropertyName = "NgayCap";
            this.ngayCapDataGridViewTextBoxColumn.HeaderText = "NgayCap";
            this.ngayCapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCapDataGridViewTextBoxColumn.Name = "ngayCapDataGridViewTextBoxColumn";
            this.ngayCapDataGridViewTextBoxColumn.Width = 68;
            // 
            // noiCapDataGridViewTextBoxColumn
            // 
            this.noiCapDataGridViewTextBoxColumn.DataPropertyName = "NoiCap";
            this.noiCapDataGridViewTextBoxColumn.HeaderText = "NoiCap";
            this.noiCapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noiCapDataGridViewTextBoxColumn.Name = "noiCapDataGridViewTextBoxColumn";
            this.noiCapDataGridViewTextBoxColumn.Width = 69;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.Width = 68;
            // 
            // thoiGianLamViecDataGridViewTextBoxColumn
            // 
            this.thoiGianLamViecDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianLamViec";
            this.thoiGianLamViecDataGridViewTextBoxColumn.HeaderText = "ThoiGianLamViec";
            this.thoiGianLamViecDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianLamViecDataGridViewTextBoxColumn.Name = "thoiGianLamViecDataGridViewTextBoxColumn";
            this.thoiGianLamViecDataGridViewTextBoxColumn.Width = 69;
            // 
            // ngayKyDataGridViewTextBoxColumn
            // 
            this.ngayKyDataGridViewTextBoxColumn.DataPropertyName = "NgayKy";
            this.ngayKyDataGridViewTextBoxColumn.HeaderText = "NgayKy";
            this.ngayKyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayKyDataGridViewTextBoxColumn.Name = "ngayKyDataGridViewTextBoxColumn";
            this.ngayKyDataGridViewTextBoxColumn.Width = 68;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 69;
            // 
            // tinhTrangHDDataGridViewTextBoxColumn
            // 
            this.tinhTrangHDDataGridViewTextBoxColumn.DataPropertyName = "TinhTrangHD";
            this.tinhTrangHDDataGridViewTextBoxColumn.HeaderText = "TinhTrangHD";
            this.tinhTrangHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhTrangHDDataGridViewTextBoxColumn.Name = "tinhTrangHDDataGridViewTextBoxColumn";
            this.tinhTrangHDDataGridViewTextBoxColumn.Width = 68;
            // 
            // exportFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 502);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnXuatFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exportFile";
            this.Text = "exportFile";
            this.Load += new System.EventHandler(this.exportFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTNVCoBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.BindingSource quanLyNhanSuDataSetBindingSource;
        private QuanLyNhanSuDataSet quanLyNhanSuDataSet;
        private QuanLyNhanSuDataSet1 quanLyNhanSuDataSet1;
        private System.Windows.Forms.BindingSource quanLyNhanSuDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dgv;
        private QuanLyNhanSuDataSet2 quanLyNhanSuDataSet2;
        private System.Windows.Forms.BindingSource tTNVCoBanBindingSource;
        private QuanLyNhanSuDataSet2TableAdapters.TTNVCoBanTableAdapter tTNVCoBanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMTNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianLamViecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangHDDataGridViewTextBoxColumn;
    }
}