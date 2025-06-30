Console.WriteLine("Bem-Vindo ao de OastWest");
Console.WriteLine(" ");
Console.WriteLine("De qual facção você deseja ser: Herói, Vilão ou Mercenário (Neutro)? (1,2 ou 3)");
int f;
f= int.Parse(Console.ReadLine());

if (f == 1 )
{
    Console.WriteLine("Vejo que você escolheu ser um herói, também vejo um grande potencial em você, acho que deveria ir conversar com o mestre da guilda dos aventureiros, com certeza vai ter um espaço para você brilhar lá.");
}    
if (f == 2 )
{
    Console.WriteLine("Então você decidiu ser um vilão né, interessante, tenha cuidado, muitos mercenários ganham recompensa por caçar você, porém nada que o dinheiro não possa te ajudar. Você deveria ir procurar a torre do mago, com certeza ele poderá te ajudar;");
}
if (f == 3 )
{
    Console.WriteLine("Vejo que você escolheu ser um mercenário não é mesmo, uma sábia escolha visto que não precisa ter nenhuma responsabilidade, deveria ir a guilda para encontrar contratos, pode haver boas recompensas..");
}