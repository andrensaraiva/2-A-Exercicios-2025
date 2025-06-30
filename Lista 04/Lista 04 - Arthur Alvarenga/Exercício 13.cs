int m = 100;
Console.WriteLine("Nível de Moral Inicial: " + m);
Console.WriteLine(" ");
string[] eventos = { "Vitória", "Derrota", "Bônus" };
Random random = new Random();
int indice = random.Next(eventos.Length);

string EventoEscolhido = eventos[indice];

Console.ReadLine();


if (EventoEscolhido == "Vitória")
{
    Console.WriteLine("Sua tropa venceu a batalha, com isso eles ficam motivados, a moral aumenta em 30.");
    Console.WriteLine(" ");
    Console.WriteLine("Moral Atual: " + (m + 30));
}
else if (EventoEscolhido == "Derrota")
{
    Console.WriteLine("Sua tropa perde a batalha, com isso o desânimo domina todos rapidamente, a moral diminui em 20.");
    Console.WriteLine(" ");
    Console.WriteLine("Moral Atual: " + (m - 20));
}
else if (EventoEscolhido == "Bônus")
{
    Console.WriteLine("Sua tropa recebe um Bônus, a moral aumenta em 10.");
    Console.WriteLine(" ");
    Console.WriteLine("Moral Atual: " + (m + 10));
}