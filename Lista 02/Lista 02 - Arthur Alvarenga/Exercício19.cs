int a, b, c;
string a1, b2, c3;

Console.WriteLine("Codificador de Letras");
Console.WriteLine(" ");
Console.WriteLine("Digite as 3 letras que deseja codificar:");
a1 = Console.ReadLine();
b2 = Console.ReadLine();
c3 = Console.ReadLine();

Console.WriteLine("Digite o número que deseja para a letra " + a1);
a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número que deseja para a letra " + b2);
b = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número que deseja para a letra " + c3);
c = int.Parse(Console.ReadLine());

Console.WriteLine("O resultado é: " + a1 + b2 + c3 + " = " + (a + b + c));






