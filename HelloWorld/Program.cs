using System;

namespace HelloWorld
{
    //PascalCase
    public class Program
    {
        static void Main(string[] args)
        {
            //camelCase
            string firstName = "Piotr";

            //UPPER_CASE
            const double PI_NUMBER = 3.14;
            Console.WriteLine("Hello World!");
            Console.WriteLine("To jest nowy napis");
            if (PI_NUMBER > 2)
            {
                WritePiNumber(PI_NUMBER);
            }
        }

        private static string WritePiNumber(double pi)
        {
            return ("3.14");
        }
    }

    public interface IProgram
    {
    }
}
