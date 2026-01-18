using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace APIsAndJSON;

public static class WeatherMap
{
    public static double GetTemp(string apiCall)
    {
        var client = new HttpClient();
        var response = client.GetStringAsync(apiCall).Result;
        // var formattedResponse = JObject.Parse(response).GetValue("main").ToString();

        var parsedResponse = JObject.Parse(response);
        var mainObject = parsedResponse["main"];
        if (mainObject == null)
            throw new Exception("Invalid response: 'main' object is missing from the API response.");

        var temp = mainObject.Value<double?>("temp");

        if (temp == null)
            throw new Exception("Invalid response: 'temp' value is missing from the 'main' object.");

        return temp.Value; // Safely return the temperature as a double
    }
}


// var temp = JObject.Parse(response).GetValue("temp");
        // return WeatherMap.GetTemp(temp.ToString());
    