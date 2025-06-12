int red = 0;

Console.WriteLine("você se depara com 3 botoes um vermelho, um azul e um verde , qual você quer apertar?(vermelho= 1 / azul= 2  / verde= 3");
red = int.Parse(Console.ReadLine());

if (red == 1)
{
    Console.WriteLine("botao vermelho fez nada");
}
else if (red == 2)
{
    Console.WriteLine("o botao azul abriu a porta! uhuuuuul!");
}
else if (red == 3)
{
    Console.WriteLine("botao verde fez nada tbm");
}
else { 
Console.WriteLine("burro são  só aquelas opções");    
}
