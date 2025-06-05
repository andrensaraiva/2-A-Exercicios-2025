// Maquina de Doces Simulada

float choco = 2.50f;
float bala = 0.75f;
float chicle = 5.45f;
int choco2 = 0;
int bala2 = 0;
int chicle2 = 0;
float total = 0.0f;
Console.WriteLine("Quantos chocolates, balas e clicletes voce tem?");
choco2 = int.Parse(Console.ReadLine());
bala2 = int.Parse(Console.ReadLine());
chicle2 = int.Parse(Console.ReadLine());
choco *= choco2; 
bala *= bala2;
chicle *= chicle2;
total = choco + bala + chicle;
Console.WriteLine("Subtotal de chocolate: " + choco + ".");
Console.WriteLine("Subtotal de bala: " + bala + ".");
Console.WriteLine("Subtotal de chiclete: " + chicle + ".");
Console.WriteLine("Total a pagar: " + total + ".");