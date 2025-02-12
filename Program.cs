using System;
using System.Collections.Generic;
using System.Linq;

namespace AirTech_Test
{
    class Program
    {

        public readonly string nameInmutable  = "Jhon"; // readonly can make inmutable to variable nameInmutable

        public IList<String> citiesList = new List<string>()
            { "nasville",
                "nasville",
                "los angeles",
                "nasville",
                "Madrid",
                "memphis",
                "barcelona",
                "los angeles",
                "sevilla",
                "Madrid",
                "canary islands",
                "barcelona",
                "Madrid",
                "Madrid",
                "nasville",
                "barcelona",
                "london",
                "berlin",
                "Madrid",
                "nasville",
                "london",
                "Madrid",
                "Madrid"};

        static void Main(string[] args)
        {            
            var mc = new Program();          
            
            Console.WriteLine("TEST JS");
            Console.WriteLine("--------------"); 
            Console.WriteLine("1.Problem 1 - (A)");
            hello(mc.nameInmutable);
            Console.WriteLine("--------------");
            Console.WriteLine("2. Problem 1 - (B)");
            Console.WriteLine("How would you make name inmutable?");
            Console.WriteLine("(Can write or just describe)");
            Console.WriteLine("Inmutable types can be use in C# with:");
            Console.WriteLine("- Use readonly for fields that can be assigned once (either at the declaration or in a constructor).");
            Console.WriteLine("- Use const for compile-time constants that don’t change.");
            Console.WriteLine("- For reference types, ensure the properties or fields themselves are immutable, or use collections from System.Collections.Immutable.");
            Console.WriteLine("Into the code you can see a variable 'nameInmutable' as inmutable using readonly in a basic example. ");
            Console.WriteLine("--------------");
            Console.WriteLine("3. Problem 2");
            Console.WriteLine("               ");
            PrintWordOccurrences(mc.citiesList);

        }
        public static void hello(string nameInmutable) {

            var mc = new Program();
            Console.WriteLine($"Hello Inmutable {nameInmutable} in the console");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            // mc.nameInmutable = name; // error, mc.nameInmutable can't be mutable            
            Console.WriteLine($"Hello Mutable {name} in the console");
        }

        public static void PrintWordOccurrences(IList<string> words)
        {
            var wordCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            
            foreach (var word in wordCounts.OrderByDescending(w => w.Value).Take(5))
            {
                
                Console.WriteLine($"{word.Key}: {word.Value}");
                
            }
        }
    }
}
