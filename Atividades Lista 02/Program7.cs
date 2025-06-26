float altura = 5.5f;
float largura = 12.5f;
float área = 100.5f;

Console.WriteLine("Digite a altura e largura de um retângulo");
Console.WriteLine("Digite a altura do retângulo");

altura = float.Parse(Console.ReadLine());

Console.WriteLine("Agora, digite sua largura");

largura = float.Parse(Console.ReadLine());

área = altura * largura;

Console.WriteLine("A área de seu retângulo é" + área);


