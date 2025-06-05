float a;
Console.WriteLine("Calculadora de Troco de uma Pizza");
Console.WriteLine();
Console.WriteLine("Preço da Pizza R$54,90");
Console.WriteLine("Digite o preço que vai ser pago");
a = float.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("O troco que a ser dado é " + (a - 54,90));