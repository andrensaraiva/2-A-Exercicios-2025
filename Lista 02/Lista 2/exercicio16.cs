Console.WriteLine("Bala-bombom = 1");
int n29 = 1;

Console.WriteLine("Pirulito = 2");
int n30 = 2;

Console.WriteLine("torta = 10");
int n31 = 10;

Console.WriteLine("Quantas Balas-bombom você quer? ");
int n32 = int.Parse(Console.ReadLine());

Console.WriteLine("subtotal Bala-bombom: " + (n29 * n32));

Console.WriteLine("Quantos Pirulitos? ");
int n33 = int.Parse(Console.ReadLine());

Console.WriteLine("subtotal Pirulito: " + (n30 * n33));

Console.WriteLine("Quantas tortas? ");
int n34 = int.Parse(Console.ReadLine());

Console.WriteLine("subtotal Torta: " + (n31 * n34));

Console.WriteLine("Total: " + (n29 * n32 + n30 * n33 + n31 * n34));
