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
    public class DataProviderBaoHiem
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=SON-DINH;Initial Catalog=QuanLyNhanSu;Integrated Security=True"); 
        }
        
        //form Bảo hiểm
        public DataTable BaoHiemLoad()
        {
            DataProvider da = new DataProvider();
            return da.HienThi("SELECT * FROM BaoHiem ");

        }
        public Boolean ThemBH(BaoHiem bh)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlThem = "INSERT INTO BaoHiem VALUES(@MaNV , @MaBH , @NgayCap , @NgayHetHan , @NoiCap)";
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.Parameters.AddWithValue("MaNV", bh.MaNV);
                cmd.Parameters.AddWithValue("MaBH", bh.MaBH);
                cmd.Parameters.AddWithValue("NgayCap", bh.NgayCap);
                cmd.Parameters.AddWithValue("NgayHetHan", bh.NgayHetHan);
                cmd.Parameters.AddWithValue("NoiCap", bh.NoiCap);
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
        public Boolean SuaBH(BaoHiem bh)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlSua = "DECLARE @dem int select @dem = COUNT(MaNV) FROM BaoHiem WHERE MaNV = @MaNV " +
                    "IF @dem = 1 UPDATE BaoHiem SET MaNV = @MaNV, MaBH = @MaBH , NgayCap = @NgayCap , NgayHetHan = @NgayHetHan , NoiCap = @NoiCap WHERE MaNV = @MaNV else raiserror('',16,1)";
                SqlCommand cmd = new SqlCommand(sqlSua, conn);
                cmd.Parameters.AddWithValue("MaNV", bh.MaNV);
                cmd.Parameters.AddWithValue("MaBH", bh.MaBH);
                cmd.Parameters.AddWithValue("NgayCap", bh.NgayCap);
                cmd.Parameters.AddWithValue("NgayHetHan", bh.NgayHetHan);
                cmd.Parameters.AddWithValue("NoiCap", bh.NoiCap);
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
        public Boolean XoaBH(string MaNV)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                string sqlXoa = "DECLARE @dem int select @dem = COUNT(MaNV) FROM BaoHiem WHERE MaNV = @MaNV " +
                    "IF @dem != 0 DELETE FROM BaoHiem WHERE MaNV = @MaNV else raiserror('',16,1)";
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
