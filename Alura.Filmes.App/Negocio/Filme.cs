﻿
using Alura.Filmes.App.Extensions;
using System.Collections;
using System.Collections.Generic;

namespace Alura.Filmes.App.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Anolancamento { get; set; }
        public short Duracao { get; set; }
        public string TextoClassificacao { get; private set; }
        public IList<FilmeAtor> Atores { get; set; }
        public Idioma IdiomaFalado { get; set; }
        public Idioma IdiomaOriginal { get; set; }
        public ClassificacaoIndicativa Classificacao
        {
            get { return TextoClassificacao.ParaValor(); }
            set { TextoClassificacao = value.ParaString(); }
        }
        public Filme()
        { 
            Atores = new List<FilmeAtor>();
        }
        public override string ToString()
        {
            return $"Filme ({Id}) - {Titulo} \t Lançado em {Anolancamento}";
        }
    }
}
