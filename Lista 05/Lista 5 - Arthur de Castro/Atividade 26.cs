string[] salas = new string[5];
int total;
salas[0] = "Corredor Vazio";
salas[1] = "Sala com Armadilha";
salas[2] = "Sala com Tesouro";
salas[3] = "Sala com Monstro";
salas[4] = "Chefe da Masmorra";

Console.WriteLine("=== Masmorra ===");
Console.Write("Quantas salas a masmorra terá?");
total = int.Parse(Console.ReadLine());

for (int i = 0; i < total; i++)
{
    Random random = new Random();
    int escolha = random.Next(5);

    Console.WriteLine("Sala "+ (i+1) + ": Você entra em " + salas[escolha] );
    switch (escolha)
    {
        case 0:
            Console.WriteLine("Sem perigos e itens");
            Console.ReadLine();
            break;
        case 1:
            Console.WriteLine("Sala com muitas armadilhas");
            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("Sala com muitos tesouros");
            Console.ReadLine();
            break;
        case 3:
            Console.WriteLine("Sala tem um perigo consideravel,Cuidado!");
            Console.ReadLine();
            break;
        case 4:
            Console.WriteLine("A Sala tem um dos montros mais fortes da masmorra, Boa Sorte!");
            Console.ReadLine();
            break;
    }
        
}