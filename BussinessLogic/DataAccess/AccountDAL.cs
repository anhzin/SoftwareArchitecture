using BussinessLogic.Entities;
using DtProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        //public Account GetAccountByUsername(string username)
        //{
        //    Account account = null;
        //    using (var db = new MotorcycleShopsEntities())
        //    {
        //        account = db.Accounts.FirstOrDefault(a => a.Username.Equals(username));
        //    }
        //    return account;
        //}
        public Account GetAccountByUsername(string username)
        {
            string sql = "SELECT * FROM Accounts WHERE Username = @username";
            var usernameParam = DataProvider.Param("username", username);
            Account account = null;
            try
            {
                using (var reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text, usernameParam))
                {
                    if (reader.Read())
                    {
                        account = new Account()
                        {
                            Username = reader.GetString(0),
                            Password = reader.GetString(1),
                            EmployeeID = reader.GetInt64(2)
                        };
                    }
                }
            }
            catch (Exception e)
            {

            }
            return account;
        }
    }
}
