using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Gato : Animais
    {
        public Gato(string nome, int idade, string porte) 
            : base(nome, idade, porte)
        {
        }
    }
}
