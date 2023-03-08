using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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


namespace Railway
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source= LABSCIFIPC16\LOCALHOST; Initial Catalog = LogIn&SignUp; Integrated security=True");

            try

            {

                sqlCon.Open();  // I am opening the connection to the db 


                //Build our actual query 

                string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST; Initial Catalog=RailwaySystem_; Integrated Security=True";


                //Establish a sql command

                SqlCommand cmd = new SqlCommand(dbsCon, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

        }

        private void ToLogInPage (object sender, RoutedEventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            Close();
        }
    }
}
