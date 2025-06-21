namespace SenaiAPI.DTos
{
    public class EscolaDTo
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public EnderecoDTo? Endereco { get; set; }
    }
}