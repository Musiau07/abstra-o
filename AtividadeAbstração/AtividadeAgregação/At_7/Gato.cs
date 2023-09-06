using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_7
{
     class Gato:Animal
    {
        private string CorPelo;

        public string Pelo
        {
            get
            { 
                return CorPelo;
            }
            set
            { 
                CorPelo = value;
            }
        }
    }
}
