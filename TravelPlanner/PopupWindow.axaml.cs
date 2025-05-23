using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TravelPlanner;

public partial class PopupWindow : Window
{
    public PopupWindow(string name, string country, List<string> attractions, string transport,
        ObservableCollection<string> cities)
    {
        InitializeComponent();

        NameTextBlock.Text = name;
        CountryTextBlock.Text = country;
        AttractionsListBox.ItemsSource = attractions;
        TransportTextBlock.Text = transport;
        CitiesListBox.ItemsSource = cities;
        
    }
    
    private void OnCloseClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}