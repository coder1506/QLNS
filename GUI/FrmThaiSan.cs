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
    public partial class FrmThaiSan : Form
    {
        int chon = 0;
        public FrmThaiSan()
        {
            InitializeComponent();
        }

        private void FrmThaiSan_Load(object sender, EventArgs e)
        {
            XuLyThaiSan xl = new XuLyThaiSan();
            dgvThaiSan.DataSource = xl.LoadTS();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //load comboBox
            cmbMaPB.DataSource = xl.LoadCmb("SELECT * FROM PhongBan");
            cmbMaPB.DisplayMember = "MaPB";
            
        }

        private void dgvThaiSan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cmbMaPB.Text = dgvThaiSan.Rows[index].Cells[0].Value.ToString();
            txtMaNV.Text = dgvThaiSan.Rows[index].Cells[1].Value.ToString();
            txtHoTen.Text = dgvThaiSan.Rows[index].Cells[2].Value.ToString();
            txtTroCap.Text = dgvThaiSan.Rows[index].Cells[3].Value.ToString();
            dtNgayVe.Text = dgvThaiSan.Rows[index].Cells[4].Value.ToString();
            dtNgayTroLai.Text = dgvThaiSan.Rows[index].Cells[5].Value.ToString();
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
                if (txtMaNV.Text == "" || cmbMaPB.Text == "" || txtHoTen.Text == "" || txtTroCap.Text == "")
                {
                    MessageBox.Show("Vui lòng điều đẩy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyThaiSan xl = new XuLyThaiSan();
                    if (xl.InsertTS(cmbMaPB.Text, txtMaNV.Text, txtHoTen.Text, long.Parse(txtTroCap.Text), DateTime.Parse(dtNgayVe.Text), DateTime.Parse(dtNgayTroLai.Text)))
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvThaiSan.DataSource = xl.LoadTS();
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
                if (txtMaNV.Text == "" || cmbMaPB.Text == "" || txtHoTen.Text == "" || txtTroCap.Text == "")
                {
                    MessageBox.Show("Vui lòng điều mã nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyThaiSan xl = new XuLyThaiSan();
                    if (xl.UpdateTS(cmbMaPB.Text, txtMaNV.Text, txtHoTen.Text, long.Parse(txtTroCap.Text), DateTime.Parse(dtNgayVe.Text), DateTime.Parse(dtNgayTroLai.Text)))
                        MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvThaiSan.DataSource = xl.LoadTS();
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
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Vui lòng điều mã nhân viên cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XuLyThaiSan xl = new XuLyThaiSan();
                    if (xl.DeleteTS(txtMaNV.Text))
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvThaiSan.DataSource = xl.LoadTS();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng điều đúng thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
