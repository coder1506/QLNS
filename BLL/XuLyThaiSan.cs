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
    public class XuLyThaiSan
    {
        public DataTable LoadTS()
        {
            DataProviderThaiSan dp = new DataProviderThaiSan();
            return dp.ThaiSanLoad(new ThaiSan());
        }
        public DataTable LoadCmb(string str)
        {
            DataProviderKhenThuong dp = new DataProviderKhenThuong();
            return dp.loadCmb(str);
        }
        public Boolean InsertTS(string MaPB, string MaNV,string HoTen ,long TroCap, DateTime NgayVe, DateTime NgayTroLai)
        {
            DataProviderThaiSan dp = new DataProviderThaiSan();
            ThaiSan bh = new ThaiSan(MaPB, MaNV, HoTen, TroCap,NgayVe, NgayTroLai);
            return dp.ThemTS(bh);
        }
        public Boolean UpdateTS(string MaPB, string MaNV, string HoTen, long TroCap, DateTime NgayVe, DateTime NgayTroLai)
        {
            DataProviderThaiSan dp = new DataProviderThaiSan();
            ThaiSan bh = new ThaiSan(MaPB, MaNV, HoTen, TroCap, NgayVe, NgayTroLai);
            return dp.SuaTS(bh);
        }
        public Boolean DeleteTS(string MaNV)
        {
            DataProviderThaiSan dp = new DataProviderThaiSan();
            return dp.XoaTS(MaNV);
        }
    }
}
