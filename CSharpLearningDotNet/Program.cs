using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            var names = new List<string> { "Naveen", "Shanmugam","Jana"};
            names.Add("Selva");
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}"); 
            }
            Console.WriteLine(names[0]);
            Console.WriteLine(names[3]);

            var cars = new string[] { "Mustang", "Challenger", "Camaro SS" };
            cars = [..cars, "Thunderbird"];
            foreach (var car in cars)
            {
                Console.WriteLine($"My favourite car is {car}"); 
            }

            var numbers = new List<int> { 45, 46, 99, 89, 23, 11, 4 };
            Console.WriteLine($"The index of 99 is {numbers.IndexOf(99)}");
            numbers.Sort();
            
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number}");
            }
            Console.WriteLine($"The index of 99 is {numbers.IndexOf(99)}");
        }
    }
}

