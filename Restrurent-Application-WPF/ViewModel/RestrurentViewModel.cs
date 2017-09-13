using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restrurent_Application_WPF.Model;
using Restrurent_Application_WPF.Page_Screens;

namespace Restrurent_Application_WPF.ViewModel
{
    public class RestrurentViewModel
    {
        public List<FoodItems> FoodItems { get; set; }
        public List<TableList> TableList { get; set; }
        RestrurentDB _rDB;
        public RestrurentViewModel()
        {
            _rDB = new RestrurentDB();
        }

        public List<FoodItems> GetFoodItems()
        {
            FoodItems = _rDB.FoodItems.ToList();
            return FoodItems;
        }

        public List<TableList> getTableList()
        {
            TableList = _rDB.TableList.ToList();
            return TableList;
        }

    }
}
