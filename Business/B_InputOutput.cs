using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InputOutput
    {
        public static List<InputOutputEnitity> InOutPutList()
        {
            using(var db = new InventoryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public static void CreateInOutPut(InputOutputEnitity oInOutPut)
        {
            using(var db = new InventoryContext())
            {
                db.InOuts.Add(oInOutPut);
                db.SaveChanges();
            }
        }

        public static void UpdateInOutPut(InputOutputEnitity oInOutPut)
        {
            using (var db = new InventoryContext())
            {
                db.InOuts.Update(oInOutPut);
                db.SaveChanges();
            }
        }
    }
}
