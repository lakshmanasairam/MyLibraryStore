using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLibraryStore.Models;

namespace MyLibraryStore.Repository
{
    public interface IBookRepository
    {
        IEnumerable<BookDetails> GetBooks();
        BookDetails GetBookById(int id);

        void CreateBook(BookDetails bookDetails);

        void EditBook(int? id, BookDetails bookDetails);

        void DeleteBook(int? id);
    }
}
