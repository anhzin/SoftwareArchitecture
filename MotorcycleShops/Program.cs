using BussinessLogic.DataAccess;
using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleShops
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }
        
        private static void Test()
        {
            var bikeDAL = BikeDAL.GetInstance();
            var bikes = bikeDAL.GetAllBikes();
            Console.WriteLine("number of bikes: " + bikes.Count);
            Console.ReadLine();

            var bike = new Bike()
            {
                EngineNumber = "engine1",
                ChassisNumber = "chassic1",
                Brand = "brand",
                Color = "yellow",
                Capacity = 125,
                CustomerID = null,
                PlateNumber = "tada",
                ModelCode = "model",
                StoreID = null,
                Price = 0,
                WarrantyPeriod = "khong bao hanh",                
            };
            bikeDAL.InsertBike(bike);
        }
    }
}
