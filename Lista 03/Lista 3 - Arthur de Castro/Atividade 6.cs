int a;
string b;

Console.WriteLine("O ferreiro está em promoção para aventureiros");
Console.WriteLine("Quantas moedas de ouro você tem?");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Você é membro da guilda(Sim/Não)");
b = Console.ReadLine();
if (a >= 40 && b == "Sim")
{
    Console.WriteLine("Posso te fazer um desconto já que é da Guilda a espada fica 40");
}
else if (a >= 70 && b == "Não")
{
    Console.WriteLine("A espada fica a 70");
}
else if (a < 40 && b == "Sim")
{
    Console.WriteLine("Vejo que não tem o dinheiro necessário posso fazer fiado");
}
else if (a < 70 && b == "Não");
{
    Console.WriteLine("Se não tem dinheiro pode ir saindo da loja");
}