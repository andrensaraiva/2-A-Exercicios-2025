int f = 10, a = 10, e = 10, ele = 10;


string[] climas = { "Ensolarado", "Chuvoso", "Nublado", "Tempestuoso" };

Random random = new Random();

int indice  = random.Next(climas.Length);

string ClimaEscolhido = climas[indice];

Console.WriteLine( "O Clima escolhido é : " + ClimaEscolhido);
Console.WriteLine(" ");
Console.WriteLine("Os atributos base são: ");
Console.WriteLine("Fogo: 10");
Console.WriteLine("Água: 10");
Console.WriteLine("Escuridão: 10");
Console.WriteLine("Eletricidade: 10 ");
Console.ReadLine();

if (ClimaEscolhido == "Ensolarado")
{
    Console.WriteLine(" ");
    Console.WriteLine("Clima Ensolarado: ");
    Console.WriteLine(" ");
    Console.WriteLine("Os atributos agora são: ");
    Console.WriteLine("Fogo: " + f*1.20);
    Console.WriteLine("Água: " + a*0.90);
    Console.WriteLine("Escuridão: " + e);
    Console.WriteLine("Eletricidade: " + ele);
}
else if (ClimaEscolhido == "Chuvoso")
{
    Console.WriteLine(" ");
    Console.WriteLine("Clima Chuvoso: ");
    Console.WriteLine(" ");
    Console.WriteLine("Os atributos agora são: ");
    Console.WriteLine("Fogo: " + f * 0.90);
    Console.WriteLine("Água: " + a * 1.20);
    Console.WriteLine("Escuridão: " + e);
    Console.WriteLine("Eletricidade: " + ele*1.10);
}
else if (ClimaEscolhido == "Nublado")
{
    Console.WriteLine(" ");
    Console.WriteLine("Clima Nublado: ");
    Console.WriteLine(" ");
    Console.WriteLine("Os atributos agora são: ");
    Console.WriteLine("Fogo: " + f);
    Console.WriteLine("Água: " + a);
    Console.WriteLine("Escuridão: " + e*1.15);
    Console.WriteLine("Eletricidade: " + ele);
}
else if (ClimaEscolhido == "Tempestuoso")
{
    Console.WriteLine(" ");
    Console.WriteLine("Clima Tempestuoso: ");
    Console.WriteLine(" ");
    Console.WriteLine("Os atributos agora são: ");
    Console.WriteLine("Fogo: " + f*0.85);
    Console.WriteLine("Água: " + a*1.10);
    Console.WriteLine("Escuridão: " + e);
    Console.WriteLine("Eletricidade: " + ele*1.25);
}