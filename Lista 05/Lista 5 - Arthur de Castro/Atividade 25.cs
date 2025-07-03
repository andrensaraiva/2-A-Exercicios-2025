string[] itens = new string[3];
int preço = 0;
string resposta;

itens[0] = "Pão";
itens[1] = "Café";
itens[2] = "Banana";



Console.WriteLine("Compras");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Escolha três itens para comprar: Pão, Café, Banana");
    resposta = Console.ReadLine();
    if (resposta == itens[0])
    {
        Console.WriteLine("Você comprou um pão custou 10 reais");
        preço = preço + 10;
    }
    else if (resposta == itens[1])
    {
        Console.WriteLine("Você comprou um Café custou 99 reais");
        preço = preço + 99;
    }
    else if (resposta == itens[2])
    {
        Console.WriteLine("Você comprou uma Banana custou 1 reais");
        preço = preço + 1;
    }

}   
if (preço >= 100)
{
    Console.WriteLine("Você recebeu um desconto de 10% então o preço final ficou em:R$" + preço * 0.9);
}
else
{
    Console.WriteLine("O peço final ficou de:R$" + preço);
}