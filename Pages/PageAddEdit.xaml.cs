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
    /// Логика взаимодействия для PageAddEdit.xaml
    /// </summary>
    public partial class PageAddEdit : Page
    {
        private LibraryExam_10Entities1 _library = new LibraryExam_10Entities1();
        public PageAddEdit()
        {
            InitializeComponent();
           // DataContext = _library;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
           /* if (_library.id == 0) LibraryExam_10Entities1.GetContext().BookFond.Add(_library);
            try { 
                LibraryExam_10Entities1.GetContext().SaveChanges(); MessageBox.Show("Save"); 
            }
            catch (Exception ex) { } */
        }

    }
}
