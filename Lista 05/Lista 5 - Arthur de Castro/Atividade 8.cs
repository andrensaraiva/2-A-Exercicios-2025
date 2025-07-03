
int[] resposta = new int[3];

Console.WriteLine("Pontuações dos Últimos Jogos");
Console.WriteLine("Digite as pontuções");
resposta[0] = int.Parse(Console.ReadLine());
resposta[1] = int.Parse(Console.ReadLine());
resposta[2] = int.Parse(Console.ReadLine());

Console.WriteLine("Sua pontuação total foi de: " + (resposta[0] + resposta[1] + resposta[2]));

if (resposta[0] >= (resposta[1]+resposta[2]))
{
    Console.WriteLine("Sua maior pontuação foi de: " + resposta[0]);

}
else if (resposta[1] >= (resposta[0] + resposta[2]))
{
    Console.WriteLine("Sua maior pontuação foi de: " + resposta[1]);
}
else if (resposta[2] >= (resposta[0] + resposta[1]))
{
    Console.WriteLine("Sua maior pontuação foi de: " + resposta[2]);
}
else
{
    Console.WriteLine("Sua pontuação foi igual");
}