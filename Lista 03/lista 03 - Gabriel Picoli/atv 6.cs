string guilda = "nome";
int ouro = 10;

Console.WriteLine("o ferreiro está com promoção para aventureiros!");
Console.WriteLine("pequeno aventureiro, quantas moedas de ouro você tem?");
ouro = int.Parse(Console.ReadLine());

Console.WriteLine("você é um dos membros da minha guilda?(sim/nao)");
guilda = Console.ReadLine();

if (ouro >= 25 && guilda == "sim") {
    Console.WriteLine("você pode comprar essa espada por apenas 25 moedas!!");
}
else if (ouro < 25 && guilda == "sim") {
    Console.WriteLine("como você nao tem dinheiro nao posso te vender nada");
}
else if (ouro >= 45 && guilda == "nao") {
    Console.WriteLine("como você não é da guilda não posso de vender com desconto, mas você ainda pode comprar por 45 moedas!");
}
else if (ouro < 45 && guilda == "nao") {
    Console.WriteLine("você não consegue comprar nada aqui, por agora.");
}