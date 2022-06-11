using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        private OpenWeatherData _currentWeather;

        public OpenWeatherData CurrentWeather
        {
            get
            {
                return _currentWeather;
            }
            set
            {
                _currentWeather = value;

                OnPropertyChanged();
            }
        }


        private bool _isLoading;

        public bool IsLoading
        {
            get { return _isLoading; }
            set { _isLoading = value;

                OnPropertyChanged();
            }
        }


        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }


         protected async override void OnAppearing()
         {
            base.OnAppearing();



            IsLoading = true;
            CurrentWeather = await GetWeatherData();
            IsLoading = false;
        //    BindingContext = this;
         }
        private async Task<OpenWeatherData> GetWeatherData()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            if (status != PermissionStatus.Granted)
            {
                var newstatus = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }

            var location = await Geolocation.GetLocationAsync();

            var latitude = location.Latitude;
            var longitude = location.Longitude;


            //location.Latitude = 
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await client.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?lat=-33.9320&lon=18.6262&units=metric&appid=b5e2f5bf1453a26cf3b7befd53c1d227");

            var weatherData = JsonConvert.DeserializeObject<OpenWeatherData>(response);

            return weatherData;
        }

        /*private List<OpenWeatherData> _weather;

        public List<OpenWeatherData> Weather
        {
            get { return _weather; }
            set
            {
                _weather = value;

                OnPropertyChanged();
            }
        }*/
    }
}
