using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.DataAccess
{
    public class EmployeeDAL
    {
        private static EmployeeDAL _instance = null;
        private static Object _lockObj = new Object();

        private EmployeeDAL()
        {

        }
        public static EmployeeDAL GetInstance()
        {
            lock (_lockObj)
            {
                if (_instance == null)
                {
                    _instance = new EmployeeDAL();
                }
                return _instance;
            }
        }

        public Employee GetEmployeeByID(long ID)
        {
            Employee employee = null;
            using (var db = new MotorcycleShopsEntities())
            {
                employee = db.Employees.FirstOrDefault(e => e.ID == ID);
            }
            return employee;
        }

        public List<Employee> GetAllItems()
        {
            List<Employee> result = null;
            using (var db = new MotorcycleShopsEntities())
            {
                result = db.Employees.ToList();
            }
            return result;
        }
    }
}
