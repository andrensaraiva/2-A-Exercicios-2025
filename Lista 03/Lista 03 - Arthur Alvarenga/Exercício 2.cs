Console.WriteLine("Elara vê um baú com uma fechadura simples.");

string a;

Console.WriteLine("Você tem a 'Chave de Cobre'? (sim/nao)");
a = Console.ReadLine();

if (a == "sim")
{
    Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro!");
}
else
{
    Console.WriteLine("O baú está trancado. Você precisa da chave certa.");
}