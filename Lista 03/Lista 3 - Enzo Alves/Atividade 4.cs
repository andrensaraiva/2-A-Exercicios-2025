int a;

Console.WriteLine(" Você encontra a entrada da Caverna dos Sussurro, com uma placa: Apenas nível 5 ou mais");
Console.WriteLine("Qual é seu level atual");
a = int.Parse(Console.ReadLine());
if (a >= 5)
{
    Console.WriteLine("Você é forte o bastante! A caverna se abre.");
}
else
{
    Console.WriteLine("Volte quando você estiver mais forte, Diniz."); 
}
