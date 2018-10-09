using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CasaDoCodigo
{
    public partial class Startup
    {
        class DataService : IDataService
        {
            private readonly ApplicationContext contexto;
            private readonly IProdutoRepository produtoRepository;

            public DataService(ApplicationContext contexto, IProdutoRepository produtoRepository)
            {
                this.contexto = contexto;
                this.produtoRepository = produtoRepository;
            }
            public void InicializarDB()
            {
                contexto.Database.EnsureCreated();
                List<Livro> livros = GetLivros();

                produtoRepository.SaveProdutos(livros);
            }            

            private static List<Livro> GetLivros()
            {
                var json = File.ReadAllText("livros.json");
                var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
                return livros;
            }
        }

        public class Livro
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public Decimal Preco { get; set; }
        }
    }
}
