    using System.Text.Json.Nodes; 
    using Newtonsoft.Json.Linq;
    using APIsAndJSON;
    namespace APIsAndJSON;

    public static class Program
    {
            public static void Main(string[] args)
            { 
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Ron vs Kanye");
                Console.WriteLine("2 - Open Weather");
    
                var choice = Console.ReadLine();
    
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Kanye is upset, and says to Ron, :");
    
                        APIsAndJSON.RonVSKanyeAPI.KanyeQuote();
    
                        Console.WriteLine("Ron walks out of the bathroom and says back, :");
    
                        APIsAndJSON.RonVSKanyeAPI.RonQuote();
    
                        Console.WriteLine("Kanye, with tears in his eyes says, :");
    
                        APIsAndJSON.RonVSKanyeAPI.KanyeQuote();
    
                        APIsAndJSON.RonVSKanyeAPI.RonQuote();
    
                        Console.WriteLine("Finally, Kanye says, :");
    
                        APIsAndJSON.RonVSKanyeAPI.KanyeQuote();
    
                        APIsAndJSON.RonVSKanyeAPI.RonQuote();
    
                        APIsAndJSON.RonVSKanyeAPI.KanyeQuote();
                        break;

                    case "2":
                        OpenWeatherMapApi.Run();
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice");
                        break; 

                }
                
                
    
            }
            
         
      
        }
        

        
//////////////////////////////////////////
    //         {
    //             var json = @"{
    //         'main': { 'temp': 25.0, 'feels_like': 24.5 },
    //         'weather': [ { 'description': 'clear sky' } ],
    //         'name': 'CityName'
    //     }";
    //
    //             var parsedResponse = JObject.Parse(json);
    //
    //             // Iterate through all keys and print their types
    //             foreach (var property in parsedResponse.Properties())
    //             {
    //                 Console.WriteLine(
    //                     $"{property.Name}: {property.Value.Type}"); // Shows type (e.g., Object, Array, String, etc.)
    //             }
    //
    //             // Check one key's exact type
    //             Console.WriteLine($"Type of 'main': {parsedResponse["main"].GetType()}");
    //         }
    //     }
    // }
    ///////////////////////////////////
   