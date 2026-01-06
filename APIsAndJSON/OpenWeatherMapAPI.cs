using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapApi
    {

        public static void Run()
        {
            string key = File.ReadAllText("key.txt");
            string apiKey = JObject.Parse(key).GetValue("APIKey")!.ToString();

            Console.WriteLine("What is your zipcode?");
            var zipCode = Console.ReadLine();

            var apiCall =
                $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={apiKey}";

            Console.WriteLine();
            Console.WriteLine(
                $"The temperature in {zipCode} is {GetTemp(apiCall)} degrees Fahrenheit.");
        }

        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
            return temp;
        }
    }
}

// public static void Main(string[] args)
    // {
    //     Console.Write("Enter your zip code: ");
    //
    //     // Retrieve the API call URL
    //
    //     string key = File.ReadAllText("key.txt");
    //
    //     string apiKey = JObject.Parse(key).GetValue("APIKey")!.ToString();
    //
    //     Console.WriteLine("What is your zipcode?");
    //
    //     var zipCode = Console.ReadLine();
    //
    //
    //     var apiCall =
    //         $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={apiKey}";
    //
    //     Console.WriteLine();
    //     Console.WriteLine(
    //         $"The temperature in {zipCode} is {OpenWeatherMapApi.GetTemp(apiCall)} degrees Fahrenheit.");
    //
    // }


    // public static double GetTemp(string apiCall)
    //
    // {
    //     var client = new HttpClient();
    //
    //     var response = client.GetStringAsync(apiCall).Result;
    //
    //     var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
    //
    //     return temp;
    // }
    // }

