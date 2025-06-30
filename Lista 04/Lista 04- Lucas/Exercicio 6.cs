int f = 10, a = 10, t = 10, e = 10;

String[] clima= { "Chuvoso", "Ensolarado", "Nevasca", "Tempestade" };
Random random = new Random();
int indice = random.Next(clima.Length); 
string ClimaEscolhido = clima[indice];
Console.WriteLine("O clima escolhido é " + ClimaEscolhido);

Console.WriteLine("Atributos base são: Fogo, Agua, Terra, Eletricidade");
Console.ReadLine();
Console.WriteLine("O clima é igual a " + ClimaEscolhido);

if (ClimaEscolhido == "Chuvoso")
{
    Console.WriteLine("Os atributos agora são:");
    Console.WriteLine("Fogo: " + f * 0.2);
    Console.WriteLine("Agua: " + a * 3);
    Console.WriteLine("Terra: " + t * 0.3);
    Console.WriteLine("Eletricidade: " + e * 2);
}
else if (ClimaEscolhido == "Ensolarado")
{
    Console.WriteLine("Os atributos agora são:");
    Console.WriteLine("Fogo: " + f * 4);
    Console.WriteLine("Agua: " + a * 0.2);
    Console.WriteLine("Terra: " + t * 3);
    Console.WriteLine("Eletricidade: " + e);
}
else if (ClimaEscolhido == "Nevasca")
{
    Console.WriteLine("Os atributos agora são:");
    Console.WriteLine("Fogo: " + f * 0, 5);
    Console.WriteLine("Agua: " + a * 4);
    Console.WriteLine("Terra: " + t * 3);
    Console.WriteLine("Eletricidade: " + e * 1);
}
else if (ClimaEscolhido == "Tempestade")
{
    Console.WriteLine("Os atributos agora são:");
    Console.WriteLine("Fogo: " + f * 0, 2);
    Console.WriteLine("Agua: " + a * 2);
    Console.WriteLine("Terra: " + t * 0, 3);
    Console.WriteLine("Eletricidade: " + e * 5);
}
