// Calculadora de IMC

float peso = 0.0f;
float altura = 0.0f;
float IMC = 0.0f;
Console.WriteLine("Digite o seu peso em kg e sua altura em m: ");
peso = float.Parse(Console.ReadLine());
altura = float.Parse(Console.ReadLine());
IMC = peso / (altura * altura);
Console.WriteLine("Seu IMC e " + IMC + ".");

