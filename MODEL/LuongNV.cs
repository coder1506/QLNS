using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class LuongNV
    {
        private string _MaPB, _MaNV, _MaLuong;
        private long _LCB, _PhuCap, _Thuong, _KyLuat, _TongLuong;
        private int _Thang, _Nam, _SoNgayCong, _SoGioLamThem;

        public string MaPB { get => _MaPB; set => _MaPB = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaLuong { get => _MaLuong; set => _MaLuong = value; }
        public long LCB { get => _LCB; set => _LCB = value; }
        public long PhuCap { get => _PhuCap; set => _PhuCap = value; }
        public long Thuong { get => _Thuong; set => _Thuong = value; }
        public long KyLuat { get => _KyLuat; set => _KyLuat = value; }
        public long TongLuong { get => _TongLuong; set => _TongLuong = value; }
        public int Thang { get => _Thang; set => _Thang = value; }
        public int Nam { get => _Nam; set => _Nam = value; }
        public int SoNgayCong { get => _SoNgayCong; set => _SoNgayCong = value; }
        public int SoGioLamThem { get => _SoGioLamThem; set => _SoGioLamThem = value; }
        public LuongNV() { }
        public LuongNV(string MaPB , string MaNV , string MaLuong , long LCB , long PhuCap , long Thuong , long KyLuat , int Thang , int Nam , int SoGioLamThem , int SoNgayCong , long TongLuong)
        {
            this.MaPB = MaPB;
            this.MaNV = MaNV;
            this.MaLuong = MaLuong;
            this.LCB = LCB;
            this.PhuCap = PhuCap;
            this.Thuong = Thuong;
            this.KyLuat = KyLuat;
            this.Thang = Thang;
            this.Nam = Nam;
            this.SoGioLamThem = SoGioLamThem;
            this.SoNgayCong = SoNgayCong;
            this.TongLuong = TongLuong;
        }
    }
}
