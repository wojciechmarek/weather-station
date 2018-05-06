using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using WeatherStation.Model.Mappings;
using WeatherStation.Model.Services;


namespace WeatherStation.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private const string DEFAULT_CITY = "Rzeszow";

        #region Objects Declarations for Grids

        //title bar
        public RelayCommand CloseApplicationButton { get; set; }
        //public RelayCommand WindowMoving { get; set; }

        private string titleLabel = "Szkolenie techniczne 1";
        public string TitleLabel
        {
            get { return titleLabel; }
            set
            {
                Set(ref titleLabel, value);
            }
        }


        //navigation bar
        public RelayCommand<object> NavigationButtons { get; set; }

        //grid visibility
        private bool todayGridVisibility = true;
        public bool TodayGridVisibility
        {
            get { return todayGridVisibility; }
            set
            {
                Set(ref todayGridVisibility, value);
            }
        }

        private bool forecastGridVisibility = false;
        public bool ForecastGridVisibility
        {
            get { return forecastGridVisibility; }
            set
            {
                Set(ref forecastGridVisibility, value);
            }
        }

        private bool settingstGridVisibility = false;
        public bool SettingsGridVisibility
        {
            get { return settingstGridVisibility; }
            set
            {
                Set(ref settingstGridVisibility, value);
            }
        }

        private bool authorGridVisibility = false;
        public bool AuthorGridVisibility
        {
            get { return authorGridVisibility; }
            set
            {
                Set(ref authorGridVisibility, value);
            }
        }




        //today grid

        private string cityName = DEFAULT_CITY;    //common for today and forecast
        public string CityName
        {
            get { return cityName; }
            set
            {
                Set(ref cityName, value);
            }
        }

        private int todayTemperature = 12;
        public int TodayTemperature
        {
            get { return todayTemperature; }
            set
            {
                Set(ref todayTemperature, value);
            }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set
            {
                Set(ref date, value);
            }
        }

        private int temperatureMax;
        public int TemperatureMax
        {
            get { return temperatureMax; }
            set
            {
                Set(ref temperatureMax, value);
            }
        }

        private int temperatureMin;
        public int TemperatureMin
        {
            get { return temperatureMin; }
            set
            {
                Set(ref temperatureMin, value);
            }
        }

        private int todayPressure;
        public int TodayPressure
        {
            get { return todayPressure; }
            set
            {
                Set(ref todayPressure, value);
            }
        }

        private int todayHumidity;
        public int TodayHumidity
        {
            get { return todayHumidity; }
            set
            {
                Set(ref todayHumidity, value);
            }
        }

        private string todaySunrise;
        public string TodaySunrise
        {
            get { return todaySunrise; }
            set
            {
                Set(ref todaySunrise, value);
            }
        }

        private string todaySunset;
        public string TodaySunset
        {
            get { return todaySunset; }
            set
            {
                Set(ref todaySunset, value);
            }
        }

        private BitmapImage todayImage = new BitmapImage(new Uri($@"http://openweathermap.org/img/w/09d.png"));
        public BitmapImage TodayImage
        {
            get { return todayImage; }
            set
            {
                Set(ref todayImage, value);
            }
        }


        //todo : image icon


        //forecast grid


        private string nextDay1 = DateTime.Now.AddDays(1).DayOfWeek.ToString();
        public string NextDay1
        {
            get { return nextDay1; }
            set
            {
                Set(ref nextDay1, value);
            }
        }

        private string nextDay2 = DateTime.Now.AddDays(2).DayOfWeek.ToString();
        public string NextDay2
        {
            get { return nextDay2; }
            set
            {
                Set(ref nextDay2, value);
            }
        }

        private string nextDay3 = DateTime.Now.AddDays(3).DayOfWeek.ToString();
        public string NextDay3
        {
            get { return nextDay3; }
            set
            {
                Set(ref nextDay3, value);
            }
        }

        private int nextDay1temp;
        public int NextDay1temp
        {
            get { return nextDay1temp; }
            set
            {
                Set(ref nextDay1temp, value);
            }
        }

        private int nextDay2temp;
        public int NextDay2temp
        {
            get { return nextDay2temp; }
            set
            {
                Set(ref nextDay2temp, value);
            }
        }

        private int nextDay3temp;
        public int NextDay3temp
        {
            get { return nextDay3temp; }
            set
            {
                Set(ref nextDay3temp, value);
            }
        }

        private int nextDay1pressure;
        public int NextDay1pressure
        {
            get { return nextDay1pressure; }
            set
            {
                Set(ref nextDay1pressure, value);
            }
        }

        private int nextDay2pressure;
        public int NextDay2pressure
        {
            get { return nextDay2pressure; }
            set
            {
                Set(ref nextDay2pressure, value);
            }
        }

        private int nextDay3pressure;
        public int NextDay3pressure
        {
            get { return nextDay3pressure; }
            set
            {
                Set(ref nextDay3pressure, value);
            }
        }

        private int nextDay1himidity;
        public int NextDay1himidity
        {
            get { return nextDay1himidity; }
            set
            {
                Set(ref nextDay1himidity, value);
            }
        }

        private int nextDay2himidity;
        public int NextDay2himidity
        {
            get { return nextDay2himidity; }
            set
            {
                Set(ref nextDay2himidity, value);
            }
        }

        private int nextDay3himidity;
        public int NextDay3himidity
        {
            get { return nextDay3himidity; }
            set
            {
                Set(ref nextDay3himidity, value);
            }
        }

        private BitmapImage nextDay1image = new BitmapImage(new Uri($@"http://openweathermap.org/img/w/09d.png"));
        public BitmapImage NextDay1image
        {
            get { return nextDay1image; }
            set
            {
                Set(ref nextDay1image, value);
            }
        }

        private BitmapImage nextDay2image = new BitmapImage(new Uri($@"http://openweathermap.org/img/w/09d.png"));
        public BitmapImage NextDay2image
        {
            get { return nextDay2image; }
            set
            {
                Set(ref nextDay2image, value);
            }
        }

        private BitmapImage nextDay3image = new BitmapImage(new Uri($@"http://openweathermap.org/img/w/09d.png"));
        public BitmapImage NextDay3image
        {
            get { return nextDay3image; }
            set
            {
                Set(ref nextDay3image, value);
            }
        }



        //settings


        public RelayCommand SearchLocationButton { get; set; }

        private string cityNotFound = string.Empty;
        public string CityNotFound
        {
            get { return cityNotFound; }
            set
            {
                Set(ref cityNotFound, value);

            }
        }

        public string CityNameToSearch { get; set; }



        #endregion


        //Today today;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            InitializeEvents();
            

            //services = new Services();
            //today = services.GetTodayWeather("kolbuszowa");
            //forecast = services.GetForecast("kolbuszowa");

           // var x = services.GetTodayWeather("kolbuszowa");

            //.WriteLine(forecast.cod);

            //Forecast forecast = services.GetForecast("Kolbuszowa");
            //var today = services.GetTodayWeather("kolbuszowa");
            //var x = today.Name;
            //var x = today.cod;

            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        

        private void CloseApp()
        {
            Environment.Exit(0);
        }

        private void CitySearch()
        {
            MessageBox.Show(CityNameToSearch);
        }

        

        private void InitializeEvents()
        {
            SearchLocationButton = new RelayCommand(CitySearch);
            CloseApplicationButton = new RelayCommand(CloseApp);

            NavigationButtons = new RelayCommand<object>(ChangeGrid);

        }

        private void ChangeGrid(object o)
        {
            switch (o.ToString())
            {
                case "today":
                    TodayGridVisibility = true;
                    ForecastGridVisibility = false;
                    SettingsGridVisibility = false;
                    AuthorGridVisibility = false;
                    TitleLabel = "Dzisiaj";
                    break;

                case "forecast":
                    TodayGridVisibility = false;
                    ForecastGridVisibility = true;
                    SettingsGridVisibility = false;
                    AuthorGridVisibility = false;
                    TitleLabel = "Prognoza";

                    break;

                case "settings":
                    TodayGridVisibility = false;
                    ForecastGridVisibility = false;
                    SettingsGridVisibility = true;
                    AuthorGridVisibility = false;
                    TitleLabel = "Ustawienia";

                    break;

                case "author":
                    TodayGridVisibility = false;
                    ForecastGridVisibility = false;
                    SettingsGridVisibility = false;
                    AuthorGridVisibility = true;
                    TitleLabel = "Autor";

                    break;
            }
        }

        
    }
}