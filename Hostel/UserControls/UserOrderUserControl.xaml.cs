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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hostel.Models;

namespace Hostel.UserControls
{
    /// <summary>
    /// Логика взаимодействия для UserOrderUserControl.xaml
    /// </summary>
    public partial class UserOrderUserControl : UserControl
    {
        public Reservations Reservations { get; set; }
        public UserOrderUserControl(Reservations reservations)
        {
            InitializeComponent();
            Reservations = reservations;

            LoadLabels();
            LoadImage();
        }

        private void LoadLabels()
        {
            TitleLabel.Content = $"Номер: {Reservations.IdRoomNavigation.Title}";
            StatusLabel.Content = $"Статус: {Reservations.IdStatusReservationNavigation.StatusName}";
            CostLabel.Content = $"Стоимость: {Reservations.IdRoomNavigation.Cost} ₽";
        }

        private void LoadImage()
        {
            if (Reservations.IdRoomNavigation.Image != null 
                && Reservations.IdRoomNavigation.Image.Length > 0)
            {
                Uri resUri = new Uri(Environment.CurrentDirectory + Reservations.IdRoomNavigation.Image);
                ImageRoom.Source = new BitmapImage(resUri);
            }
            else
            {
                ImageRoom.Source = new BitmapImage(new Uri("pack://application:,,,/Images/picture.png"));
            }
        }
    }
}
