using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public static class Arquivos
    {
        public static void arquivo_anterior()
        {
            //string caminho = "dados.txt";
            StreamReader sr = new StreamReader(@"C:\csharp\dados.txt");

            while (sr.EndOfStream != true)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }
        public static void arquivo()
        {
            //Declaração de variáveis
            string nome = "";
            string idade = "";
            string salario = "";
            int i = 0;
            int s = 0;

            //Exercício 01 - Coletando nome e exibindo em tela.

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            //Exercício 02 - Coletando idade para permitir entrada.
            Console.Write("Informa sua idade: ");
            idade = Console.ReadLine();
            i = Int32.Parse(idade); //Converte o valor recebido na string idade, e armazena como inteiro na variável i.

            if (i < 18)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Acesso negado! Você não é maior de idade!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Environment.Exit(0);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso permitido! Você é maior de idade!");
                Console.WriteLine("");
            }
            //Exercício 03 - Substituindo letras de uma string.
            //string frase = "Local impróprio para menores de idade";
            //Console.Write(frase.Replace("a", "o"));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Informe o valor do seu salário:  ");
            salario = Console.ReadLine();
            s = Int32.Parse(salario);

            if (s < 1900)
            {
                s = s + 300;
                Console.WriteLine("Você recebeu um ajuste de salário no valor de R$300,00.");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Seu novo salário é {0}", s);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Seu salário está dentro do esperado!");
                Console.WriteLine("----------------------------------------");
            }
            //Exercício 04 - Gravar arquivo.txt
            string caminho = "dados.txt";

            Console.WriteLine();
            Console.WriteLine("Processo final");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Gravar informações.");
            Console.WriteLine("Pressione qualquer outra tecla para fechar a aplicação.");
            Console.WriteLine("----------------------------------------");
            Console.Write("-> ");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {   //Excrevendo informações no arquivo
                StreamWriter sw = new StreamWriter(@"C:\csharp\dados.txt", true);
                sw.WriteLine("Nome: " + nome);
                sw.WriteLine("Idade: " + idade);
                sw.WriteLine("Salário atual: " + s);
                sw.WriteLine("----------------------------------------");
                sw.Close();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public static void deletar_arquivo()
        {
            Console.WriteLine("Você realmente deseja DELETAR o arquivo?");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Digite CANCELAR para prosseguir...");
            Console.WriteLine("Digite DELETAR para excluir o arquivo.");
            Console.WriteLine("----------------------------------------");
            Console.Write("-> ");
            string escolha = Console.ReadLine();
            escolha.ToUpper();

            switch (escolha)
            {

                case "CANCELAR":
                    arquivo();
                    break;

                case "DELETAR":
                    File.Delete(@"C:\csharp\dados.txt");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Arquivo deletado!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;

                default:
                    Console.WriteLine("Por favor, digite uma opção válida!");
                    deletar_arquivo();
                    break;
            }




        }
    }
}







