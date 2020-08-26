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
    public partial class FrmnhanVienThuViec : Form
    {
        public FrmnhanVienThuViec()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {

        }
        int chon = 0;

        private void button6_Click(object sender, EventArgs e)
        {
            txtdc.Clear();
            txtht.Clear();
            txtS.Clear();
            txttd.Clear();
            txtvt.Clear();
            gtnam.Checked = false;
            gtnu.Checked = false;
            cbmnv.Text = "";
            cbmp.Text = "";
            th.Text = "";
            nbd.Value = DateTime.Now;
            nhh.Value = DateTime.Now;
            ns.Value = DateTime.Now;
        }

        private void FrmnhanVienThuViec_Load(object sender, EventArgs e)
        {
            XuLiNV xl = new XuLiNV();
            vCn.DataSource = xl.HienThiTv();
            cbmp.DataSource = xl.hienThiPB();
            cbmnv.DataSource = xl.HienThiTv();
            cbmp.DisplayMember = "MaPB";
            cbmnv.DisplayMember = "MaNV";
            cbmp.ValueMember = "MaPB";
            cbmnv.ValueMember = "MaNVTV";

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void txtS_TextChanged_1(object sender, EventArgs e)
        {
            XuLiNV xl = new XuLiNV();
            vCn.DataSource = xl.search2(txtS.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chon = 1;
            button2.Enabled = false;
            button3.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            button6.Enabled = false;
        }
        private void them()
        {
            XuLiNV xl = new XuLiNV();
            string gt = "";
            if (gtnam.Checked == true) { gt = "nam"; }
            else if (gtnu.Checked == true) gt = "nữ";
            if (xl.themNVTV(cbmnv.Text, cbmp.Text, txtht.Text, DateTime.Parse(ns.Text), gt, txtdc.Text, txtvt.Text, int.Parse(th.Text), DateTime.Parse(nbd.Text), DateTime.Parse(nhh.Text), txttd.Text))
            {
                MessageBox.Show("Thêm thành công!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbmnv.DataSource = xl.HienThiTv();
                cbmnv.DisplayMember = "MaNV";
                vCn.DataSource = xl.HienThiTv();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sua()
        {
            XuLiNV xl = new XuLiNV();
            if (txtdc.Text == "" || txtht.Text == "" || txttd.Text == "" || txtvt.Text == "" || gtnam.Checked == false && gtnu.Checked == false || th.Text == "" || cbmnv.Text == "" || ns.Value == DateTime.Now || nhh.Value == DateTime.Now)
                MessageBox.Show("Bạn phải điền hết thông tin muốn sửa vào", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string gt = "";
                if (gtnam.Checked == true) gt = "Nam";
                else gt = "Nữ";
                if (xl.capNhat1(cbmnv.Text, cbmp.Text, txtht.Text, DateTime.Parse(ns.Text), gt, txtdc.Text, txtvt.Text, int.Parse(th.Text), DateTime.Parse(nbd.Text), DateTime.Parse(nhh.Text), txttd.Text))
                {
                    MessageBox.Show("Sửa thành công!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    vCn.DataSource = xl.HienThiTv();
                }
                else MessageBox.Show("Mã nhân viên không tồn tại hoặc thông tin nhập vào không hợp lệ!!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void xoa()
        {
            XuLiNV xl = new XuLiNV();
            if (xl.xoa2(cbmnv.Text))
            {
                MessageBox.Show("xoá thành công!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                vCn.DataSource = xl.HienThiTv();
                cbmp.DataSource = xl.hienThiPB();
                cbmnv.DataSource = xl.HienThiTv();
                cbmp.DisplayMember = "MaPB";
                cbmnv.DisplayMember = "MaNVTV";
                cbmp.ValueMember = "MaPB";
                cbmnv.ValueMember = "MaNVTV";
            }
            else MessageBox.Show("nhân viên không tồn tại!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chon = 2;
            button1.Enabled = false;
            button3.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            chon = 3;
            button2.Enabled = false;
            button1.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            button6.Enabled = false;
        }

        private void vCn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                cbmnv.SelectedValue = vCn.Rows[i].Cells[0].Value.ToString();
                cbmp.SelectedValue = vCn.Rows[i].Cells["MaPB"].Value.ToString();
                txtht.Text = vCn.Rows[i].Cells["HoTen"].Value.ToString();
                ns.Value = (DateTime)vCn.Rows[i].Cells["NgaySinh"].Value;
                txtdc.Text = vCn.Rows[i].Cells["DiaChi"].Value.ToString();
                txtvt.Text = vCn.Rows[i].Cells["ViTriTV"].Value.ToString();
                th.Text = vCn.Rows[i].Cells["SoThangTV"].Value.ToString();
                nbd.Value = (DateTime)vCn.Rows[i].Cells["NgayBatDau"].Value;
                nhh.Value = (DateTime)vCn.Rows[i].Cells["NgayHetHan"].Value;
                txttd.Text = vCn.Rows[i].Cells["TrinhDo"].Value.ToString();
                if (vCn.Rows[i].Cells["GioiTinh"].Value.ToString().ToLower().Equals("nam")) { gtnam.Checked = true; gtnu.Checked = false; }
                else { gtnam.Checked = false; gtnu.Checked = true; }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã chọn sai tác vụ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
