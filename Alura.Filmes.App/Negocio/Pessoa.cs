

namespace Alura.Filmes.App.Negocio
{
    public class Pessoa
    {
        public byte Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public override string ToString()
        {
            var tipo = this.GetType().Name;
            return $"{tipo} ({Id}) " +
                   $"\nNome: {PrimeiroNome} {UltimoNome}" +
                   $"\nEmail: {Email}" +
                   $"\nSituacao: {Ativo}" +
                   $"\n------------------" +
                   $"\n";
        }
    }
}
