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
    public partial class ExportFileLuongNV : Form
    {
        public ExportFileLuongNV()
        {
            InitializeComponent();
        }

        private void ExportFileLuongNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet4.BangCongNV' table. You can move, or remove it, as needed.
            this.bangCongNVTableAdapter.Fill(this.quanLyNhanSuDataSet4.BangCongNV);

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            xuatFile(dgv, @"F:\xuatFile\", "BangLuongNhanVien");
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
