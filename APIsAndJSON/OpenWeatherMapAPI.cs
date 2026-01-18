using Newtonsoft.Json.Linq;

namespace APIsAndJSON;

public static class OpenWeatherMapApi
{
    public static double Run()
    {
        string key = File.ReadAllText("appsettings.json");
        var apiKey = JObject.Parse(key).GetValue("APIKey").ToString();

        Console.Write("Enter your zip code: ");
        var zipCode = Console.ReadLine();

        var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={apiKey}";
        Console.WriteLine();
        Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees Fahrenheit. ");
        return WeatherMap.GetTemp(apiCall);
    }
}

// Extracted a method for better readability and reuse
    
        // var apiKey = GetApiKeyFromConfig(); // Clearer purpose of this variable
    //
    //     string configContent = File.ReadAllText("appsettings.json");
    //     return JObject.Parse(configContent).Value<string>("APIKey"); // Ensures more type safety
    // }

    



// public OpenWeatherMapApi()
//     {
//         string key = File.ReadAllText("key.txt");
//         _apiKey = JObject.Parse(key).GetValue("APIKey")!.ToString();
//     }
//
//     string GetWeatherApiCall(string zipCode)
//     {
//         return $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={_apiKey}";
//     }
//     public static double GetTemp(string apiCall)
// {
///////////////////////////////////////////////////////////

    
// // public static void Main(string[] args)
//
//         Console.Write("Enter your zip code: ");
//
//         // Retrieve the API call URL
//
//         string key = File.ReadAllText("key.txt");
//
//         string apiKey = JObject.Parse(key).GetValue("APIKey")!.ToString();
//
//         Console.WriteLine("What is your zipcode?");
//
//         string zipCode = Console.ReadLine();
//         
//         string url = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={apiKey}";
//
//     }
//     public static double GetTemp(string apiCall)
//     
//     {
//         var client = new HttpClient();
//     
//         var response = client.GetStringAsync(apiCall).Result;
//     
//         var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
//     
//         return temp;
//         
//     }
// }
/////////////////////////////////////////////////////////
//     public static void Run2()
//     {
//         Console.Write("Enter your zip code: ");
//
//         // Retrieve the API call URL
//
//         string key = File.ReadAllText("key.txt");
//
//         string apiKey = JObject.Parse(key).GetValue("APIKey")!.ToString();
//
//         Console.WriteLine("What is your zipcode?");
//
//         var zipCode = Console.ReadLine();
//
//
//         var apiCall =
//             $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={apiKey}";
//
//         Console.WriteLine();
//         Console.WriteLine(
//             $"The temperature in {zipCode} is {OpenWeatherMapApi.GetTemp(apiCall)} degrees Fahrenheit.");
//     }
// }

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
        //BELOW IS THE NEWEST VERSION OF CODE THAT I SUBBED OUT

////////////
/// ///////////////////////////
//
//     string apiKey = File.ReadAllText("key.txt");
//         
//     string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";
//
//         using (HttpClient client = new HttpClient())
//     {
//         try
//         {
//             // Get the API response
//             HttpResponseMessage response = client.GetAsync(url).Result;
//
//             // Ensure the request was successful
//             response.EnsureSuccessStatusCode();
//
//             string jsonResponse = response.Content.ReadAsStringAsync().Result;
//
//             // Log the raw response
//             Console.WriteLine("Raw Response: " + jsonResponse);
//
//             // Attempt to parse the response as a JObject
//             JObject parsedResponse = JObject.Parse(jsonResponse);
//             Console.WriteLine(parsedResponse.ToString());
//         }
//         catch (Exception e)
//         {
//             // Log any errors
//             Console.WriteLine("Error: " + e.Message);
//         }
//     }
// }
// }