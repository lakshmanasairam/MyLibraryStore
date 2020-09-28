using MyLibraryStore.Data;
using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public class BookedRepository :IBookRepository
    {
        private ApplicationDbContext _dbContext = null;

        public BookedRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public BookDetails GetBookById(int id)
        {
            return _dbContext.Books.ToList().SingleOrDefault(otp => otp.Id == id);
        }

        public IEnumerable<BookDetails> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public void Dispose()
        {
            if(_dbContext!=null)
            {
                _dbContext.Dispose();
            }
        }
        public void CreateBook(BookDetails bookDetails)
        {
            if(bookDetails==null)
            {
                throw new AccessViolationException(nameof(bookDetails));
            }
            _dbContext.Books.Add(bookDetails);
            _dbContext.SaveChanges();
        }

        public void EditBook(int? id, BookDetails bookDetails)
        {
            if (id == null || bookDetails == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            var note = _dbContext.Books.SingleOrDefault(temp => temp.Id == id);
            if (note == null)
            {
                throw new NullReferenceException();
            }
            note.BookName = bookDetails.BookName;
            note.Author = bookDetails.BookName;
            note.ISBN = bookDetails.ISBN;
            note.PublishedDate = bookDetails.PublishedDate;
            note.Genre = bookDetails.Genre;
            _dbContext.SaveChanges();
        }
        public void DeleteBook(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            var notes = _dbContext.Books.FirstOrDefault(temp => temp.Id == id);
            if (notes == null)
            {
                throw new NullReferenceException();
            }
            _dbContext.Books.Remove(notes);
            _dbContext.SaveChanges();
        }
    }
}
