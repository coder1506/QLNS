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
    public class XuLyKyLuat
    {
        public DataTable LoadKyLuat()
        {
            DataProviderKyLuat dp = new DataProviderKyLuat();
            return dp.KyLuatLoad();
        }
        public DataTable LoadCmb(string str)
        {
            DataProviderKyLuat dp = new DataProviderKyLuat();
            return dp.loadCmb(str);
        }
        public Boolean InsertKyLuat(string MaPB,string MaNV , string HoTen,long TienPhat,string MaKyLuat, DateTime NgayKyLuat , string LyDo)
        {
            DataProviderKyLuat dp = new DataProviderKyLuat();
            KyLuat bh = new KyLuat(MaPB,MaNV, HoTen,TienPhat,MaKyLuat, NgayKyLuat,LyDo);
            return dp.ThemKyLuat(bh);
        }
        public Boolean UpdateKyLuat(string MaPB, string MaNV, string HoTen, long TienPhat, string MaKyLuat, DateTime NgayKyLuat, string LyDo)
        {
            DataProviderKyLuat dp = new DataProviderKyLuat();
            KyLuat bh = new KyLuat(MaPB, MaNV, HoTen, TienPhat, MaKyLuat, NgayKyLuat, LyDo);
            return dp.SuaKyLuat(bh);
        }
        public Boolean DELETEKyLuat(string MaNV)
        {
            DataProviderKyLuat dp = new DataProviderKyLuat();
            return dp.XoaKyLuat(MaNV);
        }
    }
}
