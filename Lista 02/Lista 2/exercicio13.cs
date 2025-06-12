int Peso = 0;
float altura = 1.0f;

Console.WriteLine("Qual o seu peso?");
Peso = int.Parse(Console.ReadLine());

Console.WriteLine("E a sua altura?");
altura = int.Parse(Console.ReadLine());

Console.WriteLine("imc: " + (Peso / (altura * altura)));
