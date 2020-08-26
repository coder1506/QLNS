namespace GUI
{
    partial class ExportFileBangLuongCongTy
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
            this.quanLyNhanSuDataSet6 = new GUI.QuanLyNhanSuDataSet6();
            this.bangLuongCongTyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangLuongCongTyTableAdapter = new GUI.QuanLyNhanSuDataSet6TableAdapters.BangLuongCongTyTableAdapter();
            this.maLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongCongTyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLuongDataGridViewTextBoxColumn,
            this.lCBDataGridViewTextBoxColumn,
            this.phuCapDataGridViewTextBoxColumn,
            this.ngaySuaDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bangLuongCongTyBindingSource;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1011, 449);
            this.dgv.TabIndex = 3;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(868, 455);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(132, 37);
            this.btnXuatFile.TabIndex = 4;
            this.btnXuatFile.Text = "Xuất file Excel";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // quanLyNhanSuDataSet6
            // 
            this.quanLyNhanSuDataSet6.DataSetName = "QuanLyNhanSuDataSet6";
            this.quanLyNhanSuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangLuongCongTyBindingSource
            // 
            this.bangLuongCongTyBindingSource.DataMember = "BangLuongCongTy";
            this.bangLuongCongTyBindingSource.DataSource = this.quanLyNhanSuDataSet6;
            // 
            // bangLuongCongTyTableAdapter
            // 
            this.bangLuongCongTyTableAdapter.ClearBeforeFill = true;
            // 
            // maLuongDataGridViewTextBoxColumn
            // 
            this.maLuongDataGridViewTextBoxColumn.DataPropertyName = "MaLuong";
            this.maLuongDataGridViewTextBoxColumn.HeaderText = "MaLuong";
            this.maLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLuongDataGridViewTextBoxColumn.Name = "maLuongDataGridViewTextBoxColumn";
            // 
            // lCBDataGridViewTextBoxColumn
            // 
            this.lCBDataGridViewTextBoxColumn.DataPropertyName = "LCB";
            this.lCBDataGridViewTextBoxColumn.HeaderText = "LCB";
            this.lCBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lCBDataGridViewTextBoxColumn.Name = "lCBDataGridViewTextBoxColumn";
            // 
            // phuCapDataGridViewTextBoxColumn
            // 
            this.phuCapDataGridViewTextBoxColumn.DataPropertyName = "PhuCap";
            this.phuCapDataGridViewTextBoxColumn.HeaderText = "PhuCap";
            this.phuCapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phuCapDataGridViewTextBoxColumn.Name = "phuCapDataGridViewTextBoxColumn";
            // 
            // ngaySuaDataGridViewTextBoxColumn
            // 
            this.ngaySuaDataGridViewTextBoxColumn.DataPropertyName = "NgaySua";
            this.ngaySuaDataGridViewTextBoxColumn.HeaderText = "NgaySua";
            this.ngaySuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySuaDataGridViewTextBoxColumn.Name = "ngaySuaDataGridViewTextBoxColumn";
            // 
            // ExportFileBangLuongCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 521);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportFileBangLuongCongTy";
            this.Text = "ExportFileBangLuongCongTy";
            this.Load += new System.EventHandler(this.ExportFileBangLuongCongTy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongCongTyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnXuatFile;
        private QuanLyNhanSuDataSet6 quanLyNhanSuDataSet6;
        private System.Windows.Forms.BindingSource bangLuongCongTyBindingSource;
        private QuanLyNhanSuDataSet6TableAdapters.BangLuongCongTyTableAdapter bangLuongCongTyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySuaDataGridViewTextBoxColumn;
    }
}