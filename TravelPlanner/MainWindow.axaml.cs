using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Remote.Protocol;

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
        string name = TextBox.Text;
        
        string country = (ComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Brak";
        
        var attractions = new List<string>();
        if (CheckBox.IsChecked == true) attractions.Add("Muzea");
        if (CheckBox2.IsChecked == true) attractions.Add("Parki Narodowe");
        if (CheckBox3.IsChecked == true) attractions.Add("Zabytki");
        if (CheckBox4.IsChecked == true) attractions.Add("Restauracje");
        if (CheckBox5.IsChecked == true) attractions.Add("Galerie sztuki");
        if (CheckBox6.IsChecked == true) attractions.Add("Festiwale i koncerty");
        
        string transport;
        if (Airplane.IsChecked == true)
            transport = "Samolot";
        else if (Car.IsChecked == true)
            transport = "Samochód";
        else if (Train.IsChecked == true)
            transport = "Pociąg";
        else if (Ship.IsChecked == true)
            transport = "Statek";
        else
            transport = "Brak";
        
        var popup = new PopupWindow(name, country, attractions, transport, _cities);
        popup.Show();
    }
}