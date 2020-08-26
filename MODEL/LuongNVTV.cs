using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class LuongNVTV
    {
        string _MaPB, _MaNV;
        int _Thang, _Nam, _SoGioLamThem, _SoNgayCong;
        long _LuongTV , _TongLuong;

        public string MaPB { get => _MaPB; set => _MaPB = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public int Thang { get => _Thang; set => _Thang = value; }
        public int Nam { get => _Nam; set => _Nam = value; }
        public int SoGioLamThem { get => _SoGioLamThem; set => _SoGioLamThem = value; }
        public int SoNgayCong { get => _SoNgayCong; set => _SoNgayCong = value; }
        public long LuongTV { get => _LuongTV; set => _LuongTV = value; }
        public long TongLuong { get => _TongLuong; set => _TongLuong = value; }
        public LuongNVTV() { }
        public LuongNVTV(string MaPB , string MaNV , int Thang , int Nam , long LuongTV , int SoGioLamThem , int SoNgayCong ,long TongLuong)
        {
            this.MaPB = MaPB;
            this.MaNV = MaNV;
            this.Thang = Thang;
            this.Nam = Nam;
            this.LuongTV = LuongTV;
            this.SoGioLamThem = SoGioLamThem;
            this.SoNgayCong = SoNgayCong;
            this._TongLuong = TongLuong;
        }
    }
}
