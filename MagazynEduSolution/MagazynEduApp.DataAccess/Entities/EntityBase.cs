using System.ComponentModel.DataAnnotations;

namespace MagazynEduApp.DataAccess.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
