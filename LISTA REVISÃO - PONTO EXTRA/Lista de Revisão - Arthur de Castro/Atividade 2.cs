int danoJogador;
int defesaMonstro;

Console.WriteLine("Digite seu dano");
danoJogador = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a defesa do Monstro");
defesaMonstro = int.Parse(Console.ReadLine());

int danofinal = danoJogador - defesaMonstro;

float VidarestantePorc = (100-danofinal) / 100;

Console.WriteLine("Seu inimigo ficou com " +  (VidarestantePorc*100) + "% da vida.");