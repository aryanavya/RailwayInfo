using System.Net;

namespace LuisBot
{
    public class PNRStatus
    {
        public static object GetPNRStatus(string PNR)
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");

                var json = client.DownloadString("https://api.railwayapi.com/v2/pnr-status/pnr/" + PNR + "/apikey/c3prk0pp13/");
                return json;
            }
        }
    }
}