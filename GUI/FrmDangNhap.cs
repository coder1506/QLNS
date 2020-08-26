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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XuLiTk xl = new XuLiTk();
            if (xl.dangNhap(txtU.Text, txtP.Text) == null) {
                MessageBox.Show("tài khoản hoặc mật khẩu không chính xác", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string str = "Đăng nhập thành công dưới quyền " + xl.dangNhap(txtU.Text, txtP.Text);
                MessageBox.Show(str, "successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if(xl.dangNhap(txtU.Text, txtP.Text).ToLower().Equals("admin"))
                {
                    FrmMain m = new FrmMain();
                    this.Hide();
                    FrmMain fr = new FrmMain();
                    fr.Quyen = "admin";
                    m.ShowDialog();
                    m.Show();
                }
                else
                {
                    FrmMain m = new FrmMain();
                    this.Hide();
                    FrmMain fr = new FrmMain();
                    fr.Quyen = "user";
                    m.ShowDialog();
                    m.Show();
                }
            }
        }
    }
}
