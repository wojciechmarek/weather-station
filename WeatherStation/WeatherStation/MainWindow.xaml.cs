using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WeatherStation
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void navButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            switch (button.Name)
            {
                case "navButton_today":
                    Today_Grid.Visibility = Visibility.Visible;
                    Forecast_Grid.Visibility = Visibility.Hidden;
                    Settings_Grid.Visibility = Visibility.Hidden;
                    Author_Grid.Visibility = Visibility.Hidden;
                    titleLabel.Content = "Dzisiaj";
                break;

                case "navButton_forecast":
                    Today_Grid.Visibility = Visibility.Hidden;
                    Forecast_Grid.Visibility = Visibility.Visible;
                    Settings_Grid.Visibility = Visibility.Hidden;
                    Author_Grid.Visibility = Visibility.Hidden;
                    titleLabel.Content = "Prognoza";

                    break;

                case "navButton_settings":
                    Today_Grid.Visibility = Visibility.Hidden;
                    Forecast_Grid.Visibility = Visibility.Hidden;
                    Settings_Grid.Visibility = Visibility.Visible;
                    Author_Grid.Visibility = Visibility.Hidden;
                    titleLabel.Content = "Ustawienia";

                    break;

                case "navButton_author":
                    Today_Grid.Visibility = Visibility.Hidden;
                    Forecast_Grid.Visibility = Visibility.Hidden;
                    Settings_Grid.Visibility = Visibility.Hidden;
                    Author_Grid.Visibility = Visibility.Visible;
                    titleLabel.Content = "Autor";

                    break;


                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
