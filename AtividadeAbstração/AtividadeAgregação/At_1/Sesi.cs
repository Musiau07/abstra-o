using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_1
{
     class Sesi:Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite a 1 nota do aluno: ");
            double media1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Digite a 2 nota do aluno: ");
            double media2 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Digite a 3 nota do aluno: ");
            double media3 = Convert.ToUInt32(Console.ReadLine());
            double media = media1 + media2 + media3 / 3;
            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (media >= 5)
            {
                Console.WriteLine("Aluno em recuperação");
            }
            else
            {
                Console.WriteLine("aluno reprovado");
            }
        }
    }
}
