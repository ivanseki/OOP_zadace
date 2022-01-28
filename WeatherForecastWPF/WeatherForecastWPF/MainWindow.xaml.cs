using System;
using System.Collections.Generic;
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
using System.Net.Http;
using Newtonsoft.Json;
using WeatherNet;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WeatherForecastWPF
{
    public partial class MainWindow : Window
    {
        List<City> cityList;
        const string APP_ID = "be45432593038f676bc6befb2d46bb17";

        public MainWindow()
        {
            InitializeComponent();

            //cityList = JsonConvert.DeserializeObject<List<City>>(File.ReadAllText(@"E:\Ivan\Downloads\__FAKS\2. godina\OOP\Zadace\WeatherForecastWPF\WeatherForecastWPF\city.list.json"));

            using(StreamReader r = new StreamReader(@"E:\Ivan\Downloads\__FAKS\2. godina\OOP\Zadace\WeatherForecastWPF\WeatherForecastWPF\city.list.json"))
            {
                string json = r.ReadToEnd();
                cityList = JsonConvert.DeserializeObject<List<City>>(json);
            }

        }
        private void GetCurrentWeather_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter || e.Key == Key.Return)
            {
                try
                {
                    int index = isCityValid();

                    if(index >= 0)
                    {
                        string query = String.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}&units=metric", cityList[index].Id, APP_ID);
                        JObject response = JObject.Parse(new System.Net.WebClient().DownloadString(query));

                        if(response.SelectToken("cod").ToString().Equals("200"))
                        {
                            displayWeatherImage(Convert.ToInt32(response.SelectToken("weather[0].id").ToString()));
                            lblCityAndCountry.Content = response.SelectToken("name").ToString() + ", " + response.SelectToken("sys.country").ToString();
                            lblWeather.Content = response.SelectToken("main.temp").ToString() + "°C, " + response.SelectToken("weather[0].main").ToString();
                            lblWeatherDescription.Content = response.SelectToken("weather[0].description").ToString();
                        }
                        else if(response.SelectToken("cod").ToString().Equals("429"))
                        {
                            MessageBox.Show("The account is temporary blocked due to exceeding the requests limitition.\nPlease try agian later.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid city name", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        /*
        private void GetCurrentWeather_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Get4DaysWeather_Click(object sender, RoutedEventArgs e)
        {

        }
        */

        public class City
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }
        
        private int isCityValid()
        {
            return cityList.FindIndex(x => x.Name.ToLower().Equals(CityInput.Text.ToLower()));
        }

        private void displayWeatherImage(int weatherId)
        {
            BitmapImage image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/11d.png", UriKind.Absolute));
            if (weatherId >= 200 && weatherId <= 232)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/11d.png", UriKind.Absolute));
            }
            else if (weatherId >= 300 && weatherId <= 321)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/09d.png", UriKind.Absolute));
            }
            else if (weatherId >= 500 && weatherId <= 504)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/10d.png", UriKind.Absolute));
            }
            else if (weatherId == 511)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/13d.png", UriKind.Absolute));
            }
            else if (weatherId >= 520 && weatherId <= 531)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/09d.png", UriKind.Absolute));
            }
            else if (weatherId >= 600 && weatherId <= 622)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/13d.png", UriKind.Absolute));
            }
            else if (weatherId >= 700 && weatherId <= 781)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/50d.png", UriKind.Absolute));
            }
            else if (weatherId == 800)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/01d.png", UriKind.Absolute));
            }
            else if (weatherId == 801)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/02d.png", UriKind.Absolute));
            }
            else if (weatherId == 802)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/03d.png", UriKind.Absolute));
            }
            else if (weatherId >= 803 && weatherId <= 804)
            {
                image = new BitmapImage(new Uri(@"http://openweathermap.org/img/w/04d.png", UriKind.Absolute));
            }

            icon.Source = image;
        }
    }
}
