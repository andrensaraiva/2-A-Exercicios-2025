bool JogadorTemChave, PortaEstaAberta;

Console.WriteLine("Para passar é necessario que pelo menos uma condição seja verdadeira. (Responda com true ou false)");
Console.WriteLine(" ");
Console.WriteLine("Voce tem a chave?");
JogadorTemChave = bool.Parse(Console.ReadLine());
Console.WriteLine("A porta esta aberta?");
PortaEstaAberta = bool.Parse(Console.ReadLine());
bool PodePassar;        
if (PortaEstaAberta || JogadorTemChave)
{
    PodePassar = true;
    Console.WriteLine("Voce pode passar!");
}
else
{
    Console.WriteLine("Voce nao passa");
}
