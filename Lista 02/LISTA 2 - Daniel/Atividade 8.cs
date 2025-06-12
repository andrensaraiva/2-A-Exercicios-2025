// 8. Contador de Dano Básico

float a;
float b;

Console.WriteLine("Me diga a força de ataque do seu heroi");
a = float.Parse(Console.ReadLine());

Console.WriteLine("Agora a força de defesa do inimigo");
b = float.Parse(Console.ReadLine());


Console.WriteLine("Dano: " + (a - b));


