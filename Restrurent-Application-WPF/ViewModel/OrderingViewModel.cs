using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restrurent_Application_WPF.Model;
using Restrurent_Application_WPF.ActionEvents;
using Restrurent_Application_WPF.DB_Layer;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Restrurent_Application_WPF.ViewModel
{
    public class OrderingViewModel : ObservableObject
    {
        private string status;
        public string Message
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                NotifyPropertyChanged();
            }
        }
        private List<TableList> _table;
        public List<TableList> Tablelist
        {
            get { return _table; }
            set { _table = value; }
        }
        private TableList _stablelist;

        public TableList STableList
        {
            get { return _stablelist; }
            set { _stablelist = value; }
        }

        
        public ICollection<FoodItems> Foodlist
        {
            get;
            private set;
        }
        private FoodItems _sFoodItem;

        public FoodItems SFoodList
        {
            get { return _sFoodItem; }
            set { _sFoodItem = value; }
        }
        private DataAccessLayer _dbLayerObj;
        private ViewOrderItems selectedOrderItem;

        public ViewOrderItems SelectedOrderItem
        {
            get
            {
                return selectedOrderItem;
            }
            set
            {
                selectedOrderItem = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
                NotifyPropertyChanged("CanNotModify");
            }
        }


        public OrderingViewModel() : this(new DataAccessLayer())
        {
            Message = "";
        }

        public OrderingViewModel(DataAccessLayer _dbLayerObj)
        {
            getTableList();
            getFoodList();
            this._dbLayerObj = _dbLayerObj;
        }

        public List<TableList> getTableList()
        {
            Tablelist = new List<TableList>();
            _dbLayerObj = new DataAccessLayer();
            Tablelist = _dbLayerObj.getTableListToPlaceOrder();
            return Tablelist;
        }

        public List<TableList> getFoodList()
        {
            _dbLayerObj = new DataAccessLayer();
            Foodlist = _dbLayerObj.GetFoodItems();
            return Tablelist;
        }

        public FoodItems getFoodDetail(int foodid)
        {
            return _dbLayerObj.getFoodDetails(foodid);
        }
       
        public ICollection<ViewOrderItems> foodOrderItems
        {
            get;
            private set;
        }
        
        public bool PlaceOrder(List<ViewOrderItems> Obj)
        {
            _dbLayerObj = new DataAccessLayer();
            return _dbLayerObj.PlaceOrder(Obj);
        }

        



    }
}
