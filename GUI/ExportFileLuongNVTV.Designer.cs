namespace GUI
{
    partial class ExportFileLuongNVTV
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
            this.quanLyNhanSuDataSet5 = new GUI.QuanLyNhanSuDataSet5();
            this.bangCongNVThuViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangCongNVThuViecTableAdapter = new GUI.QuanLyNhanSuDataSet5TableAdapters.BangCongNVThuViecTableAdapter();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioLamThemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangCongNVThuViecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPBDataGridViewTextBoxColumn,
            this.maNVTVDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.luongTVDataGridViewTextBoxColumn,
            this.soGioLamThemDataGridViewTextBoxColumn,
            this.soNgayCongDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bangCongNVThuViecBindingSource;
            this.dgv.Location = new System.Drawing.Point(-1, 1);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1014, 434);
            this.dgv.TabIndex = 5;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(871, 441);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(132, 37);
            this.btnXuatFile.TabIndex = 6;
            this.btnXuatFile.Text = "Xuất file Excel";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // quanLyNhanSuDataSet5
            // 
            this.quanLyNhanSuDataSet5.DataSetName = "QuanLyNhanSuDataSet5";
            this.quanLyNhanSuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangCongNVThuViecBindingSource
            // 
            this.bangCongNVThuViecBindingSource.DataMember = "BangCongNVThuViec";
            this.bangCongNVThuViecBindingSource.DataSource = this.quanLyNhanSuDataSet5;
            // 
            // bangCongNVThuViecTableAdapter
            // 
            this.bangCongNVThuViecTableAdapter.ClearBeforeFill = true;
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "MaPB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "MaPB";
            this.maPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            this.maPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNVTVDataGridViewTextBoxColumn
            // 
            this.maNVTVDataGridViewTextBoxColumn.DataPropertyName = "MaNVTV";
            this.maNVTVDataGridViewTextBoxColumn.HeaderText = "MaNVTV";
            this.maNVTVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVTVDataGridViewTextBoxColumn.Name = "maNVTVDataGridViewTextBoxColumn";
            this.maNVTVDataGridViewTextBoxColumn.Width = 125;
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
            // luongTVDataGridViewTextBoxColumn
            // 
            this.luongTVDataGridViewTextBoxColumn.DataPropertyName = "LuongTV";
            this.luongTVDataGridViewTextBoxColumn.HeaderText = "LuongTV";
            this.luongTVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongTVDataGridViewTextBoxColumn.Name = "luongTVDataGridViewTextBoxColumn";
            this.luongTVDataGridViewTextBoxColumn.Width = 125;
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
            // ExportFileLuongNVTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 491);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportFileLuongNVTV";
            this.Text = "ExportFileLuongNVTV";
            this.Load += new System.EventHandler(this.ExportFileLuongNVTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangCongNVThuViecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnXuatFile;
        private QuanLyNhanSuDataSet5 quanLyNhanSuDataSet5;
        private System.Windows.Forms.BindingSource bangCongNVThuViecBindingSource;
        private QuanLyNhanSuDataSet5TableAdapters.BangCongNVThuViecTableAdapter bangCongNVThuViecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioLamThemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
    }
}