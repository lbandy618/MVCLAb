using DesignPatternsLab;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            CountryController controller = new CountryController();
            controller.WelcomeAction();
        }
    }
}