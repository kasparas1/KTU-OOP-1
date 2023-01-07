using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kd1
{

    class BookRegister
    {
        private List<Book> AllBooks;
        public BookRegister()
        {
            AllBooks = new List<Book>();
        }
        public BookRegister(List<Book> Book)
        {
            AllBooks = new List<Book>();
            foreach (Book book in Book)
                this.AllBooks.Add(book);
        }
       public void AddBook(Book book)
        {
            AllBooks.Add(book);
        }
        public Book GetBook(int index)
        {
            return AllBooks[index];
        }
        public int Count()
        {
            return this.AllBooks.Count();
        }
            
            
           
            
    }
}
