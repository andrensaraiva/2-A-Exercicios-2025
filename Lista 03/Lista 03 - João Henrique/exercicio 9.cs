using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

int a;
string b;
string c;

Console.WriteLine("Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)");
a = int.Parse(Console.ReadLine());


if (a == 1)
{
    Console.WriteLine("Nesse tunel tem um urso que não ve uma ursa a 2 anos. correr ou encarar??");
    b = (Console.ReadLine());
    if (b == "correr")
    {
        Console.WriteLine("o urso te pegou de jeito");
    }
    else
    {
        Console.WriteLine("ele tremeu e foi dormir");
    }
}


else if (a == 2)
{
    Console.WriteLine("Nesse túnel tem um baú, quer abrir? (sim/nao)");
    c = (Console.ReadLine());
        if (c == "sim")
        {
            Console.WriteLine("voce achou muito ouro");
        }        
        else
    { Console.WriteLine("continua pobre entao comedia");
    }
}

