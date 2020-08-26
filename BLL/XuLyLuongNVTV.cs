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
    public class XuLyLuongNVTV
    {
        public DataTable LoadLuongNVTV()
        {
            DataProviderLuongNVTV dp = new DataProviderLuongNVTV();
            return dp.LuongNVTVLoad();
        }
        public DataTable LoadCmb()
        {
            DataProviderLuongNVTV dp = new DataProviderLuongNVTV();
            return dp.loadCmb();
        }
        public Boolean InsertLuongNVTV(string MaPB, string MaNV, int Thang, int Nam, long LuongTV, int SoGioLamThem, int SoNgayCong)
        {
            DataProviderLuongNVTV dp = new DataProviderLuongNVTV();
            LuongNVTV bh = new LuongNVTV(MaPB, MaNV, Thang, Nam, LuongTV, SoGioLamThem, SoNgayCong, TinhLuong(LuongTV,SoGioLamThem,SoNgayCong));
            return dp.ThemLuongNVTV(bh);
        }
        public Boolean UpdateLuongNVTV(string MaPB, string MaNV, int Thang, int Nam, long LuongTV, int SoGioLamThem, int SoNgayCong)
        {
            DataProviderLuongNVTV dp = new DataProviderLuongNVTV();
            LuongNVTV bh = new LuongNVTV(MaPB, MaNV, Thang, Nam, LuongTV, SoGioLamThem, SoNgayCong, TinhLuong(LuongTV, SoGioLamThem, SoNgayCong));
            return dp.SuaLuongNVTV(bh);
        }
        public Boolean DELETELuongNVTV(string MaNV)
        {
            DataProviderLuongNVTV dp = new DataProviderLuongNVTV();
            return dp.XoaLuongNVTV(MaNV);
        }
        public long TinhLuong(long LuongTV , int SoGioLamThem , int SoNgayCong )
        {
            return (LuongTV * SoNgayCong) + (SoGioLamThem * 20000);
        }
    }
}
