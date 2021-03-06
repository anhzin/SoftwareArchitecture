﻿using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.DataAccess
{
    public class BillDetailDAL
    {
        private static BillDetailDAL _instance = null;
        private static Object lockObj = new Object();
        private BillDetailDAL()
        {

        }
        public static BillDetailDAL GetInstance()
        {
            lock (lockObj)
            {
                if (_instance == null)
                {
                    _instance = new BillDetailDAL();
                }
                return _instance;
            }
        }

        public long Insert(BillDetail bd)
        {
            long id = 1;
            using (var db = new MotorcycleShopsEntities())
            {
                db.BillDetails.Add(bd);
                db.SaveChanges();
                id = bd.ID;
            }
            return id;
        }
    }
}
