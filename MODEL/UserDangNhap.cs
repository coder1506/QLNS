using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class UserDangNhap
    {
        private string _Username;

        public string Username { get => _Username; set => _Username = value; }

        private string _Password;

        public string Password { get => _Password; set => _Password = value; }

        public UserDangNhap() { }
        public UserDangNhap(string username,string Password) {
            this.Username = username;
            this.Password = Password;
        }

    }
}
