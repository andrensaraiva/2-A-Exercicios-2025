Console.WriteLine("Um guarda te bloqueia");
Console.WriteLine("Como você passa por ele 1 - Persuadir , 2 - Subornar , 3 - Lutar");
string resposta = Console.ReadLine();
if  (resposta ==  "1")
{
    Random random = new Random();
    int dado = random.Next(1,21);
    if (dado > 10)
    {
        Console.WriteLine("Você passa pelo guarda");
    }
    else
    {
        Console.WriteLine("Você é preso pelo guarda");
    }
}
else if (resposta == "2")
{
    Console.WriteLine("Quantos moedas de ouro você da para o guarda");
    int dinheiro = int.Parse(Console.ReadLine());
    if (dinheiro >= 50)
    {
        Console.WriteLine("O guarda deixa você passar");
    }
    else
    {
        Console.WriteLine("Você é preso pelo guarda");
    }
}
else if (resposta == "3")
{
    Console.WriteLine("Você luta e consegue passar com poucos ferimentos");
}
else
{
    Console.WriteLine("Digite Direito");
}