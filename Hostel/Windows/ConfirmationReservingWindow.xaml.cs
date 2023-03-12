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
    /// Логика взаимодействия для ConfirmationReservingWindow.xaml
    /// </summary>
    public partial class ConfirmationReservingWindow : Window
    {
        db_hostelContext DbContext;
        Users User;
        Rooms Room;

        DateTime SettlementDate;
        DateTime ReleaseDate;

        public ConfirmationReservingWindow(Users user, Rooms room)
        {
            InitializeComponent();
            User = user;
            Room = room;
            DbContext = RoomsWindow.DbContext;

            SettlementDatePicker.DisplayDateStart = DateTime.Now;
            ReleaseDatePicker.DisplayDateStart = DateTime.Now;

            LoadBaseInfos();
        }

        private void LoadBaseInfos()
        {
            SNPUserLabel.Content = $"{User.Surname} {User.Name} {User.Patronomyc}";
            RoomLabel.Content = $"{Room.Title} Комфортность: {Room.Comfort}";
        }

        private void SettlementDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            SettlementDate = Convert.ToDateTime(SettlementDatePicker.SelectedDate);
        }

        private void ReleaseDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ReleaseDate = Convert.ToDateTime(ReleaseDatePicker.SelectedDate);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ConfirmOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (SettlementDate != null && ReleaseDate != null)
            {
                if (SettlementDate < ReleaseDate)
                {
                    Reservations newReserve = new Reservations();
                    newReserve.IdUser = User.IdUser;
                    newReserve.IdStatusReservation = 4;
                    newReserve.IdRoom = Room.IdRoom;
                    newReserve.SettlementDate = Convert.ToDateTime(SettlementDate.ToShortDateString());
                    newReserve.ReleaseDate = Convert.ToDateTime(ReleaseDate.ToShortDateString());

                    Room.IdStatus = 4;

                    DbContext.Reservations.Add(newReserve);
                    DbContext.SaveChanges();

                    MessageBox.Show("Заявка создана, вы можете остледить её в заказах", "Информация",
                        MessageBoxButton.OK, MessageBoxImage.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("Выберите корректную дату", "Информация",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
