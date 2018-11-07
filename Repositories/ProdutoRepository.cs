using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CasaDoCodigo.Startup;

namespace CasaDoCodigo.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext contexto;
        private readonly IProdutoRepository produtoRepository;

<<<<<<< HEAD
        public ProdutoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            
        }

        public IList<Produto> GetProdutos()
        {
            return contexto.Set<Produto>().ToList();
=======
        public ProdutoRepository(ApplicationContext contexto, IProdutoRepository  produtoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
>>>>>>> 948217f97326ed93ba20b7e42616bcff108f6598
        }

        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
                contexto.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
<<<<<<< HEAD
=======

>>>>>>> 948217f97326ed93ba20b7e42616bcff108f6598
            }
            contexto.SaveChanges();
        }
    }
}
