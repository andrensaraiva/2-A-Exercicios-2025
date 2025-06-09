using System.Runtime.Intrinsics.X86;

string ingrediente1 = "asa de morcego";

string ingrediente2 = "pó de fada";

string ingrediente3 = "Lágrima de Unicórnio";

Console.WriteLine("Peça três ingredientes");

ingrediente1 = Console.ReadLine();

ingrediente2 = Console.ReadLine();

ingrediente3 = Console.ReadLine();

string poção = "ketchup";

Console.WriteLine("Peça o nome da poção.");
poção = Console.ReadLine();

Console.WriteLine("---Receita da Poção: " + poção + "-- - 1.Adicione " + ingrediente1 + ". 2.Misture com " + ingrediente2 + ". 3.Finalize com uma pitada de " + ingrediente3 + ". Sua poção " + poção + " está pronta!");

