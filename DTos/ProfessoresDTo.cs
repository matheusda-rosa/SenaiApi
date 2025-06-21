using SenaiAPI.Entidades;
using System.ComponentModel.DataAnnotations;

namespace SenaiAPI.DTos
{
    public class ProfessorDTo
    {
        public class Professor
        {
            [Required]
            [MaxLength(60)]
            public string Nome { get; set; }
            public long EscolaId { get; set; }
        }
    }
}
