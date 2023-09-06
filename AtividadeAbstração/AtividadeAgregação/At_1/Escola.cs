using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_1
{
     abstract class Escola
    {
        public abstract void CalcularMedia();

        public void DescobrirNome() 
        {
            Console.WriteLine("Digite o nome da sua escola:");
            string escola = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o nome da sua cidade:");
            string cidade = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o nome do seu estado:");
            string estado = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite a sua serie:");
            string serie= Convert.ToString(Console.ReadLine());
            if (escola == "SENAI" && escola == "SESI" && cidade =="Garça"  )
            {
                Console.WriteLine("Aluno do curso SESI/SENAI");
            }
            else
            {
                Console.WriteLine("O aluno é da escola: "+ escola+"e a sua cidade: "+cidade);
            }
           
        }
    }
}
