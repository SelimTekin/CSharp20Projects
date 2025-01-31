using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project13_WeatherApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/istanbul/EN"),
				Headers =
	{
		{ "x-rapidapi-key", "65d19863b5msh4772432a7c96bf5p11ae0bjsn115de79f9fb2" },
		{ "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var json = JObject.Parse(body);

				var fahrenheit = json["main"]["feels_like"].ToString();
				var windSpeed = json["wind"]["speed"].ToString();
				var humidity = json["main"]["humidity"].ToString();
				var weatherStatus = json["weather"][0]["main"].ToString();
				
				lblFahrenheit.Text = fahrenheit;
				lblHumidity.Text = humidity;
				lblWindSpeed.Text = windSpeed;

				double celsius = (double.Parse(fahrenheit) - 32) / (1.8);
				lblCelsius.Text = celsius.ToString("0.00"); // virgülden sonra 2 basamak

				pictureBox1.ImageLocation = "C:\\Users\\selim\\source\\repos\\CSharp20Projects\\Project13_WeatherApp\\images\\" + GetImage(weatherStatus);
			}
		}

		private string GetImage(string weatherStatus)
		{
			switch (weatherStatus)
			{
				case "Mist":
					return "cloud.jpeg";
				case "Sun":
					return "sun.png";
				case "Snow":
					return "snow.jpeg";
				case "Rain":
					return "rainy.jpeg";
				default:
					return "";
			}
		}

	}
}
