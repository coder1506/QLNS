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
    public partial class FrmThongTinCoBan : Form
    {
        public FrmThongTinCoBan()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int chon = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            txtcmt.Clear();
            txtcv.Clear();
            txtht.Clear();
            txtnc.Clear();
            txtTg.Clear();
            txttthd.Clear();
            ns.Value = DateTime.Now;
            nk.Value = DateTime.Now;
            nhh.Value = DateTime.Now;
            nc.Value = DateTime.Now;
            gtnam.Checked = false;
            gtnu.Checked = false;
            cbmp.Text = "";
            cbml.Text = "";
            cbmnv.Text = "";
        }

        private void FrmThongTinCoBan_Load(object sender, EventArgs e)
        {
            XuLiNV xl = new XuLiNV();
            vCn.DataSource = xl.hienThiBangCb();
            cbmp.DataSource = xl.hienThiPB();
            cbml.DataSource = xl.hienThiL();
            cbmnv.DataSource = xl.hienThiBangCb();
            cbmp.DisplayMember = "MaPB";
            cbml.DisplayMember = "MaLuong";
            cbmnv.DisplayMember = "MaNV";
            cbmp.ValueMember = "MaPB";
            cbml.ValueMember = "MaLuong";
            cbmnv.ValueMember = "MaNV";
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void vCn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                cbmnv.SelectedValue = vCn.Rows[i].Cells[0].Value.ToString();
                cbml.SelectedValue = vCn.Rows[i].Cells["MaLuong"].Value.ToString();
                cbmp.SelectedValue = vCn.Rows[i].Cells["MaPB"].Value.ToString();
                txtcmt.Text = vCn.Rows[i].Cells["CMTND"].Value.ToString();
                nc.Value = (DateTime)vCn.Rows[i].Cells["NgayCap"].Value;
                ns.Value = (DateTime)vCn.Rows[i].Cells["NgaySinh"].Value;
                nk.Value = (DateTime)vCn.Rows[i].Cells["NgayKy"].Value;
                nhh.Value = (DateTime)vCn.Rows[i].Cells["NgayHetHan"].Value;
                txtht.Text = vCn.Rows[i].Cells["HoTen"].Value.ToString();
                txtcv.Text = vCn.Rows[i].Cells["ChucVu"].Value.ToString();
                txtnc.Text = vCn.Rows[i].Cells["NoiCap"].Value.ToString();
                txtTg.Text = vCn.Rows[i].Cells["ThoiGianLamViec"].Value.ToString();
                txttthd.Text = vCn.Rows[i].Cells["TinhTrangHD"].Value.ToString();
                if (vCn.Rows[i].Cells["GioiTinh"].Value.ToString().ToLower().Equals("nam")) { gtnam.Checked = true; gtnu.Checked = false; }
                else { gtnam.Checked = false; gtnu.Checked = true; }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã chọn sai tác vụ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void them()
        {
            XuLiNV xl = new XuLiNV();
            string gt = "";
            if (gtnam.Checked == true) { gt = "nam"; }
            else if (gtnu.Checked == true) gt = "nữ";
            if (xl.themNV(cbmnv.Text, cbmp.Text, txtht.Text, cbml.Text, DateTime.Parse(ns.Text), gt, txtcmt.Text, DateTime.Parse(nc.Text), txtnc.Text, txtcv.Text, int.Parse(txtTg.Text), DateTime.Parse(nk.Text), DateTime.Parse(nhh.Text), txttthd.Text))
            {
                MessageBox.Show("Thêm thành công!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbmnv.DataSource = xl.hienThiBangCb();
                cbmnv.DisplayMember = "MaNV";
                cbmnv.ValueMember = "MaNV";
                vCn.DataSource = xl.hienThiBangCb();
            }
            else
            {
                MessageBox.Show("nhân viên hoặc mã lương đã có hoặc nhập sai định dạng dữ liệu!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sua()
        {
            XuLiNV xl = new XuLiNV();
            string gt = "";
            if (txtcmt.Text == "" || txtcv.Text == "" || txtht.Text == "" || txtnc.Text == "" || txtTg.Text == "" || txttthd.Text == "" || gtnam.Checked == false && gtnu.Checked == false)
            {
                MessageBox.Show("bạn phải điền hết thông tin vào!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (gtnam.Checked == true) { gt = "nam"; }
                else if (gtnu.Checked == true) gt = "nữ";
                if (xl.Sua(cbmnv.Text, cbmp.Text, txtht.Text, cbml.Text, DateTime.Parse(ns.Text), gt, txtcmt.Text, DateTime.Parse(nc.Text), txtnc.Text, txtcv.Text, int.Parse(txtTg.Text), DateTime.Parse(nk.Text), DateTime.Parse(nhh.Text), txttthd.Text))
                {
                    MessageBox.Show("Sửa thành công!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cbmnv.DataSource = xl.hienThiBangCb();
                    cbmnv.DisplayMember = "MaNV";
                    cbmnv.ValueMember = "MaNV";
                    vCn.DataSource = xl.hienThiBangCb();
                }
                else
                {
                    MessageBox.Show("nhân viên không tồn tại hoặc thông tin không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void xoa()
        {
            XuLiNV xl = new XuLiNV();
            if (xl.xoa1(cbmnv.Text))
            {
                MessageBox.Show("xoá thành công!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                vCn.DataSource = xl.hienThiBangCb();
                cbmnv.DataSource = xl.hienThiBangCb();
                cbmnv.DisplayMember = "MaNV";
                cbmnv.ValueMember = "MaNV";
            }
            //nhánh này có thể xảy ra khi ràng buộc sql sinh ra lỗi
            else MessageBox.Show("nhân viên không tồn tại hoặc thông tin không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            chon = 1;
            button6.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chon = 2;
            button6.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void vCn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chon = 3;
            button6.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chon = 0;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            button6.Enabled = true;
        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {
            XuLiNV xl = new XuLiNV();
            vCn.DataSource = xl.search1(txtS.Text);
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
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            button6.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            chon = 0;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            button6.Enabled = true;
        }
    }
}
