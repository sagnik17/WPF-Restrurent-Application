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
        enum bookingstatus { Booked, Reserved, Available };
        protected override void Seed(RestrurentDB context)
        {
            try
            {

                List<FoodItems> fooditems = new List<FoodItems>()
                {
                    new FoodItems { FoodName = "Tea", Description = "Tea", fPrice = 8 },
                     new FoodItems { FoodName = "Samosa", Description = "Samosa", fPrice = 12 },
                      new FoodItems { FoodName = "Vada Pav", Description = "Vada Pav", fPrice = 12 },
                       new FoodItems { FoodName = "Dosa", Description = "Dosa", fPrice = 20 }
                };

                List<TableList> tablelist = new List<TableList>()
                {
                    new TableList { TableName = "Table 1", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Table 2", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Table 3", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Table 4", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Table 5", BookingStatus = bookingstatus.Booked.ToString() },
                    new TableList {  TableName = "Table 6", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Table 7", BookingStatus = bookingstatus.Available.ToString() },
                    new TableList {  TableName = "Table 8", BookingStatus = bookingstatus.Available.ToString() },
                     new TableList {  TableName = "Table 9", BookingStatus = bookingstatus.Available.ToString() }
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
