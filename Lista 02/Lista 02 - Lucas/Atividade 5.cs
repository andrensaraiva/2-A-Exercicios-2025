using System.Security.Cryptography.X509Certificates;

string nome = "P1";
int nivel = 1;

Console.WriteLine("Qual seu nome de jogador?");
nome = Console.ReadLine();

Console.WriteLine("Qual o seu nivel?");
nivel = int.Parse(Console.ReadLine());

Console.WriteLine("Bem-vindo(a), " + nome + "! " + " Você começa no nível " + nivel);
