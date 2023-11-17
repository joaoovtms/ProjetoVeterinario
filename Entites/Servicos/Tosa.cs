using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Tosa : Servicos
    {
        public Tosa(string descServico, double preco, DateTime dataInicio, DateTime prazoFim) 
            : base(descServico, preco, dataInicio, prazoFim)
        {
        }
    }
}
