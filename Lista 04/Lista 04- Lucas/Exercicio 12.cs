int m, h;
Console.WriteLine("Escolha um minério para fazer sua espada");
Console.WriteLine("1, ferro = comum");
Console.WriteLine("2, diamante = raro");
Console.WriteLine("3, rubi = épico");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Qual seu nivel de habilidade com a forja?");
h = int.Parse(Console.ReadLine());

if (m == 1 & h >= 50)
{
    Console.WriteLine("Voce forjou uma espada de ferro de nivel comum");
}
else if (m == 1 & h <= 50)
{
    Console.WriteLine("Voce não conseguiu forjar sua espada, volte quando tiver um nivel maior de habilidade com forja");
}
else if (m == 2 & h >= 50)
{
    Console.WriteLine("Voce forjou uma espada de diamante de nivel raro");
}
else if (m == 2 & h <= 50)
{
    Console.WriteLine("Voce não conseguiu forjar sua espada, volte quando tiver um nivel maior de habilidade com forja");
}
else if (m == 3 & h >= 50)
{
    Console.WriteLine("Voce forjou uma espada de rubi de nivel épico");
}
else if (m == 3 & h <= 50)
{
    Console.WriteLine("Voce não conseguiu forjar sua espada, volte quando tiver um nivel maior de habilidade com forja");
}