using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_3
{
     class Projeto:Estudante
    {
        public int DataDoProjeto { get; set; }
       
        public void EscolherProfissao() 
        {
            Console.WriteLine("Qual profissão gostaria de escolher?");
            string prof=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Qual faculdade gostaria de cursar?");
            string facul=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Citar 3 coisas que gostaria de estar fazendo daqui a 5 anos?");
            string citar=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Quais são as suas expectativas quando finalizar o ensino médio?");
            string expec=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Citar 3 características de quais são os seus projetos para o futuro?");
            string caract=Convert.ToString(Console.ReadLine());
            Console.WriteLine("As suas escolhas foram para profissão: " + prof + "a sua faculdade " + facul + "o que gostaria daqui a 5 anos " + citar + "as suas expectativas foram: " + expec + "os seus projetos foram: " + caract);
        }

    }
}
