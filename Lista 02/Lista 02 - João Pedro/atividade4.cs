float numero;
float valor;

Console.WriteLine("Diga um valor em reais");
numero = float.Parse(Console.ReadLine());

valor = numero * 5;
Console.WriteLine("O valor em dólares é: " + valor);
