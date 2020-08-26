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
    public class DataProviderLuongNV
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=SON-DINH;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        public DataTable LuongNVLoad()
        {
            DataProvider da = new DataProvider();
            return da.HienThi("SELECT * FROM BangCongNV ");

        }
        public Boolean ThemLuongNV(LuongNV tv)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlThem = "INSERT INTO BangCongNV VALUES(@MaPB , @MaNV , @MaLuong , @LCB , @PhuCap , @Thuong , @KyLuat , @Thang ,@Nam ,@SoGioLamThem ,@SoNgayCong ,@TongLuong)";
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.Parameters.AddWithValue("MaPB", tv.MaPB);
                cmd.Parameters.AddWithValue("MaNV", tv.MaNV);
                cmd.Parameters.AddWithValue("MaLuong", tv.MaLuong);
                cmd.Parameters.AddWithValue("LCB", tv.LCB);
                cmd.Parameters.AddWithValue("PhuCap", tv.PhuCap);
                cmd.Parameters.AddWithValue("Thuong", tv.Thuong);
                cmd.Parameters.AddWithValue("KyLuat", tv.KyLuat);
                cmd.Parameters.AddWithValue("Thang", tv.Thang);
                cmd.Parameters.AddWithValue("Nam", tv.Nam);
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
        public Boolean SuaLuongNV(LuongNV tv)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlSua = "DECLARE @dem int select @dem = COUNT(MaNV) FROM BangCongNV WHERE MaNV = @MaNV IF @dem != 0 UPDATE BangCongNV " +
                    "SET Thuong = @Thuong ,KyLuat = @KyLuat ,Thang = @Thang , Nam = @Nam , " +
                    "SoGioLamThem = @SoGioLamThem , SoNgayCong = @SoNgayCong , Luong = @TongLuong WHERE MaNV = @MaNV else raiserror('', 16, 1)";
                SqlCommand cmd = new SqlCommand(sqlSua, conn);
                cmd.Parameters.AddWithValue("MaNV", tv.MaNV);
                cmd.Parameters.AddWithValue("Thuong", tv.Thuong);
                cmd.Parameters.AddWithValue("KyLuat", tv.KyLuat);
                cmd.Parameters.AddWithValue("Thang", tv.Thang);
                cmd.Parameters.AddWithValue("Nam", tv.Nam);
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
        public Boolean XoaLuongNV(string MaNV)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlXoa = "DECLARE @dem int select @dem = COUNT(MaNV) FROM BangCongNV WHERE MaNV = @MaNV " +
                    "IF @dem != 0 DELETE FROM BangCongNV WHERE MaNV = @MaNV else raiserror('',16,1)";
                SqlCommand cmd = new SqlCommand(sqlXoa, conn);
                cmd.Parameters.AddWithValue("MaNV", MaNV);
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
