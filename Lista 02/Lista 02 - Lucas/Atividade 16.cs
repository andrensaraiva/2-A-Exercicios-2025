float chocolate;
float bala;
float chiclete;

Console.WriteLine("Quantos produtos voce quer de chocolate?");
chocolate = float.Parse(Console.ReadLine());

Console.WriteLine("Quantas balas voce quer?");
bala = float.Parse(Console.ReadLine());

Console.WriteLine("Quantos chicletes voce quer?");
chiclete = float.Parse(Console.ReadLine());

Console.WriteLine("Seu chocolate custou: " +  (chocolate * 10));
Console.WriteLine("Sua bala custou: " + (bala * 9.99));
Console.WriteLine("Seu chiclete custou: " + (chiclete * 2.90));

Console.WriteLine("Seu subtotal custou: " + (chocolate * 10 + bala * 9.99 +  chiclete * 2.90));