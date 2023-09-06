using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_6
{
     class Losango:Formula
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Digite o lado do losango: ");
            int lado=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura do losango:  ");
            int alt=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("As informações são do lado: " + lado + " e altura " + alt);

            int result=lado*alt;
            Console.WriteLine(result);
        }

    }
}
