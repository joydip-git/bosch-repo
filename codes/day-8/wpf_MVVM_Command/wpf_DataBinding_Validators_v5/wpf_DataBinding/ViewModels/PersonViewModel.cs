using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using wpf_DataBinding.Commands;
using wpf_DataBinding.Models;
using wpf_DataBinding.Repository;

namespace wpf_DataBinding.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; private set; }
        public PersonLoadCommand PersonLoadCommand { get; private set; }

        public PersonViewModel()
        {
            People = new ObservableCollection<Person>();
            PersonLoadCommand = new PersonLoadCommand(this.LoadData, this.CanLoad);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("People"));
        }

        public void LoadData(object parameter)
        {
            try
            {
                var all = PersonRepository.People;
                all.ForEach(p => People.Add(p));
                OnPropertyChanged("People");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public bool CanLoad(object parameter)
        {
            return true;
        }
    }
}
