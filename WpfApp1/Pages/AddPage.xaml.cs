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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            CbFIO.SelectedValuePath = "ID";
            CbFIO.DisplayMemberPath = "NameStudent";
            CbFIO.ItemsSource = DataHelper.entities.Student.ToList();

            //CbClass.SelectedValuePath = "ID";
            //CbClass.DisplayMemberPath = "Number";
            //CbClass.ItemsSource = DataHelper.entities.Class.ToList();

            CbItem.SelectedValuePath = "ID";
            CbItem.DisplayMemberPath = "Name";
            CbItem.ItemsSource = DataHelper.entities.Item.ToList();

            CbMark.SelectedValuePath = "ID";
            CbMark.DisplayMemberPath = "Name";
            CbMark.ItemsSource = DataHelper.entities.Mark.ToList();
        }


        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Progress progress = new Progress()
            {
                IdItem = (int)CbItem.SelectedValue,
                IdMark = (int)CbMark.SelectedValue,
                IdStudent = (int)CbFIO.SelectedValue,
            };
            DataHelper.entities.Progress.Add(progress);
            DataHelper.entities.SaveChanges();
            MessageBox.Show("Оценка успешно добавлена");
        }
    }
}
