using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace wpf_DataBinding
{
    /// <summary>
    /// Interaction logic for DataWindow.xaml
    /// </summary>
    public partial class DataWindow : Window
    {
        private ObservableCollection<DataWindowPersonViewModel> people = new ObservableCollection<DataWindowPersonViewModel>();
        public DataWindow()
        {
            InitializeComponent();
            //gridPerson.ColumnDefinitions.Add(new ColumnDefinition());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var all = PersonRepository.People;
            all
                .Select(p => new DataWindowPersonViewModel { Person = p, ConvertedSalary = p.Salary.ToString() })
                .ToList<DataWindowPersonViewModel>()
                .ForEach(dvp => people.Add(dvp));

            comboPeople.ItemsSource = people;
            comboPeople.DisplayMemberPath = "Person.Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in people)
            {
                MessageBox.Show(item.Person.Name);
            }
        }

        private void btnIncrease_Click(object sender, RoutedEventArgs e)
        {
            //people.ForEach(p => p.Salary *= 2);
            //people.ForEach(p => MessageBox.Show(p.Salary.ToString()));
            try
            {
                foreach (var p in people)
                {
                    p.Person.Salary *= 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //foreach (var p in people)
            //{
            //    MessageBox.Show(p.Salary.ToString());
            //}
        }
    }
}
