namespace GUI
{
    partial class ExportFileNVTV
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
            this.quanLyNhanSuDataSet3 = new GUI.QuanLyNhanSuDataSet3();
            this.hoSoNVThuViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoSoNVThuViecTableAdapter = new GUI.QuanLyNhanSuDataSet3TableAdapters.HoSoNVThuViecTableAdapter();
            this.maNVTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viTriTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soThangTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoSoNVThuViecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVTVDataGridViewTextBoxColumn,
            this.maPBDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.viTriTVDataGridViewTextBoxColumn,
            this.soThangTVDataGridViewTextBoxColumn,
            this.ngayBatDauDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.trinhDoDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.hoSoNVThuViecBindingSource;
            this.dgv.Location = new System.Drawing.Point(-1, 1);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1011, 449);
            this.dgv.TabIndex = 3;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(868, 454);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(132, 37);
            this.btnXuatFile.TabIndex = 4;
            this.btnXuatFile.Text = "Xuất file Excel";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // quanLyNhanSuDataSet3
            // 
            this.quanLyNhanSuDataSet3.DataSetName = "QuanLyNhanSuDataSet3";
            this.quanLyNhanSuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoSoNVThuViecBindingSource
            // 
            this.hoSoNVThuViecBindingSource.DataMember = "HoSoNVThuViec";
            this.hoSoNVThuViecBindingSource.DataSource = this.quanLyNhanSuDataSet3;
            // 
            // hoSoNVThuViecTableAdapter
            // 
            this.hoSoNVThuViecTableAdapter.ClearBeforeFill = true;
            // 
            // maNVTVDataGridViewTextBoxColumn
            // 
            this.maNVTVDataGridViewTextBoxColumn.DataPropertyName = "MaNVTV";
            this.maNVTVDataGridViewTextBoxColumn.HeaderText = "MaNVTV";
            this.maNVTVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVTVDataGridViewTextBoxColumn.Name = "maNVTVDataGridViewTextBoxColumn";
            this.maNVTVDataGridViewTextBoxColumn.Width = 125;
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "MaPB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "MaPB";
            this.maPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            this.maPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // viTriTVDataGridViewTextBoxColumn
            // 
            this.viTriTVDataGridViewTextBoxColumn.DataPropertyName = "ViTriTV";
            this.viTriTVDataGridViewTextBoxColumn.HeaderText = "ViTriTV";
            this.viTriTVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.viTriTVDataGridViewTextBoxColumn.Name = "viTriTVDataGridViewTextBoxColumn";
            this.viTriTVDataGridViewTextBoxColumn.Width = 125;
            // 
            // soThangTVDataGridViewTextBoxColumn
            // 
            this.soThangTVDataGridViewTextBoxColumn.DataPropertyName = "SoThangTV";
            this.soThangTVDataGridViewTextBoxColumn.HeaderText = "SoThangTV";
            this.soThangTVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soThangTVDataGridViewTextBoxColumn.Name = "soThangTVDataGridViewTextBoxColumn";
            this.soThangTVDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayBatDauDataGridViewTextBoxColumn
            // 
            this.ngayBatDauDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDau";
            this.ngayBatDauDataGridViewTextBoxColumn.HeaderText = "NgayBatDau";
            this.ngayBatDauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayBatDauDataGridViewTextBoxColumn.Name = "ngayBatDauDataGridViewTextBoxColumn";
            this.ngayBatDauDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 125;
            // 
            // trinhDoDataGridViewTextBoxColumn
            // 
            this.trinhDoDataGridViewTextBoxColumn.DataPropertyName = "TrinhDo";
            this.trinhDoDataGridViewTextBoxColumn.HeaderText = "TrinhDo";
            this.trinhDoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trinhDoDataGridViewTextBoxColumn.Name = "trinhDoDataGridViewTextBoxColumn";
            this.trinhDoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ExportFileNVTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 503);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportFileNVTV";
            this.Text = "ExportFileNVTV";
            this.Load += new System.EventHandler(this.ExportFileNVTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoSoNVThuViecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnXuatFile;
        private QuanLyNhanSuDataSet3 quanLyNhanSuDataSet3;
        private System.Windows.Forms.BindingSource hoSoNVThuViecBindingSource;
        private QuanLyNhanSuDataSet3TableAdapters.HoSoNVThuViecTableAdapter hoSoNVThuViecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viTriTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soThangTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhDoDataGridViewTextBoxColumn;
    }
}