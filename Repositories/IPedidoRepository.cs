using CasaDoCodigo.Models;
using System.Collections.Generic;
using static CasaDoCodigo.Startup;

namespace CasaDoCodigo.Repositories
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }
}