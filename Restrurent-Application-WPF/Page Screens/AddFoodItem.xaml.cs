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
using Restrurent_Application_WPF.Page_Screens;

namespace Restrurent_Application_WPF.Page_Screens
{
    /// <summary>
    /// Interaction logic for AddFoodItem.xaml
    /// </summary>
    public partial class AddFoodItem : Page
    {
        DataAccessLayer _dbLayer;
        public AddFoodItem()
        {
            InitializeComponent();
            this.WindowHeight = 450;
            this.WindowWidth = 600;
           
            
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            foodnametxt.Clear();
            Descriptiontxt.Clear();
            pricetxt.Clear();

        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            FoodItems newFoodItem = new FoodItems();

            newFoodItem.FoodName = foodnametxt.Text.ToString();
            newFoodItem.Description = Descriptiontxt.Text.ToString();
            newFoodItem.Price = Convert.ToInt32(pricetxt.Text.ToString());
            
            _dbLayer = new DataAccessLayer();
            
            int foodid = _dbLayer.InsertNewFoodItem(newFoodItem);

            if(foodid > 0)
            {
                ShowFoodItems showfooditems = new ShowFoodItems();
               
                
                MainWindow main = new MainWindow();
              
                main.MainFrame1.UpdateLayout();
                main.pageload2(showfooditems);
                status.Content = "Food Item Added Successfully";
            }
        }
    }
}
