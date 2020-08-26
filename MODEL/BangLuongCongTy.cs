using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class BangLuongCongTy
    {
        private string _MaLuong;
        private long _LCB, _PhuCap;
        private DateTime _NgaySua;

        
        public BangLuongCongTy() { }
        public BangLuongCongTy(string MaLuong , long LCB , long PhuCap , DateTime NgaySua )
        {
            this.MaLuong = MaLuong;
            this.LCB = LCB;
            this.NgaySua = NgaySua;
            this.PhuCap = PhuCap;
        }

        public string MaLuong { get => _MaLuong; set => _MaLuong = value; }
        public long LCB { get => _LCB; set => _LCB = value; }
        public long PhuCap { get => _PhuCap; set => _PhuCap = value; }
        public DateTime NgaySua { get => _NgaySua; set => _NgaySua = value; }
    }
}
