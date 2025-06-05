float altura;
float largura;
float area;

Console.WriteLine("Digite a altura");
altura = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a largura");
largura = float.Parse(Console.ReadLine());

area = altura * largura;
Console.WriteLine("A área será de: " + area);
