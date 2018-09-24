using System.Net;

namespace LuisBot
{
    public class TrainNumber
    {
        public static object GetTrainNumber(string name)
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");

                var json = client.DownloadString("https://api.railwayapi.com/v2/name-number/train/" + name + "/apikey/c3prk0pp13/");
                return json;
            }
        }

    }
}