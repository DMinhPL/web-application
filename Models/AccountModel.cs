using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private OnlineShopDBContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDBContext();
        }
        public bool  Login(string username, string password)
        {
            object[] sqlParams = 
            {
                new SqlParameter("@Username",username),
                new SqlParameter("@Password", password),
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @Username, @Password", sqlParams).SingleOrDefault();
            return res;
        }
    }

  
}
