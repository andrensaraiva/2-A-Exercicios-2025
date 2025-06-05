string a = "11";
string b = "12";
string c = "13"; 
string d = "14";

Console.WriteLine("Hoje vamos fazer uma poção! Escolha um ingrediente");

a = Console.ReadLine();

Console.WriteLine("Mais 1");

b = Console.ReadLine();

Console.WriteLine("Escolha o último");

c = Console.ReadLine();

Console.WriteLine("Agora escolha o nome da poção"); 

d = Console.ReadLine();


Console.WriteLine("--- Receita da Poção: " + d +  " ---");
Console.WriteLine("1. Adicione: " + a);
Console.WriteLine("2. Misture com: " + b);
Console.WriteLine("3. Finalize com uma pitada " + c);
Console.WriteLine("Sua poção " + c + " está pronta! ");
