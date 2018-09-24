namespace LuisBot
{
    public class TrainPosition1
    {

        public class Rootobject3
        {
            public Train train { get; set; }
            public int response_code { get; set; }
            public int debit { get; set; }
            public string start_date { get; set; }
            public Route[] route { get; set; }
            public string position { get; set; }
            public Current_Station current_station { get; set; }
        }

        public class Train
        {
            public Day[] days { get; set; }
            public string name { get; set; }
            public string number { get; set; }
            public Class1[] classes { get; set; }
        }

        public class Day
        {
            public string runs { get; set; }
            public string code { get; set; }
        }

        public class Class1
        {
            public string available { get; set; }
            public string name { get; set; }
            public string code { get; set; }
        }

        public class Current_Station
        {
            public float lat { get; set; }
            public float lng { get; set; }
            public string name { get; set; }
            public string code { get; set; }
        }

        public class Route
        {
            public bool has_departed { get; set; }
            public bool has_arrived { get; set; }
            public int day { get; set; }
            public string scharr_date { get; set; }
            public string actdep { get; set; }
            public string status { get; set; }
            public string scharr { get; set; }
            public string schdep { get; set; }
            public string actarr_date { get; set; }
            public int latemin { get; set; }
            public string actarr { get; set; }
            public Station station { get; set; }
            public int distance { get; set; }
        }

        public class Station
        {
            public float lat { get; set; }
            public float lng { get; set; }
            public string name { get; set; }
            public string code { get; set; }
        }

    }
}