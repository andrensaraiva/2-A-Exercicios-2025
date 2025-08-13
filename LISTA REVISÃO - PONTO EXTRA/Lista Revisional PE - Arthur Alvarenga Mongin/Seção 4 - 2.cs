int[] dano = new int[5];
Console.WriteLine("Digite o dano de 5 turnos:");
dano[0] = int.Parse(Console.ReadLine());
dano[1] = int.Parse(Console.ReadLine());
dano[2] = int.Parse(Console.ReadLine());
dano[3] = int.Parse(Console.ReadLine());
dano[4] = int.Parse(Console.ReadLine());

int danofinal = (dano[0] + dano[1] + dano[2] + dano[3] + dano[4]);
int danomedio = (danofinal / 50);

Console.WriteLine(" ");
Console.WriteLine("O resultado dos turnos foi: ");
Console.WriteLine(" ");
Console.WriteLine("Dano final: " + danofinal);
Console.WriteLine("Dano medio: " + danomedio);

