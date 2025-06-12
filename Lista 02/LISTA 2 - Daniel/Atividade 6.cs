// 6. Calculadora de Média

float a;
float b;
float c,d;

Console.WriteLine("Me diga suas três nota em valores decimais:");

a = float.Parse(Console.ReadLine());
b = float.Parse(Console.ReadLine());
c = float.Parse(Console.ReadLine());

d = (a + b + c);
Console.WriteLine("Media aritmetica:" + (d / 3 ));

