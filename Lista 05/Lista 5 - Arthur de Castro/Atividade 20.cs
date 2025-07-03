int[] coisas = new int[5];
coisas[3] = 20;

Console.WriteLine("Quantos andares a torre tem?");
coisas[0] = int.Parse(Console.ReadLine());

while (coisas[1] < coisas[0])
{
    Console.WriteLine("Você sube um andar aparece [1]monstro ou [2]báu ");
    coisas[2] = int.Parse(Console.ReadLine());
    switch (coisas[2])
    {
        case 1:
            Console.WriteLine("Você é atacado é perde 5 de vida ");
            coisas[3] = coisas[3] - 5;
            break;
        case 2:
            Console.WriteLine("Você ganha 5 de vida");
            coisas[3] = coisas[3] + 5;
            break;
    }   
    if (coisas[3] <= 0)
    {
        Console.WriteLine("Você morreu");
        coisas[1] = coisas[1] + coisas[0];
    }
}