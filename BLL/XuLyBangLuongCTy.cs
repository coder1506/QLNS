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
    public class XuLyBangLuongCTy
    {
        public DataTable LoadBangLuongCTy()
        {
            DataProviderBangLuongCTy dp = new DataProviderBangLuongCTy();
            return dp.BangLuongCTyLoad();
        }
        public Boolean InsertBangLuongCTy(string MaLuong, long LCBcu, long PhuCapcu, DateTime NgaySua)
        {
            DataProviderBangLuongCTy dp = new DataProviderBangLuongCTy();
            BangLuongCongTy bh = new BangLuongCongTy(MaLuong, LCBcu,PhuCapcu, NgaySua);
            return dp.ThemBangLuongCTy(bh);
        }
        public Boolean UpdateBangLuongCTy(string MaLuong, long LCBcu, long PhuCapcu, DateTime NgaySua)
        {
            DataProviderBangLuongCTy dp = new DataProviderBangLuongCTy();
            BangLuongCongTy bh = new BangLuongCongTy(MaLuong, LCBcu, PhuCapcu, NgaySua);
            return dp.SuaBangLuongCTy(bh);
        }
        public Boolean DELETEBangLuongCTy(string MaLuong)
        {
            DataProviderBangLuongCTy dp = new DataProviderBangLuongCTy();
            return dp.XoaBangLuongCTy(MaLuong);
        }
        public DataTable LoadCmb(string str)
        {
            DataProviderBangLuongCTy dp = new DataProviderBangLuongCTy();
            return dp.loadCmb(str);
        }
    }
}
