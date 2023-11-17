using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Pessoas
    {
        public int ID { get; set; } = 1;
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }

        public Pessoas(string nome, int idade, DateTime dataNascimento, string cPF)
        {
            Nome = nome;
            Idade = idade;
            DataNascimento = dataNascimento;
            CPF = cPF;
            ID += 1;
        }
    }
}
