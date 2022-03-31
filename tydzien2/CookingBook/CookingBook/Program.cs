using System;

namespace CookingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            DetectOsVersion();
            Console.WriteLine("Welcome to cooking book app!");
            Console.WriteLine("Please let me know what you want to do:");
            Console.WriteLine("1. Add recipe");
            Console.WriteLine("2. Remove recipe");
            Console.WriteLine("3. Check recipe");
            Console.WriteLine("Press 1, 2, or 3...");

            string choice = Console.ReadLine();

            Console.WriteLine($"You have chosen option number: {choice}");

            //Stałe
            const string FILE_NAME = "";

            //Zmienne
            int chosenOption;
        }

        static void DetectOsVersion()
        {
            OperatingSystem oSVersion = Environment.OSVersion;
            Console.WriteLine(oSVersion.VersionString);
        }
    }
}
