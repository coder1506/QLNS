using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MODEL;

namespace DAL
{
    public class DataProviderThaiSan
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=SON-DINH;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        public DataTable ThaiSanLoad(ThaiSan ts)
        {
            DataProvider da = new DataProvider();
            return da.HienThi("SELECT * FROM ThaiSan ");

        }
        public DataTable loadCmb(string str)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            string PB = str;
            SqlCommand cmd = new SqlCommand(PB, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
        public Boolean ThemTS(ThaiSan ts)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlThem = "DECLARE @dem int select @dem = COUNT(MaNV) from TTNVCoBan WHERE MaNV = @MaNV " +
                    "and GioiTinh = N'Nữ' and MaPB = @MaPB if @dem = 1 INSERT INTO ThaiSan values(@MaPB , @MaNV, @HoTen , @TroCap, @NgayVe , @NgayTroLai) else raiserror('', 16, 1)";
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.Parameters.AddWithValue("MaPB", ts.MaPB);
                cmd.Parameters.AddWithValue("MaNV", ts.MaNV);
                cmd.Parameters.AddWithValue("HoTen", ts.HoTen);
                cmd.Parameters.AddWithValue("TroCap", ts.TroCap);
                cmd.Parameters.AddWithValue("NgayVe", ts.NgayVe);
                cmd.Parameters.AddWithValue("NgayTroLai", ts.NgayTroLai);
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
        public Boolean SuaTS(ThaiSan ts)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlSua = "DECLARE @dem int select @dem = COUNT(MaNV) from TTNVCoBan WHERE MaNV = @MaNV and GioiTinh = N'Nữ'  and MaPB = @MaPB" +
                    "IF @dem != 0 UPDATE ThaiSan SET HoTen = @HoTen, TroCap = @TroCap , NgayVeSinh = @NgayVeSinh , NgayLamTroLai = @NgayLamTroLai WHERE MaNV = @MaNV  else raiserror('',16,1)";
                SqlCommand cmd = new SqlCommand(sqlSua, conn);
                cmd.Parameters.AddWithValue("MaPB", ts.MaPB);
                cmd.Parameters.AddWithValue("MaNV", ts.MaNV);
                cmd.Parameters.AddWithValue("HoTen", ts.HoTen);
                cmd.Parameters.AddWithValue("TroCap", ts.TroCap);
                cmd.Parameters.AddWithValue("NgayVeSinh", ts.NgayVe);
                cmd.Parameters.AddWithValue("NgayLamTroLai", ts.NgayTroLai);
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
        public Boolean XoaTS(string MaNV)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlXoa = "DECLARE @dem int select @dem = COUNT(MaNV) FROM ThaiSan WHERE MaNV = @MaNV " +
                    "IF @dem = 1 DELETE FROM ThaiSan WHERE MaNV = @MaNV else raiserror('',16,1)";
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
    }
}
