using System.ComponentModel.DataAnnotations;

namespace SenaiAPI.Entidades
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
