using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class TTCoBan
    {
        private string _MaNV;
        private string _MaPB;
        private string _HoTen;
        private string _MaLuong;
        private DateTime _NgaySinh;
        private string _GioiTinh;
        private string _Cmt;
        private DateTime _NgayCap;
        private string _NoiCap;
        private string _ChucVu;
        private int _ThoiGianLamViec;
        private DateTime _NgayKy;
        private DateTime _NgayHetHan;
        private string _TinhTrangHD;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaPB { get => _MaPB; set => _MaPB = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string MaLuong { get => _MaLuong; set => _MaLuong = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string Cmt { get => _Cmt; set => _Cmt = value; }
        public DateTime NgayCap { get => _NgayCap; set => _NgayCap = value; }
        public string NoiCap { get => _NoiCap; set => _NoiCap = value; }
        public string ChucVu { get => _ChucVu; set => _ChucVu = value; }
        public int ThoiGianLamViec { get => _ThoiGianLamViec; set => _ThoiGianLamViec = value; }
        public DateTime NgayKy { get => _NgayKy; set => _NgayKy = value; }
        public DateTime NgayHetHan { get => _NgayHetHan; set => _NgayHetHan = value; }
        public string TinhTrangHD { get => _TinhTrangHD; set => _TinhTrangHD = value; }
        public TTCoBan() { }
        public TTCoBan(string maNV, string maPB, string hoTen, string maLuong, DateTime ngaySinh, string gioiTinh, string cmt, DateTime ngayCap, string noiCap, string chucVu, int thoiGianLamViec, DateTime ngayKy, DateTime ngayHetHan, string tinhTrangHD)
        {
            MaNV = maNV;
            MaPB = maPB;
            HoTen = hoTen;
            MaLuong = maLuong;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Cmt = cmt;
            NgayCap = ngayCap;
            NoiCap = noiCap;
            ChucVu = chucVu;
            ThoiGianLamViec = thoiGianLamViec;
            NgayKy = ngayKy;
            NgayHetHan = ngayHetHan;
            TinhTrangHD = tinhTrangHD;
        }
    }
}
