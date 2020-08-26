using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class PhongBan
    {
        private string _MaPB, _TenPB;
        private DateTime _NgayThanhLap;

        public string MaPB { get => _MaPB; set => _MaPB = value; }
        public string TenPB { get => _TenPB; set => _TenPB = value; }
        public DateTime NgayThanhLap { get => _NgayThanhLap; set => _NgayThanhLap = value; }
        public PhongBan() { }
        public PhongBan(string MaPB , string TenPB , DateTime NgayThanhLap)
        {
            this.MaPB = MaPB;
            this.TenPB = TenPB;
            this.NgayThanhLap = NgayThanhLap;
        }
    }
}
