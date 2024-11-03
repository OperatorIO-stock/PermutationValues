using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cupTea = "Кофе";
            string cupCoffee = "Чай";

            Console.WriteLine($"Кружка #1: {cupTea}\nКружка #2: {cupCoffee}");

            string cupFree = cupCoffee;
            cupCoffee = cupTea;
            cupTea = cupFree;

            Console.WriteLine("");
            Console.WriteLine($"Кружка #1: {cupTea}\nКружка #2: {cupCoffee}");

            Console.ReadLine();
        }
    }
}
