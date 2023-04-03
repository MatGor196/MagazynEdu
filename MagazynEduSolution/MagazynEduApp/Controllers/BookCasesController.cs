using MagazynEduApp.DataAccess;
using MagazynEduApp.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MagazynEduApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookCasesController : ControllerBase
    {
        private readonly IRepository<BookCase> _bookCaseRepository;
        public BookCasesController(IRepository<BookCase> bookCaseRepository) 
        { 
            _bookCaseRepository = bookCaseRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<BookCase> GetAllBooks()
        {
            return _bookCaseRepository.GetAll();
        }

        [HttpGet]
        [Route("{bookCaseId}")]
        public BookCase GetBookCaseById(int bookCaseId) 
        {
            return _bookCaseRepository.GetById(bookCaseId);
        }
    }
}
