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
    public class DataProviderLuongNVTV
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=SON-DINH;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        public DataTable LuongNVTVLoad()
        {
            DataProvider da = new DataProvider();
            return da.HienThi("SELECT * FROM BangCongNVThuViec ");

        }
        public Boolean ThemLuongNVTV(LuongNVTV tv)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlThem = "INSERT INTO BangCongNVThuViec VALUES(@MaPB , @MaNVTV , @Thang ,@Nam , @LuongTV ,@SoGioLamThem ,@SoNgayCong ,@TongLuong)";
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.Parameters.AddWithValue("MaPB", tv.MaPB);
                cmd.Parameters.AddWithValue("MaNVTV", tv.MaNV);
                cmd.Parameters.AddWithValue("Thang", tv.Thang);
                cmd.Parameters.AddWithValue("Nam", tv.Nam);
                cmd.Parameters.AddWithValue("LuongTV", tv.LuongTV);
                cmd.Parameters.AddWithValue("SoGioLamThem", tv.SoGioLamThem);
                cmd.Parameters.AddWithValue("SoNgayCong", tv.SoNgayCong);
                cmd.Parameters.AddWithValue("TongLuong", tv.TongLuong);
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
        public Boolean SuaLuongNVTV(LuongNVTV tv)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlSua = "DECLARE @dem int select @dem = COUNT(MaNVTV) FROM BangCongNVThuViec WHERE MaNVTV = @MaNVTV IF @dem != 0 UPDATE BangCongNVThuViec SET Thang = @Thang," +
                    " Nam = @Nam, LuongTV = @LuongTV, SoGioLamThem = @SoGioLamThem, SoNgayCong = @SoNgayCong, Luong = @TongLuong WHERE MaNVTV = @MaNVTV else raiserror('', 16, 1)";
                SqlCommand cmd = new SqlCommand(sqlSua, conn);
                cmd.Parameters.AddWithValue("MaNVTV", tv.MaNV);
                cmd.Parameters.AddWithValue("Thang", tv.Thang);
                cmd.Parameters.AddWithValue("Nam", tv.Nam);
                cmd.Parameters.AddWithValue("LuongTV", tv.LuongTV);
                cmd.Parameters.AddWithValue("SoGioLamThem", tv.SoGioLamThem);
                cmd.Parameters.AddWithValue("SoNgayCong", tv.SoNgayCong);
                cmd.Parameters.AddWithValue("TongLuong", tv.TongLuong);
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
        public Boolean XoaLuongNVTV(string MaNV)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlXoa = "DECLARE @dem int select @dem = COUNT(MaNVTV) FROM BangCongNVThuViec WHERE MaNVTV = @MaNVTV " +
                    "IF @dem != 0 DELETE FROM BangCongNVThuViec WHERE MaNVTV = @MaNVTV else raiserror('',16,1)";
                SqlCommand cmd = new SqlCommand(sqlXoa, conn);
                cmd.Parameters.AddWithValue("MaNVTV", MaNV);
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
        public DataTable loadCmb()
        {
            SqlConnection conn = getConnection();
            conn.Open();
            string tv = "SELECT * FROM BangCongNVThuViec ";
            SqlCommand cmd = new SqlCommand(tv, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
    }
    
}
