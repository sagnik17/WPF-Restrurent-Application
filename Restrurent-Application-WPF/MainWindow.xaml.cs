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

namespace Restrurent_Application_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //using (var context = new RestrurentDB()) { context.Database.Initialize(true); }
            InitializeComponent();
           
            this.DataContext = new RestrurentViewModel();
        }

        private void AddItems_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        public void pageload1(Page pageToLoad)
        {
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Content = pageToLoad;
        }

        public void pageload2(Page pageToLoad)
        {
            MainFrame1.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame1.Content = pageToLoad;
        }

        private void PlaceNewOrder_Click(object sender, RoutedEventArgs e)
        {
            ShowTableList showtablelist = new ShowTableList();
            pageload2(showtablelist);
        }


        public void Refresh()
        {
            AddFoodItem fooditemscreen = new AddFoodItem();
            ShowFoodItems showfooditems = new ShowFoodItems();
            pageload1(fooditemscreen);
            pageload2(showfooditems);
        }
    }
}
