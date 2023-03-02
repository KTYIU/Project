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
    /// Interaction logic for ViewData.xaml
    /// </summary>
    public partial class ViewData : Window
    {
        public ViewData()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            

        }
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST; Initial Catalog=RailwaySystem_; Integrated Security=True";

            /*try
            {
                SqlConnection sqlCon = new SqlConnection(dbsCon);
                string query = "SELECT * FROM Schedule";                //have to create schedule table combining needed data
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable("SignUpTable");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
