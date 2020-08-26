using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class UserDangKi:UserDangNhap
    {
        private string _HoVaTen;
        public string HoVaTen { get => _HoVaTen; set => _HoVaTen = value; }
        private DateTime _NgaySinh;
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        private string _Quyen;
        public string Quyen { get => _Quyen; set => _Quyen = value; }

        public UserDangKi() { }
        public UserDangKi(string UserName, string Password,string HoVaTen,DateTime NgaySinh,string Quyen) : base(UserName, Password)
        {
            this.HoVaTen = HoVaTen;
            this.NgaySinh = NgaySinh;
            this.Quyen = Quyen;
        }
    }
}
