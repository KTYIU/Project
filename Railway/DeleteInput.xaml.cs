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
using System.Data.SqlClient;
using System.Data;

namespace Railway
{
    /// <summary>
    /// Interaction logic for DeleteInput.xaml
    /// </summary>
    public partial class DeleteInput : Window
    {
        public DeleteInput()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST; Initial Catalog=RailwaySystem_; Integrated Security=True";

            try
            {
                SqlConnection sqlCon = new SqlConnection(dbsCon);
                string query = $"delete from PassengerSchedule where [Username]={usrnm.Text} and TrainName={trainName.Text}";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable("SignUpTable");

                MessageBox.Show("Deletion successful!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
