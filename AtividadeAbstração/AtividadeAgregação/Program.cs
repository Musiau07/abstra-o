using AtividadeAgregação.At_1;
using AtividadeAgregação.At_2;
using AtividadeAgregação.At_3;
using AtividadeAgregação.At_4;
using AtividadeAgregação.At_5;
using AtividadeAgregação.At_6;
using AtividadeAgregação.At_7;
using AtividadeAgregação.At_8;
using AtividadeAgregação.At_9;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgregação
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //Escola escola = new Escola();
            //escola.DescobrirNome();
            //Sesi sesi = new Sesi();
            //sesi.CalcularMedia();
            //Senai senai = new Senai();
            //senai.CalcularMedia();

            //Exercicio 2
            //Desenvolvedor desenvolvedor = new Desenvolvedor();
            //desenvolvedor.CalcularHorasExtras();
            //Bancario bancario = new Bancario();
            //bancario.CalcularHorasExtras();
            //GerenteTI gerente = new GerenteTI();
            //gerente.CalcularHorasExtras();

            //Exercicio 3
            //Estudante estudante = new Estudante();
            //Projeto projeto = new Projeto();
            //projeto.EscolherProfissao();

            //Exercicio 4
            //DigitarInformacoes();

            //Exercicio 5
            //Definir();
            //Json();

            //Exercicio 6
            //Losango losango = new Losango();
            //losango.CalcularArea();
            //Retangulo retangulo = new Retangulo();
            //retangulo.CalcularArea();
            //Console.WriteLine(retangulo);


            //Exercicio 7
            //Animal();

            //Exercicio 8
            //Midia midia = new Midia();
            //midia.ImprimirDados();

            //DVD dvd = new DVD();
            //dvd.VerFilmes();

            //USB usb = new USB();
            //usb.LerMusica();
          
            //Exercicio 9
            //ContaBancaria();
            Console.ReadKey();

        }
        //Exercicio 4
        //public static void DigitarInformacoes()
        //{
        //    Programador programador = new Programador();
        //    programador.programador();

        //    Console.WriteLine("Digite as informações: ");
        //    string nome=Console.ReadLine();
        //    int idade=Convert.ToInt32(Console.ReadLine());
        //    string cidade=Console.ReadLine();
        //    string rg=Console.ReadLine();
        //    int area=Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("suas informações: "+nome+" "+idade+" "+cidade+" "+rg+" "+area);
        //    string stringjson=JsonConvert.SerializeObject(programador,Formatting.Indented);
        //    File.WriteAllText("text.json", stringjson);
        //}

        //Exercicio 5
        //    public static void Definir()
        //    {
        //        Empresario empresario = new Empresario();
        //        empresario.Nome = "mariana";
        //        empresario.Endereco = "carlos ferrari";
        //        empresario.CNPJ = "514.184.187.87";
        //        empresario.nomeEmpresa = "bigmart";
        //        empresario.Cidade = "garça";
        //    }
        //    public static void Json()
        //    {
        //        Empresario empresario1 = new Empresario();
        //        empresario1.Nome = "alan";
        //        empresario1.Endereco = "zapata";
        //        empresario1.CNPJ = "123.495.009.14";
        //        empresario1.nomeEmpresa = "galvão";
        //        empresario1.Cidade = "garça";
        //        Console.WriteLine(empresario1.Nome);
        //        Console.WriteLine(empresario1.Endereco);
        //        Console.WriteLine(empresario1.CNPJ);
        //        Console.WriteLine(empresario1.nomeEmpresa);
        //        Console.WriteLine(empresario1.Cidade);

        //        Empresario empresario2 = new Empresario();
        //        empresario2.Nome = "bianca";
        //        empresario2.Endereco = "nelly";
        //        empresario2.CNPJ = "154.894.198.41";
        //        empresario2.nomeEmpresa = "escola";
        //        empresario2.Cidade = "garça";
        //        Console.WriteLine(empresario2.Nome);
        //        Console.WriteLine(empresario2.Endereco);
        //        Console.WriteLine(empresario2.CNPJ);
        //        Console.WriteLine(empresario2.nomeEmpresa);
        //        Console.WriteLine(empresario2.Cidade);

        //        Empresario empresario3 = new Empresario();
        //        empresario3.Nome = "igor";
        //        empresario3.Endereco = "aurelio";
        //        empresario3.CNPJ = "156.461.891.71";
        //        empresario3.nomeEmpresa = "bazar";
        //        empresario3.Cidade = "garça";
        //        Console.WriteLine(empresario3.Nome);
        //        Console.WriteLine(empresario3.Endereco);
        //        Console.WriteLine(empresario3.CNPJ);
        //        Console.WriteLine(empresario3.nomeEmpresa);
        //        Console.WriteLine(empresario3.Cidade);

        //        Empresario empresario4 = new Empresario();
        //        empresario4.Nome = "clara";
        //        empresario4.Endereco = "campo belo";
        //        empresario4.CNPJ = "657.411.987.41";
        //        empresario4.nomeEmpresa = "batista";
        //        empresario4.Cidade = "garça";
        //        Console.WriteLine(empresario4.Nome);
        //        Console.WriteLine(empresario4.Endereco);
        //        Console.WriteLine(empresario4.CNPJ);
        //        Console.WriteLine(empresario4.nomeEmpresa);
        //        Console.WriteLine(empresario4.Cidade);

        //        string stringjson1 = JsonConvert.SerializeObject(empresario1, Newtonsoft.Json.Formatting.Indented);
        //        string stringjson2 = JsonConvert.SerializeObject(empresario2, Newtonsoft.Json.Formatting.Indented);
        //        string stringjson3 = JsonConvert.SerializeObject(empresario3, Newtonsoft.Json.Formatting.Indented);
        //        string stringjson4 = JsonConvert.SerializeObject(empresario4, Newtonsoft.Json.Formatting.Indented);

        //        File.WriteAllText("text.json", stringjson1 + stringjson2 + stringjson3 + stringjson4);
        //    }

        //}

        //Exercicio 7
        //public static void Animal()
        //{
        //    Animal animal = new Animal();
        //    animal.nome = "laila";
        //    animal.idade = 3;

        //    Gato gato = new Gato();
        //    gato.nome = "chico";
        //    gato.idade = 4;
        //    gato.Pelo = "azul";

        //    Cachorro cachorro = new Cachorro();
        //    cachorro.nome = "thor";
        //    cachorro.idade = 5;
        //    cachorro.Tipo = "labrador";

        //    string stringJson=JsonConvert.SerializeObject(animal,Formatting.Indented);

        //    File.WriteAllText("animal.Json", stringJson);
        //}

        //Exercicio 9
        //public static void ContaBancaria() 
        //{
        //    Console.WriteLine("Digite o valor que gostaria de depostar na conta");
        //    double valorDp = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Digite o valor de saque que gostaria de efetuar");
        //    double valorSq = Convert.ToDouble(Console.ReadLine());

        //    ContaBancaria contaBancaria = new ContaBancaria();
        //    contaBancaria.Depositar(valorDp);
        //    contaBancaria.Sacar(valorSq);
        //    contaBancaria.Saldo = valorDp;
        //    }

    }
}
