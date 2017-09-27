using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.DataAccess
{
    public class MaintenanceBillDAL
    {
        private static MaintenanceBillDAL _instance = null;
        private static Object _lockObj = new Object();

        private MaintenanceBillDAL()
        {

        }
        public static MaintenanceBillDAL GetInstance()
        {
            lock (_lockObj)
            {
                if (_instance == null)
                {
                    _instance = new MaintenanceBillDAL();
                }
                return _instance;
            }
        }

        public long Insert(MaintenanceBill bill)
        {
            long id = 1;
            using (var db = new MotorcycleShopsEntities())
            {
                db.MaintenanceBills.Add(bill);
                db.SaveChanges();
                id = bill.ID;
            }
            return id;
        }
    }
}
