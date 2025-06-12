// 19. Decodificador de Mensagem Secreta


int a, b, c;
string a1, b2, c3;

Console.WriteLine("Decodificador de Mensagem");
Console.WriteLine();
Console.WriteLine("Dgite a mensagem de três letras");
Console.WriteLine("Primeira letra");
a1 = Console.ReadLine();
Console.WriteLine("Segunda letra");
b2 = Console.ReadLine();
Console.WriteLine("Terceira letra");
c3 = Console.ReadLine();
Console.WriteLine("Qual  vai ser o numero para a letra " + a1);
a = int.Parse(Console.ReadLine());
Console.WriteLine("Qual  vai ser o numero para a letra " + b2);
b = int.Parse(Console.ReadLine());
Console.WriteLine("Qual  vai ser o numero para a letra " + c3);
c = int.Parse(Console.ReadLine());
Console.WriteLine(" Sua mensagem codificada é " + a + b + c);

