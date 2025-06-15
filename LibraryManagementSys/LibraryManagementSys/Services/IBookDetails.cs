using LibraryManagementSys.Models;
using DTO;

namespace LibraryManagementSys.Services
{
    public interface IBookDetails
    {
        Task<BookDto> BookDetails_Get(int id);
        Task<Book> BookDetails_Update(int id);
        Task<Book> BookDetails_Delete(int id);
        Task<Book> BookDetails_Insert(string id);
        bool isDeleted(int id); 

    }
}
