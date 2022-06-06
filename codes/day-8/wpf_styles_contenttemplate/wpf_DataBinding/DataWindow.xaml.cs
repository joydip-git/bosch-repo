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
using wpf_DataBinding.Converters;

namespace wpf_DataBinding
{
    /// <summary>
    /// Interaction logic for DataWindow.xaml
    /// </summary>
    public partial class DataWindow : Window
    {
        private ObservableCollection<Person> people;
        public DataWindow()
        {
            InitializeComponent();
            //this.Resources.Add("salConveter", new SalaryConverter());
            Binding b = new Binding();
            //ValidationRule
            //b.ValidationRules.Add(new ExceptionValidationRule());
            //b.Converter = this.Resources["salConverter"] as SalaryConverter;
            //b.Converter = new SalaryConverter();

            

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
            try
            {
                foreach (var p in people)
                {
                    p.Salary *= 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridPerson_Error(object sender, ValidationErrorEventArgs e)
        {            
            if(e.Action== ValidationErrorEventAction.Added)
            {
                ValidationError error = e.Error;
                MessageBox.Show(error.ErrorContent.ToString());
            }
            e.Handled = true;
        }
    }
}
