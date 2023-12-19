using System;
using System.Threading;


Console.Clear();

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("-------------------------------");
    Console.WriteLine("S = Segundo => 10s = 10 segundos");
    Console.WriteLine("M = Minuto => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");
    Console.WriteLine("-------------------------------");

    string Data = Console.ReadLine().ToLower();
    char Tipo = char.Parse(Data.Substring(Data.Length - 1, 1)); //Contabiliza o que foi digitado, e salva apenas o último caracter.
    int Tempo = int.Parse(Data.Substring(0, Data.Length - 1)); //Contabiliza o que foi digitado, e salva apenas o primeiro caracter.
    int Mult = 1;

    if (Tipo == 'm')
        Mult = 60;

    if (Tempo == 0)
        System.Environment.Exit(0);

    PreStart(Tempo * Mult);

}

static void PreStart(int Time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(2500);

    Start(Time);
}

static void Start(int Time)
{

    int CurrentTime = 0;

    while (CurrentTime != Time)
    {
        Console.Clear();
        CurrentTime++;
        Console.WriteLine("Contando " + CurrentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Cronômetro finalizado!");
    Thread.Sleep(2000);
}