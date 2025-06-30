int a, b;
Console.WriteLine("1, Coroa de Éter Luminoso");
Console.WriteLine("2, Lâmina Sombria de Varkun");
Console.WriteLine("3, Amuleto das Almas Silenciosas");
Console.WriteLine("4, Elmo do Guardião das Estrelas");
Console.WriteLine("5, Botas do Vento Murmurante");
Console.WriteLine("6, Anel do Tempo Estilhaçado");
Console.WriteLine("7, Manto da Névoa Eterna");
Console.WriteLine("8, Cajado de Zynor, o Arcanista");
Console.WriteLine("9, Grimório das Chamas Vivas");
Console.WriteLine("10, Orbe do Infinito Violeta");
Console.WriteLine("Escolha algum item desta lista");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Escolha outro item desta lista");
b = int.Parse(Console.ReadLine());

if (a == 1 && b == 10)
{
    Console.WriteLine("Poção da nobreza interminável: Buff de 2x de dinheiro por 10 minutos");
}
else if (a == 2 && b == 3)
{
    Console.WriteLine("Poção de invisibilidade: Te deixa invisivel por 5 minutos.");
}
else if (a == 4 && b == 9)
{
    Console.WriteLine("Poção das chamas ardentes: Quando usa seus ataques há uma chance de meteoritos flamejantes cairem do céu.");
}
else if (a == 5 && b == 8)
{
    Console.WriteLine("Poção do passo de pena: Seus passos se tornam tão leves que voce pode flutuar por 10 minutos.");
}
else if (a == 6 && b == 7)
{
    Console.WriteLine("Poção do tempo infinito: O tempo passa mais lentamente para o usuario por 10 minutos, permitindo que ele ataque de forma mais certeira");
}
else
{
    Console.WriteLine("Não foi possivel fazer a poção");
}

