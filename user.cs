using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nzikrov;

namespace nzikrov.ModelUs
{
    internal class user
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public user(string login, string pass)
        {
            Login = login;
            Password = pass;
        }
    }
}
