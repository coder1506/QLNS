using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class KhenThuong
    {
        string _MaPB, _MaNV, _HoTen, _MaKhenThuong, _LyDo;
        long _TienThuong;
        DateTime _NgayKhenThuong;

        
        public KhenThuong() { }
        public KhenThuong(string MaPB, string MaNV, string HoTen, long TienThuong, string MaThuong, DateTime NgayThuong, string LyDo)
        {
            this.MaPB = MaPB;
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.TienThuong = TienThuong;
            this.MaKhenThuong = MaThuong;
            this.NgayKhenThuong = NgayThuong;
            this.LyDo = LyDo;
        }

        public string MaPB { get => _MaPB; set => _MaPB = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string MaKhenThuong { get => _MaKhenThuong; set => _MaKhenThuong = value; }
        public string LyDo { get => _LyDo; set => _LyDo = value; }
        public long TienThuong { get => _TienThuong; set => _TienThuong = value; }
        public DateTime NgayKhenThuong { get => _NgayKhenThuong; set => _NgayKhenThuong = value; }
    }
}
