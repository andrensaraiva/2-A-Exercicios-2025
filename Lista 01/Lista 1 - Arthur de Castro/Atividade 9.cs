string resposta1, resposta2, resposta3, resposta4;

Console.WriteLine("Qual é a poção que deseja fazer");
resposta1 = Console.ReadLine();
Console.WriteLine("Fale o primeiro ingrediente");
resposta2 = Console.ReadLine();
Console.WriteLine("Fale o segundo ingrediente");
resposta3 = Console.ReadLine();
Console.WriteLine("Fale o terceiro ingrediente");
resposta4 = Console.ReadLine();

Console.WriteLine("Receita da Poção: " + resposta1);
Console.WriteLine("1. Adicione " +  resposta2);
Console.WriteLine("2. Misture com " + resposta3);
Console.WriteLine("3. Finalize com uma pitada de " + resposta4);
Console.WriteLine("Aperte Qualquer Botão para finalizar a poção");
Console.ReadLine();
Console.WriteLine("A poção " + resposta1 + " está pronta!");
