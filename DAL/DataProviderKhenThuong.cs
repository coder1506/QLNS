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
    public class DataProviderKhenThuong
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=SON-DINH;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        public DataTable KhenThuongLoad()
        {
            DataProvider da = new DataProvider();
            return da.HienThi("SELECT * FROM Thuong ");

        }
        public Boolean ThemKhenThuong(KhenThuong pb)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlThem = "INSERT INTO Thuong VALUES(@MaPB ,@MaNV , @HoTen , @TienThuong , @MaThuong , @NgayThuong , @LyDo)";
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.Parameters.AddWithValue("MaPB", pb.MaPB);
                cmd.Parameters.AddWithValue("MaNV", pb.MaNV);
                cmd.Parameters.AddWithValue("HoTen", pb.HoTen);
                cmd.Parameters.AddWithValue("TienThuong", pb.TienThuong);
                cmd.Parameters.AddWithValue("MaThuong", pb.MaKhenThuong);
                cmd.Parameters.AddWithValue("NgayThuong", pb.NgayKhenThuong);
                cmd.Parameters.AddWithValue("LyDo", pb.LyDo);
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
        public Boolean SuaKhenThuong(KhenThuong pb)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlSua = "DECLARE @dem int select @dem = COUNT(MaNV) FROM Thuong WHERE MaNV = @MaNV " +
                    "IF @dem != 0 UPDATE Thuong SET TienThuong = @TienThuong , MaThuong = @MaThuong , NgayThuong = @NgayThuong , LyDo = @LyDo WHERE MaNV = @MaNV else raiserror('',16,1)";
                SqlCommand cmd = new SqlCommand(sqlSua, conn);
                cmd.Parameters.AddWithValue("MaNV", pb.MaNV);
                cmd.Parameters.AddWithValue("TienThuong", pb.TienThuong);
                cmd.Parameters.AddWithValue("MaThuong", pb.MaKhenThuong);
                cmd.Parameters.AddWithValue("NgayThuong", pb.NgayKhenThuong);
                cmd.Parameters.AddWithValue("LyDo", pb.LyDo);
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
        public Boolean XoaKhenThuong(string MaNV)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlXoa = "DECLARE @dem int select @dem = COUNT(MaNV) FROM Thuong WHERE MaNV = @MaNV " +
                    "IF @dem != 0 DELETE FROM Thuong WHERE MaNV = @MaNV else raiserror('',16,1)";
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
