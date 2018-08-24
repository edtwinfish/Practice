using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Book
    {
        public String Title
        {
            get
            {
                return this.Title;
            }
            set
            {
                this.Title = value;
            }
        }
        public String Author
        {
            get
            {
                return this.Author;
            }
            set
            {
                this.Author = value;
            }
        }

        public Book(String title, String author)
        {

            this.Title = title;
            this.Author = author;
        }
    }
}
