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
    public class DataProviderBangLuongCTy
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=SON-DINH;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        public DataTable BangLuongCTyLoad()
        {
            DataProvider da = new DataProvider();
            return da.HienThi("SELECT * FROM BangLuongCongTy ");

        }
        public Boolean ThemBangLuongCTy(BangLuongCongTy tv)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlThem = "INSERT INTO BangLuongCongTy VALUES(@MaLuong , @LCB , @PhuCap , @NgaySua)";
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.Parameters.AddWithValue("MaLuong", tv.MaLuong);
                cmd.Parameters.AddWithValue("LCB", tv.LCB);
                cmd.Parameters.AddWithValue("PhuCap", tv.PhuCap);
                cmd.Parameters.AddWithValue("NgaySua", tv.NgaySua);
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
        public Boolean SuaBangLuongCTy(BangLuongCongTy tv)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlSua = "DECLARE @dem int select @dem = COUNT(MaLuong) FROM BangLuongCongTy WHERE MaLuong = @MaLuong IF @dem != 0 UPDATE BangLuongCongTy " +
                    "SET MaLuong = @Maluong , LCB = @LCB , PhuCap = @PhuCap , NgaySua = @NgaySua  WHERE MaLuong = @MaLuong ";
                SqlCommand cmd = new SqlCommand(sqlSua, conn);
                cmd.Parameters.AddWithValue("MaLuong", tv.MaLuong);
                cmd.Parameters.AddWithValue("LCB", tv.LCB);
                cmd.Parameters.AddWithValue("PhuCap", tv.PhuCap);
                cmd.Parameters.AddWithValue("NgaySua", tv.NgaySua);
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
        public Boolean XoaBangLuongCTy(string MaLuong)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlXoa = "DECLARE @dem int select @dem = COUNT(MaLuong) FROM BangLuongCongTy WHERE MaLuong = @MaLuong " +
                    "IF @dem != 0 DELETE FROM BangLuongCongTy WHERE MaLuong = @MaLuong else raiserror('',16,1)";
                SqlCommand cmd = new SqlCommand(sqlXoa, conn);
                cmd.Parameters.AddWithValue("MaLuong", MaLuong);
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
        public DataTable loadCmb(string str)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
    }
}
