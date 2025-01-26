#region Menü_Başlangıcı
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Text;
using System.Text.Json.Nodes;

Console.WriteLine("Api Consume İşlemine Hoşgeldiniz");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçiniz ###");
Console.WriteLine();
Console.WriteLine("1-Şehir Listesini Getirin");
Console.WriteLine("2-Şehir ve Hava Durumu Listesini Getirin");
Console.WriteLine("3-Yeni Şehir Ekleme");
Console.WriteLine("4-Şehir Silme İşlemi");
Console.WriteLine("5-Şehir Güncelleme İşlemi");
Console.WriteLine("6-ID'ye Göre Şehir Getirme");
Console.WriteLine();
#endregion

string number;

Console.Write("Tercihiniz: ");
number = Console.ReadLine();
Console.WriteLine();

if(number == "1")
{
	string url = "https://localhost:7023/api/Weathers";
	using (HttpClient client = new HttpClient()) // API'den istek atmak için kullanılır
	{
		// Veri çekmek için kullanılır
		HttpResponseMessage response = await client.GetAsync(url);
		string responseBody = await response.Content.ReadAsStringAsync(); // response'u stringe dönüştürür
		JArray jArray = JArray.Parse(responseBody); // json formatından metne dönüştürüyoruz
		foreach(var item in jArray)
		{
			string cityName = item["cityName"].ToString();
			Console.WriteLine($"Şehir: {cityName}");
		}
	}
}
if (number == "2")
{
	string url = "https://localhost:7023/api/Weathers";
	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.GetAsync(url);
		string responseBody = await response.Content.ReadAsStringAsync();
		JArray jArray = JArray.Parse(responseBody);
		foreach (var item in jArray)
		{
			string cityName = item["cityName"].ToString();
			string temp = item["temp"].ToString();
			string country = item["country"].ToString();
			Console.WriteLine(cityName + "-" + country + "-->" + temp + "Derece");
			Console.WriteLine("------------------------------------------------");
		}
	}
}
if (number == "3")
{
	Console.WriteLine("### Yeni Veri Girişi ###");
	Console.WriteLine();
	string cityName, country, detail;
	decimal temp;

	Console.Write("Şehir Adı:");
	cityName = Console.ReadLine();

	Console.Write("Ülke Adı: ");
	country = Console.ReadLine();

	Console.Write("Hava Durumu Detayı: ");
	detail = Console.ReadLine();

	Console.Write("Sıcaklık: ");
	temp = decimal.Parse(Console.ReadLine());

	string url = "https://localhost:7023/api/Weathers";
	var newWeatherCity = new // anonymous tip eklendi
	{
		CityName = cityName,
		Country = country,
		Detail = detail,
		Temp = temp
	};

	using(HttpClient client = new HttpClient())
	{
		string json = JsonConvert.SerializeObject(newWeatherCity); // metni json'a dönüştürüyoruz
		// UTF8 formatında, medya olarak application/json dosyası gönderiyoruz.
		StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
		HttpResponseMessage response = await client.PostAsync(url, content); // post ile gönderdik
		response.EnsureSuccessStatusCode(); // isteğin başarılı olup olmadığını kontrol eder. Eğer başarısız olursa bir hata fırlatır.
	}
}
if (number == "4")
{
	Console.WriteLine("Silmek istediğiniz ID Değeri: ");
	int id = int.Parse(Console.ReadLine());

	string url = "https://localhost:7023/api/Weathers?id=";
	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.DeleteAsync(url + id);
		response.EnsureSuccessStatusCode();
	}
}
if(number == "5")
{
	Console.WriteLine("### Veri Güncelleme İşlemi ###");
	Console.WriteLine();
	string cityName, country, detail;
	decimal temp;
	int cityId;

	Console.Write("Şehir Adı:");
	cityName = Console.ReadLine();

	Console.Write("Ülke Adı: ");
	country = Console.ReadLine();

	Console.Write("Hava Durumu Detayı: ");
	detail = Console.ReadLine();

	Console.Write("Sıcaklık: ");
	temp = decimal.Parse(Console.ReadLine());

	Console.Write("Şehir Id: ");
	cityId = int.Parse(Console.ReadLine());

	var updatedWeatherVAlues = new
	{
		CityId = cityId,
		CityName = cityName,
		Country = country,
		Detail = detail,
		Temp = temp
	};

	string url = "https://localhost:7023/api/Weathers";
	using (HttpClient client = new HttpClient())
	{
		var json = JsonConvert.SerializeObject(updatedWeatherVAlues);
		StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
		HttpResponseMessage response = await client.PutAsync(url, content);
		response.EnsureSuccessStatusCode();
	}
}
if(number == "6")
{
	string url = "https://localhost:7023/api/Weathers/GetByIdWeatherCity?id=";

	Console.WriteLine("Bilgilerini Getirmek İstediğiniz Şehrin ID Değrei: ");
	int id = int.Parse(Console.ReadLine());
	Console.WriteLine();

	using(HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.GetAsync(url + id);
		response.EnsureSuccessStatusCode();
		string responseBody = await response.Content.ReadAsStringAsync(); // string olarak okuduk
		JObject weatherCityObject = JObject.Parse(responseBody);

		string cityName = weatherCityObject["cityName"].ToString();
		string detail = weatherCityObject["detail"].ToString();
		string country = weatherCityObject["country"].ToString();
		decimal temp = decimal.Parse(weatherCityObject["temp"].ToString());

		Console.WriteLine("Girmiş olduğunuz Id değerine ait bilgiler");
		Console.WriteLine();
		Console.WriteLine("Şehir: " + cityName + " Ülke: " + country + " Detay: " + detail + " Sıcaklık: " + temp);
	}

}

Console.Read();