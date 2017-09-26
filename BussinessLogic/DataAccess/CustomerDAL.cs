
using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.DataAccess
{
    public class CustomerDAL
    {
        private static CustomerDAL _instance = null;
        private static Object _lockObj = new Object();

        private CustomerDAL()
        {

        }
        public static CustomerDAL GetInstance()
        {
            lock (_lockObj)
            {
                if (_instance == null)
                {
                    _instance = new CustomerDAL();
                }
                return _instance;
            }
        }

        public TransactionResult InsertCustomer(Customer cus)
        {
            var result = new TransactionResult(true, "");
            using (var db = new MotorcycleShopsEntities())
            {
                var success = new ObjectParameter("Success", typeof(bool));
                var error = new ObjectParameter("Error", typeof(string));
                var id = new ObjectParameter("CurrentIdentity", typeof(long));
                db.INSERT_CUSTOMER(cus.Name, cus.DOB, cus.Address, cus.PhoneNumber, cus.Email, id, success, error);
                result.Success = success.Value != DBNull.Value ? (bool)success.Value : true;
                //if (!result.Success)
                //{
                    result.Error = error.Value != DBNull.Value ? (string)error.Value : "";
                    result.CurrentIdentity = error.Value != DBNull.Value ? (long)id.Value : 1;
                //}
            }
            return result;
        }
    }
}
