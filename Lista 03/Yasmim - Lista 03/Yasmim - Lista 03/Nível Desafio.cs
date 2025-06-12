// 9. A Caverna dos Ecos

Console.WriteLine("Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)");
int tunel = int.Parse(Console.ReadLine());
if (tunel == 1)
{
  Console.WriteLine("Você avança pelo túnel úmido...");
  Console.WriteLine("Você encontra um lago subterrâneo. Quer explorar o lago? (sim/nao)");
  string explorar = Console.ReadLine();
  if (explorar == "sim")
  {
    Console.WriteLine("Você descobre um baú submerso com itens antigos!");
  }
 else
  {
    Console.WriteLine("Você decide não se arriscar e volta pelo túnel.");
  }
else if (tunel == 2)
{
 Console.WriteLine("Você avança pelo túnel com brilho...");
 Console.WriteLine("O brilho vem de cristais mágicos. Quer tentar extrair um cristal? (sim/nao)");
 string extrair = Console.ReadLine();
 if (extrair == "sim")
 {
  Console.WriteLine("Você extrai um Cristal de Energia Pura!");
 }
 else
 {
  Console.WriteLine("Você decide não tocar nos cristais e segue adiante.");
 }
else
{
 Console.WriteLine("Escolha inválida.");
}

// 10. O Resgate do Grifo

Console.WriteLine("Sua Perícia com Armadilhas é maior que 7? (sim/nao)");
string pericia = Console.ReadLine();
Console.WriteLine("Você conhece o Feitiço de Dissipação Menor? (sim/nao)");
string feitiço = Console.ReadLine();
Console.WriteLine("Você possui um Cristal de Amplificação? (sim/nao)");
string cristal = Console.ReadLine();

if (pericia == "sim" && feitiço == "sim" || feitiço == "sim" && cristal == "sim")
{
    Console.WriteLine("Você consegue libertar o grifo da armadilha mágica!");
}
else
{
    Console.WriteLine("Você falha em libertar o grifo. Ele permanece preso.");
}

// Fim do jogo
Console.WriteLine("Fim das decisões de hoje, Mestre do Jogo!");