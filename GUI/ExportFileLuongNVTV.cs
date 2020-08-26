using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace GUI
{
    public partial class ExportFileLuongNVTV : Form
    {
        public ExportFileLuongNVTV()
        {
            InitializeComponent();
        }

        private void ExportFileLuongNVTV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet5.BangCongNVThuViec' table. You can move, or remove it, as needed.
            this.bangCongNVThuViecTableAdapter.Fill(this.quanLyNhanSuDataSet5.BangCongNVThuViec);

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            xuatFile(dgv, @"F:\xuatFile\", "BangLuongNhanVienThuViec");
        }
        private void xuatFile(DataGridView g, string url, string nameFile)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(url + nameFile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
    }
}
