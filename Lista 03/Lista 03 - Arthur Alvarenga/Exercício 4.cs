Console.WriteLine("Elara encontra a entrada da Caverna dos Sussurros, com uma placa: Apenas nível 5 ou mais");

int a;

Console.WriteLine("Qual é o seu nível atual?");
a = int.Parse(Console.ReadLine());

if (a >= 5)
{
    Console.WriteLine("Você é forte o bastante! A caverna se abre.");
}
else
{
    Console.WriteLine("Volte quando estiver mais forte, Elara.");
}
