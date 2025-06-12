string art1 = "";
string art2 = "";
string pwr = "";

Console.WriteLine("o portal arcano não se abre para qualquer um... disse a placa ao pé do altar");
Console.WriteLine("você possui poeira arcana?");
art1 = (Console.ReadLine());
Console.WriteLine("você possui bafo de dragão?");
art2 = (Console.ReadLine());
Console.WriteLine("você é treinado por algum mestre mago?");
pwr = (Console.ReadLine());

if (art1 == "sim" && art2 == "sim" || pwr == "sim")
{
    Console.WriteLine("o portal se abre para aqueles que possuem conhecimento ou força");
}
else
{
    Console.WriteLine("você não tem nada ainda. volte quando for forte...");
}