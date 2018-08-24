using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\nMENU \n-----------------\n");
            Console.WriteLine("1 sortDogsArray\n");
            Console.WriteLine("2 sortAgeArray\n");
            Console.WriteLine("0 Exit");
            Console.WriteLine("Please select the menu number to run!\n");
            var menu = Console.ReadLine();

            switch(menu)
            {
                case "1":
                    Console.WriteLine("sortDogsArray");
                    sortDogsArray();
                    break;
                case "2":
                    Console.WriteLine("sortAgeArray");
                    sortAgeArray();
                    break;
                case "0":                    
                    break;
            }; 

            //find item in array
            //sort multi-dimensional array
            //find item in multi-dimensional array
            //sort list
            //find item in list
        }

        public static void sortDogsArray()
        {
            //sort array
            string[] dogs = { "abe", "charlie", "springer", "dodger" };
            Console.WriteLine("dogs: ");
            foreach (string dog in dogs)
            {
                Console.WriteLine(dog);
            }

            IEnumerable<string> dogAscending =
                from dog in dogs
                orderby dog
                select dog;

            Console.WriteLine("\n\ndogAscending: ");
            foreach (string dog in dogAscending)
            {
                Console.WriteLine(dog);
            }

            IEnumerable<string> dogsDescending =
                from dog in dogs
                orderby dog descending
                select dog;

            Console.WriteLine("\n\nDogsDescending: ");
            foreach (string dog in dogsDescending)
            {
                Console.WriteLine(dog);
            }

            Main();
        }

        public static void sortAgeArray()
        {
            int[] ages = { 7, 12, 15, 35, 52 };

            IEnumerable<int> agesAscending =
                from age in ages
                orderby age
                select age;

            Console.WriteLine("\n\nagesAscending: ");
            foreach(int age in agesAscending)
            {
                Console.WriteLine(age);
            }

            IEnumerable<int> agesDescending =
                from age in ages
                orderby age descending
                select age;

            Console.WriteLine("agesDescending: ");
            foreach(int age in agesDescending)
            {
                Console.WriteLine(age);
            }

            Main();
        }
    }
}
