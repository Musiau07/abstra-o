using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_2
{
     class Desenvolvedor: Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a sua modalidade de trabalho, sendo: A - Presencial, B - Hibrido e C - Remoto");
            string modalidade = Convert.ToString(Console.ReadLine());

            if(modalidade== "A")
            {
                Console.WriteLine("Digite a sua horas trabalhadas: ");
                double qtd=Convert.ToDouble(Console.ReadLine());
                double resultado=qtd*100;
                Console.WriteLine("O total de horas a receber é´: " + resultado);
            }
            else if(modalidade== "B")
            {
                Console.WriteLine("Digite a sua horas trabalhadas: ");
                double qtd = Convert.ToDouble(Console.ReadLine());
                double resultado = qtd * 50;
                Console.WriteLine("O total de horas a receber é´: " + resultado);
            }
            else if (modalidade== "C")
            {
                Console.WriteLine("O seu horário é flexível, ou seja, você escolhe seu horário de trabalho, então não contempla horas extras");
            }
            else 
            { 
                Console.WriteLine("Você digitou uma opção inválida");
            }
        }
    }
}
