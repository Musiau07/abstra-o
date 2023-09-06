using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_8
{
    class DVD
    {
        private string Filme;
        public string filme
        {
            get
            {
                return this.Filme;
            }
            set
            {
                this.Filme = value;
            }
        }
        public void VerFilmes()
        {
            Console.WriteLine("Digite dois filmes que gosta de assistir, qual o gênero dos filmes e o seu ano de lançamento: ");
            string flme = Console.ReadLine();
            string filme1 = Console.ReadLine();
            string genero = Console.ReadLine();
            string lanç = Console.ReadLine();
            Console.WriteLine("As Informaçoes são: " + flme + " " + filme1 + " " + " " + genero + " " + lanç);
            Console.ReadKey();

        }

    }
}
