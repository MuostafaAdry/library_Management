using System.Buffers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace constractor1
{

    class Collection
    {
        public int id;
        public string title;
        public string auther;
        public int isnb;
        public bool avaliable;

        public Collection(int id = 1, string title = "no title", string auther = "no auther", int isnb = 10, bool avaliable = true)
        {
            this.id = id;
            this.title = title;
            this.auther = auther;
            this.isnb = isnb;
            this.avaliable = avaliable;
        }

         
    }
    class Book
    {
          string title;
          string auther;
          int isnb;
          bool avaliable;
         public List<Collection>collections;

        public Book(string title="no title", string auther="no name", int isnb = 123, bool avaliable=true)
        {
            this.title = title;
            this.auther = auther;
            this.isnb = isnb;
            this.avaliable = avaliable;
            this.collections = new List<Collection>();
        }
        //set and get for title 
        public string SetTile(string newTitle)
        {
            Collection collection = new Collection(1, newTitle, "no auther", 123, true);
            collections.Add(collection);
            return title = newTitle;
        }
        public string GetTitle()
        {
            return title;
        }

        //set and get for auther 
        public string SetAuther(string newAuther)
        {
            Collection collection = new Collection(2, "no title", newAuther, 123, true);
            collections.Add(collection);
            return auther = newAuther;
        }
        public string GetAuther()
        {
            return auther;
        }
        //set and get for isnb
     

        public bool GetBook()
        {
            if (avaliable  )
            {
                Console.WriteLine("the book is avaliable");
                return true;
            }
            else
            {
                Console.WriteLine("the book is NOT avaliable");
            }
                 return false;
        }

        public bool setBook(bool value)
        {
            Collection collection = new Collection(3, "no title", "no auther", 123, value);
            collections.Add(collection);
            return avaliable = value;
        }
           public int SetIsnb(int newIsnb)
        {
            Collection collection = new Collection(4, "no title", "no auther ", newIsnb, false);
            collections.Add(collection);
            return isnb = newIsnb;
        }
        public int GetIsnb()
        {
            return isnb;
        }

        //adding book

        public void AddBook(string bookTtiel, string bookauther, int isnb, bool avaliable)
        {
            Collection collection = new Collection(5, bookTtiel, bookauther, isnb, avaliable);
            collections.Add(collection);
            Console.WriteLine($"the book {bookTtiel} with auther {bookauther} added ");
        }

        //searching for a book
        public void SearchBook(string searchValue)
        {
          
            bool found = false;
            for (int j = 0; j < collections.Count; j++)
                {
                    if (collections[j].title == searchValue || collections[j].auther == searchValue)
                    {
                        found = true;
                        Console.WriteLine($"the book is avaliable");
                        break;
                    }
                     

                }
                     if (!found)
                     {
                       Console.WriteLine("The book is NOT available");
                      }
             

        }
        //brrow bok
        public void BrrowBook(string brrowValue)
        {
            bool isbrrow = false;
                for (int b = 0; b < collections.Count; b++)
                {
                    if (collections[b].title == brrowValue || collections[b].auther == brrowValue)
                    {
                        isbrrow = true;
                        avaliable = false;
                        Console.WriteLine($"you brrow the {brrowValue} book");
                        break;
                    }
                     

                }
            if (!isbrrow)
            {
                Console.WriteLine($"the book is NOT avaliable");
                
            }
             
        }

        //Return  book
        public void ReturnBook(int ISNBnumber)
        {
            bool rebook = false;
                for (int b = 0; b < collections.Count; b++)
                {
                    if (collections[b].isnb == ISNBnumber && collections[b].avaliable == false)
                    {
                        rebook = true;
                        avaliable = true;
                        Console.WriteLine($"you return  the {collections[b].title} book");
                        break;
                    }
                    

                }
            if (!rebook)
            {
                Console.WriteLine($"the book allready avaliable");
            }
             
             

        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("enter the new title of book");
            book.SetTile(Console.ReadLine());
            Console.WriteLine($"the name of the book is {book.GetTitle()}");
            //=========
            Console.WriteLine("enter the name of auther ");
            book.SetAuther(Console.ReadLine());
            Console.WriteLine($"the auther of the book is {book.GetAuther()}");
           
            //=========
             
            book.SetIsnb(123456789);
            Console.WriteLine($"the isnb of the book is {book.GetIsnb()}");
            //=============
            Console.WriteLine($"the value of avaliable BEFORE return the book {book.GetBook()}");
            book.setBook(true);
            Console.WriteLine($"the value of avaliable AFTER  return the book {book.GetBook()}");
            //for each collections
            for (int i = 0; i < book.collections.Count; i++)
            {
                Console.WriteLine("===================");
                Console.WriteLine(book.collections[i].id);
                Console.WriteLine(book.collections[i].title);
                Console.WriteLine(book.collections[i].auther);
                Console.WriteLine(book.collections[i].isnb);
                Console.WriteLine(book.collections[i].avaliable);
                Console.WriteLine("==================");
            }

            //Collection collection = new Collection();
            Console.WriteLine("search for a book with title or the auther name");
            book.SearchBook(Console.ReadLine());
            Console.WriteLine("==================");
            Console.WriteLine("enter the Title&Auther&Isnb of the book ");
            book.AddBook(Console.ReadLine(), Console.ReadLine(),int.Parse(Console.ReadLine()),false);
            Console.WriteLine("================");
            for (int i = 0; i < book.collections.Count; i++)
            {
                Console.WriteLine("===================");
                Console.WriteLine(book.collections[i].id);
                Console.WriteLine(book.collections[i].title);
                Console.WriteLine(book.collections[i].auther);
                Console.WriteLine(book.collections[i].isnb);
                Console.WriteLine(book.collections[i].avaliable);
                Console.WriteLine("==================");
            }
            Console.WriteLine("Search again enter the name of the book");
            book.SearchBook(Console.ReadLine());

            //brrow
            Console.WriteLine("enter the name of the book that you need to brrow");
            book.BrrowBook(Console.ReadLine());
            //return
            Console.WriteLine("enter the isnb of the return book");
            book.ReturnBook(int.Parse(Console.ReadLine()));
        }
    }
}
