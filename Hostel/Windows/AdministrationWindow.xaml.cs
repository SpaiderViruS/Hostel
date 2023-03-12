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
using System.Windows.Shapes;
using Hostel.Models;

namespace Hostel.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdministrationWindow.xaml
    /// </summary>
    public partial class AdministrationWindow : Window
    {
        Users User;
        public AdministrationWindow(Users user)
        {
            InitializeComponent();
            User = user;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.ShowDialog();
        }

        private void CheckReservationsButton_Click(object sender, RoutedEventArgs e)
        {
            UserOrdersWindow userOrdersWindow = new UserOrdersWindow(User);
            userOrdersWindow.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }
    }
}
