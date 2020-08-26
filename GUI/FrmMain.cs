using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMain : Form
    {
        private static string quyen = "admin";

        public string Quyen { get => quyen; set => quyen = value; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
            this.Close();
            //dn.Show();


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (quyen.ToLower().Equals("user")) ql.Enabled = false;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void menuItemdmk_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau fdm = new FrmDoiMatKhau();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            FrmThongTinCoBan fdm = new FrmThongTinCoBan();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            FrmThongTinCaNhan fdm = new FrmThongTinCaNhan();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            FrmnhanVienThuViec fdm = new FrmnhanVienThuViec();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            FrmPhongBan fdm = new FrmPhongBan();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            FrmLuongNV fdm = new FrmLuongNV();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            FrmBangLuongCongTy fdm = new FrmBangLuongCongTy();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            DangKi fdm = new DangKi();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void BaoHiem_Click(object sender, EventArgs e)
        {
            FrmBaoHiem fdm = new FrmBaoHiem();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void ThaiSan_Click(object sender, EventArgs e)
        {
            FrmThaiSan fdm = new FrmThaiSan();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void LuongNhanVien_Click(object sender, EventArgs e)
        {
            FrmLuongNV fdm = new FrmLuongNV();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void LuongNhanVienThuViec_Click(object sender, EventArgs e)
        {
            FrmLuongNVTV fdm = new FrmLuongNVTV();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuatNV_Click(object sender, EventArgs e)
        {
            exportFileNV fdm = new exportFileNV();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void xuatNVTV_Click(object sender, EventArgs e)
        {
            ExportFileNVTV fdm = new ExportFileNVTV();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void LuongNV_Click(object sender, EventArgs e)
        {
            ExportFileLuongNV fdm = new ExportFileLuongNV();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void LuongNVTV_Click(object sender, EventArgs e)
        {
            ExportFileLuongNVTV fdm = new ExportFileLuongNVTV();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void BangLuong_Click(object sender, EventArgs e)
        {
            ExportFileBangLuongCongTy fdm = new ExportFileBangLuongCongTy();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhenThuong fdm = new FrmKhenThuong();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void kỷLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKyLuat fdm = new FrmKyLuat();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void tăngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTangLuong fdm = new FrmTangLuong();
            main_show.Show();
            main_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            main_show.Controls.Add(fdm);
            fdm.Show();
        }
    }
}
