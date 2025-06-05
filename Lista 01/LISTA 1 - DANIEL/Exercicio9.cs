//  Construtor de Poção Maluca

using System;

string ingre1;
string ingre2;
string ingre3;
string poção;


Console.WriteLine("Me diga o nome de tres ingredientes: ");
Console.WriteLine("1. "); 
    ingre1 = Console.ReadLine();

Console.WriteLine("2. ");
ingre2 = Console.ReadLine();

Console.WriteLine("3. ");
ingre3 = Console.ReadLine();



Console.WriteLine("Agora de nome a sua poção: ");
poção = Console.ReadLine();

Console.WriteLine("--- Receita da Poção: " + poção + "---");

Console.WriteLine("1. Adicione " + ingre1);
Console.WriteLine("2. Misture com " + ingre2);
Console.WriteLine("3. Finalize com uma pitada de " + ingre3);

Console.WriteLine("Sua poção " +poção + " está pronta!");




