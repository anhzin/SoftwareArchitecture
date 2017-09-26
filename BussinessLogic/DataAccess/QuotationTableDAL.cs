using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.DataAccess
{
    public class QuotationTableDAL
    {
        private static QuotationTableDAL _instance = null;
        private static Object _lockObj = new Object();

        private QuotationTableDAL()
        {

        }
        public static QuotationTableDAL GetInstance()
        {
            lock (_lockObj)
            {
                if (_instance == null)
                {
                    _instance = new QuotationTableDAL();
                }
                return _instance;
            }
        }

        public List<QuotationTable> GetAllItems()
        {
            List<QuotationTable> result = null;
            using (var db = new MotorcycleShopsEntities())
            {
                var list = db.QuotationTables.ToList();
                result = new List<QuotationTable>(list);                           
            }

            return result;
        }
    }
}
