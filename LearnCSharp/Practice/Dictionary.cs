namespace LearnCSharp.Practice
{
    public class Dictionary
    {
        public static void DictionaryMethod()
        {
            // Declaration...
            Dictionary<int, String> student = new Dictionary<int, String>();
            student.Add(100, "Sabari");
            student.Add(200, "Anu");
            student.Add(300, "Jeevitha");
            student.Add(400, "Preethi");
            student.Add(500, "Vivek");

            // Declaration type...
            var cities = new Dictionary<string, string>() {
                    {"UK", "London, Manchester, Birmingham"},
                    {"USA", "Chicago, New York, Washington"},
                    {"India", "Mumbai, New Delhi, Pune"}
            };

            // Printing the values...
            foreach (var value in student)
            {
                Console.WriteLine(value.Key + " | " + value.Value);
            }

            // Printing stratergy...
            foreach (KeyValuePair<int, string> value in student)
            {
                Console.WriteLine(value);
            }

            // Printing the value using Key...
            Console.WriteLine(cities["UK"]); 
            Console.WriteLine(cities["USA"]);
            
            //ContainsKey() to check for an unknown key...
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            //TryGetValue() to get a value of unknown key...
            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
