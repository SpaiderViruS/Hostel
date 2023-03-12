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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        db_hostelContext DbContext;

        public RegistrationWindow()
        {
            InitializeComponent();

            DbContext = new db_hostelContext();
        }

        private void TryRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(PhoneTextBox.Text)
                && !string.IsNullOrEmpty(PasswordPasswodBox.Password))
            {
                Users checkPhone = DbContext.Users.Where(u =>
                  u.PhoneNumber == PhoneTextBox.Text).FirstOrDefault();

                if (checkPhone == null)
                {
                    Users newUser = new Users();
                    newUser.Surname = SurnameTextBox.Text;
                    newUser.Patronomyc = PatronomycTextBox.Text;
                    newUser.Name = NameTextBox.Text;
                    newUser.PhoneNumber = PhoneTextBox.Text;
                    newUser.Password = PasswordPasswodBox.Password;
                    newUser.IdRole = 2;

                    DbContext.Users.Add(newUser);
                    DbContext.SaveChanges();

                    MessageBox.Show("Вы успешно зарегистрировались", "Информация",
                        MessageBoxButton.OK, MessageBoxImage.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("Данный телефон уже зарегистрирован, попробуйте другой", "Информация",
                           MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void NameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = Char.IsDigit(e.Text, 0);
        }

        private void PhoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.Text, 0);
        }

        private void PhoneTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}
