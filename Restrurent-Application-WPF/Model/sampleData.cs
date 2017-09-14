using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restrurent_Application_WPF.Model
{

    public class sampleData : CreateDatabaseIfNotExists<RestrurentDB>
    {
        enum bookingstatus { Booked, Reserved, Available };
        protected override void Seed(RestrurentDB context)
        {
            try
            {

                List<FoodItems> fooditems = new List<FoodItems>()
                {
                    new FoodItems { FoodName = "Tea", Description = "Tea", Price = 8 },
                     new FoodItems { FoodName = "Samosa", Description = "Samosa", Price = 12 },
                      new FoodItems { FoodName = "Vada Pav", Description = "Vada Pav", Price = 12 },
                       new FoodItems { FoodName = "Dosa", Description = "Dosa", Price = 20 }
                };

                List<TableList> tablelist = new List<TableList>()
                {
                    new TableList { BookingStatus = bookingstatus.Available.ToString() },
                    new TableList { BookingStatus = bookingstatus.Available.ToString() },
                    new TableList { BookingStatus = bookingstatus.Available.ToString() },
                    new TableList { BookingStatus = bookingstatus.Available.ToString() },
                    new TableList { BookingStatus = bookingstatus.Booked.ToString() },
                    new TableList { BookingStatus = bookingstatus.Available.ToString() },
                    new TableList { BookingStatus = bookingstatus.Available.ToString() },
                    new TableList { BookingStatus = bookingstatus.Available.ToString() },
                     new TableList { BookingStatus = bookingstatus.Available.ToString() }
                };

                foreach (FoodItems f in fooditems)
                {
                    context.FoodItems.Add(f);
                }

                foreach (TableList t in tablelist)
                {
                    context.TableList.Add(t);
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
