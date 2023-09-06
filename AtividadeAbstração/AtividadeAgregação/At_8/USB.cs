using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação.At_8
{
    class USB
    {
        private string Musica;

        public string musica
        {
            get
            {
                return this.Musica;
            }
            set
            {
                this.Musica = value;
            }
        }
        private string capArmazenamento;
        public string CapArmaz
        {
            get
            {
                return this.capArmazenamento;
            }
            set
            {
                this.capArmazenamento = value;
            }
        }
        public void LerMusica()
        {

            Console.WriteLine("São possíveis salvar 409 músicas de 5 MB em um pendrive de 2 GB");
            Console.WriteLine("usuário digite 5 músicas que gosta de ouvir,identificando o nome da música e o cantor");
            string Musica1 = Console.ReadLine();
            string Musica2 = Console.ReadLine();
            string Musica3 = Console.ReadLine();
            string Musica4 = Console.ReadLine();
            string Musica5 = Console.ReadLine();
            Console.WriteLine("As Informaçoes são: " + Musica1 + " " + Musica2 + " " + Musica3 + " " + Musica4 + " " + Musica5);
            Console.ReadKey();

        }

    }
}
