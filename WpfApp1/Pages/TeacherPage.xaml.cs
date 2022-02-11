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
        public TeacherPage()
        {
            InitializeComponent();
            DgStudent.ItemsSource = DataHelper.entities.Progress.ToList();
            CbClass.SelectedValuePath = "ID";
            CbClass.DisplayMemberPath = "Number";
            CbClass.ItemsSource = DataHelper.entities.Class.ToList();
        }

        private void CbClass_DropDownClosed(object sender, EventArgs e)
        {
            DgStudent.ItemsSource = DataHelper.entities.Progress.Where(x => x.Student.Class.ID == (int)CbClass.SelectedValue).ToList();
        }

        private void BtnAll_Click(object sender, RoutedEventArgs e)
        {
            DgStudent.ItemsSource = DataHelper.entities.Progress.ToList();
        }
    }
}
