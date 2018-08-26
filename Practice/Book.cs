using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Book
    {
        public String Title { get; set; }
        public String Author { get; set; }

        public Book(String title, String author)
        {

            this.Title = title;
            this.Author = author;
        }
    }
}
