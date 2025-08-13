int DanodoJogador, DefesadoMonstro;

Console.WriteLine("Calculadora de Batalha");
Console.WriteLine(" ");
Console.WriteLine("Digite o Dano do Jogador: ");
DanodoJogador = int .Parse(Console.ReadLine());
Console.WriteLine("Digite a Defesa do Monstro: ");
DefesadoMonstro = int.Parse(Console.ReadLine());
float DanoFinal = (DanodoJogador - DefesadoMonstro);
Console.WriteLine("O Dano final foi: " +  DanoFinal);
float vidarestantepercentual = 100f;
Console.WriteLine(" ");
Console.WriteLine("A vida restante do monstro é de: " +  (vidarestantepercentual - DanoFinal) + "%");