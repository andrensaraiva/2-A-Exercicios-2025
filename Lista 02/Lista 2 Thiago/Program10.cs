using System.Net;

float preço = 49.99f;
float valorPago = 67.5f;
float troco = 2.5f;

Console.WriteLine("Escreva a quantia em dinheiro que você irá pagar");

valorPago = float.Parse(Console.ReadLine());

troco = valorPago - preço;

Console.WriteLine("Seu troco é" + troco);