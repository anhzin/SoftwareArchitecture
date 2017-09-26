using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.DataAccess
{
    public class SaleReceiptDAL
    {
        private static SaleReceiptDAL _instance = null;
        private static Object _lockObj = new Object();

        private SaleReceiptDAL()
        {

        }
        public static SaleReceiptDAL GetInstance()
        {
            lock (_lockObj)
            {
                if (_instance == null)
                {
                    _instance = new SaleReceiptDAL();
                }
                return _instance;
            }
        }
        
        public TransactionResult CreateNewSaleReceipt(string phone, Bike bike)
        {
            var cashier = AccountInformation.GetInstance().CurrentAccount.Employee;
            var result = new TransactionResult();
            using (var db = new MotorcycleShopsEntities())
            {
                var success = new ObjectParameter("Success", typeof(bool));
                var error = new ObjectParameter("Error", typeof(string));
                db.NEW_SALE_TRANSACTION(phone, bike.EngineNumber, bike.ChassisNumber, cashier.ID, DateTime.Now, cashier.StoreID, success, error);
                result.Success = success.Value != DBNull.Value ? (bool)success.Value : true;
                result.Error = error.Value != DBNull.Value ? (string)error.Value : "";
            }
            return result;
        } 

        public void InsertRecord(SaleReceipt sale)
        {
            using (var db = new MotorcycleShopsEntities())
            {
                db.SaleReceipts.Add(sale);
                db.SaveChanges();
            }
        }
    }
}
