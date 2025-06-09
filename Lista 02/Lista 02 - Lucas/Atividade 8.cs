using System.Security.Cryptography.X509Certificates;

int a, b;

Console.WriteLine("Qual a sua força");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Qual a defesa inimiga");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Voce deu " + (a - b) + " de dano");