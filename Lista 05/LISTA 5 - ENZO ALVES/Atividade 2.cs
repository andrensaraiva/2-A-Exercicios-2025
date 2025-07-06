string resposta;

Console.WriteLine("Escolha sua Classe");
Console.WriteLine("[G]Guerreiro [M]Mago [A]Arqueiro");
resposta = Console.ReadLine();
switch (resposta)
{
    case "G":
        Console.WriteLine("Você escolhe a classe Guerreira! Poder e honra ao império");
        break;
    case "M":
        Console.WriteLine("Você escolhe a classe Mago! Magia e Sabedoria");
        break;
    case "A":
        Console.WriteLine("Você escolhe a classe Arqueira! Agilidade e Precisão");
        break;
    default:
        Console.WriteLine("Não existe ou escreva direito");
        break;
}