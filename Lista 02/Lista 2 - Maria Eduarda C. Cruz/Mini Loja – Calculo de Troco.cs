// Mini Loja – Calculo de Troco

float preco = 39.90f;
float cliente = 0f;
float troco = 0f;
Console.WriteLine("Qual o valor pago pelo cliente? ");
cliente = float.Parse(Console.ReadLine());
troco = cliente - preco;
Console.WriteLine("Voce precisar dar " + troco + " de troco.");
