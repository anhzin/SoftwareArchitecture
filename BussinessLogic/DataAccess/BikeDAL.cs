using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.DataAccess
{
    public class BikeDAL
    {
        private static BikeDAL _instance = null;
        private static Object lockObj = new Object();
        public static BikeDAL GetInstance()
        {
            lock (lockObj)
            {
                if (_instance == null)
                {
                    _instance = new BikeDAL();
                }
                return _instance;
            }                        
        }
        public List<Bike> GetAllBikes()
        {
            List<Bike> results = null;
            using (var db = new MotorcycleShopsEntities())
            {
                results = db.Bikes.ToList<Bike>();
            }
            return results;
        }

        public bool InsertBike(Bike bike)
        {
            bool result = false;
            using (var db = new MotorcycleShopsEntities())
            {
                var success = new ObjectParameter("Success", typeof(bool));
                var error = new ObjectParameter("Error", typeof(string));
                db.INSERT_BIKE(bike.EngineNumber, bike.ChassisNumber, bike.Brand, bike.ModelCode, bike.Capacity, bike.Color, bike.PlateNumber, bike.StoreID, bike.Price, bike.CustomerID, bike.WarrantyPeriod, success, error);
                result = Convert.ToBoolean(success.Value);
            }
            return result;
        }
    }
}
