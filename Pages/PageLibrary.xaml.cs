using LibraryApp_Exam_10.Entities;
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

namespace LibraryApp_Exam_10.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLibrary.xaml
    /// </summary>
    public partial class PageLibrary : Page
    {
        public PageLibrary()
        {
            InitializeComponent();
            DGridLibrary.ItemsSource = LibraryExam_10Entities1.GetContext().BookFond.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageAddEdit());
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            //     var booksForRemoving = DGridLibrary.SelectedItems.Cast().ToList();

            //     if (MessageBox.Show($"Удалить следующие: {booksForRemoving.Count()} элементов?",
            //"Warning", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            //     {
            //         try
            //         {
            //             LibraryExam_10Entities1.GetContext().BookFond.RemoveRange(booksForRemoving);
            //             LibraryExam_10Entities1.GetContext().SaveChanges();
            //             MessageBox.Show("Данные удалены!");

            //             DGridLibrary.ItemsSource = LibraryExam_10Entities1.GetContext().BookFond.ToList();
            //         }
            //         catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
