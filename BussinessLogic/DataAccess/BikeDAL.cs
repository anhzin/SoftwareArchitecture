using BussinessLogic.Entities;
using DtProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
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
            var sql = "SELECT * FROM Bikes";
            var ds = DataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text);
            var result = ds.Tables[0].TableToList<Bike>();
            return result;
        }

        public bool InsertBike(Bike bike)
        {
            bool result = false;
            var sql = "INSERT_BIKE";
            var engine = DataProvider.Param("EngineNumber", bike.EngineNumber);
            var chassis = DataProvider.Param("ChassisNumber", bike.ChassisNumber);
            var brand = DataProvider.Param("Brand", bike.Brand);
            var code = DataProvider.Param("ModelCode", bike.ModelCode);
            var capacity = DataProvider.Param("Capacity", bike.Capacity);
            var color = DataProvider.Param("Color", bike.Color);
            var plate = DataProvider.Param("PlateNumber", bike.PlateNumber);
            var storeID = DataProvider.Param("StoreID", bike.StoreID);
            var price = DataProvider.Param("Price", bike.Price);
            var customerID = DataProvider.Param("CustomerID", bike.CustomerID);
            var warranty = DataProvider.Param("WarrantyPeriod", bike.WarrantyPeriod);
            var success = DataProvider.OutputParam("Success", SqlDbType.Bit);
            var error = DataProvider.OutputParam("Error", SqlDbType.NVarChar, -1);
            result = DataProvider.ExecuteNonQuery(sql, CommandType.StoredProcedure, engine, chassis, brand, code, capacity, color, plate, storeID, price, customerID, warranty, success, error);
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

        public bool Delete(long id)
        {
            using (var db = new MotorcycleShopsEntities())
            {
                var record = db.Bikes.SingleOrDefault(i => i.ID == id);
                if (record != null)
                {
                    var result = db.Bikes.Remove(record);
                    db.SaveChanges();
                    if (result != null)
                    {
                        return true;
                    }
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

        //public bool InsertBike(Bike bike)
        //{
        //    bool result = false;
        //    using (var db = new MotorcycleShopsEntities())
        //    {
        //        var success = new ObjectParameter("Success", typeof(bool));
        //        var error = new ObjectParameter("Error", typeof(string));
        //        db.INSERT_BIKE(bike.EngineNumber, bike.ChassisNumber, bike.Brand, bike.ModelCode, bike.Capacity, bike.Color, bike.PlateNumber, bike.StoreID, bike.Price, bike.CustomerID, bike.WarrantyPeriod, success, error);
        //        result = Convert.ToBoolean(success.Value);
        //    }
        //    return result;
        //}

        //public List<Bike> GetAllBikes()
        //{
        //    List<Bike> results = null;
        //    using (var db = new MotorcycleShopsEntities())
        //    {
        //        results = db.Bikes.ToList<Bike>();
        //    }
        //    return results;
        //}
    }
}
