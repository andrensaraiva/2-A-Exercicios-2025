string al1, al2, al3;
Console.WriteLine("Você estava andando e acaba encontrando um enigma, onde é preciso posicionar as alavancas de forma certa para resolve-lo");
Console.WriteLine(" ");
Console.WriteLine("Em qual posição você deseja por a primeira alavanca? (cima ou baixo)");
al1 = Console.ReadLine();
Console.WriteLine("Em qual posição você deseja por a segunda alavanca? (cima ou baixo)");
al2 = Console.ReadLine();
Console.WriteLine("Em qual posição você deseja por a terceira alavanca? (cima ou baixo)");
al3 = Console.ReadLine();

int contador = 0;

if (al1 == "cima") contador++;
if (al2 == "baixo") contador++;
if (al3 == "cima") contador++;

if (contador == 3)
{
    Console.WriteLine("A porta se abre!");
}
else
{
    Console.WriteLine("Nada Acontece, a ordem das alavancas esta errada.");
}