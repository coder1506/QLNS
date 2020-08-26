using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Microsoft.SqlServer.Server;

namespace GUI
{
    public partial class FrmLuongNV : Form
    {
        int chon = 0;
        public FrmLuongNV()
        {
            InitializeComponent();
        }
        private void FrmLuongNV_Load(object sender, EventArgs e)
        {
            XuLyLuongNV xl = new XuLyLuongNV();
            dgvLuongNV.DataSource = xl.LoadLuongNV();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //load comboBox
            cmbMaPB.DataSource = xl.LoadCmb("SELECT * FROM PhongBan");
            cmbMaPB.DisplayMember = "MaPB";
            cmbMaLuong.DataSource = xl.LoadCmb("SELECT * FROM BangLuongCongTy");
            cmbMaLuong.DisplayMember = "MaLuong";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            chon = 1;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chon = 2;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            chon = 3;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void them()
        {
            try
            {
                if (txtMaNV.Text == "" || txtThang.Text == "" || txtNam.Text == "" || cmbMaLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng điều đẩy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyLuongNV xl = new XuLyLuongNV();
                    if (xl.InsertLuongNV(cmbMaPB.Text, txtMaNV.Text, cmbMaLuong.Text, long.Parse(txtLCB.Text), long.Parse(txtPhuCap.Text), long.Parse(txtThuong.Text), long.Parse(txtKyLuat.Text),int.Parse(txtThang.Text), int.Parse(txtNam.Text), int.Parse(txtSoGioLamThem.Text), int.Parse(txtSoNgayCong.Text)))
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvLuongNV.DataSource = xl.LoadLuongNV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng điều đúng thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void sua()
        {
            try
            {
                if (txtMaNV.Text == "" || txtThang.Text == "" || txtNam.Text == "" )
                {
                    MessageBox.Show("Vui lòng điều mã nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyLuongNV xl = new XuLyLuongNV();
                    if (xl.UpdateLuongNV(cmbMaPB.Text, txtMaNV.Text, cmbMaLuong.Text, long.Parse(txtLCB.Text), long.Parse(txtPhuCap.Text), long.Parse(txtThuong.Text), long.Parse(txtKyLuat.Text), int.Parse(txtThang.Text), int.Parse(txtNam.Text), int.Parse(txtSoGioLamThem.Text), int.Parse(txtSoNgayCong.Text)))
                        MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvLuongNV.DataSource = xl.LoadLuongNV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng điều đúng thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void xoa()
        {
            try
            {
                if (txtMaNV.Text == "" || cmbMaPB.Text == "")
                {
                    MessageBox.Show("Vui lòng điều mã nhân viên cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyLuongNV xl = new XuLyLuongNV();
                    if (xl.DELETELuongNV(txtMaNV.Text))
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvLuongNV.DataSource = xl.LoadLuongNV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng điều đúng thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvLuongNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cmbMaPB.Text = dgvLuongNV.Rows[index].Cells[0].Value.ToString();
            txtMaNV.Text = dgvLuongNV.Rows[index].Cells[1].Value.ToString();
            cmbMaLuong.Text = dgvLuongNV.Rows[index].Cells[2].Value.ToString();
            txtLCB.Text = dgvLuongNV.Rows[index].Cells[3].Value.ToString();
            txtPhuCap.Text = dgvLuongNV.Rows[index].Cells[4].Value.ToString();
            txtThuong.Text = dgvLuongNV.Rows[index].Cells[5].Value.ToString();
            txtKyLuat.Text = dgvLuongNV.Rows[index].Cells[6].Value.ToString();
            txtThang.Text = dgvLuongNV.Rows[index].Cells[7].Value.ToString();
            txtNam.Text = dgvLuongNV.Rows[index].Cells[8].Value.ToString();
            txtSoGioLamThem.Text = dgvLuongNV.Rows[index].Cells[9].Value.ToString();
            txtSoNgayCong.Text = dgvLuongNV.Rows[index].Cells[10].Value.ToString();
            txtTongLuong.Text = dgvLuongNV.Rows[index].Cells[11].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            switch (chon)
            {
                case 1:
                    tl = MessageBox.Show("Bạn có muốn thêm không ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                        them();
                    break;
                case 2:
                    tl = MessageBox.Show("Bạn có muốn sửa không ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                        sua();
                    break;
                case 3:
                    tl = MessageBox.Show("Bạn có muốn xóa không ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                        xoa();
                    break;
            }
            chon = 0;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            chon = 0;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void cmbMaLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            XuLiNV xl = new XuLiNV();
            dgvLuongNV.DataSource = xl.search2(txtTimKiem.Text);
        }
    }
}
