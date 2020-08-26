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
    public partial class FrmThongTinCaNhan : Form
    {
        public FrmThongTinCaNhan()
        {
            InitializeComponent();
        }
        int chon = 0;
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            XuLiNV xl = new XuLiNV();
            vCn.DataSource = xl.hienThiBangTt();
            //load comboBox
            cbmnv.DataSource = xl.bangMaNVCb();
            cbmnv.DisplayMember = "MaNV";
            cbmnv.ValueMember = "MaNV";

            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        

        private void vCn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                cbmnv.Text = vCn.Rows[i].Cells[0].Value.ToString();
                txtht.Text = vCn.Rows[i].Cells["HoTen"].Value.ToString();
                ns.Value = (DateTime)vCn.Rows[i].Cells["NgaySinh"].Value;
                txtNs.Text = vCn.Rows[i].Cells["NoiSinh"].Value.ToString();
                txtDctamc.Text = vCn.Rows[i].Cells["Dctamtru"].Value.ToString();
                txtDctc.Text = vCn.Rows[i].Cells["DCThuongChu"].Value.ToString();
                txtDt.Text = vCn.Rows[i].Cells["DanToc"].Value.ToString();
                txtTg.Text = vCn.Rows[i].Cells["TonGiao"].Value.ToString();
                txtQt.Text = vCn.Rows[i].Cells["QuocTich"].Value.ToString();
                txtBc.Text = vCn.Rows[i].Cells["BangCap"].Value.ToString();
                txtSdt.Text = vCn.Rows[i].Cells["SDT"].Value.ToString();
                if (vCn.Rows[i].Cells["GioiTinh"].Value.ToString().ToLower().Equals("nam")) { gtnam.Checked = true; gtnu.Checked = false; }
                else { gtnam.Checked = false; gtnu.Checked = true; }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã chọn sai tác vụ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbmnv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void ok_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {
            XuLiNV xl = new XuLiNV();
            vCn.DataSource = xl.search(txtS.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chon = 1;
            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            chon = 2;
            button1.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            chon = 3;
            button2.Enabled = false;
            button1.Enabled = false;
            button6.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void them()
        {
            XuLiNV xl = new XuLiNV();
            string gt = "";
            if (gtnam.Checked == true) gt = "Nam";
            else gt = "Nữ";
            if (xl.themTTCN(cbmnv.Text, txtBc.Text, txtDctamc.Text, txtDctc.Text, txtDt.Text, txtht.Text, txtNs.Text, txtQt.Text, txtSdt.Text, txtTg.Text, ns.Text, gt))
            {
                MessageBox.Show("Thêm thành công!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                vCn.DataSource = xl.hienThiBangTt();
                cbmnv.DataSource = xl.bangMaNVCb();
                cbmnv.DisplayMember = "MaNV";
                cbmnv.ValueMember = "MaNV";
            }
            else MessageBox.Show("Mã nhân viên đã tồn tại hoặc thông tin nhập vào không hợp lệ!!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void sua()
        {
            XuLiNV xl = new XuLiNV();
            if (txtBc.Text == "" || txtDctamc.Text == "" || txtDctc.Text == "" || txtDt.Text == "" || txtht.Text == "" || txtNs.Text == "" || txtQt.Text == "" || txtSdt.Text == "" || txtTg.Text == "" || ns.Text == "" || gtnam.Checked == false && gtnu.Checked == false)
                MessageBox.Show("Bạn phải điền hết thông tin muốn sửa vào", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string gt = "";
                if (gtnam.Checked == true) gt = "nam";
                else gt = "nữ";
                if (xl.capNhat(cbmnv.Text, txtBc.Text, txtDctamc.Text, txtDctc.Text, txtDt.Text, txtht.Text, txtNs.Text, txtQt.Text, txtSdt.Text, txtTg.Text, ns.Text, gt))
                {
                    MessageBox.Show("Sửa thành công!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cbmnv.DataSource = xl.bangMaNVCb();
                    cbmnv.DisplayMember = "MaNV";
                    cbmnv.ValueMember = "MaNV";
                    vCn.DataSource = xl.hienThiBangTt();
                }
                else MessageBox.Show("Mã nhân viên không tồn tại hoặc thông tin nhập vào không hợp lệ!!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void xoa()
        {
            XuLiNV xl = new XuLiNV();
            if (xl.xoa(cbmnv.Text))
            {
                MessageBox.Show("Xoá thành công!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbmnv.DataSource = xl.bangMaNVCb();
                cbmnv.DisplayMember = "MaNV";
                cbmnv.ValueMember = "MaNV";
                vCn.DataSource = xl.hienThiBangTt();
            }
            else MessageBox.Show("Nhân viên không tồn tại hoặc thông tin nhập vào không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            txtBc.Clear();
            txtDctamc.Clear();
            txtDctc.Clear();
            txtDt.Clear();
            txtht.Clear();
            txtNs.Clear();
            txtQt.Clear();
            txtSdt.Clear();
            txtTg.Clear();
            cbmnv.Text = "";
            gtnam.Checked = false;
            gtnu.Checked = false;
            ns.Value = DateTime.Now;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            chon = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
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
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
    }
}
