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
using Hostel.UserControls;
using Word = Microsoft.Office.Interop.Word;

namespace Hostel.Windows
{
    /// <summary>
    /// Логика взаимодействия для UserOrdersWindow.xaml
    /// </summary>
    public partial class UserOrdersWindow : Window
    {
        db_hostelContext DbContext;
        Users User;
        public UserOrdersWindow(Users user)
        {
            InitializeComponent();
            User = user;

            DbContext = db_hostelContext.DbContext;

            if (User.IdRole == 1)
            {
                LoadAdminListView();
            }
            else
            {
                LoadListView();
            }
        }

        private void LoadAdminListView()
        {
            OrdersListView.Items.Clear();
            List<Reservations> reserv = new List<Reservations>();
            reserv = DbContext.Reservations.Where(r => r.IdStatusReservation == 4).ToList();

            foreach (Reservations reservation in reserv)
            {
                OrdersListView.Items.Add(new UserOrderUserControl(reservation)
                {
                    Width = GetOptimizedWidth()
                });
            }
        }

        private void LoadListView()
        {
            OrdersListView.Items.Clear();
            List<Reservations> reserv = new List<Reservations>();
            reserv = db_hostelContext.DbContext.Reservations.Where(r => r.IdUser == User.IdUser).ToList();

            foreach (Reservations reservation in reserv)
            {
                OrdersListView.Items.Add(new UserOrderUserControl(reservation)
                {
                    Width = GetOptimizedWidth()
                });
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

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OrdersListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (OrdersListView.SelectedItem != null)
            {
                Reservations reservations = ((UserOrderUserControl)OrdersListView.SelectedItem).Reservations;
                if (User.IdRole == 1)
                {
                    if (MessageBox.Show("Подтвердить бронирование?", "Вопрос",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        reservations.IdStatusReservation = 1;

                        DbContext.SaveChanges();

                        if (MessageBox.Show("Сформировать чек о заселении?", "Вопрос",
                            MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CreateTicket(reservations);
                        }

                        LoadAdminListView();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (reservations.IdStatusReservation == 1)
                    {
                        if (MessageBox.Show("Сформировать чек о заселении?", "Вопрос",
                            MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CreateTicket(reservations);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

        private void CreateTicket(Reservations res)
        {
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = true;
            Object template = Type.Missing;
            Object newTemplate = false;
            Object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            Object visible = true;
            object missing = Type.Missing;
            Word._Document wordDoc = wordApp.Documents.Add(
                ref missing, ref missing, ref missing, ref missing);
            object start = 0, end = 0;

            Word.Range range = wordDoc.Range(ref start, ref end);
            range.Text = $"Квитанция о проживании № 1\n".ToUpper();

            range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            range.ParagraphFormat.SpaceAfter = 0;
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;

            start = wordDoc.Range().End - 1; end = wordDoc.Range().End - 1;
            range = wordDoc.Range(ref start, ref end);

            range.Text = $"\nНомер: {res.IdRoomNavigation.Title}\n";

            range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            range.ParagraphFormat.SpaceAfter = 0;
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;

            start = wordDoc.Range().End - 1; end = wordDoc.Range().End - 1;
            range = wordDoc.Range(ref start, ref end);

            range.Text = $"Дата квитацнии: {DateTime.Now.ToShortDateString()}\n";

            range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            range.ParagraphFormat.SpaceAfter = 0;
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;

            start = wordDoc.Range().End - 1; end = wordDoc.Range().End - 1;
            range = wordDoc.Range(ref start, ref end);

            range.Text = $"Дата заселения: {res.SettlementDate}\n";

            range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            range.ParagraphFormat.SpaceAfter = 0;
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;

            start = wordDoc.Range().End - 1; end = wordDoc.Range().End - 1;
            range = wordDoc.Range(ref start, ref end);

            range.Text = $"Дата освобождения: {res.ReleaseDate}\n";

            range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            range.ParagraphFormat.SpaceAfter = 0;
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;

            start = wordDoc.Range().End - 1; end = wordDoc.Range().End - 1;
            range = wordDoc.Range(ref start, ref end);

            DateTime setDate = Convert.ToDateTime(res.SettlementDate);
            DateTime releaseDate = Convert.ToDateTime(res.ReleaseDate);
            range.Text = $"Кол - во дней: {(releaseDate - setDate).TotalDays}\n";

            range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            range.ParagraphFormat.SpaceAfter = 0;
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;

            start = wordDoc.Range().End - 1; end = wordDoc.Range().End - 1;
            range = wordDoc.Range(ref start, ref end);

            range.Text = $"Стоимость: {res.IdRoomNavigation.Cost}\n";

            range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            range.ParagraphFormat.SpaceAfter = 0;
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;
        }
    }
}
