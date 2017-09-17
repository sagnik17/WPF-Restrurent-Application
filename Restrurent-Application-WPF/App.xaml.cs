using Restrurent_Application_WPF.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Restrurent_Application_WPF.ViewModel;

namespace Restrurent_Application_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            using (var context = new RestrurentDB()) { context.Database.Initialize(true); }
        }
         
    }
}
