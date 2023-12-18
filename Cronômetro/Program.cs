using System;
using System.Threading;

Console.Clear();
Start();

static void Start()
{
    int Time = 10;
    int CurrentTime = 0;

    while (CurrentTime != Time)
    {
        Console.Clear();
        CurrentTime++;
        Console.WriteLine("Contando " + CurrentTime);
        Thread.Sleep(1000);
    }
}