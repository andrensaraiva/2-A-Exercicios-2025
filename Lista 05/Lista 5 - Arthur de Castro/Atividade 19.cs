int cristais=0, coletar;

Console.WriteLine("Coletando Recursos");
while (cristais < 20)
{
    Console.WriteLine("Quantos cristais você vai pegar 1 a 3");
    coletar = int.Parse(Console.ReadLine());
    cristais = cristais + coletar;
}
Console.WriteLine("Parabéns você pegou " + cristais);
