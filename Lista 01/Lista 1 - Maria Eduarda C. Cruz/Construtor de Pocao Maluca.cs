// Construtor de Pocao Maluca

string ing1;
string ing2;
string ing3;
string pocao;
Console.WriteLine("Escreva o nome de um ingrediente: ");
ing1 = Console.ReadLine();
Console.WriteLine("Mais um: ");
ing2 = Console.ReadLine();
Console.WriteLine("O ultimo ingrediente: ");
ing3 = Console.ReadLine();
Console.WriteLine("E qual vai ser o nome da pocao? ");
pocao = Console.ReadLine();
Console.WriteLine("Receita da pocao " + pocao + ": 1. Adicione " + ing1 + " 2. Misture com " + ing2 + " 3. Finalize com uma pitada de " 
    + ing3 + ". Sua pocao " + pocao + " esta pronta!");
