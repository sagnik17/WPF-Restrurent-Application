﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restrurent_Application_WPF.Model;
using Restrurent_Application_WPF.Page_Screens;
using Restrurent_Application_WPF.ActionEvents;
using Restrurent_Application_WPF.DB_Layer;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Restrurent_Application_WPF.ViewModel
{
    public class RestrurentViewModel : ObservableObject
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
        public ICollection<FoodItems> FoodItems
        {
            get;
            private set;
        }
        private List<TableList> TableList { get; set; }

        private FoodItems selectedFoodItem;
       
        private DataAccessLayer _dbLayerObj;

        public RestrurentViewModel() : this(new DataAccessLayer())
        {
            GetCustomerList();
            Message = "";
        }

        public RestrurentViewModel(DataAccessLayer _dbLayerObj)
        {
            FoodItems = new ObservableCollection<FoodItems>();
            this._dbLayerObj = _dbLayerObj;
        }

        public List<TableList> getTableList()
        {
            //TableList = _dbLayerObj.getTableList();
            return TableList;
        }

        public FoodItems SelectedFoodItem
        {
            get
            {
                return selectedFoodItem;
            }
            set
            {
                selectedFoodItem = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("CanModify");
                NotifyPropertyChanged("CanNotModify");
            }
        }

        public bool CanNotModify
        {
            get
            {
                return SelectedFoodItem == null;
            }
        }
        public bool CanModify
        {
            get
            {
                return SelectedFoodItem != null;
            }
        }

        public bool IsValid
        {
            get
            {
                return SelectedFoodItem == null ||
                       (
                           !String.IsNullOrWhiteSpace(SelectedFoodItem.FoodName) &&
                           !String.IsNullOrWhiteSpace(SelectedFoodItem.Description) &&
                           !String.IsNullOrWhiteSpace(SelectedFoodItem.Price.ToString())
                       );
            }
        }
        public ICommand GetFoodListCommand
        {
            get
            {
                return new ActionCommand(p => GetCustomerList());
            }
        }
        private void GetCustomerList()
        {
            FoodItems.Clear();
            selectedFoodItem = null;

            foreach (var fooditem in _dbLayerObj.GetFoodItems())
                FoodItems.Add(fooditem);
        }

        public ICommand UpdateCommand
        {
            get
            {
                return new ActionCommand(p => UpdateFoodItem(),
                                         p => IsValid);
            }
        }
        public ICommand DeleteCommand
        {
            get
            {
                return new ActionCommand(p => DeleteFoodItem());
            }
        }


        public void AddFoodItem(FoodItems fodditem)
        {
            _dbLayerObj.InsertNewFoodItem(fodditem);
        }
        private void UpdateFoodItem()
        {
            if (SelectedFoodItem != null || SelectedFoodItem.Description == null)
            {
                _dbLayerObj.UpdateFoodDetails(SelectedFoodItem);
                Message = "Item Updated Successfully";
                GetCustomerList();
            }
        }

        private void DeleteFoodItem()
        {
            if (SelectedFoodItem != null || SelectedFoodItem.Description == null)
            {
                _dbLayerObj.DeleteFoodDetails(SelectedFoodItem);
                Message = "Item Deleted Successfully";
                GetCustomerList();
            }
        }

    }
}
