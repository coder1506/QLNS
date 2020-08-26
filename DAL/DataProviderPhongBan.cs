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
    public class DataProviderPhongBan
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=SON-DINH;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        public DataTable PhongBanLoad()
        {
            DataProvider da = new DataProvider();
            return da.HienThi("SELECT * FROM PhongBan ");

        }
        public Boolean ThemPB(PhongBan pb)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlThem = "INSERT INTO PhongBan VALUES(@MaPB , @TenPB , @NgayThanhLap)";
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.Parameters.AddWithValue("MaPB", pb.MaPB);
                cmd.Parameters.AddWithValue("TenPB", pb.TenPB);
                cmd.Parameters.AddWithValue("NgayThanhLap", pb.NgayThanhLap);
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
        public Boolean SuaPB(PhongBan pb)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlSua = "DECLARE @dem int select @dem = COUNT(MaPB) FROM PhongBan WHERE MaPB = @MaPB " +
                    "IF @dem != 0 UPDATE PhongBan SET TenPB = @TenPB , NgayThanhLap = @NgayThanhLap WHERE MaPB = @MaPB else raiserror('',16,1)";
                SqlCommand cmd = new SqlCommand(sqlSua, conn);
                cmd.Parameters.AddWithValue("MaPB", pb.MaPB);
                cmd.Parameters.AddWithValue("TenPB", pb.TenPB);
                cmd.Parameters.AddWithValue("NgayThanhLap", pb.NgayThanhLap);
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
        public Boolean XoaPB(string MaPB)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlXoa = "DECLARE @dem int select @dem = COUNT(MaPB) FROM PhongBan WHERE MaPB = @MaPB " +
                    "IF @dem != 0 DELETE FROM PhongBan WHERE MaPB = @MaPB else raiserror('',16,1)";
                SqlCommand cmd = new SqlCommand(sqlXoa, conn);
                cmd.Parameters.AddWithValue("MaPB", MaPB);
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
            string PB = "SELECT * FROM PhongBan ";
            SqlCommand cmd = new SqlCommand(PB, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
    }
}
