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

            if (choice == "1")
            {
                // your existing Ron vs Kanye code
            }
            else if (choice == "2")
            {
                OpenWeatherMapApi.Run();
            }

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

        }
        
     
    }
