int r;


Console.WriteLine("O que vôce deseja fazer?");
Console.WriteLine(" ");
Console.WriteLine("Defender a floresta, Destruir o amuleto da floresta, ou tentar rouba-lo para si? (1,2 ou 3) ");
r = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Reputação");
Console.WriteLine("Crisols da Floresta: 100 ");
Console.WriteLine("Lradroes da Escuridão: 100 ");
Console.WriteLine("Chama do Caos: 100 ");
Console.WriteLine(" ");
Console.WriteLine("Cada escolha sua terá uma consequência...");
if (r == 1)
{
    Console.WriteLine("Crisols da Floresta: +50 de reputação");
    Console.WriteLine("Lradroes da Escuridão: -20 de reputação");
    Console.WriteLine("Chama do Caos: -10 de reputação");
}
else  if (r == 2)
{
    Console.WriteLine(" Crisols da Floresta: -50 de reputação");
    Console.WriteLine("Lradroes da Escuridão: -20 de reputação");
    Console.WriteLine("Chama do Caos: = +30 de reputação");
}
else if (r == 3)
{
    Console.WriteLine(" Crisols da Floresta: -30 de reputação");
    Console.WriteLine("Lradroes da Escuridão: +30 de reputação");
    Console.WriteLine("Chama do Caos: = +0 de reputação");
}