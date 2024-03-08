using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 - Visualizar arquivos anteriores.");
            Console.WriteLine("2 - Prosseguir para tentativa de acesso.");
            Console.WriteLine("3 - Deletar arquivo.");
            Console.WriteLine("------------------------------------------");
            Console.Write("-> ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Arquivos.arquivo_anterior();
                    break;

                case "2":
                    Arquivos.arquivo();
                    break;

                case "3":
                    Arquivos.deletar_arquivo();
                    break;

                default:
                    Console.WriteLine("Você não selecionou uma opção válida, o sistema será fechado!");
                    Environment.Exit(0);
                    break;
            }


        }
    }

}
