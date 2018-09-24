using System;
using System.Net;

namespace LuisBot
{
    public class TrainPosition
    {
        public static object GetTrainPosition(string number)
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");

                var json = client.DownloadString("https://api.railwayapi.com/v2/live/train/" + number + "/date/" + DateTime.Now.Date.ToString("dd'-'MM'-'yyyy") + "/apikey/c3prk0pp13/");
                return json;
            }
        }

    }
}