﻿using CasaDoCodigo.Models;
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

            public DataService(ApplicationContext contexto)
            {
                this.contexto = contexto;
            }
            public void InicializarDB()
            {
                contexto.Database.EnsureCreated();
                var json = File.ReadAllText("livros.json");
                var livros=JsonConvert.DeserializeObject<List<Livro>>(json);

                foreach (var livro in livros)
                {
                    contexto.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));

                }
                contexto.SaveChanges();
            }
        }

        class Livro
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public Decimal Preco { get; set; }
        }
    }
}
