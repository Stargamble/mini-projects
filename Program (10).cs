using System;

namespace CityTest
{
    public class City
    {

        private string name;
        private int population;
        private string country;

        
        public City(string name, int population)
        {
            this.name = name;
            this.population = population;
        }

        public City(string name, int population, string country)
        {
            this.name = name;
            this.population = population;
            this.country = country;
        }

        public string GetCity()
        {
            return name;
        }

        public int GetPopulation()
        {
            return population;
        }

      
        public string Country
        {
            get { return country; }
        }


        public static void DisplayInfo()
        {
            Console.WriteLine("City Info Version 1.0");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            City.DisplayInfo();
            City myCity = new City("Seattle", 750000, "USA");

            Console.WriteLine($"City: {myCity.GetCity()}");
            Console.WriteLine($"Population: {myCity.GetPopulation()}");
            Console.WriteLine($"Country: {myCity.Country}");
        }
    }
}


