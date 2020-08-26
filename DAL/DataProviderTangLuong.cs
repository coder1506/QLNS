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
    public class DataProviderTangLuong
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=SON-DINH;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        public DataTable TangLuongLoad()
        {
            DataProvider da = new DataProvider();
            return da.HienThi("SELECT * FROM TangLuong ");

        }
        public Boolean ThemTangLuong(TangLuong pb)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlThem = "INSERT INTO TangLuong VALUES(@MaPB ,@MaNV , @HoTen , @GioiTinh , @ChucVu , @MaLuong , @NgayTang)";
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.Parameters.AddWithValue("MaPB", pb.MaPB);
                cmd.Parameters.AddWithValue("MaNV", pb.MaNV);
                cmd.Parameters.AddWithValue("HoTen", pb.HoTen);
                cmd.Parameters.AddWithValue("GioiTinh", pb.GioiTinh);
                cmd.Parameters.AddWithValue("ChucVu", pb.ChucVu);
                cmd.Parameters.AddWithValue("MaLuong", pb.MaLuong);
                cmd.Parameters.AddWithValue("NgayTang", pb.NgayTang);
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
        public Boolean SuaTangLuong(TangLuong pb)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlSua = "DECLARE @dem int select @dem = COUNT(MaNV) FROM TangLuong WHERE MaNV = @MaNV " +
                    "IF @dem != 0 UPDATE TangLuong SET MaLuong = @MaLuong , NgayTang = @NgayTang WHERE MaNV = @MaNV else raiserror('',16,1)";
                SqlCommand cmd = new SqlCommand(sqlSua, conn);
                cmd.Parameters.AddWithValue("MaNV", pb.MaNV);
                cmd.Parameters.AddWithValue("MaLuong", pb.MaLuong);
                cmd.Parameters.AddWithValue("NgayTang", pb.NgayTang);
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
        public Boolean XoaTangLuong(string MaNV)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlXoa = "DECLARE @dem int select @dem = COUNT(MaNV) FROM TangLuong WHERE MaNV = @MaNV " +
                    "IF @dem != 0 DELETE FROM TangLuong WHERE MaNV = @MaNV else raiserror('',16,1)";
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
            string PB = str;
            SqlCommand cmd = new SqlCommand(PB, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
    }
}
