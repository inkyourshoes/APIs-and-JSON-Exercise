    using System.Text.Json.Nodes; 
    using Newtonsoft.Json.Linq;
    using APIsAndJSON;
    public class Program
    {
        static void Main(string[] args)
        {

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
