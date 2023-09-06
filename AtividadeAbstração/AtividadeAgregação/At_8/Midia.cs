using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_8
{
    class Midia
    {
        private int codigo;
        private double preco;
        private string nome;

        public int cd
        {
            get
            {
                return this.codigo;
            }
            set 
            { 
               this.codigo = value;
            }
        }
        public double pc
        { 
            get
            {
                return this.preco;
            } 
            set
            {
                this.preco = value;
            } 
        }

        public string nom
        {
            get
            { 
                return this.nome;
            }
            set 
            {  
                this.nome = value;
            }
        }

         public virtual void ImprimirDados()
        {
            Console.WriteLine("Digite o nome do cantor favorito: ");
            string can=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o nome da musica: ");
            string ms=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o ano de lançamento: ");
            int ano= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O cantor favorito é: " + can);
            Console.WriteLine("O nome da musica é: " + ms);
            Console.WriteLine("O ano de lançamento foi: " + ano);
        }

    }
}
