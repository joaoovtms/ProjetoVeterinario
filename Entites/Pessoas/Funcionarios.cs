using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Funcionarios : Pessoas
    {
        public Funcionarios(string nome, int idade, DateTime dataNascimento, string cPF) 
            : base(nome, idade, dataNascimento, cPF)
        {
        }
    }
}
