using System;
using System.ComponentModel;

string a;

Console.WriteLine("Você encontra um baú com uma fechadura simples");
Console.WriteLine("Você tem uma Chave Simples, utilizá-la? (Sim/Não)");
a = Console.ReadLine();
if (a == "Sim")
{
    Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro, parabéns!!");
}
else
{
    Console.WriteLine("O baú está trancado. Você precisa da chave certa");
}
