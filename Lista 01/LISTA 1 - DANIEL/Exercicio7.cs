// Gerador de Grito de Guerra

string frase;
string epico;
string alvo;

Console.WriteLine("Agora vamos criar uma frase de impacto!");


Console.WriteLine("Digite aqui um verbo de efeito: ");
frase = Console.ReadLine();



Console.WriteLine("Agora, um substantivo épico.");


Console.WriteLine("Digite aqui (ex: Honra, Glória, Justiça): ");
epico = Console.ReadLine();



Console.WriteLine("Pense em um nome para seu pior inimigo que vai enfrentar.");


Console.WriteLine("E ai... qual vai ser??");
alvo = Console.ReadLine();

Console.WriteLine("Este vai ser seu GRITO DE GUERRA:");

Console.WriteLine("Pela " + epico + "! " + "Vamos " + frase + " e derrotar " + alvo + "!");