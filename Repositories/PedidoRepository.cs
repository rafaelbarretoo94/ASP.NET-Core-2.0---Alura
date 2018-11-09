using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>
    {
        public PedidoRepository(ApplicationContext contexto) : base(contexto)
        {

        }
    }
}
