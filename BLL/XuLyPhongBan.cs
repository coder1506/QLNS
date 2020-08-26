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
    public class XuLyPhongBan
    {
        public DataTable LoadPB()
        {
            DataProviderPhongBan dp = new DataProviderPhongBan();
            return dp.PhongBanLoad();
        }
        public DataTable LoadCmb()
        {
            DataProviderPhongBan dp = new DataProviderPhongBan();
            return dp.loadCmb();
        }
        public Boolean InsertPB(string MaPB , string TenPB , DateTime NgayThanhLap)
        {
            DataProviderPhongBan dp = new DataProviderPhongBan();
            PhongBan bh = new PhongBan(MaPB,TenPB,NgayThanhLap);
            return dp.ThemPB(bh);
        }
        public Boolean UpdatePB(string MaPB, string TenPB, DateTime NgayThanhLap)
        {
            DataProviderPhongBan dp = new DataProviderPhongBan();
            PhongBan bh = new PhongBan(MaPB, TenPB, NgayThanhLap);
            return dp.SuaPB(bh);
        }
        public Boolean DELETEPB(string MaPB)
        {
            DataProviderPhongBan dp = new DataProviderPhongBan();
            return dp.XoaPB(MaPB);
        }
    }
}
