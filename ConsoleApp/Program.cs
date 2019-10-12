using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci una parola");
            string s = Console.ReadLine();
            foreach (char c in s)
            {
                Console.WriteLine(System.Convert.ToInt32(c));
            }
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}