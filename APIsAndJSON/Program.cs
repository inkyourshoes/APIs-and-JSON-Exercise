using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kanye is upset, and says to Ron, :");
            
            QuoteGenerator.KanyeQuote();
            
            Console.WriteLine("Ron walks out of the bathroom and says back, :");
            
            QuoteGenerator.RonQuote();
            
            Console.WriteLine("Kanye, with tears in his eyes says, :");
            
            QuoteGenerator.KanyeQuote();
            
            QuoteGenerator.RonQuote();
            
            Console.WriteLine("said Ron:");
            
            Console.WriteLine("Finally, Kanye says, :");
            
            QuoteGenerator.KanyeQuote();
            
            QuoteGenerator.RonQuote();
            
            QuoteGenerator.KanyeQuote();
            
        }
    }
}
