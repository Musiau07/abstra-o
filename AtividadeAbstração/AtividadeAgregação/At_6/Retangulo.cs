using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_6
{
     class Retangulo:Formula
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Digite a base do retangulo: ");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura do retangulo:  ");
            int alt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("As informações são da base: " + Base + " e altura " + alt);

            int result = Base * alt;
            Console.WriteLine(result);
        }
    }
}
