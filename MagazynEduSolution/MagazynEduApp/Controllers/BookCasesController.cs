using MagazynEduApp.DataAccess;
using MagazynEduApp.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MagazynEduApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookCasesController : ControllerBase
    {
        private readonly IRepository<BookCase> _bookCasesRepository;
        public BookCasesController(IRepository<BookCase> bookCaseRepository) 
        { 
            _bookCasesRepository = bookCaseRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<BookCase> GetAllBooks()
        {
            return _bookCasesRepository.GetAll();
        }

        [HttpGet]
        [Route("{bookCaseId}")]
        public BookCase GetBookCaseById(int bookCaseId) 
        {
            return _bookCasesRepository.GetById(bookCaseId);
        }
    }
}
