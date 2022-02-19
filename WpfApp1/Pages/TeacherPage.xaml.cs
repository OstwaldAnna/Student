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
using WpfApp1.Bd;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Interaction logic for TeacherPage.xaml
    /// </summary>
    public partial class TeacherPage : Page
    {
        public TeacherPage() {
            InitializeComponent();
            DgStudent.ItemsSource = DataHelper.entities.Progress.ToList();
            CbClass.SelectedValuePath = "ID";
            CbClass.DisplayMemberPath = "Number";
            CbClass.ItemsSource = DataHelper.entities.Class.ToList();
        }

        private void CbClass_DropDownClosed(object sender, EventArgs e) 
            {
            //Сортировка по класам
            DgStudent.ItemsSource = DataHelper.entities.Progress.Where(x => x.Student.Class.ID == (int)CbClass.SelectedValue).ToList();
            }

        private void BtnAll_Click(object sender, RoutedEventArgs e) 
            {
            //Вывод всего DataGrid
            DgStudent.ItemsSource = DataHelper.entities.Progress.ToList();
            }

        private void BtnDelete_Click(object sender, RoutedEventArgs e) 
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить оценку?", "Подтверждение", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
			switch (result)
			{
                case MessageBoxResult.Yes:
                    break;
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Cancel:
                    break;
				default:
                    break;
			}
		}
    }
}