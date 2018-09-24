namespace LuisBot
{
    public class TrainNumber1
    {

        public class Rootobject2
        {
            public int debit { get; set; }
            public int response_code { get; set; }
            public Train train { get; set; }
        }

        public class Train
        {
            public string number { get; set; }
            public Day[] days { get; set; }
            public string name { get; set; }
            public Class1[] classes { get; set; }
        }

        public class Day
        {
            public string code { get; set; }
            public string runs { get; set; }
        }

        public class Class1
        {
            public string code { get; set; }
            public string available { get; set; }
            public string name { get; set; }
        }

    }
}