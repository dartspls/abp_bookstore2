using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class BookAppService :
        CrudAppService<
            Book, // Book entity
            BookDto, // To show books
            Guid, // Primary key of the book entity
            PagedAndSortedResultRequestDto, // Paging and sorting
            CreateUpdateBookDto>, // Create/update
        IBookAppService // Implement the interface we created
    {
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {

        }
    }
}
