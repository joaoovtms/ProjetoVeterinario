using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Servicos
    {
        public string DescServico { get; set; }
        public double Preco { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime PrazoFim { get; set; }

        public Servicos(string descServico, double preco, DateTime dataInicio, DateTime prazoFim)
        {
            DescServico = descServico;
            Preco = preco;
            DataInicio = dataInicio;
            PrazoFim = prazoFim;
        }
    }
}
