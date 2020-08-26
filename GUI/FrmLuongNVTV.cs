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

namespace GUI
{
    public partial class FrmLuongNVTV : Form
    {
        int chon = 0;
        public FrmLuongNVTV()
        {
            InitializeComponent();
        }

        private void FrmLuongNVTV_Load(object sender, EventArgs e)
        {
            XuLyLuongNVTV xl = new XuLyLuongNVTV();
            dgvLuongNVTV.DataSource = xl.LoadLuongNVTV();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //load comboBox
            cmbMaPB.DataSource = xl.LoadCmb();
            cmbMaPB.DisplayMember = "MaPB";
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
                if (cmbMaPB.Text == "" || txtMaNV.Text == "" || txtThang.Text == "" || txtNam.Text == "" || txtLuongTV.Text == "")
                {
                    MessageBox.Show("Vui lòng điều đẩy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyLuongNVTV xl = new XuLyLuongNVTV();
                    if (xl.InsertLuongNVTV(cmbMaPB.Text, txtMaNV.Text, int.Parse(txtThang.Text), int.Parse(txtNam.Text), long.Parse(txtLuongTV.Text), int.Parse(txtSoGioLamThem.Text), int.Parse(txtSoNgayCong.Text)))
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvLuongNVTV.DataSource = xl.LoadLuongNVTV();
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
                if (cmbMaPB.Text == "" || txtMaNV.Text == "" || txtThang.Text == "" || txtNam.Text == "" || txtLuongTV.Text == "")
                {
                    MessageBox.Show("Vui lòng điều mã nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyLuongNVTV xl = new XuLyLuongNVTV();
                    if (xl.UpdateLuongNVTV(cmbMaPB.Text, txtMaNV.Text, int.Parse(txtThang.Text), int.Parse(txtNam.Text), long.Parse(txtLuongTV.Text), int.Parse(txtSoGioLamThem.Text), int.Parse(txtSoNgayCong.Text)))
                        MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvLuongNVTV.DataSource = xl.LoadLuongNVTV();
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
                    XuLyLuongNVTV xl = new XuLyLuongNVTV();
                    if (xl.DELETELuongNVTV(txtMaNV.Text))
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvLuongNVTV.DataSource = xl.LoadLuongNVTV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng điều đúng thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvLuongNVTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cmbMaPB.Text = dgvLuongNVTV.Rows[index].Cells[0].Value.ToString();
            txtMaNV.Text = dgvLuongNVTV.Rows[index].Cells[1].Value.ToString();
            txtThang.Text = dgvLuongNVTV.Rows[index].Cells[2].Value.ToString();
            txtNam.Text = dgvLuongNVTV.Rows[index].Cells[3].Value.ToString();
            txtLuongTV.Text = dgvLuongNVTV.Rows[index].Cells[4].Value.ToString();
            txtSoGioLamThem.Text = dgvLuongNVTV.Rows[index].Cells[5].Value.ToString();
            txtSoNgayCong.Text = dgvLuongNVTV.Rows[index].Cells[6].Value.ToString();
            txtTongLuong.Text = dgvLuongNVTV.Rows[index].Cells[7].Value.ToString();
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            XuLiNV xl = new XuLiNV();
            dgvLuongNVTV.DataSource = xl.search2(txtTimKiem.Text);
        }
    }
}
