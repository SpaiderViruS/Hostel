using Hostel.Models;
using Hostel.Windows;
using System.Linq;
using System.Windows;

namespace Hostel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static db_hostelContext DbContext;

        public MainWindow()
        {
            InitializeComponent();
            DbContext = new db_hostelContext();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(LoginTextBox.Text)
              && !string.IsNullOrEmpty(PasswordPasswordBox.Password))
            {
                Users user = DbContext.Users.Where(u => u.PhoneNumber == LoginTextBox.Text.Trim()
                && u.Password == PasswordPasswordBox.Password).FirstOrDefault();

                if (user != null)
                {
                    if (user.IdRole != 1)
                    {
                        MessageBox.Show($"Вы успешно авторизовались, как {user.Name} {user.Surname} {user.Patronomyc}", "Информация",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                        RoomsWindow roomsWindow = new RoomsWindow(user);
                        roomsWindow.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show($"Вы успешно авторизовались, как {user.Name} {user.Surname} {user.Patronomyc}", "Информация",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                        AdministrationWindow administratorWindow = new AdministrationWindow(user);
                        administratorWindow.Show();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин/пароль", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните поля", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void EnterAsGuest_Click(object sender, RoutedEventArgs e)
        {
            RoomsWindow roomsWindow = new RoomsWindow(null);
            roomsWindow.Show();
            Close();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.ShowDialog();
        }

        private void ShowPasswordCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (ShowPasswordCheckBox.IsChecked == false)
            {
                CheckPasswordTextBox.Text = PasswordPasswordBox.Password;

                CheckPasswordTextBox.Visibility = Visibility.Visible;
                PasswordPasswordBox.Visibility = Visibility.Hidden;
            }
        }

        private void ShowPasswordCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (ShowPasswordCheckBox.IsChecked == true)
            {
                PasswordPasswordBox.Password = CheckPasswordTextBox.Text;

                CheckPasswordTextBox.Visibility = Visibility.Hidden;
                PasswordPasswordBox.Visibility = Visibility.Visible;
            }
        }
    }
}
