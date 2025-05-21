using System.Collections.ObjectModel;
using Avalonia.Controls;

namespace TravelPlanner;

public partial class MainWindow : Window
{
    private ObservableCollection<string> _cities = new();

    public MainWindow()
    {
        InitializeComponent();

        CityListBox.ItemsSource = _cities; 
        AddCityButton.Click += AddCityButton_Click;
        SubmitButton.Click += SubmitButton_Click;
    }

    private void AddCityButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var city = CityTextBox.Text?.Trim();
        if (!string.IsNullOrWhiteSpace(city))
        {
            _cities.Add(city);
            CityTextBox.Text = "";
        }
    }

    private void SubmitButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        
    }
}