float comprCano = 0.0f;
float distância = 0.0f;
float quantidadeCano = 0.0f;
float sobrouCano = 0.0f;


Console.WriteLine("Precisamos encanar este lugar. Qual o comprimento dos canos?");

comprCano = float.Parse(Console.ReadLine());

Console.WriteLine("Qual a distância da encanação?");

distância = float.Parse(Console.ReadLine());

quantidadeCano = distância / comprCano;

sobrouCano = quantidadeCano % 2;

Console.WriteLine("O número de canos a serem usados é" + quantidadeCano);
Console.WriteLine("A quantidade que sobrou foi" + sobrouCano); 





