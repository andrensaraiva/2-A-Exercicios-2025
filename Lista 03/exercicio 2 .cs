string b = "b";

Console.WriteLine("Você tem a 'Chave de Cobre'? (sim/nao)");
b = Console.ReadLine();
if (b == "sim")
{
    Console.WriteLine("Você abre o baú e encontra 50 moedas de ouro!");
}

else
{
    Console.WriteLine("O baú está trancado. Você precisa da chave certa.");
}