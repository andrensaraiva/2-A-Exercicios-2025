float arroz = 30.99f;
float valor;

Console.WriteLine("Digite um valor para pagar o seu produto: ");
valor = float.Parse(Console.ReadLine());

Console.WriteLine("Seu troco é " + (valor - arroz));
