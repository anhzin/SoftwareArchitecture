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
            try
            {
                using (var ds = DataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text))
                {
                    var result = ds.Tables[0].TableToList<Bike>();
                    return result;
                }
            } catch (Exception e)
            {
                return null;
            }
                           
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
            try
            {
                result = DataProvider.ExecuteNonQuery(sql, CommandType.StoredProcedure, engine, chassis, brand, code, capacity, color, plate, storeID, price, customerID, warranty, success, error);
            }
            catch (Exception e)
            {

            }            
            return result;
        }

        public Bike SearchBike(string engine, string chassis)
        {
            Bike bike = null;
            string sql = "SELECT * FROM Bikes WHERE EngineNumber = @engine AND ChassisNumber = @chassis";
            var engineParam = DataProvider.Param("engine", engine);
            var chassisParam = DataProvider.Param("chassis", chassis);
            try
            {
                using (var ds = DataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text, engineParam, chassisParam))
                {
                    var list = ds.Tables[0].TableToList<Bike>();
                    if(list != null && list.Count > 0)
                    {
                        return list[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            } catch (Exception e)
            {
                return null;
            }
            return bike;
        }

        public bool UpdateBike(Bike bike)
        {
            string sql = "UPDATE Bikes "
                + "SET EngineNumber = @engine, ChassisNumber = @chassis, Brand = @brand, ModelCode = @code, Capacity = @capacity, Color = @color, PlateNumber = @plate, StoreID = @storeID, Price = @price, CustomerID = @customerID, WarrantyPeriod = @warranty "
                + "WHERE ID = @id SELECT @@ROWCOUNT";
            var id = DataProvider.Param("id", bike.ID);
            var engine = DataProvider.Param("engine", bike.EngineNumber);
            var chassis = DataProvider.Param("chassis", bike.ChassisNumber);
            var brand = DataProvider.Param("brand", bike.Brand);
            var code = DataProvider.Param("code", bike.ModelCode);
            var capacity = DataProvider.Param("capacity", bike.Capacity);
            var color = DataProvider.Param("color", bike.Color);
            var plate = DataProvider.Param("plate", bike.PlateNumber);
            var storeId = DataProvider.Param("storeID", bike.StoreID);
            var price = DataProvider.Param("price", bike.Price);
            var customerId = DataProvider.Param("customerID", bike.CustomerID);
            var warranty = DataProvider.Param("warranty", bike.WarrantyPeriod);
            try
            {
                var rowCount = (int)DataProvider.ExecuteScalarQuery(sql, CommandType.Text, id, engine, chassis, brand, code, capacity, color, plate, storeId, price, customerId, warranty);
                return rowCount > 0 ? true : false;
            } catch(Exception e)
            {
                return false;
            }
        }

        public bool Delete(long id)
        {
            var sql = "DELETE FROM Bikes WHERE ID = @id SELECT @@ROWCOUNT";
            var idParam = DataProvider.Param("id", id);
            try
            {
                var rowCount = (int)DataProvider.ExecuteScalarQuery(sql, CommandType.Text, idParam);
                return rowCount > 0 ? true : false;
            } catch(Exception e)
            {
                return false;
            }
        }
    

        public List<Bike> FilterBike(string engine, string chassis, string code)
        {
            List<Bike> list = null;
            string sql = "SELECT * FROM Bikes";
            try
            {
                using (var ds = DataProvider.ExecuteQueryWithDataSet(sql, CommandType.Text))
                {
                    list = ds.Tables[0].TableToList<Bike>();
                    if(list != null && list.Count > 0)
                    {
                        if (!string.IsNullOrWhiteSpace(engine))
                        {
                            list = list.Where(i => i.EngineNumber.ToUpper().Contains(engine.ToUpper())).ToList<Bike>();
                        }
                        if (!string.IsNullOrWhiteSpace(chassis))
                        {
                            list = list.Where(i => i.ChassisNumber.ToUpper().Contains(chassis.ToUpper())).ToList<Bike>();
                        }
                        if (!string.IsNullOrWhiteSpace(code))
                        {
                            list = list.Where(i => i.ModelCode.ToUpper().Contains(code.ToUpper())).ToList<Bike>();
                        }
                    }
                }
            } catch (Exception e)
            {
                return null;
            }
            return list;
        }        
    }
}
