// See https://aka.ms/new-console-template for more information
int numero = 0;
Console.WriteLine("qual botão você quer apertar? (1) (2) (3)");
numero = int.Parse(Console.ReadLine());

if (numero == 1)
{
    Console.WriteLine("Você conseguiu escapar da caverna!");
}

else if (numero == 2)
{
    Console.WriteLine("Você é sugado para outrada sala da caverna");
}

else if (numero == 3)
{
    Console.WriteLine("Você cai em uma armadilha (-20 hp)");
}

else
{
    Console.WriteLine("Resposta invalida");
}

