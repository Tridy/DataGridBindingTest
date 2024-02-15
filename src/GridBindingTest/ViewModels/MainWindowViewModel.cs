using System.Collections.ObjectModel;
using GridBindingTest.Models;
using ReactiveUI;

namespace GridBindingTest.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<Person> _people;

    public ObservableCollection<Person> People
    {
        get => _people;
        set => this.RaiseAndSetIfChanged(ref _people, value);
    }

    public MainWindowViewModel()
    {
        Person[] data = DataSource.GetData();
        People = new ObservableCollection<Person>(data);
    }
}