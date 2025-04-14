using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nzikrov.BdMod;
using nzikrov.dbContext;
using nzikrov.ModelUs;

namespace nzikrov
{
    public class AuthService : IauthService1
    {
        private List<user> _users;
        private ShopDBEntities1 dbContext;
        public AuthService()
        {
            ShopDBEntities1 dbContext = new ShopDBEntities1();
        }

            public bool CheckData(string Login, string Password)
        {
            var user = dbContext.Users.Include(u => u.Role).FirstOrDefault(u => u.Login == Login && u.Password == Password);

            if (user != null && user.Password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
