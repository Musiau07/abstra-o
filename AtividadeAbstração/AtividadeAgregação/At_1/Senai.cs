using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_1
{
    class Senai : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite a 1 nota do aluno de 0 a 100: ");
            double media1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Digite a 2 nota do aluno de 0 a 100: ");
            double media2 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Digite a 3 nota do aluno de 0 a 100: ");
            double media3 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Digite a 4 nota do aluno de 0 a 100: ");
            double media4 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Digite a frequencia:");
            double frequencia = Convert.ToInt32(Console.ReadLine());
            double media = media1 + media2 + media3+ media4 / 4;
            if (media >= 7 && frequencia >= 90)
            {
                Console.WriteLine("Parabens aluno aprovadono curso técnico do Senai");
            }
            else if (media <7 && frequencia >= 90)
            {
                Console.WriteLine("Você precisa fazer trabalho de recuperação");
            }
            else if (media >=7 && frequencia <90)
            {
                Console.WriteLine("aluno reprovado por faltas");
            }
            else 
            {
                 Console.WriteLine("aluno reprovado");
            }
        }
    }
}
