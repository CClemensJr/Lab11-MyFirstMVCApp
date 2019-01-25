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

        /// <summary>
        /// This method receives two arguments from the controller, a startYear and an endYear. The method then reads data from a csv file to a string array, creates a list to hold TimePerson objects, then iterates over the string array, splitting the string up, instantiating an object, and assigning the values to the appropriate property. The object is then added to a list that is filtered based on the range of years between start year and end year. This filtered list is then sent back to the controller.
        /// </summary>
        /// <param name="startYear"></param>
        /// <param name="endYear"></param>
        /// <returns></returns>
        public static List<TimePerson> GetPersons(int startYear, int endYear)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");
            string[] personOfTheYearData = File.ReadAllLines(path);

            List<TimePerson> people = new List<TimePerson>();

            for (int i = 1; i < personOfTheYearData.Length; i++)
            {
                var dataString = personOfTheYearData[i].Split(',');

                people.Add(new TimePerson()
                {
                    Year = (dataString[0] == "") ? 0 : Convert.ToInt32(dataString[0]),
                    Honor = dataString[1],
                    Name = dataString[2],
                    Country = dataString[3],
                    BirthYear = (dataString[4] == "") ? 0 : Convert.ToInt32(dataString[4]),
                    DeathYear = (dataString[5] == "") ? 0 : Convert.ToInt32(dataString[5]),
                    Title = dataString[6],
                    Category = dataString[7],
                    Context = dataString[8]
                });
            }

            List<TimePerson> filteredPeople = people.Where(p => p.Year >= startYear && p.Year <= endYear).ToList();

            return filteredPeople;
        }
    }
}
