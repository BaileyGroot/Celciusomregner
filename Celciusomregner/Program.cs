using System;

namespace Celciusomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave A
            // Celciusomregner

            Console.WriteLine("Write a number: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Write a number: ");
            double f = double.Parse(Console.ReadLine());

            double a = r * 0.8;
            double b = f * 1.8 + 32;

            Console.WriteLine("Reamur er: " + a + " og Fahrenheit er " + b );


            //Prevents the program for shutting down.
            Console.ReadKey();
        }
    }
}
