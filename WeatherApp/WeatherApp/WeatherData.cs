using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WeatherApp
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Clouds
    {
       public int all { get; set; }
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
      //  public int all { get; set; }
        public double speed { get; set; }
        public int sea_level { get; set; }
    }

    public class OpenWeatherData
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Wind
    {
       public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }
    }

    /*private async void GetWeatherData()
    {
        var client = new HttpClient();

       HttpClient DefaultRequestHeaders.Add("Accept", "application/json");

        var response = await client.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?lat=-33.5975&lon=18.9061&appid=b5e2f5bf1453a26cf3b7befd53c1d227");

        var weatherData = JsonConvert.DeserializeObject<OpenWeatherData>

    }*/
     //HttpClient client = new HttpClient(); // To get the joke from the internet

    //client.DefaultRequestHeaders.Add("Accept", "application/json"); //Http header we can send through to the server. The text must be exact. 

    // string response = await client.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?lat=-33.5975&lon=18.9061&appid=b5e2f5bf1453a26cf3b7befd53c1d227");

}








    
