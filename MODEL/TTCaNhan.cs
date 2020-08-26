using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class TTCaNhan
    {
        private string _MaNV;
        private string _HoTen;
        private DateTime _NgaySinh;
        private string _GioiTinh;
        private string _NoiSinh;
        private string _DctamTru;
        private string _DcThuongTru;
        private string _DanToc;
        private string _TonGiao;
        private string _QuocTich;
        private string _BangCap;
        private string _Sdt;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string NoiSinh { get => _NoiSinh; set => _NoiSinh = value; }
        public string DctamTru { get => _DctamTru; set => _DctamTru = value; }
        public string DcThuongTru { get => _DcThuongTru; set => _DcThuongTru = value; }
        public string DanToc { get => _DanToc; set => _DanToc = value; }
        public string TonGiao { get => _TonGiao; set => _TonGiao = value; }
        public string QuocTich { get => _QuocTich; set => _QuocTich = value; }
        public string BangCap { get => _BangCap; set => _BangCap = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }

        public TTCaNhan() {  }
        public TTCaNhan(string maNV, string hoTen, DateTime ngaySinh, 
            string gioiTinh, string noiSinh, string dctamTru, string dcThuongTru, 
            string danToc, string tonGiao, string quocTich, string bangCap, string sdt)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            NoiSinh = noiSinh;
            DctamTru = dctamTru;
            DcThuongTru = dcThuongTru;
            DanToc = danToc;
            TonGiao = tonGiao;
            QuocTich = quocTich;
            BangCap = bangCap;
            Sdt = sdt;
        }
    }
}
