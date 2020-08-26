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
    public class XuLyKhenThuong
    {
        public DataTable LoadKhenThuong()
        {
            DataProviderKhenThuong dp = new DataProviderKhenThuong();
            return dp.KhenThuongLoad();
        }
        public DataTable LoadCmb(string str)
        {
            DataProviderKhenThuong dp = new DataProviderKhenThuong();
            return dp.loadCmb(str);
        }
        public Boolean InsertKhenThuong(string MaPB, string MaNV, string HoTen, long TienThuong, string MaKhenThuong, DateTime NgayKhenThuong, string LyDo)
        {
            DataProviderKhenThuong dp = new DataProviderKhenThuong();
            KhenThuong bh = new KhenThuong(MaPB, MaNV, HoTen, TienThuong, MaKhenThuong, NgayKhenThuong, LyDo);
            return dp.ThemKhenThuong(bh);
        }
        public Boolean UpdateKhenThuong(string MaPB, string MaNV, string HoTen, long TienThuong, string MaKhenThuong, DateTime NgayKhenThuong, string LyDo)
        {
            DataProviderKhenThuong dp = new DataProviderKhenThuong();
            KhenThuong bh = new KhenThuong(MaPB, MaNV, HoTen, TienThuong, MaKhenThuong, NgayKhenThuong, LyDo);
            return dp.SuaKhenThuong(bh);
        }
        public Boolean DELETEKhenThuong(string MaNV)
        {
            DataProviderKhenThuong dp = new DataProviderKhenThuong();
            return dp.XoaKhenThuong(MaNV);
        }
    }
}
