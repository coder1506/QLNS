using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class ThaiSan
    {
        private string _MaPB, _MaNV, _HoTen;
        private long _TroCap;
        private DateTime _NgayVe, _NgayTroLai;
        public string MaPB { get => _MaPB; set => _MaPB = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public long TroCap { get => _TroCap; set => _TroCap = value; }
        public DateTime NgayVe { get => _NgayVe; set => _NgayVe = value; }
        public DateTime NgayTroLai { get => _NgayTroLai; set => _NgayTroLai = value; }
        public ThaiSan() { }
        public ThaiSan(string MaPB, string MaNV, string HoTen, long TroCap, DateTime NgayVe, DateTime NgayTroLai)
        {
            this.MaPB = MaPB;
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.TroCap = TroCap;
            this.NgayVe = NgayVe;
            this.NgayTroLai = NgayTroLai;
        }
    }
}
