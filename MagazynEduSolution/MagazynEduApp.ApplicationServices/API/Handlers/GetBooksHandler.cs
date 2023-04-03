using MagazynEduApp.ApplicationServices.API.Domain;
using MediatR;
using MagazynEduApp.DataAccess;
using MagazynEduApp.ApplicationServices.API.Domain.Models;
using MagazynEduApp.DataAccess.Entities;

namespace MagazynEduApp.ApplicationServices.API.Handlers
{
    public class GetBooksHandler : IRequestHandler<GetBooksRequest, GetBooksResponse>
    {
        private readonly IRepository<DataAccess.Entities.Book> _booksRepository;
        public GetBooksHandler(IRepository<DataAccess.Entities.Book> booksRepository) 
        {
            _booksRepository = booksRepository;
        }

        public Task<GetBooksResponse> Handle(GetBooksRequest request, CancellationToken cancellationToken)
        {
            var books = _booksRepository.GetAll();
            var domainBooks = new List<Domain.Models.Book>();

            var domainbooks = books
              .Select(book => new Domain.Models.Book()
              {
                  Id = book.Id,
                  Title = book.Title
              })
              .ToList();

            var response = new GetBooksResponse()
            {
                Data = domainBooks
            };

            return Task.FromResult(response);
        }
    }
}
