// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

int vida = 100;
float altura = 1.8f;
bool vf = true;
string palavra = "amoroxo";
char umaletra = 'a';

Console.WriteLine("escreva um numero");
vida = int.Parse(Console.ReadLine());

vida = vida * 10;
vida = vida / 2;
vida = vida % 7;
vida = vida + 23;
vida = vida - 43;
Console.WriteLine("sua vida é: " + vida);

