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
    public class XuLyBaoHiem
    {
        public DataTable LoadBH()
        {
            DataProviderBaoHiem dp = new DataProviderBaoHiem();
            return dp.BaoHiemLoad();
        }
        public Boolean InsertBH(string MaNV, long MaBH, DateTime NgayCap, DateTime NgayHetHan, string NoiCap)
        {
            DataProviderBaoHiem dp = new DataProviderBaoHiem();
            BaoHiem bh = new BaoHiem(MaNV, MaBH, NgayCap, NgayHetHan, NoiCap);
            return dp.ThemBH(bh);
        }
        public Boolean UpdateBH(string MaNV, long MaBH, DateTime NgayCap, DateTime NgayHetHan, string NoiCap)
        {
            DataProviderBaoHiem dp = new DataProviderBaoHiem();
            BaoHiem bh = new BaoHiem(MaNV, MaBH, NgayCap, NgayHetHan, NoiCap);
            return dp.SuaBH(bh);
        }
        public Boolean DELETEBH(string MaNV)
        {
            DataProviderBaoHiem dp = new DataProviderBaoHiem();
            return dp.XoaBH(MaNV);
        }
    }
}