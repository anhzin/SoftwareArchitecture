using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.DataAccess
{
    public class BillEmployeesDAL
    {
        private static BillEmployeesDAL _instance = null;
        private static Object _lockObj = new Object();

        private BillEmployeesDAL()
        {

        }
        public static BillEmployeesDAL GetInstance()
        {
            lock (_lockObj)
            {
                if (_instance == null)
                {
                    _instance = new BillEmployeesDAL();
                }
                return _instance;
            }
        }

        public long Insert(BillEmployee billEmp)
        {
            long id = 1;
            using (var db = new MotorcycleShopsEntities())
            {
                db.BillEmployees.Add(billEmp);
                db.SaveChanges();
            }
            return id;
        }
    }
}
