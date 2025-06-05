float preco = 10f;
float cliente;
float troco;

Console.WriteLine("Qual o valor pago?");
cliente = float.Parse(Console.ReadLine());

troco = cliente - preco;
Console.WriteLine("Você precisa devolver " + troco + " reais");
