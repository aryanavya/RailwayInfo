using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace LuisBot
{
    public class TrainAvailablity
    {
        public static object SeatAvailable(List<string> seat)
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");

                var json = client.DownloadString("https://api.railwayapi.com/v2/check-seat/train/"+seat[0]+"/source/"+seat[1]+ "/dest/" + seat[2] + "/date/" + seat[3] + "/pref/" + seat[4] + "/quota/" + seat[5] + "/apikey/c3prk0pp13/");
                return json;
            }
        }

    }
}