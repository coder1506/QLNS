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
    public class DataProviderForE
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=SON-DINH;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        public DataTable getDataTable(string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getDataTableManv(string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getDataTableManv1(string manv,string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaNV", manv);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getDataTableManv2(string manv,string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaNV", "%"+manv+"%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        
        public Boolean delete(string key,string sqlStr)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("key", key);
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
        public Boolean update(TTCaNhan TT,string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("MaNV", TT.MaNV);
                cmd.Parameters.AddWithValue("Ngs", TT.NgaySinh);
                cmd.Parameters.AddWithValue("ht", TT.HoTen);
                cmd.Parameters.AddWithValue("gt", TT.GioiTinh);
                cmd.Parameters.AddWithValue("ns", TT.NoiSinh);
                cmd.Parameters.AddWithValue("dctt", TT.DctamTru);
                cmd.Parameters.AddWithValue("dctht", TT.DcThuongTru);
                cmd.Parameters.AddWithValue("dt", TT.DanToc);
                cmd.Parameters.AddWithValue("tg", TT.TonGiao);
                cmd.Parameters.AddWithValue("qt", TT.QuocTich);
                cmd.Parameters.AddWithValue("bc", TT.BangCap);
                cmd.Parameters.AddWithValue("sdt", TT.Sdt);
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
        public Boolean update(NVThuViec TT, string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("MaPB", TT.MaPB);
                cmd.Parameters.AddWithValue("HoTen", TT.HoTen);
                cmd.Parameters.AddWithValue("GioiTinh", TT.GioiTinh);
                cmd.Parameters.AddWithValue("NgaySinh", TT.NgaySinh);
                cmd.Parameters.AddWithValue("diaChi", TT.DiaChi);
                cmd.Parameters.AddWithValue("viTri", TT.ViTri);
                cmd.Parameters.AddWithValue("soThang", TT.SoThang);
                cmd.Parameters.AddWithValue("ngayBatDau", TT.NgayBatDau);
                cmd.Parameters.AddWithValue("ngayHetHan", TT.NgayHetHan);
                cmd.Parameters.AddWithValue("trinhDo", TT.TrinhDo);
                cmd.Parameters.AddWithValue("MaNV", TT.MaNV);
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
        public Boolean update(TTCoBan TT, string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ht", TT.HoTen);
                cmd.Parameters.AddWithValue("ngs", TT.NgaySinh);
                cmd.Parameters.AddWithValue("gt", TT.GioiTinh);
                cmd.Parameters.AddWithValue("cmt", TT.Cmt);
                cmd.Parameters.AddWithValue("ngc", TT.NgayCap);
                cmd.Parameters.AddWithValue("nc", TT.NoiCap);
                cmd.Parameters.AddWithValue("cv", TT.ChucVu);
                cmd.Parameters.AddWithValue("tg", TT.ThoiGianLamViec);
                cmd.Parameters.AddWithValue("nk", TT.NgayKy);
                cmd.Parameters.AddWithValue("nhh", TT.NgayHetHan);
                cmd.Parameters.AddWithValue("tthd", TT.TinhTrangHD);
                cmd.Parameters.AddWithValue("MaNV", TT.MaNV);
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
        public Boolean insert(TTCoBan TT,string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("MaNV", TT.MaNV);
                cmd.Parameters.AddWithValue("MaPB", TT.MaPB);
                cmd.Parameters.AddWithValue("HoTen", TT.HoTen);
                cmd.Parameters.AddWithValue("MaLuong", TT.MaLuong);
                cmd.Parameters.AddWithValue("NgaySinh", TT.NgaySinh);
                cmd.Parameters.AddWithValue("gt", TT.GioiTinh);
                cmd.Parameters.AddWithValue("cmt", TT.Cmt);
                cmd.Parameters.AddWithValue("Ngc", TT.NgayCap);
                cmd.Parameters.AddWithValue("nc", TT.NoiCap);
                cmd.Parameters.AddWithValue("Cv", TT.ChucVu);
                cmd.Parameters.AddWithValue("TG", TT.ThoiGianLamViec);
                cmd.Parameters.AddWithValue("Nk", TT.NgayKy);
                cmd.Parameters.AddWithValue("Nhh", TT.NgayHetHan);
                cmd.Parameters.AddWithValue("Tthd", TT.TinhTrangHD);
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
        public Boolean insert(NVThuViec TT, string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("MaNV", TT.MaNV);
                cmd.Parameters.AddWithValue("MaPB", TT.MaPB);
                cmd.Parameters.AddWithValue("HoTen", TT.HoTen);
                cmd.Parameters.AddWithValue("ngaySinh", TT.NgaySinh);
                cmd.Parameters.AddWithValue("gioiTinh", TT.GioiTinh);
                cmd.Parameters.AddWithValue("diaChi", TT.DiaChi);
                cmd.Parameters.AddWithValue("viTri", TT.ViTri);
                cmd.Parameters.AddWithValue("soThang", TT.SoThang);
                cmd.Parameters.AddWithValue("ngayBatDau", TT.NgayBatDau);
                cmd.Parameters.AddWithValue("ngayHetHan", TT.NgayHetHan);
                cmd.Parameters.AddWithValue("trinhDo", TT.TrinhDo);
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
