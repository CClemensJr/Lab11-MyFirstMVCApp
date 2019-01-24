using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace My_First_MVC.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; } = "Data not provided";
        public string Name { get; set; } = "Data not provided";
        public string Country { get; set; } = "Data not provided";
        public int BirthYear { get; set; } = 0;
        public int DeathYear { get; set; } = 0;
        public string Title { get; set; } = "Data not provided";
        public string Category { get; set; } = "Data not provided";
        public string Context { get; set; } = "Data not provided";

        public static List<TimePerson> GetPersons(int startYear, int endYear)
        {
            List<TimePerson> people = new List<TimePerson>();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");
            string[] personOfTheYearData = File.ReadAllLines(path);

            // iterate through the array and set the values appropriately to a new TimePerson object
            for (int i = 1; i < personOfTheYearData.Length; i++)
            {
                var dataString = personOfTheYearData[i].Split(',');

                // Create full list of people from csv
                people.Add(new TimePerson()
                {
                    Year = (dataString[0] == "") ? 0 : Convert.ToInt32(dataString[0]),
                    Honor = dataString[1],
                    Name = dataString[2],
                    Country = personOfTheYearData[3],
                    BirthYear = (dataString[4] == "") ? 0 : Convert.ToInt32(dataString[4]),
                    DeathYear = (dataString[5] == "") ? 0 : Convert.ToInt32(dataString[5]),
                    Title = personOfTheYearData[6],
                    Category = personOfTheYearData[7],
                    Context = personOfTheYearData[8]
                });
            }

            // Then do LINQ wuery (with lambda expression) to filter
            List<TimePerson> filteredPeople = people.Where(p => p.Year >= startYear && p.Year <= endYear).ToList();
            // Return list

            return filteredPeople;
        }
    }
}
