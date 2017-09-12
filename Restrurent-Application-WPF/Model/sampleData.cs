using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restrurent_Application_WPF.Model
{
    public class sampleData : DropCreateDatabaseAlways<RestrurentDB>
    {
        protected override void Seed(RestrurentDB context)
        {
            try
            {
                List<FoodItems> fooditems = new List<FoodItems>()
                {
                    new FoodItems { FoodName = "Tea", Description = "Tea", Price = 10 },
                     new FoodItems { FoodName = "Samosa", Description = "Samosa", Price = 15 },
                      new FoodItems { FoodName = "Vada Pav", Description = "Vada Pav", Price = 20 }
                };

                foreach(FoodItems f in fooditems)
                {
                    context.FoodItems.Add(f);
                }

                context.SaveChanges();
                base.Seed(context);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
