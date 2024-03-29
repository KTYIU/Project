﻿using System;
using System.Collections.Generic;
using System.Data;
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

namespace Railway
{
    /// <summary>
    /// Interaction logic for PassengerDataTable.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST; Initial Catalog=RailwaySystem_; Integrated Security=True";
            try
            {
                SqlConnection sqlCon = new SqlConnection(dbsCon);
                string query = $"select [Username], [Password] from {account.Items} where [Username]={usrnmbox.Text} and [Password]={psswrdbox.Password}";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable("SignUpTable");

                MessageBox.Show($"Your username is: {usrnmbox.Text} and your password is: {psswrdbox.Password}", "Save info", MessageBoxButton.OK, MessageBoxImage.Information);
                ViewData vd = new ViewData();
                vd.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
