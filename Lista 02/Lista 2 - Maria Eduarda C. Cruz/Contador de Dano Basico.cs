// Contador de Dano Basico

int ataque = 0;
int defesa = 0;
int dano = 0;
Console.WriteLine("Digite a forca de ataque do heroi e a defesa do inimigo: ");
ataque = int.Parse(Console.ReadLine());
defesa = int.Parse(Console.ReadLine());
dano = ataque - defesa;
Console.WriteLine(dano);