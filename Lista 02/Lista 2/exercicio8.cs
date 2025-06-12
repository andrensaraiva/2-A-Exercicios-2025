int forca = 10;
int defesa = 10;

Console.WriteLine("Força de ataque do herói");
forca = int.Parse(Console.ReadLine());

Console.WriteLine("Defesa do inimigo");
defesa = int.Parse(Console.ReadLine());

Console.WriteLine("Resultado: " + (forca - defesa));

