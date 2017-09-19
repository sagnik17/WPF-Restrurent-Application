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
using Restrurent_Application_WPF.Page_Screens;
using System.Windows.Controls.Primitives;

namespace Restrurent_Application_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  
        }

        private void AddItems_Click(object sender, RoutedEventArgs e)
        {
            AddFoodItem fooditemscreen = new AddFoodItem();
            pageload1(fooditemscreen);
           
        }

        public void pageload1(Page pageToLoad)
        {
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Content = pageToLoad;
        }

        private void PlaceNewOrder_Click(object sender, RoutedEventArgs e)
        {
            PlaceNewOrder showtablelist = new PlaceNewOrder();
            pageload1(showtablelist);
        }

        private void UpdateOrder_Click(object sender, RoutedEventArgs e)
        {
            UpdateOrders updateorderpage = new UpdateOrders();
            pageload1(updateorderpage);
        }

        private void GenerateBill_Click(object sender, RoutedEventArgs e)
        {
            GenerateBill obj = new GenerateBill();
            pageload1(obj);
        }
    }
}
