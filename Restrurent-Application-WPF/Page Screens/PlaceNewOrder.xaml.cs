using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Restrurent_Application_WPF.ViewModel;
using Restrurent_Application_WPF.Model;

namespace Restrurent_Application_WPF.Page_Screens
{
    /// <summary>
    /// Interaction logic for PlaceNewOrder.xaml
    /// </summary>
    public partial class PlaceNewOrder : Page
    {
        private OrderingViewModel _oVM;
        private FoodOrders obj;
        private FoodItems fooditemdata;
        private ViewOrderItems _vOrderItems;
        private List<ViewOrderItems> mycart;
             
        public PlaceNewOrder()
        {
            InitializeComponent();
            DataContext = new OrderingViewModel();
            mycart = new List<ViewOrderItems>();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            if(fooditem.SelectedValue != null || tableitem.SelectedValue != null || Quantitytxt.Text != null)
            {
                _vOrderItems = new ViewOrderItems();
                _oVM = new OrderingViewModel();
                fooditemdata = _oVM.getFoodDetail(Convert.ToInt32(fooditem.SelectedValue));
                _vOrderItems.Quantity = Convert.ToInt32(Quantitytxt.Text);
                _vOrderItems.Price = fooditemdata.fPrice * _vOrderItems.Quantity;
                _vOrderItems.FoodID = fooditemdata.FoodID;
                _vOrderItems.FoodName = fooditemdata.FoodName;
                _vOrderItems.TableID = Convert.ToInt32(tableitem.SelectedValue);
                mycart.Add(_vOrderItems);
                fooditemsgrid.ItemsSource = mycart;
                fooditemsgrid.Items.Refresh();
                status.Content = "Item Added To List";
            }
            else
            {
                status.Foreground = Brushes.Red;
                status.Content = "All Fields are compulsory";
                status.Foreground = Brushes.Green;
            }
           
        }

        private void PlaceOrder_Click(object sender, RoutedEventArgs e)
        {
            if(fooditemsgrid.ItemsSource != null)
            {
                _oVM = new OrderingViewModel();
                bool confirm = _oVM.PlaceOrder(mycart);
                if(confirm)
                {
                    DataContext = new OrderingViewModel();
                    mycart.Clear();
                    fooditemsgrid.ItemsSource = mycart;
                    fooditemsgrid.Items.Refresh();
                    status.Content = "Order Placed";
                }
                else
                {
                    status.Content = "Something Went Wrong";
                }
               
            }
            else
            {
                status.Content = "No Food Items Added to List";
            }
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<ViewOrderItems> temp = new List<ViewOrderItems>();
           
            int selecteditem = Convert.ToInt32(fooditemsgrid.SelectedValue);
            temp = mycart.Where(p => p.FoodID != selecteditem).ToList();
            //temp.RemoveAt(selecteditem);
            mycart.Clear();
            foreach (var v in temp)
            {
                mycart.Add(v);
            }
            fooditemsgrid.ItemsSource = mycart;
            fooditemsgrid.Items.Refresh();
            status.Content = "Item Deleted from List";

        }
    }
}
