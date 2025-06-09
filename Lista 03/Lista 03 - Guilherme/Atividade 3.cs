// See https://aka.ms/new-console-template for more information
string Resposta = "oi";
Console.WriteLine("A ponte esta instavel, tem certeza que quer atravessar? (sim/não)");
Resposta = Console.ReadLine();
if (Resposta == "sim")
{
    Console.WriteLine("Você cai da ponte e quebra a suas pernas brutalmente (-70 hp)");
}
else if (Resposta == "não")
{
    Console.WriteLine("Você procura outro caminho, é melhor prevenir do que remediar");
}

