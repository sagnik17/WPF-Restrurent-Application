using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restrurent_Application_WPF.Model
{
    public class RestrurentDB : DbContext
    {
        public RestrurentDB() : base("DBContext")
        {
           Database.SetInitializer(new sampleData());
        }
        public DbSet<FoodItems> FoodItems { get; set; }
        public DbSet<TableList> TableList { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<FoodOrders> FoodOrders { get; set; }
        
       
       
    }
}
