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
using Hostel.Windows;
using Hostel.Models;
using Hostel.UserControls;

namespace Hostel.Windows
{
    /// <summary>
    /// Логика взаимодействия для RoomsWindow.xaml
    /// </summary>
    public partial class RoomsWindow : Window
    {
        public static db_hostelContext DbContext;

        Users currentUser;
        public RoomsWindow(Users user)
        {
            InitializeComponent();
            DbContext = new db_hostelContext();
            currentUser = user;

            if (currentUser != null)
            {
                if (currentUser.IdRole == 2)
                {
                    GoToOrdersButton.Visibility = Visibility.Visible;
                }
            }

            LoadComboBoxes();
            UpdateListView();
        }

        private void LoadComboBoxes()
        {
            FilterListView.Items.Add("Все");
            FilterListView.Items.Add("До 1 - 2 человек");
            FilterListView.Items.Add("До 2 - 3 человек");
            FilterListView.Items.Add("От 5 и больше");

            SortingListView.Items.Add("Все");
            SortingListView.Items.Add("Наименование ↑");
            SortingListView.Items.Add("Наименование ↓");
            SortingListView.Items.Add("Стоимость ↑");
            SortingListView.Items.Add("Стоимость ↓");

            FilterListView.SelectedIndex = 0;
            SortingListView.SelectedIndex = 0;
        }

        private void UpdateListView()
        {
            RoomListView.Items.Clear();
            List<Rooms> rooms = new List<Rooms>();
            rooms = DbContext.Rooms.ToList();

            // Поиск
            if (!string.IsNullOrEmpty(SearchTextBox.Text.ToLower()))
            {
                rooms = rooms.Where(a =>
                a.Title.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList();
            }

            // Сортировка
            if (SortingListView.SelectedIndex != 1)
            {
                if (SortingListView.SelectedIndex == 1)
                {
                    rooms = rooms.OrderBy(a =>
                    a.Title).ToList();
                }
                else if (SortingListView.SelectedIndex == 2)
                {
                    rooms = rooms.OrderByDescending(a =>
                    a.Title).ToList();
                }
                else if (SortingListView.SelectedIndex == 3)
                {
                    rooms = rooms.OrderBy(a =>
                    a.Cost).ToList();
                }
                else if (SortingListView.SelectedIndex == 4)
                {
                    rooms = rooms.OrderByDescending(a =>
                    a.Cost).ToList();
                }
            }

            // Фильтрация
            if (FilterListView.SelectedIndex != 1)
            {
                if (FilterListView.SelectedIndex == 1)
                {
                    rooms = rooms.Where(r => r.Capacity < 3).ToList();
                }
                else if (FilterListView.SelectedIndex == 2)
                {
                    rooms = rooms.Where(r => r.Capacity > 3 && r.Capacity < 5).ToList();
                }
                else if (FilterListView.SelectedIndex == 3)
                {
                    rooms = rooms.Where(r => r.Capacity > 5).ToList();
                }
            }

            foreach (Rooms r in rooms)
            {
                RoomListView.Items.Add(new RoomUserControl(r)
                {
                    Width = GetOptimizedWidth()
                });
            }

            if (RoomListView.Items.Count <= 0)
            {
                NoItemslabel.Visibility = Visibility.Visible;
            }
            else
            {
                NoItemslabel.Visibility = Visibility.Collapsed;
            }
        }

        private double GetOptimizedWidth()
        {
            if (WindowState == WindowState.Maximized)
            {
                return (RenderSize.Width - 55) / 1.15;
            }
            else
            {
                return (Width - 55) / 1.15;
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateListView();
        }

        private void GoToOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            UserOrdersWindow userOrdersWindow = new UserOrdersWindow(currentUser);
            userOrdersWindow.ShowDialog();
        }

        private void SortingListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateListView();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateListView();
        }

        private void RoomListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (RoomListView.SelectedItem != null)
            {
                Rooms room = ((RoomUserControl)RoomListView.SelectedItem).Room;

                if (currentUser != null)
                {
                    if (currentUser.IdRole == 2)
                    {
                        if (room.IdStatusNavigation.IdStatus == 2)
                        {
                            if (MessageBox.Show("Вы действительно хотите забронировать этот номер?", "Вопрос",
                                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                            {
                                ConfirmationReservingWindow confirmationReservingWindow = new ConfirmationReservingWindow(currentUser, room);
                                confirmationReservingWindow.ShowDialog();

                                UpdateListView();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Данный номер уже забронирован, приносим извинения", "Информация",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else if (currentUser.IdRole != 1)
                    {
                        MessageBox.Show("Для бронирования номер необходимо зарегистрироваться", "Информация",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Для бронирования номер необходимо зарегистрироваться", "Информация",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
