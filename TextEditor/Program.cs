using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Menu();

        static void Menu()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("------------------------");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": Abrir(); break;
                case "2": Editar(); break;
                case "0": Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();


        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("----------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);

        }
        static void Salvar(string text)

        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
        }
    }
}