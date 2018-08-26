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
            //sort array practice methods
            Console.WriteLine("1 sortDogsArray\n");
            Console.WriteLine("2 sortAgeArray\n");
            Console.WriteLine("3 sortBooksByTitle\n");
            Console.WriteLine("4 sortBooksByAuthor\n");
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
                case "3":
                    Console.WriteLine("sortBooksByTitle");
                    sortBooks();
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

        public static void sortBooks()
        {
            List<Book> books = new List<Book>()
            {
                new Book("Twilight", "Stephanie Meyer"),
                new Book("CarterOfMars", "Edgar Rice Burroughs"),
                new Book("Harry Potter and the Sorcerers Stone", "J.K. Rowling")
            };
            Console.WriteLine("\nBooks before sort");
            foreach(Book book in books)
            {
                Console.WriteLine(book.Title);
            }

            IEnumerable<string> bookList = from book in books
                                         orderby book.Title
                                         select book.Title;
            Console.WriteLine("\nBooks after sort");
            foreach (string book in bookList)
            {
                Console.WriteLine(book);
            }

            IEnumerable<string> bookListByAuthor = from book in books
                                                   orderby book.Author
                                                   select book.Author;
            Console.WriteLine("\nBooks after sort by Author");
            foreach (string book in bookListByAuthor)
            {
                Console.WriteLine(book);
            }

            IEnumerable<Book> bookListByTitleLambda =
                books.OrderBy(b => b.Title);

            Console.WriteLine("\nBooks after sort by title using Lambda");
            foreach(Book book in bookListByTitleLambda)
            {
                Console.WriteLine(book.Title);
            }

            IEnumerable<Book> bookListByAuthorLambda =
                books.OrderBy(b => b.Author);

            Console.WriteLine("\nBooks after sort by author using Lambda");
            foreach(Book book in bookListByAuthorLambda)
            {
                Console.WriteLine(book.Author);
            }
            Main();
        }
    }
}
