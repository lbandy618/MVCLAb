using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal class CountryController
    {
        public List<Country> CountryDb = new List<Country>()
            {
                new Country("United States", "North America", new List<string>(){"Red", "White", "Blue"}),
                new Country("France", "Europe", new List<string>(){}),
                new Country("Saxony", "Europe", new List<string>(){}),
                new Country("Spain", "Intercontinental", new List<string>(){"Red", "Yellow"}),
                new Country("Brazil", "South America", new List<string>(){"Green", "Yellow", "Blue"}),
                new Country("London", "England", new List<string>(){}),
                new Country("Vancouver", "Canada", new List<string>(){}),
            };

        public void CountryAction(Country country)
        {
            CountryView view = new CountryView(country);
            view.Display();
        }
        public void WelcomeAction()
        {
            bool runProgram = true;
            while (runProgram)
            {
                CountryListView view = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
                view.Display();
                Country result = CountryDb[getCountryIndex()];
                CountryAction(result);
                runProgram = GetContinue();
            }
        }

        public static bool GetContinue()
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine("Would you like to learn about another country? y/n: ");
                string choice = Console.ReadLine().ToLower().Trim();

                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid input.");
                }
            }

            return result;
        }

        public int getCountryIndex()
        {
            int result = 0;
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.Write("Not a valid catagory, please try again: ");
                }
                if (result >= 0 && result < CountryDb.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That was out of range.");
                }
            }
            return result;
        }
    }
}
