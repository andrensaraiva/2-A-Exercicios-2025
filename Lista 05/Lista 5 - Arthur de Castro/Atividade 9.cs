string[] nomes = new string[4];
int resposta;

nomes[0] = "Roberto";
nomes[1] = "Carlos";
nomes[2] = "Pedro";
nomes[3] = "João";
Console.WriteLine("Quatros membros fundadores da guilda digite um número de um deles");
resposta = int.Parse(Console.ReadLine());

switch (resposta)
{
    case 1: 
        Console.WriteLine("O nome do membro é " + nomes[0]);
        break;
    case 2:
        Console.WriteLine("O nome do membro é " + nomes[1]);
        break;
    case 3:
        Console.WriteLine("O nome do membro é " + nomes[2]);
        break;
    case 4:
        Console.WriteLine("O nome do membro é " + nomes[3]);
        break;
}