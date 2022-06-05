using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        public static bool IsProductInWarehouse(string idStorageId)
        {
            using (var db = new InventoryContext())
            {
                var product = db.Storages.ToList().Where(x => x.StorageId == idStorageId).Any();
                return product;
            }
        }

        public static List<StorageEntity> StorageProductByWarehouse(string idWarehouse)
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.Include(s => s.Product).Include(s => s.WareHouse).Where(x => x.WareHouseId == idWarehouse).ToList();
            }
        }

        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
