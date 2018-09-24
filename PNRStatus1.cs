namespace LuisBot
{
    public class PNRStatusQuery
    {

        public class Rootobject1
        {
            public int response_code { get; set; }
            public bool chart_prepared { get; set; }
            public To_Station to_station { get; set; }
            public From_Station from_station { get; set; }
            public string pnr { get; set; }
            public Boarding_Point boarding_point { get; set; }
            public Passenger[] passengers { get; set; }
            public string doj { get; set; }
            public int total_passengers { get; set; }
            public int debit { get; set; }
            public Reservation_Upto reservation_upto { get; set; }
            public Train train { get; set; }
            public Journey_Class journey_class { get; set; }
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

        public class Boarding_Point
        {
            public float lat { get; set; }
            public float lng { get; set; }
            public string name { get; set; }
            public string code { get; set; }
        }

        public class Reservation_Upto
        {
            public float lat { get; set; }
            public float lng { get; set; }
            public string name { get; set; }
            public string code { get; set; }
        }

        public class Train
        {
            public Class1[] classes { get; set; }
            public string name { get; set; }
            public string number { get; set; }
            public Day[] days { get; set; }
        }

        public class Class1
        {
            public string name { get; set; }
            public string code { get; set; }
            public string available { get; set; }
        }

        public class Day
        {
            public string code { get; set; }
            public string runs { get; set; }
        }

        public class Journey_Class
        {
            public object name { get; set; }
            public string code { get; set; }
        }

        public class Passenger
        {
            public string current_status { get; set; }
            public string booking_status { get; set; }
            public int no { get; set; }
        }

    }
}