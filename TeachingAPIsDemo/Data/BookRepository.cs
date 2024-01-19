using TeachingAPIsDemo.Models;
using static TeachingAPIsDemo.Data.BookDatabase;

namespace TeachingAPIsDemo.Data
{
    public class BookRepository
    {
        public static Book UpdateBook(int id, Book updatedBook)
        {
            var bookToUpdate = Books.Where(x => x.Id == id).FirstOrDefault();

            bookToUpdate.Title = updatedBook.Title;
            bookToUpdate.Description = updatedBook.Description;
            bookToUpdate.Author = updatedBook.Author;
            bookToUpdate.CreatedDate = updatedBook.CreatedDate;
            bookToUpdate.Genre = updatedBook.Genre;

            ReplaceBookInList(bookToUpdate);

            return bookToUpdate;
        }

        private static void ReplaceBookInList(Book book)
        {
            var index = Books.IndexOf(book);

            Books.RemoveAt(index);
            Books.Insert(index, book);
        }
    }
}
