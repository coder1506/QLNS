using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class NVThuViec
    {
        private string _MaNV;
        private string _MaPB;
        private string _HoTen;
        private DateTime _NgaySinh;
        private string _GioiTinh;
        private string _DiaChi;
        private string _ViTri;
        private int _SoThang;
        private DateTime _NgayBatDau;
        private DateTime _NgayHetHan;
        private string _TrinhDo;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaPB { get => _MaPB; set => _MaPB = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string ViTri { get => _ViTri; set => _ViTri = value; }
        public int SoThang { get => _SoThang; set => _SoThang = value; }
        public DateTime NgayBatDau { get => _NgayBatDau; set => _NgayBatDau = value; }
        public DateTime NgayHetHan { get => _NgayHetHan; set => _NgayHetHan = value; }
        public string TrinhDo { get => _TrinhDo; set => _TrinhDo = value; }

        public NVThuViec() { }
        public NVThuViec(string maNV, string maPB, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string viTri, int soThang, DateTime ngayBatDau, DateTime ngayHetHan, string trinhDo)
        {
            MaNV = maNV;
            MaPB = maPB;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            ViTri = viTri;
            SoThang = soThang;
            NgayBatDau = ngayBatDau;
            NgayHetHan = ngayHetHan;
            TrinhDo = trinhDo;
        }
    }
}
