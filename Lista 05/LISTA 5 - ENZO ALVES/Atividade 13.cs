int[] resposta = new int[4];

Console.WriteLine("Calculando Dano ao Longo de Vários Turnos:");
Console.WriteLine("Qual é a vida do inimigo");
resposta[0] = int.Parse(Console.ReadLine());
Console.WriteLine("O dano do veneno");
resposta[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Quantidade de turnos que o veneno fica");
resposta[2] = int.Parse(Console.ReadLine());   

for  (int i = 0; i < 3; i++)
{
    resposta[3] =(resposta[0] - (resposta[1] * resposta[2]));
}
Console.WriteLine("A vida do inimigo ficou em " +  resposta[3]);