int numero = 0;

Console.WriteLine("Qual botão você aperta? (1 = vermelho , 2 = azul , 3 = verde)");
numero = int.Parse(Console.ReadLine());

if (numero == 1)
{
    Console.WriteLine("Nada acontece com o botão vermelho.");
}

else if (numero == 2)
{
    Console.WriteLine("A porta se abre! O botão azul era o correto.");
}

else if (numero == 3)
{
    Console.WriteLine("O botão verde não funciona.");
}

else if (numero >= 4)
{
    Console.WriteLine("Escolha inválida.");
}