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
        private BikeDAL()
        {

        }
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

        public Bike SearchBike(string engine, string chassis)
        {
            Bike bike = null;
            using (var db = new MotorcycleShopsEntities())
            {
                bike = db.Bikes.FirstOrDefault(b => b.ChassisNumber.Equals(chassis) && b.EngineNumber.Equals(engine));
            }
            return bike;
        }

        public bool UpdateBike(Bike bike)
        {
            using (var db = new MotorcycleShopsEntities())
            {
                var result = db.Bikes.SingleOrDefault(b => b.ID == bike.ID);
                if(result != null)
                {
                    result.Brand = bike.Brand;
                    result.Capacity = bike.Capacity;
                    result.ChassisNumber = bike.ChassisNumber;
                    result.Color = bike.Color;
                    result.CustomerID = bike.CustomerID;
                    result.EngineNumber = bike.EngineNumber;
                    result.ModelCode = bike.ModelCode;
                    result.PlateNumber = bike.PlateNumber;
                    result.Price = bike.Price;
                    result.StoreID = bike.StoreID;
                    result.WarrantyPeriod = bike.WarrantyPeriod;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public List<Bike> FilterBike(string engine, string chassis, string code)
        {
            List<Bike> list = null;
            using (var db = new MotorcycleShopsEntities())
            {
                if (string.IsNullOrWhiteSpace(engine))
                {
                    list = db.Bikes.ToList();
                }else
                {
                    list = db.Bikes.Where(i => i.EngineNumber.ToUpper().Contains(engine.ToUpper())).ToList();
                }
                if (!string.IsNullOrWhiteSpace(chassis))
                {
                    list = list.Where(i => i.ChassisNumber.ToUpper().Contains(chassis.ToUpper())).ToList();
                }
                if (!string.IsNullOrWhiteSpace(code))
                {
                    list = list.Where(i => i.ModelCode.ToUpper().Contains(code.ToUpper())).ToList();
                }
            }
            return list;
        }
        public bool Delete(long id)
        {
            using (var db = new MotorcycleShopsEntities())
            {
                var record = db.Bikes.SingleOrDefault(i => i.ID == id);
                if(record != null)
                {
                    var result = db.Bikes.Remove(record);
                    db.SaveChanges();
                    if(result != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
