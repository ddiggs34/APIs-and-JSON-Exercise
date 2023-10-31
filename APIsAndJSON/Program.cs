using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {


        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new RonVSKanyeAPI(client);

            Console.WriteLine("Very interesting convo here from Kanye and Ron Swanson");

            for (int i = 0; i < 5; i++) 
            {
               

                Console.WriteLine(" ");

                Console.WriteLine($"Kanye: {quote.Kanye()}");

                Console.WriteLine(" ");


                Console.WriteLine($"Ron: {quote.Ron()}");
            }

        }


    }
}
