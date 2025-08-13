Console.WriteLine("Para entra na guilda dos ladroes voce precisa ter alguns requesitos.");
Console.WriteLine(" ");
Console.WriteLine("Qual seu nivel de furtividade?");
int furtividade = int.Parse(Console.ReadLine());
Console.WriteLine("Qual seu nivel de agilidade");
int agilidade = int.Parse(Console.ReadLine());
Console.WriteLine("Se tiver uma carta de recomendação, podera entrar na guilda mesmos sem os requisitos, voce tem uma carta de recomendação? (true ou false)");
bool carta = bool.Parse(Console.ReadLine());
 if (furtividade >= 12 && agilidade >= 14 || carta == true)
{
    Console.WriteLine("Voce foi aceito!");
}
else
{
    Console.WriteLine("Voce nao foi aceito.");
}