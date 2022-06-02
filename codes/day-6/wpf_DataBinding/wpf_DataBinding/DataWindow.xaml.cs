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

namespace wpf_DataBinding
{
    /// <summary>
    /// Interaction logic for DataWindow.xaml
    /// </summary>
    public partial class DataWindow : Window
    {
        private List<Person> people;
        public DataWindow()
        {
            InitializeComponent();
            //gridPerson.ColumnDefinitions.Add(new ColumnDefinition());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            people = PersonRepository.People;
            comboPeople.ItemsSource = people;
            comboPeople.DisplayMemberPath = "Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in people)
            {
                MessageBox.Show(item.Name);
            }
        }

        private void btnIncrease_Click(object sender, RoutedEventArgs e)
        {
            people.ForEach(p => p.Salary *= 2);
            people.ForEach(p => MessageBox.Show(p.Salary.ToString()));
        }
    }
}
