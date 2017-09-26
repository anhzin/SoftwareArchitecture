using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.DataAccess
{
    public class AccountDAL
    {
        private static AccountDAL _instance = null;
        private static Object _lockObj = new Object();

        private AccountDAL()
        {

        }
        public static AccountDAL GetInstance()
        {
            lock (_lockObj)
            {
                if(_instance == null)
                {
                    _instance = new AccountDAL();
                }
                return _instance;
            }
        }
        public Account GetAccountByUsername(string username)
        {
            Account account = null;
            using (var db = new MotorcycleShopsEntities())
            {
                account = db.Accounts.FirstOrDefault(a => a.Username.Equals(username));
            }
            return account;
        }
    }
}
