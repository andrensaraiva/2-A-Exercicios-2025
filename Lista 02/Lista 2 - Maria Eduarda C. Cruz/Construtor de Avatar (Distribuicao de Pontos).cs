// Construtor de Avatar (Distribuicao de Pontos)

using System.Dynamic;

int dpontos = 150;
int forca = 0;
int agilidade = 0;
int inteligencia = 0;
int dtotal = 0;
Console.WriteLine("Voce tem " + dpontos + " para distribuir. " +
    "Quantos desses pontos voce quer aplicar na forca?");
forca = int.Parse(Console.ReadLine());
Console.WriteLine("E na agilidade?");
agilidade = int.Parse(Console.ReadLine());
Console.WriteLine("Por ultimo, quanto quer aplicar na inteligencia?");
inteligencia = int.Parse(Console.ReadLine());
dtotal = dpontos - forca - agilidade - inteligencia;
Console.WriteLine("Voce tem " + dtotal + " restantes e a distribuicao final e: Forca - " + forca + "; Agilidade - "
    + agilidade + "; Inteligencia - " + inteligencia);


// Subtraia do total a cada escolha e exiba o saldo restante e a distribuição final.
