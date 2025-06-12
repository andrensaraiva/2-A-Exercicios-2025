float n1 = 1f;
float n2 = 2.5f;
float n3 = 2.2f;

Console.WriteLine("fale 1 numero decimal");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("fale mais um");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("fale o ultimo");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine("a média deles é  " + (n1 + n2 + n3 / 3));
