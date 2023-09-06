using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_2
{
   class Bancario:Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("digite a quantidade de horas extras feitas no mês corrente: ");
            double qtd=Convert.ToDouble(Console.ReadLine());   
            
            double resultado=qtd*250;

            if(qtd>500)
            {
                double resulltado2 = resultado * 0.1;
                Console.WriteLine("O novo valor a ser recebido pelas hr extras: ");
            }
            else if (qtd>1000)
            {
                double resulltado3 = resultado * 0.15;
                Console.WriteLine("O novo valor a ser recebido pelas hr extras: ");
            }
            else 
            { 
                Console.WriteLine("O valor final a ser recebido sera: "+resultado);
            }


        }

    }
}
