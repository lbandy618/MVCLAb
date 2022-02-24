using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }

        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name} {DisplayCountry.Continent}");
            foreach(string color in DisplayCountry.Colors)
            {
                ChangeConsoleColor(color);
                Console.WriteLine($"{color}");
                Console.ResetColor();
            }
        }
        public void ChangeConsoleColor(string color)
        {
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(color);
            if(color == "Black")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }


            //if(color == "White")
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //}
            //else if(color == "Black")
            //{
            //    Console.ForegroundColor = ConsoleColor.Black;
            //    Console.BackgroundColor = ConsoleColor.White;
            //}
            //else if(color == "Red")
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //}
        }
    }
}
