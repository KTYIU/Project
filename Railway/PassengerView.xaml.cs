using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Railway
{
    /// <summary>
    /// Interaction logic for PassengerView.xaml
    /// </summary>
    public partial class PassengerView : Window
    {
        string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST; Initial Catalog=RailwaySystem_; Integrated Security=True";

        public PassengerView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void accountActionsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
