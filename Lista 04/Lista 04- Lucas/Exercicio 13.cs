Console.WriteLine("Voce e sua tropa estaop se preparando para uma batalha e voce precisa motiva-los com um acontecimento recente para aumentar sua moral");
Console.ReadLine();

String[] eventos = { "Vitória", "Derrota", "Nenhum dos lados venceu"};
Random random = new Random();
int indice = random.Next(eventos.Length);
string eventoEscolhido = eventos[indice];

Console.WriteLine("Recentemente voces sofreram uma " + eventoEscolhido);

if (eventoEscolhido == "Vitória")
{
    Console.WriteLine("A moral de sua tropa aumenta significadamente, preparandoós para a batalha que está por vir");
}
else if (eventoEscolhido == "Derrota")
{
    Console.WriteLine("A moral de sua tropa fica baixa, deixando´os desanimados e sem esperanças para a batalha");
}
else if (eventoEscolhido == "Nenhum dos lados venceu")
{
    Console.WriteLine("Mesmo sem muitas esperanças, voces vao para a batalha animados, e com a incerteza de uma vitória");
}



