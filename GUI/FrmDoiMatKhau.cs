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
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtP.Clear();
            txtP1.Clear();
            txtU.Clear();
            txtP2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn đổi mật khẩu không ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tl == DialogResult.Yes)
            {
                XuLiTk xl = new XuLiTk();
                if (txtP1.Text.Equals(txtP2.Text))
                {
                    if (xl.Sua(txtU.Text, txtP1.Text, txtP.Text)) MessageBox.Show("Đổi mật khẩu thành công!!!", "successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else MessageBox.Show("Tên đăng nhập hoặc mật khẩu cũ không chính xác", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Mật khẩu nhập lại không trùng khớp", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
