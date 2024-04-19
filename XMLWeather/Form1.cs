using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Xml;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static string place = "Tokyo";
        public static JObject jweather;
        static string WeaJsonFilePath = "C:/Users/Rowan Locke/Documents/Vis stud GitHub/XML-Weather-Template/XMLWeather/JsonWeather/" + "" + "weather.json";

        public Form1()
        {
            InitializeComponent();
            string responseBody = File.ReadAllText(WeaJsonFilePath);
            jweather = JObject.Parse(responseBody);

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            //XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

           // while (reader.Read())
            //{
                //TODO: create a day object
                
                //TODO: fill day object with required data

                //TODO: if day object not null add to the days list
            //}
        }

        public static async void ExtractAll()
        {
            // current info is not included in forecast file so we need to use this file to get it
            //XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
            double latitude;
            double longitude;
            JProperty location;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Set the base address of the API
                    client.BaseAddress = new Uri("https://api.maptiler.com");

                    // Make a GET request to a specific endpoint
                    HttpResponseMessage response = await client.GetAsync("/geocoding/" + place + ".json?key=dHM9SKF9R4X5wjqgvWnR");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        string locJsonFilePath = "C:/Users/Rowan Locke/Documents/Vis stud GitHub/XML-Weather-Template/XMLWeather/JsonWeather/location.json";

                        // Read the response content as a string
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JObject jsonObject = JObject.Parse(responseBody);
                        JArray coordinates = (JArray)jsonObject["features"][0]["geometry"]["coordinates"];
                        location = new JProperty( "location", (string)jsonObject["features"][0]["place_name"]);
                        latitude = (double)coordinates[1];
                        longitude = (double)coordinates[0];
                        File.WriteAllText(locJsonFilePath, responseBody);
                        Console.WriteLine(responseBody);

                        using (HttpClient client1 = new HttpClient())
                        {
                            try
                            {
                                // Set the base address of the API
                                client1.BaseAddress = new Uri("https://api.open-meteo.com");
                                // Make a GET request to a specific endpoint
                                HttpResponseMessage response1 = await client1.GetAsync("/v1/forecast?latitude=" + latitude + "&longitude=" + longitude + "&current=temperature_2m,apparent_temperature,is_day,precipitation,rain,snowfall,weather_code,cloud_cover&hourly=temperature_2m,apparent_temperature,rain,showers,snowfall,visibility&daily=weather_code,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,sunrise,sunset,daylight_duration,precipitation_sum,rain_sum,showers_sum,snowfall_sum,precipitation_hours,precipitation_probability_max&timezone=auto");

                                // Check if the request was successful
                                if (response1.IsSuccessStatusCode)
                                {
                                    // Read the response content as a string
                                    string responseBodyW = await response1.Content.ReadAsStringAsync();
                                    jweather = JObject.Parse(responseBodyW);
                                    jweather.Add(location);
                                    File.WriteAllText(WeaJsonFilePath, responseBodyW);
                                    Console.WriteLine(responseBodyW);
                                }
                                else
                                {
                                    Console.WriteLine("Error: " + response1.StatusCode);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
