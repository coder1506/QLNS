using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class XuLyTangLuong
    {
        public DataTable LoadTangLuong()
        {
            DataProviderTangLuong dp = new DataProviderTangLuong();
            return dp.TangLuongLoad();
        }
        public DataTable LoadCmb(string str)
        {
            DataProviderTangLuong dp = new DataProviderTangLuong();
            return dp.loadCmb(str);
        }
        public Boolean InsertTangLuong(string MaPB, string MaNV, string HoTen, string GioiTinh, string ChucVu,string MaLuong , DateTime NgayTang)
        {
            DataProviderTangLuong dp = new DataProviderTangLuong();
            TangLuong bh = new TangLuong(MaPB, MaNV, HoTen, GioiTinh, ChucVu, MaLuong, NgayTang);
            return dp.ThemTangLuong(bh);
        }
        public Boolean UpdateTangLuong(string MaPB, string MaNV, string HoTen, string GioiTinh, string ChucVu, string MaLuong, DateTime NgayTang)
        {
            DataProviderTangLuong dp = new DataProviderTangLuong();
            TangLuong bh = new TangLuong(MaPB, MaNV, HoTen, GioiTinh, ChucVu, MaLuong, NgayTang);
            return dp.SuaTangLuong(bh);
        }
        public Boolean DELETETangLuong(string MaNV)
        {
            DataProviderTangLuong dp = new DataProviderTangLuong();
            return dp.XoaTangLuong(MaNV);
        }
    }
}
