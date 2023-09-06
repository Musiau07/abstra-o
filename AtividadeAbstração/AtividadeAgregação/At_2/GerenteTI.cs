using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_2
{
     class GerenteTI:Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("digite a quantidade de horas extras feitas no mês corrente: ");
            double qtd = Convert.ToDouble(Console.ReadLine());

            double hr= qtd/2;

            if(qtd>100)
            {
                double result=(qtd/2)*100+500;
                double dias = result / 8;
                Console.WriteLine("o total por horas extras sera:  " + result + " o total por dias sera: " + dias);
            }
            else
            {
                double result= qtd*400;
                Console.WriteLine("o total de horas recebidas sera: " + result);
            }
        }
    }
}
