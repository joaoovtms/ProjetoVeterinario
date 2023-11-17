using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Cliente : Pessoas
    {
        public Cliente(string nome, int idade, DateTime dataNascimento, string cPF) 
            : base(nome, idade, dataNascimento, cPF)
        {

        }
    }
}
