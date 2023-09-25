using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    public class Funcionalidades
    {

        public void ApresentarRead()
        {
            inicio:
            Console.WriteLine("Olá, seja bem-vindo à biblioteca Prover!");
            Console.WriteLine("Digite uma das opções para realizar o que desejas!");
            Console.WriteLine("1- Cadastrar" + "\n2- Emprestar" + "\n3- Devolver");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Cadastrar();
                    Voltar();
                        break;
                case "2":
                    Console.Clear();
                    Emprestar();
                    Voltar();
                    break;
                case "3":
                    Console.Clear();
                    Devolver();
                    Voltar();
                    break;
                default:
                    while(option != "1" || option != "2" || option != "3")
                    {
                        Console.Clear();
                        VoltarRED();
                        goto inicio;
                    }

                        break;
            }
        }

        public void VoltarRED()
        {
        inici:
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite uma das opções corretamente para realizar o que desejas!");
            Console.ResetColor();
            Console.WriteLine("1- Cadastrar" + "\n2- Emprestar" + "\n3- Devolver");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Cadastrar();
                    break;
                case "2":
                    Console.Clear();
                    Emprestar();
                    break;
                case "3":
                    Console.Clear();
                    Devolver();
                    break;
                default:
                    while (option != "1" || option != "2" || option != "3")
                    {
                        Console.Clear();
                        goto inici;
                    }

                    break;

            }
        }

        public void Voltar()
        {
        inici:
            Console.Clear();
            Console.WriteLine("Digite uma das opções para realizar o que desejas!");
            Console.WriteLine("1- Cadastrar" + "\n2- Emprestar" + "\n3- Devolver");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Cadastrar();
                    break;
                case "2":
                    Console.Clear();
                    Emprestar();
                    break;
                case "3":
                    Console.Clear();
                    Devolver();
                    break;
                default:
                    while (option != "1" || option != "2" || option != "3")
                    {
                        Console.Clear();
                        VoltarRED();
                        goto inici;
                    }

                    break;

            }
        }

        public void Cadastrar()
        {
            Console.WriteLine("Para realizar o cadastro, digite as seguintes informações" + "\nTítulo: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Nome do autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Número de páginas: ");
            string pagina = Console.ReadLine();
            Console.WriteLine("Seu livro " + titulo + " do autor " + autor + " de " + pagina + " páginas" + " acaba de ser cadastrado!");
            Console.ReadLine();
            Console.WriteLine("Tecle enter para retornar ao menu!");
            Console.ReadKey();


        }

        public void Emprestar()
        {
            Console.WriteLine();


            Console.WriteLine("Tecle enter para retornar ao menu!");
            Console.ReadKey();



        }


        public void Devolver()
        {
            Console.WriteLine();

            Console.WriteLine("Tecle enter para retornar ao menu!");
            Console.ReadKey();



        }

    }
}
