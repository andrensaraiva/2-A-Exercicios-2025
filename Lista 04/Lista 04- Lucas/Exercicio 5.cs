string CB, AS;
int codigo = 1234;
int contador = 0;

Console.WriteLine("Voce encontra um cofre perdido na selva, e tenta abri-lo");
Console.ReadLine();

Console.WriteLine("Ao se aproximar ele lhe faz algumas perguntas.");
Console.ReadLine();

Console.WriteLine("Voce possui uma Chave de Bronze");
CB = Console.ReadLine();

Console.WriteLine("Qual a senha?");
codigo = int.Parse(Console.ReadLine());

Console.WriteLine("Possui Amuleto da Serpente?");
AS = Console.ReadLine();

if (CB == "sim") contador++;
if (AS == "sim") contador++;
if (codigo == 1234) contador++;

if (contador == 1)
{
    Console.WriteLine("Apenas uma trava foi aberta");
}
else if (contador == 2)
{
    Console.WriteLine("Duas travas foram abertas");
}
else if (contador == 3)
{
    Console.WriteLine("Todas as travas foram abertas");
}
else
{
    Console.WriteLine("Nenhuma trava foi aberta, volte quando tiver todos os itens");
}

  






