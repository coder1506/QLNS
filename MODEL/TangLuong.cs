using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class TangLuong
    {
        string _MaPB, _MaNV, _HoTen, _GioiTinh, _ChucVu, _MaLuong;
        DateTime _NgayTang;

        public string MaPB { get => _MaPB; set => _MaPB = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string ChucVu { get => _ChucVu; set => _ChucVu = value; }
        public string MaLuong { get => _MaLuong; set => _MaLuong = value; }
        public DateTime NgayTang { get => _NgayTang; set => _NgayTang = value; }
        public TangLuong() { }
        public TangLuong(string MaPB , string MaNV , string HoTen , string GioiTinh , string ChucVu , string MaLuong , DateTime NgayTang)
        {
            this.MaPB = MaPB;
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.ChucVu = ChucVu;
            this.MaLuong = MaLuong;
            this.NgayTang = NgayTang;
        }
    }
}
