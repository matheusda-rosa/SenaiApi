﻿using SenaiAPI.Entidades;
using System.ComponentModel.DataAnnotations;

namespace SenaiAPI.DTos
{
    public class EnderecoDTo
    {
        public long Id { get; set; }

        [MaxLength(80)]
        public string Rua { get; set; }

        [MaxLength(50)]
        public string Bairro { get; set; }


        public int Cidade { get; set; }

        [MaxLength(2)]
        public string Estado { get; set; }
        public int Numero { get; set; }
        public long EscolaId { get; set; }
    }
}
