using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherAPP.Models
{
    public class Weather
    {
        public Object getWeatherForcast()
        {
            Object jsoncontent = new Object();
            try
            {
                string url = "https://api.openweathermap.org/data/2.5/weather?q=Yerevan&APPID=a9228e7c83aa8984cb9ee00799c83c53&units=imperial";               
                WebClient client = new WebClient();
                //client.Headers.Add("Accept-Language", " en-US");
                //client.Headers["Content-Type"] = "application/json;charset=UTF-8";
                //client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
                //client.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0) Chrome/15.0.874.121");
                var content = client.DownloadString(url);
                var seriilizer = new JavaScriptSerializer();
                jsoncontent = seriilizer.Deserialize<Object>(content);
            }
            catch (WebException we)
            {
                Console.WriteLine(we.ToString());
            }
            return jsoncontent;
        }

        public Object getWeatherForcastByCity(string city)
        {
            Object jsoncontent = new Object();
            try
            {
                string url = "https://api.openweathermap.org/data/2.5/weather?q="+ city + "&APPID=a9228e7c83aa8984cb9ee00799c83c53&units=imperial";
                WebClient client = new WebClient();
                //client.Headers.Add("Accept-Language", " en-US");
                //client.Headers["Content-Type"] = "application/json;charset=UTF-8";
                //client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
                //client.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0) Chrome/15.0.874.121");
                var content = client.DownloadString(url);
                var seriilizer = new JavaScriptSerializer();
                jsoncontent = seriilizer.Deserialize<Object>(content);
            }
            catch (WebException we)
            {
                Console.WriteLine(we.ToString());
            }
            return jsoncontent;
        }
    }
}