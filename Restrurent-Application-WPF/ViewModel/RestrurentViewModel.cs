using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restrurent_Application_WPF.Model;

namespace Restrurent_Application_WPF.ViewModel
{
    public class RestrurentViewModel
    {
        RestrurentDB _rDB = new RestrurentDB();
        public IList<FoodItems> FoodItems { get; set; }
        public IList<TableList> TableList { get; set; }
        public RestrurentViewModel()
        {
            FoodItems = _rDB.FoodItems.ToList();
            TableList = _rDB.TableList.ToList();
        }
       
    }
}
