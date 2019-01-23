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
            // read in file
            // iterate through the array and set the values appropriately to a new TimePerson object
            // CSV is comma delimited
            // Create full list of people from csv
            // Then do LINQ wuery (with lambda expression) to filter
            // List<timePerson>
            // Return list
            return null;
        }
    }
}
