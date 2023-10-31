using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {

        // 1. Create an HTTPClient. This is what makes the API call

        private HttpClient _client;

        public RonVSKanyeAPI(HttpClient client)
        {
            _client = client;
        }



        public string Kanye()
        {


            // 2. Build an API URL from where the API call comes from
            var kanyeURL = "https://api.kanye.rest";

            // 3/4. Use HTTPClient instance. Send GET Request to the URL above
            //This will give us a back of string of JSON
            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;

            //Parse the JSON response into a JObject 
            //In this cases we will be getting the value of "quote" which will be the actual quote itself
            //must put To.String! If not, it will be a JToken type

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;

        }

        public string Ron()
        {

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = _client.GetStringAsync(ronURL).Result;

            //turns it into an array of response

            var ronQuote = JArray.Parse(ronResponse);


            //[0] starts the responses from the first quote in the array
            return ronQuote[0].ToString();


        }
    }




}
