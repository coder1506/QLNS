using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class XuLiTk
    {
        public string dangNhap(string username, string password)
        {
            string quyen = null;
            string sqlDangNhap = "SELECT * FROM tbuser WHERE Username = @username  COLLATE SQL_Latin1_General_CP1_CS_AS  AND Pass = @pass COLLATE SQL_Latin1_General_CP1_CS_AS ";
            UserDangNhap user = new UserDangNhap();
            user.Password = password;
            user.Username = username;
            DataProvider dp = new DataProvider();
            DataTable dt = dp.getDataTable(user, sqlDangNhap);
            if (dt.Rows.Count > 0) 
            foreach (DataRow row in dt.Rows)
            {
                     quyen = row["Quyen"].ToString();
            }
            return quyen;
        }
        public Boolean dangKi(string UserName, string Password, string HoVaTen, string NgaySinh, string Quyen)
        {
            DataProvider dp = new DataProvider();
            UserDangKi udk = new UserDangKi(UserName, Password, HoVaTen,DateTime.Parse(NgaySinh), Quyen);
            string sql = "INSERT INTO tbuser VALUES(@User,@Pass,@Quyen,@Ten,@Ns)";
            return dp.insertUser(udk,sql);
        }
        public Boolean Sua(string UserName, string Password, string HoVaTen, string NgaySinh, string Quyen)
        {
            DataProvider dp = new DataProvider();
            UserDangKi udk = new UserDangKi(UserName, Password, HoVaTen, DateTime.Parse(NgaySinh), Quyen);
            string sql = "UPDATE tbuser SET Pass = @pass, Quyen = @Quyen,Ten = @ten,Ngaysinh = @ns WHERE Username = @user";
            return dp.repair(udk,sql);
        }
        public Boolean Xoa(string userName)
        {
            DataProvider dp = new DataProvider();
            string sql = "DELETE FROM tbuser WHERE Username = @user";
            return dp.delete(userName,sql);
        }
        public Boolean Sua(string username, string password,string mkcu)
        {
            DataProvider dp = new DataProvider();
            string sqlDangNhap = "SELECT * FROM tbuser WHERE Username = @username AND Pass = @pass";
            DataTable dt = dp.getDataTable(new UserDangNhap(username, mkcu), sqlDangNhap);
            if (dt.Rows.Count > 0)
                return dp.update(new UserDangNhap(username, password));
            else return false;
        }
    }
}