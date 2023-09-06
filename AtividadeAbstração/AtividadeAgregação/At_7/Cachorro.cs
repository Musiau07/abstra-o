using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_7
{
    class Cachorro:Animal
    {
        private string Raca;

        public string Tipo
        {
            get
            {
                return Raca;
            }
            set
            {
                Raca = value;
            }
        }
    }
}
