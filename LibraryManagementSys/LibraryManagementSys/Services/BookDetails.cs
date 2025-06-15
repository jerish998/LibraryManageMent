using LibraryManagementSys.Models;
using DTO;
using LibraryManagementSys.DbContextApp;

namespace LibraryManagementSys.Services
{
    public class BookDetails : IBookDetails
    {
        private readonly DbConnectionAppContext _db_connection_app;
        public Task<Book> BookDetails_Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async List<BookDto> BookDetails_Get(int book_id)
        {
            var book = new Book();
            var book_details = await _db_connection_app.FindAsync<BookDto>(book_id);
             return book_details;
        }

        public Task<Book> BookDetails_Insert(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> BookDetails_Update(int id)
        {
            throw new NotImplementedException();
        }

        public bool isDeleted(int id)
        {
            throw new NotImplementedException();
        }
    }
}
