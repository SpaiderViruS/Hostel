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
    /// Логика взаимодействия для RoomUserControl.xaml
    /// </summary>
    public partial class RoomUserControl : UserControl
    {
        public Rooms Room { get; set; }

        public RoomUserControl(Rooms room)
        {
            InitializeComponent();

            Room = room;

            LoadLabels();
            LoadImage();
        }

        private void LoadLabels()
        {
            TitleLabel.Content = $"Наименование: {Room.Title}";
            CostLabel.Content = $"Стоимость: {Room.Cost} ₽";
            ComfortLabel.Content = $"Комфорт: {Room.Comfort}";

            StatusLabel.Content = Room.IdStatusNavigation.StatusName;
            if (Room.IdStatusNavigation.IdStatus != 2)
            {
                StatusLabel.Foreground = Brushes.Red;
            }
            else
            {
                StatusLabel.Foreground = Brushes.Green;
            }
        }

        private void LoadImage()
        {
            if (Room.Image != null && Room.Image.Length > 0)
            {
                Uri resUri = new Uri(Environment.CurrentDirectory + Room.Image);
                RoomImage.Source = new BitmapImage(resUri);
            }
            else
            {
                RoomImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/picture.png"));
            }
        }
    }
}
