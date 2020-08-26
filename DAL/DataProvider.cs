using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace DAL
{
    public class DataProvider
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=SON-DINH;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        public DataTable getDataTable(UserDangNhap user, string sqlDangNhap)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlDangNhap, conn);
            cmd.Parameters.AddWithValue("username", user.Username);
            cmd.Parameters.AddWithValue("pass", user.Password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public Boolean insertUser(UserDangKi user, string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("User", user.Username);
                cmd.Parameters.AddWithValue("Pass", user.Password);
                cmd.Parameters.AddWithValue("Quyen", user.Quyen);
                cmd.Parameters.AddWithValue("Ten", user.HoVaTen);
                cmd.Parameters.AddWithValue("Ns", user.NgaySinh.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public Boolean repair(UserDangKi user, string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("User", user.Username);
                cmd.Parameters.AddWithValue("Pass", user.Password);
                cmd.Parameters.AddWithValue("Quyen", user.Quyen);
                cmd.Parameters.AddWithValue("Ten", user.HoVaTen);
                cmd.Parameters.AddWithValue("Ns", user.NgaySinh.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public Boolean delete(string userName, string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("User", userName);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public Boolean update(UserDangNhap user)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlDangnhap = "UPDATE tbuser Set Pass = @pass Where  Username = @username";
                SqlCommand cmd = new SqlCommand(sqlDangnhap, conn);
                cmd.Parameters.AddWithValue("username", user.Username);
                cmd.Parameters.AddWithValue("pass", user.Password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally {
                conn.Close();
            }
            return true;
        }
        //Load dữ liệu
        public DataTable HienThi(string str)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader drr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(drr);
            conn.Close();
            return dt;
        }
    }
}
