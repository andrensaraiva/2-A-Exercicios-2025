int furtividade;
int agilidade;
bool carta;

Console.WriteLine("Verificador de Acesso à Guilda");
Console.WriteLine("Qual é seu level de furtividade");
furtividade = int.Parse(Console.ReadLine());
Console.WriteLine("Qual é seu level de agilidade");
agilidade = int.Parse(Console.ReadLine());
Console.WriteLine("Você tem a Carta de Recomendação 1 - Sim , 2 - Não");
string resposta = Console.ReadLine();
if (resposta == "1")
{
    carta = true;
}
else
{
     carta = false;
}

if (furtividade >= 12 && agilidade >= 14 || carta == true)
{
    Console.WriteLine("Você foi aceito na guilda");
}
else
{
    Console.WriteLine("Você foi rejeitado");
}
