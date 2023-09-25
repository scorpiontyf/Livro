using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    public class FunçãoSemRead
    {

        public string titulo;
        public string autor;
        public string pagina;
        public string status;
        public static string emprestado = "Livro Emprestado";
        public static string disponível = "Livro disponível";


        private string id { get; set; }

        public FunçãoSemRead(string titulo, string autor, string pagina, string id, string status)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.pagina = pagina;
            this.id = id;
            this.status = status;
        }





        public void Devolver()
        {

        }



        public void Biblioteca()
        {
            Console.WriteLine("Livros disponíveis: ");
            FunçãoSemRead l1 = new FunçãoSemRead("Pi", "Giovanni", "327", "1", "");
            Console.WriteLine();
            if (l1.status == emprestado)
            {
                l1.status = emprestado;
            }
            else
            {
                l1.status = disponível;
            }
            Console.WriteLine("Título:" + l1.titulo + "\nAutor:" + l1.autor + "\nPáginas" + l1.pagina + "\nID:" + l1.id + "\nDisponibilidade: " + l1.status);

            Console.WriteLine(" ");
            FunçãoSemRead l2 = new FunçãoSemRead("Como se tornar um líder servidor", "James C.Hunter", "225", "2", " ");

            if (l2.status == emprestado)
            {
                l2.status = emprestado;
            }
            else
            {
                l2.status = disponível;
            }

            Console.WriteLine("Título:" + l2.titulo + "\nAutor:" + l2.autor + "\nPáginas" + l2.pagina + "\nID:" + l2.id);
            Console.WriteLine(" ");


            FunçãoSemRead l3 = new FunçãoSemRead("As 14 indispensáveis qualidades de um líder", "James C.Hunter", "240", "3", ""); Console.WriteLine("Título:" + l3.titulo + "\nAutor:" + l3.autor + "\nPáginas:" + l3.pagina + "\nID:" + l3.id);
            if (l3.status == emprestado)
            {
                l3.status = emprestado;
            }
            else
            {
                l3.status = disponível;
            }

            Console.WriteLine(" ");


            FunçãoSemRead l4 = new FunçãoSemRead("Os 50 tons do sucesso", "Thomas J. Eddington", "225", "4", "");
            Console.WriteLine("Título: " + l4.titulo + "\nAutor: " + l4.autor + "\nPáginas: " + l4.pagina + "\nID: " + l4.id);
            if (l4.status == emprestado)
            {
                l4.status = emprestado;
            }
            else
            {
                l4.status = disponível;
            }

            Console.WriteLine(" ");


            FunçãoSemRead l5 = new FunçãoSemRead("Segredos da Mente Milionária", "T. Harv Eker", "200", "5", " ");

            Console.WriteLine("Título: " + l5.titulo + "\nAutor:" + l5.autor + "\nPáginas:" + l5.pagina + "\nID:" + l5.id);
            if (l5.status == emprestado)
            {
                l5.status = emprestado;
            }
            else
            {
                l5.status = disponível;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Digite qualquer coisa para retornar ao menu");

            Console.ReadLine();

            Voltar();

            Console.ReadLine();






        }

        public void Apresentar()
        {
            Livros2 m = new Livros2();
            Console.WriteLine("Seja bem-vindo à biblioteca Prover!");
            Console.WriteLine("1- Biblioteca" + "\n2- Emprestar" + "\n3- Devolver");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Biblioteca();
                    break;
                case "2":
                    Console.Clear();
                    m.Emprestar();
                    Voltar();
                    break;
                case "3":
                    Devolver();
                    Console.Clear();

                    Voltar();
                    break;
                default:
                    while (option != "1" || option != "2" || option != "3")
                    {
                        Console.Clear();
                        VoltarRED();
                    }
                    break;
            }

        }

        public void Voltar()
        {
            Livros2 m = new Livros2();

        inici:
            Console.Clear();
            Console.WriteLine("Digite uma das opções para realizar o que desejas!");
            Console.WriteLine("1- Biblioteca" + "\n2- Emprestar" + "\n3- Devolver");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Biblioteca();
                    break;
                case "2":
                    Console.Clear();
                    m.Emprestar();

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

        public void VoltarRED()
        {
            Livros2 m = new Livros2();

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
                    Biblioteca();
                    break;
                case "2":
                    Console.Clear();
                    m.Emprestar();

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

    }

}
