using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        //    //string apiKey = "6340c8c04cb2466456065555b00008ef";
        //    //string myCity = "Arlington, Virginia";
        //    //string apiURL = $"http://api.openweathermap.org/data/2.5/weather?q={myCity}&appid={apiKey}&units=imperial";



         
        //to get the appsettings file (hidden)
        public static void GetWeather()

        {

            //step 1. get the appsettings file (hidden)
            var apiKeyObj = File.ReadAllText("appsettings.json");

            //2. get the apikey from the appsettings file using its name
            //turns the apikey from appsettings file, parses it to JObject to get the get value of the apiKey (the api key without quotes"
            var apiKey = JObject.Parse(apiKeyObj).GetValue("apiKey").ToString();

            //3. build the api url using the zip and api key we have from postmate
            var url = $"http://api.openweathermap.org/data/2.5/weather?zip=22207&appid={apiKey}&units=imperial";

            //4. create http client
            var client = new HttpClient();

            //API call

            var jtext = client.GetStringAsync(url).Result;

            //parse string as a JSON obj - this object can be indexed like an array

            var weatherObj = JObject.Parse(jtext);

            //to print the temp 
            Console.WriteLine($"The temperature in Arlington, VA is {weatherObj["main"]["temp"]} degrees.");


        }




    }
}
