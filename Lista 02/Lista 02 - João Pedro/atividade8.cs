int ataque;
int defesa;
int resultado;

Console.WriteLine("Qual a força do ataque do herói?");
ataque = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a força da defesa do inimigo?");
defesa = int.Parse(Console.ReadLine());

resultado = ataque - defesa;

Console.WriteLine("O resultado é: " + resultado);
