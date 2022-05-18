using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_WareHouse
    {
        public static List<WareHouseEntity> WareHouseList()
        {
            using(var db = new InventoryContext())
            {
                return db.WareHouses.ToList();
            }
        }

        public static void CreateWareHouse(WareHouseEntity oWareHouse)
        {
            using(var db = new InventoryContext())
            {
                db.WareHouses.Add(oWareHouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventoryContext())
            {
                db.WareHouses.Update(oWareHouse);
                db.SaveChanges();
            }
        }
    }
}
