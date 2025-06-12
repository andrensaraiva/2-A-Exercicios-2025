// 5. O Enigma das Cores

Console.WriteLine("Uma porta mágica com três botões: Vermelho (1), Azul (2), Verde (3).");

int numero = 0;

Console.WriteLine("Qual botão você aperta?");
numero = int.Parse(Console.ReadLine());
if (numero == 1)
{
    Console.WriteLine("A porta se abre! O botão Azul estava certo.");

}
else if (numero == 2)
{
    Console.WriteLine("Nada acontece com o botão Vermelho.");

}
else if (numero == 3)
{
    Console.WriteLine("O botão Verde não funcionou.");

}
else
{
    Console.WriteLine("Escolha inválida, Elara.");
}

// 6. A Oferta do Ferreiro

Console.WriteLine("O ferreiro está em promoção para aventureiros");

int numero = 0;
string resposta = "sim/não";
Console.WriteLine("Você é membro da Guilda? (sim/nao)");
resposta = Console.ReadLine();
Console.WriteLine("Quantas moedas de ouro você tem? (precisa tem no min.100)");
numero = int.Parse(Console.ReadLine());

if (numero >= 100 && resposta = "sim")
{
    Console.WriteLine("Você usou, pois é da Guilda e gastou 100 moedas.");

}
else if (numero >= 100 && resposta = "não")
{
    Console.WriteLine("Você possui o valor, porém, não fez parte da Guilda.");

}
else if (numero <= 100 && resposta = "sim")
{
    Console.WriteLine("Não tem o valor suficiente, e ainda, não faz parte da Guilda.");

}
else if (numero <= 100 && resposta = "não")
{
    Console.WriteLine("Você é da Guilda, porém, não possui o valor desejado.");

}

// 7. O Portal Instável

Console.WriteLine("Um portal só se estabiliza com artefatos mágicos ou alto poder.");

int numero = 0;
string resposta = "sim/não";
Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
resposta = Console.ReadLine();
Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
resposta = Console.ReadLine();
Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
numero = int.Parse(Console.ReadLine());

if (gema == "sim" && orbe == "sim" || poder == "sim")
{
    Console.WriteLine("O portal se estabiliza e você atravessa!");
}
else
{
    Console.WriteLine("O portal continua instável. Você não consegue passar.");
}

// 8. A Negociação com o Goblin Astuto

Console.WriteLine("Elara encontra um goblin comerciante de olhar astuto e um sorriso travesso.");

Console.WriteLine("O goblin está de bom humor hoje? (sim/nao)");
string humor = Console.ReadLine();
Console.WriteLine("Você tem um 'Olho de Dragão Polido'? (sim/nao)");
string olho = Console.ReadLine();

// Condição: se o goblin está de bom humor OU se Elara tem o item raro
if (humor == "sim" || olho == "sim")
{
    Console.WriteLine("O goblin esfrega as mãos e sorri: 'Muito bem, vamos negociar, aventureira!'");
    Console.WriteLine("Você consegue comprar um pergaminho raro por um ótimo preço.");
}
else
{
    Console.WriteLine("O goblin cruza os braços e resmunga: 'Hoje não estou para negócios sem algo especial...'");
    Console.WriteLine("Você não consegue negociar com ele desta vez.");
}