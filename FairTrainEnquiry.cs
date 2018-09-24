namespace LuisBot
{
    public class FairTrainEnquiry
    {
        public class Rootobject
        {
            public int debit { get; set; }
            public int response_code { get; set; }
            public Train[] trains { get; set; }
            public int total { get; set; }
        }

        public class Train
        {
            public string name { get; set; }
            public string dest_arrival_time { get; set; }
            public string number { get; set; }
            public To_Station to_station { get; set; }
            public string src_departure_time { get; set; }
            public From_Station from_station { get; set; }
            public Day[] days { get; set; }
            public Class1[] classes { get; set; }
            public string travel_time { get; set; }
        }

        public class To_Station
        {
            public float lat { get; set; }
            public float lng { get; set; }
            public string name { get; set; }
            public string code { get; set; }
        }

        public class From_Station
        {
            public float lat { get; set; }
            public float lng { get; set; }
            public string name { get; set; }
            public string code { get; set; }
        }

        public class Day
        {
            public string runs { get; set; }
            public string code { get; set; }
        }

        public class Class1
        {
            public string name { get; set; }
            public string code { get; set; }
        }

    }


}