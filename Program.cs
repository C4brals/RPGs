
Menu();

static void Menu()
{
    Console.WriteLine("Digite 1 para SOMAR");
    Console.WriteLine("Digite 2 para SUBTRAIR");
    Console.WriteLine("Digite 3 para MULTIPLICAR");
    Console.WriteLine("Digite 4 para DIVIDIR");
    string Escolha = Console.ReadLine();

    switch (Escolha)
    {
        case "1":
            Somar();
            break;

        case "2":
            Subtrair();
            break;

        case "3":
            Multiplicar();
            break;

        case "4":
            Dividir();
            break;
    }
}
static void Somar()
{
    Console.WriteLine("Você escolheu somar, digite o primeiro valor: ");
    double V1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double V2 = double.Parse(Console.ReadLine());

    double Somar = V1 + V2;

    Console.WriteLine("O valor da soma é: " + Somar);
}
static void Subtrair()

{
    Console.WriteLine("Você escolheu subtrair, digite o primeiro valor: ");
    double V1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double V2 = double.Parse(Console.ReadLine());

    double Sub = V1 - V2;

    Console.WriteLine("O valor da subtração é: " + Sub);
}
static void Multiplicar()
{
    Console.WriteLine("Você escolheu multiplicar, digite o primeiro valor: ");
    double V1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double V2 = double.Parse(Console.ReadLine());

    double Mult = V1 * V2;

    Console.WriteLine("O valor da multiiplicação é: " + Mult);
}
static void Dividir()
{
    Console.WriteLine("Você escolheu dividir, digite o primeiro valor: ");
    double V1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double V2 = double.Parse(Console.ReadLine());

    double Div = V1 / V2;

    Console.WriteLine("O valor da multiiplicação é: " + Div);
}

