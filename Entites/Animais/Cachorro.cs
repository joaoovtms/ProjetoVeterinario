using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Cachorro : Animais
    {
        public Cachorro(string nome, int idade, string porte) 
            : base(nome, idade, porte)
        {
        }
    }
}
