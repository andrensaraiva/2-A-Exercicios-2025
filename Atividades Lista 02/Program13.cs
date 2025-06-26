float peso = 60.9f;
float altura = 60.5f;
float result = 25.1f;

Console.WriteLine("Digite o seu peso");

peso = float.Parse(Console.ReadLine());

Console.WriteLine("Agora, digite a sua altura");

altura = float.Parse(Console.ReadLine());

result = peso / (altura * altura);

Console.WriteLine("ATENÇÃO! O seu IMC é" + result);