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

namespace Restrurent_Application_WPF.Page_Screens
{
    /// <summary>
    /// Interaction logic for GenerateBill.xaml
    /// </summary>
    public partial class GenerateBill : Page
    {
        public GenerateBill()
        {
            InitializeComponent();
            DataContext = new OrderingViewModel();
        }
    }
}
