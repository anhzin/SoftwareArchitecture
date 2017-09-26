using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Entities
{
    public class AccountInformation
    {
        private static AccountInformation _instance = null;
        private static Object _lockObj = new object();
        private AccountInformation()
        {

        }

        public static AccountInformation GetInstance()
        {
            lock (_lockObj)
            {
                if(_instance == null)
                {
                    _instance = new AccountInformation();
                }
                return _instance;
            }
        }

        private Account currentAccount;

        public Account CurrentAccount
        {
            get { return currentAccount; }
            set { currentAccount = value; }
        }

    }
}
