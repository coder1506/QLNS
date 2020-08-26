using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class KyLuat
    {
        string _MaPB, _MaNV, _HoTen, _MaKyLuat,  _LyDo;
        long _TienPhat;
        DateTime _NgayKyLuat;

        public string MaPB { get => _MaPB; set => _MaPB = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string MaKyLuat { get => _MaKyLuat; set => _MaKyLuat = value; }
        public string LyDo { get => _LyDo; set => _LyDo = value; }
        public long TienPhat { get => _TienPhat; set => _TienPhat = value; }
        public DateTime NgayKyLuat { get => _NgayKyLuat; set => _NgayKyLuat = value; }
        public KyLuat() { }
        public KyLuat(string MaPB , string MaNV , string HoTen , long TienPhat , string MaKyLuat , DateTime NgayKyLuat , string LyDo)
        {
            this.MaPB = MaPB;
            this.MaNV = MaPB;
            this.HoTen = HoTen;
            this.TienPhat = TienPhat;
            this.MaKyLuat = MaKyLuat;
            this.NgayKyLuat = NgayKyLuat;
            this.LyDo = LyDo;
        }
    }
}
