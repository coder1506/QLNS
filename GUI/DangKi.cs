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
    public partial class DangKi : Form
    {
        int chon = 0;
        public DangKi()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtU.Clear();
            txtP.Clear();
            txtP1.Clear();
            txtHt.Clear();
            qu.Text = "user";
            ns.Value = DateTime.Now;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            chon = 2;
            button6.Enabled = false;
            button2.Enabled = false;
            button7.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            chon = 3;
            button6.Enabled = false;
            button1.Enabled = false;
            button7.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            chon = 4;
            button6.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        
        private void them()
        {
            if (txtU.Text == "" || txtHt.Text == "" || txtP.Text == "" || txtP1.Text == "")
            {
                MessageBox.Show("Bạn phải điền hết thông tin vào ô trống", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtP.Text.Equals(txtP1.Text))
            {
                XuLiTk xl = new XuLiTk();
                if (xl.dangKi(txtU.Text, txtP.Text, txtHt.Text, ns.Text, qu.Text) == false)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đăng kí thành công!!!", "successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else MessageBox.Show("mật khẩu nhập lại không khớp", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void sua()
        {
            XuLiTk xl = new XuLiTk();
            if (xl.Sua(txtU.Text, txtP.Text, txtHt.Text, ns.Text, qu.Text) == false)
            {
                MessageBox.Show("dữ liệu nhập vào không hợp lệ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("sửa thành công!!!", "successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void xoa()
        {
            XuLiTk xl = new XuLiTk();
            if (xl.Xoa(txtU.Text) == false)
            {
                MessageBox.Show("thông tin bạn nhập không hợp lệ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("xoá thành công!!!", "successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //private void button5_Click(object sender, EventArgs e)
        //{
            
        //}

        private void btnHuy_Click(object sender, EventArgs e)
        {
            chon = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            switch (chon)
            {
                case 2:
                    tl = MessageBox.Show("Bạn có muốn thêm không ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                        them();
                    break;
                case 3:
                    tl = MessageBox.Show("Bạn có muốn sửa không ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                        sua();
                    break;
                case 4:
                    tl = MessageBox.Show("Bạn có muốn xóa không ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                        xoa();
                    break;
                
            }
            chon = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            qu.Text = "user";
        }

        private void txtU_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
