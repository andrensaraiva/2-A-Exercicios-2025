using System.Runtime.Intrinsics.Arm;

string a;

Console.WriteLine("Elara vê um baú com uma fechadura simples.");

Console.WriteLine("Você tem a 'Chave de Cobre'?");
a = Console.ReadLine();

if (a == "sim")
{
    Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro!");
}

else
{
    Console.WriteLine("O baú está trancado. Você precisa da chave certa.");
}