using System.ComponentModel.DataAnnotations;

namespace SenaiAPI.DTos
{
    public class ProfessorEdicaoDTo
    {
        public class Professor
        {
            public long Id { get; set; }
            [Required]
            [MaxLength(60)]
            public string Nome { get; set; }
            public long EscolaId { get; set; }
        }
    }
}