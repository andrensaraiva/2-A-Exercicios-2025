using System.ComponentModel.Design;
using System.Security.Authentication;

string resposta;

Console.WriteLine("A ponte parece instável. Você quer atravessar? (sim/nao)");
resposta = Console.ReadLine();

{if (resposta == "sim")
    {Console.WriteLine("Você atravessa com cuidado e chega em segurança.");}
else { Console.WriteLine("Você decide procurar outro caminho. Melhor prevenir!"); }
  
}