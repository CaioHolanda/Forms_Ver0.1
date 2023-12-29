using System.Collections;
using System.Collections.Generic;

namespace Forms_Ver01.App.Negocio
{
    public class Codigos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Codigo { get; set; }
        public override string ToString()
        {
            return $"Servico ({Id}) - {Nome} \n\tNome usuario: {Usuario}\n\tCodigo: {Codigo}";
        }
    }
}
