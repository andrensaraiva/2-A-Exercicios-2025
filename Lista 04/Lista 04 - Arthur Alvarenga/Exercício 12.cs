int m, h;
Console.WriteLine("Escolha um minerío para fazer sua picareta: ");
Console.WriteLine(" ");
Console.WriteLine("1. Ferro = Comum ");
Console.WriteLine("2. Aço = Raro ");
Console.WriteLine("3. Ouro = Èpico ");
m = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Qual seu nível de habilidade com forja? ");
h = int.Parse(Console.ReadLine());
Console.WriteLine(" ");

if  (m == 1 & h > 50)
{
    Console.WriteLine("Você forjou um picareta de ferro comum.");
}
else if (m == 1 & h <= 50)
{
    Console.WriteLine("Você forjou um picareta de ferro rara.");
}
else if(m == 2 & h > 50)
{
    Console.WriteLine("Você forjou um picareta de Aço rara.");
}
else if(m == 2 & h <= 50)
{
    Console.WriteLine("Você forjou um picareta de Aço épica.");
}
else if(m == 3 & h > 50)
{
    Console.WriteLine("Você forjou um picareta de Ouro épico.");
}
else if(m == 3 & h <= 50)
{
    Console.WriteLine("Você forjou um picareta de Ouro Lendária.");
}