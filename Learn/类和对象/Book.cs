// Create a class named Book
using System.ComponentModel.DataAnnotations;

namespace Learn
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        private string name;
        public Book(string xtitle,string xauthor,int xpages)
        {
            Console.WriteLine("Now,you are create a book.");
            title = xtitle;
            pages = xpages;
            author = xauthor;
        }
        public void Print()
        {
            Console.WriteLine("{0},{1},{2},{3}", title, author, pages, name);
        }
        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                if (value == "jom")
                {
                    Console.WriteLine("ERROR");
                    name = "ERROR";
                }

                else
                {
                    name = value;
                }
            }
        }
    }
}