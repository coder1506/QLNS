using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class BaoHiem
    {
        private string _MaNV, _NoiCap;
        private long _MaBH;
        private DateTime _NgayCap, _NgayHetHan;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string NoiCap { get => _NoiCap; set => _NoiCap = value; }
        public long MaBH { get => _MaBH; set => _MaBH = value; }
        public DateTime NgayCap { get => _NgayCap; set => _NgayCap = value; }
        public DateTime NgayHetHan { get => _NgayHetHan; set => _NgayHetHan = value; }

        public BaoHiem() { }
        public BaoHiem(string manv, long mabh, DateTime ngaycap, DateTime ngayhethan, string noicap)
        {
            this.MaNV = manv;
            this.MaBH = mabh;
            this.NgayCap = ngaycap;
            this.NgayHetHan = ngayhethan;
            this.NoiCap = noicap;
        }
    }
}