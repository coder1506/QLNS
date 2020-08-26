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
    public class XuLyLuongNV
    {
        public DataTable LoadLuongNV()
        {
            DataProviderLuongNV dp = new DataProviderLuongNV();
            return dp.LuongNVLoad();
        }
        public DataTable LoadCmb(string str)
        {
            DataProviderLuongNV dp = new DataProviderLuongNV();
            return dp.loadCmb(str);
        }
        public Boolean InsertLuongNV(string MaPB, string MaNV, string MaLuong, long LCB, long PhuCap, long Thuong, long KyLuat, int Thang, int Nam, int SoGioLamThem, int SoNgayCong )
        {
            DataProviderLuongNV dp = new DataProviderLuongNV();
            LuongNV bh = new LuongNV(MaPB, MaNV,MaLuong,LCB , PhuCap , Thuong , KyLuat, Thang, Nam, SoGioLamThem, SoNgayCong, TinhLuong(LCB, PhuCap, Thuong, KyLuat, SoGioLamThem, SoNgayCong));
            return dp.ThemLuongNV(bh);
        }
        public Boolean UpdateLuongNV(string MaPB, string MaNV, string MaLuong, long LCB, long PhuCap, long Thuong, long KyLuat, int Thang, int Nam, int SoGioLamThem, int SoNgayCong)
        {
            DataProviderLuongNV dp = new DataProviderLuongNV();
            LuongNV bh = new LuongNV(MaPB, MaNV, MaLuong, LCB, PhuCap, Thuong, KyLuat, Thang, Nam, SoGioLamThem, SoNgayCong, TinhLuong(LCB, PhuCap, Thuong, KyLuat, SoGioLamThem, SoNgayCong));
            return dp.SuaLuongNV(bh);
        }
        public Boolean DELETELuongNV(string MaNV)
        {
            DataProviderLuongNV dp = new DataProviderLuongNV();
            return dp.XoaLuongNV(MaNV);
        }
        public long TinhLuong(long LCB, long PhuCap , long Thuong , long KyLuat ,int SoGioLamThem, int SoNgayCong)
        {
            return (LCB * SoNgayCong) + (SoGioLamThem * 20000) + PhuCap + Thuong - KyLuat;
        }
        
    }
}
