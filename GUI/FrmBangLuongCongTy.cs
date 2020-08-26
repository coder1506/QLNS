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
    public partial class FrmBangLuongCongTy : Form
    {
        int chon = 0;
        public FrmBangLuongCongTy()
        {
            InitializeComponent();
        }

        private void FrmBangLuongCongTy_Load(object sender, EventArgs e)
        {
            XuLyBangLuongCTy xl = new XuLyBangLuongCTy();
            dgvBangLuongCTy.DataSource = xl.LoadBangLuongCTy();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //load comboBox
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
                if (cmbMaLuong.Text == "" ||  txtLCBmoi.Text == "" || txtPhuCapmoi.Text == "")
                {
                    MessageBox.Show("Vui lòng điều đẩy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyBangLuongCTy xl = new XuLyBangLuongCTy();
                    if (xl.InsertBangLuongCTy(cmbMaLuong.Text, long.Parse(txtLCBmoi.Text), long.Parse(txtPhuCapmoi.Text), DateTime.Parse(dtNgaySua.Text)))
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvBangLuongCTy.DataSource = xl.LoadBangLuongCTy();
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
                if (cmbMaLuong.Text == "" )
                {
                    MessageBox.Show("Vui lòng điều mã nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyBangLuongCTy xl = new XuLyBangLuongCTy();
                    if (xl.UpdateBangLuongCTy(cmbMaLuong.Text, long.Parse(txtLCBmoi.Text), long.Parse(txtPhuCapmoi.Text), DateTime.Parse(dtNgaySua.Text)))
                        MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvBangLuongCTy.DataSource = xl.LoadBangLuongCTy();
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
                if (cmbMaLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng điều mã nhân viên cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyBangLuongCTy xl = new XuLyBangLuongCTy();
                    if (xl.DELETEBangLuongCTy(cmbMaLuong.Text))
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvBangLuongCTy.DataSource = xl.LoadBangLuongCTy();
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
            cmbMaLuong.Text = dgvBangLuongCTy.Rows[index].Cells[0].Value.ToString();
            txtLCBcu.Text = dgvBangLuongCTy.Rows[index].Cells[1].Value.ToString();
            txtPhuCapcu.Text = dgvBangLuongCTy.Rows[index].Cells[2].Value.ToString();
            dtNgaySua.Text = dgvBangLuongCTy.Rows[index].Cells[3].Value.ToString();
            txtLCBmoi.Text = "";
            txtPhuCapmoi.Text = "";
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
