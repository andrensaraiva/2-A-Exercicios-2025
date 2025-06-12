int numero = 0;

Console.WriteLine("Qual é o seu nível atual?");
numero = int.Parse (Console.ReadLine());

if (numero >= 5)
{
    Console.WriteLine("Você é forte o bastante! A caverna se abre.");
}

else if (numero <= 5)
{
    Console.WriteLine("Volte quando estiver mais forte.");
}