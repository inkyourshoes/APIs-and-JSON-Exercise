using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

public class OpenWeatherMapApi
{
    public static void Run()
    {
        string apiKey = File.ReadAllText("key.txt");
        string city = "London";
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Get the API response
                HttpResponseMessage response = client.GetAsync(url).Result;

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                string jsonResponse = response.Content.ReadAsStringAsync().Result;

                // Log the raw response
                Console.WriteLine("Raw Response: " + jsonResponse);

                // Attempt to parse the response as a JObject
                JObject parsedResponse = JObject.Parse(jsonResponse);
                Console.WriteLine(parsedResponse.ToString());
            }
            catch (Exception e)
            {
                // Log any errors
                Console.WriteLine("Error: " + e.Message);
            }
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

