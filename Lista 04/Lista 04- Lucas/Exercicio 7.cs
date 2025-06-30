int a;

Console.WriteLine("Voce chega em uma pequena cidade e pede informações a uma mulher sobre a localização do Vale das Almas.");
Console.WriteLine("Seja bem vindo ao Vale de Hawkings, me diga visitante, qual a sua fama?(1 = heroi, 2 = vilão, 3 = mercenario)");
a = int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("Vejo que você é um herói, visto que sua honra aqui na cidade, eu posso lhe contar onde fica o Vale das Almas.");  
}
else if (a == 2)
{
    Console.WriteLine("Vejo que você é um vilão, visto que sua honra aqui na cidade, eu não posso lhe contar onde fica o Vale das Almas.");
}
else if (a == 3)
{
    Console.WriteLine("Vejo que você é um mercenário, visto que sua honra aqui na cidade, eu posso lhe contar onde fica o Vale das Almas se voce me oferecer algo bom.");

}