using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            this.Close();
        }

        private void Load_DataGrid(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(dbsCon);


            try
            {

                sqlCon.Open();
                String query = "  ";
                SqlCommand sqlCmd = new SqlCommand(,);
                sqlCmd.ExecuteNonQuery();
                SqlDataAdapter word = new SqlDataAdapter();
                DataTable dt = new DataTable(" ");
                word.Fill(dt);
                DG.ItemsSource = dt.DefaultView;
                word.Update(dt);
                MessageBox.Show("Success");
                sqlCon.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}