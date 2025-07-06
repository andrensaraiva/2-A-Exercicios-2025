float[] resposta =  new float[3];

Console.WriteLine("Simulação de Investimento com Juros Simples");
Console.WriteLine("Digite o valor inicial");
resposta[0] = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a taxa de juros (ex:5% = 0,05)");
resposta[1] = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de tempo em anos");
resposta[2] = float.Parse(Console.ReadLine());

for (int i = 1; i <= resposta[2]; i++)
{
    Console.WriteLine("O" + i + "º anos teve o total de juros de " + (resposta[0] * resposta[1]*i));
}
Console.WriteLine("O montante foi de "+ (resposta[0] * resposta[1] * resposta[2] + resposta[0]));