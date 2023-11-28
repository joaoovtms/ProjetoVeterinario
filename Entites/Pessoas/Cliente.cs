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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            sb.Append("Nome: ");
            sb.AppendLine(Nome);
            sb.Append("Idade: ");
            sb.AppendLine(Idade.ToString());
            sb.Append("Data de Nascimento: ");
            sb.AppendLine(DataNascimento.ToString("dd/MM/yyyy"));
            sb.Append("CPF: ");
            sb.AppendLine(CPF);
            sb.AppendLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            return sb.ToString();
        }
    }
}
