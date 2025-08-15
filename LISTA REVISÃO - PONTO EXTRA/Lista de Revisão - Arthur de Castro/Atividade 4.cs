bool chave = false;
bool portaestaaberta = false;

Console.WriteLine("Verificador de Condição");
Console.WriteLine("Você tem a Chave 1 - Sim ou 2 - Não");
string resposta = Console.ReadLine();

if (resposta == "1")
{
    chave = true;
}
Console.WriteLine("A porta está aberta 1 - Sim ou 2 - Não");
resposta = Console.ReadLine();

if (resposta == "1")
{
    portaestaaberta = true;
}

bool podepassar;
if (chave == true || portaestaaberta == true)
{
    podepassar= true;
}
else
{
    podepassar= false;
}

Console.WriteLine("PodePassar = " +  podepassar);   