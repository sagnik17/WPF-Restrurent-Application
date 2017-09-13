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
    /// Interaction logic for ShowTableList.xaml
    /// </summary>
    public partial class ShowTableList : Page
    {
        enum bookingstatus { Booked, Reserved, Available };
        RestrurentViewModel _rVM;
        public ShowTableList()
        {
            InitializeComponent();
            this.WindowHeight = 450;
            this.WindowWidth = 300;
            TableList obj = new TableList()
            {
                TableID = 1,
                BookingStatus = bookingstatus.Booked.ToString()
            };
            change_table_status(obj);
        }

        public void change_table_status(TableList obj)
        {
            _rVM = new RestrurentViewModel();
            List<TableList> tabledata = new List<TableList>();
            tabledata = _rVM.getTableList();
            label1.Background = tabledata[0].TableID == 1 && tabledata[0].BookingStatus == bookingstatus.Booked.ToString() ? Brushes.LightPink : Brushes.Green;
            label2.Background = tabledata[1].TableID == 2 && tabledata[1].BookingStatus == bookingstatus.Booked.ToString() ? Brushes.LightPink : Brushes.Green;
            label3.Background = tabledata[2].TableID == 3 && tabledata[2].BookingStatus == bookingstatus.Booked.ToString() ? Brushes.LightPink : Brushes.Green;
            label4.Background = tabledata[3].TableID == 4 && tabledata[3].BookingStatus == bookingstatus.Booked.ToString() ? Brushes.LightPink : Brushes.Green;
            label5.Background = tabledata[4].TableID == 5 && tabledata[4].BookingStatus == bookingstatus.Booked.ToString() ? Brushes.LightPink : Brushes.Green;
            label6.Background = tabledata[5].TableID == 6 && tabledata[5].BookingStatus == bookingstatus.Booked.ToString() ? Brushes.LightPink : Brushes.Green;
            label7.Background = tabledata[6].TableID == 7 && tabledata[6].BookingStatus == bookingstatus.Booked.ToString() ? Brushes.LightPink : Brushes.Green;
            label8.Background = tabledata[7].TableID == 8 && tabledata[7].BookingStatus == bookingstatus.Booked.ToString() ? Brushes.LightPink : Brushes.Green;
            label9.Background = tabledata[8].TableID == 9 && tabledata[8].BookingStatus == bookingstatus.Booked.ToString() ? Brushes.LightPink : Brushes.Green;


        }


    }
}
