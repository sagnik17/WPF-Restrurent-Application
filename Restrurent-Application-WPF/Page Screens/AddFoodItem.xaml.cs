﻿using System;
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

namespace Restrurent_Application_WPF.Page_Screens
{
    /// <summary>
    /// Interaction logic for AddFoodItem.xaml
    /// </summary>
    public partial class AddFoodItem : Page
    {
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
    }
}
