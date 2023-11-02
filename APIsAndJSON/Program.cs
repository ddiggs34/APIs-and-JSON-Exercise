using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {




        static void Main(string[] args)
        {
            OpenWeatherMapAPI.GetWeather();

            Console.WriteLine("----------------------------------------------------");
            
            //var client = new HttpClient();
            //var quote = new RonVSKanyeAPI(client);

            //Console.WriteLine("Very interesting convo here from Kanye and Ron Swanson");

            //for (int i = 0; i < 5; i++) 
            //{
               

            //    Console.WriteLine(" ");

            //    Console.WriteLine($"Kanye: {quote.Kanye()}");

            //    Console.WriteLine(" ");


            //    Console.WriteLine($"Ron: {quote.Ron()}");
            //}




            //Console.WriteLine("------------------------------------------");
            ////to use an api key
            //var apiKeyObj = File.ReadAllText("appsettings.json");

            ////get the api key from the appsettings file using the name "apikey"
            //var apiKey = JObject.Parse(apiKeyObj).GetValue("apikey").ToString();

            //Console.WriteLine(apiKey);

        }

       

    }
}
