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
    /// Interaction logic for PassengerDataTable.xaml
    /// </summary>
    public partial class PassengerDataTable : Window
    {
        public PassengerDataTable()
        {
            InitializeComponent();
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (psswrdbox.Password.Length < 10)
            {
                // giving an icon to the message box as well
                MessageBox.Show("Your password should be at least 10 symbols long.", "Save error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (usrnmbox.Text == "" || usrnmbox.IsHitTestVisible.Equals("Username"))
            {
                MessageBox.Show("The username field cannot be left empty.", "Save error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show($"Your username is: {usrnmbox.Text} and your password is: {psswrdbox.Password}", "Save info", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void ChangeToSignup(object sender, RoutedEventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Close();

        }
    }
    
    
}
