using System.ComponentModel.DataAnnotations;

namespace MagazynEduApp.DataAccess.Entities
{
    public class Book : EntityBase
    {
        public int BookCaseId { get; set; }

        public BookCase BookCase { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }
        public List<Author> Authors { get; set; }
    }
}