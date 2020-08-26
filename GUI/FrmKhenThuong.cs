﻿using System;
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
    public partial class FrmKhenThuong : Form
    {
        int chon = 0;
        public FrmKhenThuong()
        {
            InitializeComponent();
        }

        private void FrmKhenThuong_Load(object sender, EventArgs e)
        {
            XuLyKhenThuong xl = new XuLyKhenThuong();
            dgvKhenThuong.DataSource = xl.LoadKhenThuong();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //load comboBox
            cmbMaPB.DataSource = xl.LoadCmb("SELECT * FROM PhongBan");
            cmbMaPB.DisplayMember = "MaPB";
            cmbMaNV.DataSource = xl.LoadCmb("SELECT * FROM TTCaNhan");
            cmbMaNV.DisplayMember = "MaNV";
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
                if (cmbMaPB.Text == "" || cmbMaNV.Text == "" || txtHoTen.Text == "" || txtTienThuong.Text == "" || txtMaKhenThuong.Text == "" || dtNgayKhenThuong.Text == "" || txtLyDo.Text == "")
                {
                    MessageBox.Show("Vui lòng điều đẩy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyKhenThuong xl = new XuLyKhenThuong();
                    if (xl.InsertKhenThuong(cmbMaPB.Text, cmbMaNV.Text, txtHoTen.Text, long.Parse(txtTienThuong.Text), txtMaKhenThuong.Text, DateTime.Parse(dtNgayKhenThuong.Text), txtLyDo.Text))
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvKhenThuong.DataSource = xl.LoadKhenThuong();
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
                if (cmbMaNV.Text == "")
                {
                    MessageBox.Show("Vui lòng điều mã nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyKhenThuong xl = new XuLyKhenThuong();
                    if (xl.UpdateKhenThuong(cmbMaPB.Text, cmbMaNV.Text, txtHoTen.Text, long.Parse(txtTienThuong.Text), txtMaKhenThuong.Text, DateTime.Parse(dtNgayKhenThuong.Text), txtLyDo.Text))
                        MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvKhenThuong.DataSource = xl.LoadKhenThuong();
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
                if (cmbMaNV.Text == "")
                {
                    MessageBox.Show("Vui lòng điều mã nhân viên cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyKhenThuong xl = new XuLyKhenThuong();
                    if (xl.DELETEKhenThuong(cmbMaNV.Text))
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvKhenThuong.DataSource = xl.LoadKhenThuong();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng điều đúng thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvKhenThuong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cmbMaPB.Text = dgvKhenThuong.Rows[index].Cells[0].Value.ToString();
            cmbMaNV.Text = dgvKhenThuong.Rows[index].Cells[1].Value.ToString();
            txtHoTen.Text = dgvKhenThuong.Rows[index].Cells[2].Value.ToString();
            txtTienThuong.Text = dgvKhenThuong.Rows[index].Cells[3].Value.ToString();
            txtMaKhenThuong.Text = dgvKhenThuong.Rows[index].Cells[4].Value.ToString();
            dtNgayKhenThuong.Text = dgvKhenThuong.Rows[index].Cells[5].Value.ToString();
            txtLyDo.Text = dgvKhenThuong.Rows[index].Cells[6].Value.ToString();
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

        
    }
}
