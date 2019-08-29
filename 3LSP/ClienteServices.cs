using System.Collections.Generic;
using System.Linq;

namespace _3LSP
{
    public class ClienteService
    {
        public IEnumerable<Cliente> clientes = new List<Cliente>{
            new ClienteOuro{ValorTotal = 1000},
            new ClientePrata{ValorTotal = 500}
        };

        public double SomaTodos()
        {
            var valor = clientes.Select(x => x.Desconto()).Sum();
            return valor;
        }
    }
}