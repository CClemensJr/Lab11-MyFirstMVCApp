using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_First_MVC.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public static List<TimePerson> GetPersons(int startYear, int endYear)
        {
            List<TimePerson> people = new List<TimePerson>();
            // read in file
            // iterate through the array and set the values appropriately to a new TimePerson object
            // CSV is comma delimited
            // Create full list of people from csv
            // Then do LINQ wuery (with lambda expression) to filter
            // List<timePerson>
            // Return list
            TimePerson timePerson = new TimePerson();
            TimePerson tp1 = timePerson;
            tp1.Year = 1982;
            tp1.Name = "ChaCha Palov";
            tp1.Honor = "Fed the birds.";

            TimePerson tp2 = timePerson;
            tp2.Year = 1984;
            tp2.Name = "HCnast Palov";
            tp2.Honor = "Fed the dogs.";

            TimePerson tp3 = timePerson;
            tp3.Year = 1985;
            tp3.Name = "Chattle Pal";
            tp3.Honor = "Fed the cows.";

            TimePerson tp4 = timePerson;
            tp4.Year = 1993;
            tp4.Name = "Chaha Ov";
            tp4.Honor = "Fed the people.";

            people.Add(tp1);
            people.Add(tp2);
            people.Add(tp3);
            people.Add(tp4);

            return people;
        }
    }
}
