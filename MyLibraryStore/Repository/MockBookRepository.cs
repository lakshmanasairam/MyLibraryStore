using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLibraryStore.Models;

namespace MyLibraryStore.Repository
{
    public class MockBookRepository:IBookRepository
    {
        public void CreateBook(BookDetails bookDetails)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int? id)
        {
            throw new NotImplementedException();
        }

        public void EditBook(int? id, BookDetails bookDetails)
        {
            throw new NotImplementedException();
        }

        public BookDetails GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<BookDetails>GetBooks()
        {
            return new List<BookDetails>
            {
                new BookDetails{Id=1,BookName="2 states",Author="Chethan Bagat",ISBN="Is45612",PublishedDate=Convert.ToDateTime("05/05/2014")},
                new BookDetails{Id=3,BookName="Here There Every where",Author="Sudhamurthy",ISBN="Is45613",PublishedDate=Convert.ToDateTime("05/05/2014")},
                new BookDetails{Id=2,BookName="Apana time ayaga",Author="Chethan Bagat",ISBN="Is453211",PublishedDate=Convert.ToDateTime("05/05/2012")}
            };
        }
    }
}
