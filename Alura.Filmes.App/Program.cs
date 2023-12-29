using Forms_Ver01.App.Dados;
using Forms_Ver01.App.Extensions;
namespace Alura.Filmes.App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (var contexto = new CodigosContexto())
            {
                contexto.LogSQLToConsole();

                #region Codigo de envio de comando SQL direto ao BD
                //var sql = "INSERT INTO language (name) VALUES ('Teste 1'), ('Teste 2'), ('Teste 3')";
                //var registros = contexto.Database.ExecuteSqlCommand(sql);
                //Console.WriteLine($"O total de registros afetados foi de: {registros}");

                //var deletesql = "DELETE FROM language WHERE name LIKE 'Teste%'";
                //registros = contexto.Database.ExecuteSqlCommand(deletesql);
                //Console.WriteLine($"O total de registros afetados foi de: {registros}");
                #endregion

                #region Query usando Stored procedure
                //var categ = "Action";
                //var paramCateg = new SqlParameter("category_name", categ);
                //var paramTotal = new SqlParameter
                //{
                //    ParameterName = "@total_actors",
                //    Size = 4,
                //    Direction = System.Data.ParameterDirection.Output
                //};
                //contexto.Database
                //    .ExecuteSqlCommand("total_actors_from_given_category @category_name, @total_actors OUT", paramCateg, paramTotal);

                //Console.WriteLine($"O total de atores na categoria {categ} e de: {paramTotal.Value}");
                #endregion

                #region Query e listagem dos 5 mais atuantes atores presentes no BD
                //var atoresMaisAtuantes = contexto.Atores
                //    .Include(a => a.Filmografia)
                //    .OrderByDescending(a => a.Filmografia.Count)
                //    .Take(5);

                //foreach(var ator in atoresMaisAtuantes)
                //{
                //    Console.WriteLine($"O Ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmografia.Count}");
                //}
                #endregion

                #region Listando registros usando herancas entre classes (Pessoa-->Cliente e Funcionario)
                //Console.WriteLine("Clientes----------------------------------");
                //foreach (var cliente in contexto.Clientes)
                //{
                //    Console.WriteLine(cliente);
                //}
                //Console.WriteLine("Funcionarios------------------------------");
                //foreach (var funcionario in contexto.Funcionarios)
                //{
                //    Console.WriteLine(funcionario);
                //}
                #endregion

                #region Teste de inclusao de instancia em BD com uso da conversao da tabela de Classificacao
                //var filme = new Filme();
                //filme.Titulo = "Cassino Royale";
                //filme.Duracao = 130;
                //filme.Anolancamento = "2005";
                //filme.Classificacao = ClassificacaoIndicativa.MaioresQue14;
                //filme.IdiomaFalado = contexto.Idiomas.First();
                //contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;
                //contexto.Filme.Add(filme);
                //contexto.SaveChanges();

                //var filmeinserido = contexto.Filme.First(f => f.Titulo == "Cassino Royale");
                //Console.WriteLine(filmeinserido.Classificacao);
                #endregion

                #region Exemplo de conversao entre as Classificacoes
                //var indicacao = ClassificacaoIndicativa.MaioresQue14;
                //Console.WriteLine(indicacao.ParaString());
                //Console.WriteLine("G".ParaValor());
                #endregion

                #region Este codigo corrige o abaixo, pois usa as restricoes
                //var filme = new Filme();
                //filme.Titulo = "Senhor dos Aneis";
                //filme.Duracao = 120;
                //filme.Anolancamento = "2000";
                //filme.Classificacao = ClassificacaoIndicativa.MaioresQue10;
                //filme.IdiomaFalado = contexto.Idiomas.First();
                //contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;
                //contexto.Filme.Add(filme);
                //contexto.SaveChanges();
                #endregion

                #region Este codigo provoca excecao, pois há restrição na atribuicao de Classificacao
                //var filme = new Filme();
                //filme.Titulo = "Senhor dos Aneis";
                //filme.Duracao = 120;
                //filme.Anolancamento = "2000";
                //filme.Classificacao = "aleatorio";
                //filme.IdiomaFalado = contexto.Idiomas.First();
                //contexto.Entry(filme).Property("last_update").CurrentValue=DateTime.Now;
                //contexto.Filme.Add(filme);
                //contexto.SaveChanges();
                #endregion

                #region Este codigo provoca excecao, pois há restricao de duplicidade, definido em Indexes
                //var ator1 = new Ator { PrimeiroNome = "Emma", UltimoNome = "Watson" };
                //var ator2 = new Ator { PrimeiroNome = "Emma", UltimoNome = "Watson" };
                //contexto.Atores.AddRange(ator1, ator2);
                //contexto.SaveChanges();

                //var emmaWatson = contexto.Atores
                //    .Where(a => a.PrimeiroNome == "Emma" && a.UltimoNome == "Watson");
                //Console.WriteLine($"Total de atores encontrados:{emmaWatson.Count()}");
                #endregion

                #region Query e listagem de filmes por idiomas falados(dublados)
                //var idiomas = contexto.Idiomas
                //    .Include(i => i.FilmesFalados);

                //foreach (var idioma in idiomas)
                //{
                //    Console.WriteLine(idioma);
                //    foreach(var falados in idioma.FilmesFalados)
                //    {
                //        Console.WriteLine(falados);
                //    }
                //    Console.WriteLine("\n");
                //}
                #endregion

                #region Query e listagem de elenco por filme

                //var filme = contexto.Filme
                //    .Include(f => f.Atores)
                //    .ThenInclude(fa => fa.Ator)
                //    .First(a => a.Id == 10);

                //Console.WriteLine("-----------------------");
                //Console.WriteLine($"{filme} \nDescrição {filme.Descricao}");
                //Console.WriteLine("-----------------------");
                //Console.WriteLine("Elenco: ");
                //foreach (var ator in filme.Atores)
                //{
                //    Console.WriteLine(ator.Ator);
                //}
                #endregion

                #region Listagem de todo conteúdo da tabela FilmeAtor (tabela de Join)
                //foreach (var item in contexto.Elenco)
                //{
                //    var entidade = contexto.Entry(item);
                //    var filmId = entidade.Property("film_id").CurrentValue;
                //    var actorId = entidade.Property("actor_id").CurrentValue;
                //    var lastUpdate = entidade.Property("last_update").CurrentValue;

                //    Console.WriteLine($"Filme {filmId} - Ator {actorId} - Última alteração {lastUpdate}");
                //}
                #endregion

                #region Query para os 10 atores modificados recentemente
                //var atores = contexto.Atores
                //    .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                //    .Take(10);
                //foreach (var a in atores)
                //{
                //    Console.WriteLine(a+" - "+contexto.Entry(a).Property("last_update").CurrentValue);
                //}
                #endregion
            }
        }
    }
}