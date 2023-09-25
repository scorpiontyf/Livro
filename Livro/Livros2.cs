using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    public class Livros2
    {


        FunçãoSemRead l1 = new FunçãoSemRead("Pi", "Giovanni", "327", "1", " ");
        FunçãoSemRead l2 = new FunçãoSemRead("Como se tornar um líder servidor", "James C.Hunter", "225", "2", " ");
        FunçãoSemRead l3 = new FunçãoSemRead("As 14 indispensáveis qualidades de um líder", "James C.Hunter", "240", "3", " ");
        FunçãoSemRead l4 = new FunçãoSemRead("Os 50 tons do sucesso", "Thomas J. Eddington", "225", "4", " ");
        FunçãoSemRead l5 = new FunçãoSemRead("Segredos da Mente Milionária", "T. Harv Eker", "200", "5", " ");

        public void Emprestar()
        {


        ini:
            Console.WriteLine("Digite o id do livro que deseja emprestar");
            string id = Console.ReadLine();


            switch (id)
            {

                case "1":
                    Console.WriteLine("Seu livro " + l1.titulo + "foi emprestado!");
                    l1.status = FunçãoSemRead.emprestado;
                    break;
                case "2":
                    Console.WriteLine("Seu livro " + l2.titulo + " foi emprestado!");
                    l2.status = FunçãoSemRead.emprestado;

                    break;
                case "3":
                    Console.WriteLine("Seu livro " + l3.titulo + " foi emprestado!");
                    l3.status = FunçãoSemRead.emprestado;

                    break;
                case "4":
                    Console.WriteLine("Seu livro " + l4.titulo + " foi emprestado!");
                    l4.status = FunçãoSemRead.emprestado;

                    break;
                case "5":
                    Console.WriteLine("Seu livro " + l5.titulo + " foi emprestado!");
                    l5.status = FunçãoSemRead.emprestado;
                    break;
                default:
                    Console.WriteLine("Livro indisponível, digite qualquer coisa para retornar à operação.");
                    Console.ReadLine();
                    goto ini;


            }

        }


    }
}
