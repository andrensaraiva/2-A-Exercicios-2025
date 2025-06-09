// See https://aka.ms/new-console-template for more information
int numero = 0;

string Guilda = "Guilda ou sla";

Console.WriteLine("Olá jovem, estou com promoções excelentes para aventureiros!");

Console.WriteLine("Quantas moedas de ouro você tem?");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("Você faz parte de uma guilda?(sim/não)");
Guilda = Console.ReadLine();

if (numero >= 50 && Guilda == "sim")
{
    Console.WriteLine("Você é realmente um aventureiro! e ainda tem dinheiro o suficiente para fazer boas compras, pode entrar!");
}

else if (numero >= 50 && Guilda == "não")
{
    Console.WriteLine("Você é um aventureiro solitário, mas possui uma boa quantidade de moedas, pode entrar!");
}

else if (numero < 50 && Guilda == "sim")
{
    Console.WriteLine("Você é um aventureiro, mas não pussi moedas o suficiente, vá buscar mais e depois volte!");
}

else if (numero < 50 && Guilda == "não")
{
    Console.WriteLine("Você não é um aventureiro de verdade! Sai da minha loja e volte quando for um!");
}
