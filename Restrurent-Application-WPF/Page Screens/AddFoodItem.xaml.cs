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
using Restrurent_Application_WPF.DB_Layer;
using Restrurent_Application_WPF.Model;
using Restrurent_Application_WPF.ViewModel;

namespace Restrurent_Application_WPF.Page_Screens
{
    /// <summary>
    /// Interaction logic for AddFoodItem.xaml
    /// </summary>
    public partial class AddFoodItem : Page
    {
        private RestrurentViewModel _rVmObj;
        public AddFoodItem()
        {
            InitializeComponent();
            this.WindowHeight = 450;
            this.WindowWidth = 600;
            DataContext = new RestrurentViewModel();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            foodnametxt.Clear();
            Descriptiontxt.Clear();
            pricetxt.Clear();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (foodnametxt.Text == "" || Descriptiontxt.Text == "" || pricetxt.Text == "")
                {
                    status.Foreground = Brushes.Red;
                    status.Content = "All Fields are compulsory";
                }
                else
                {
                    _rVmObj = new RestrurentViewModel();
                    FoodItems fooditem = new FoodItems();
                    fooditem.FoodName = foodnametxt.Text;
                    fooditem.Description = Descriptiontxt.Text;
                    fooditem.fPrice = Convert.ToInt32(pricetxt.Text.ToString());
                    _rVmObj.AddFoodItem(fooditem);
                    DataContext = new RestrurentViewModel();
                    status.Foreground = Brushes.Green;
                    status.Content = "Item Added Successfully";
                }
            }
            catch(Exception exp)
            {
                status.Foreground = Brushes.Red;
                status.Content = "Please enter correct data";
            }
            
        }

    }
}
