float peso;
float altura;
float imc;

Console.WriteLine("Qual o peso?");
peso = float.Parse(Console.ReadLine());
Console.WriteLine("Qual a altura?");
altura = float.Parse(Console.ReadLine());

imc = peso / (altura * altura);

Console.WriteLine("O IMC é: " + imc);
