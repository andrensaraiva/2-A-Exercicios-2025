string item = "asdasd";
string iten = "sdadw";
int arc = 0;

Console.WriteLine("você encontrou um portal magico que so  se abre com os dois itens magicos ou alto poder arcano.");
Console.WriteLine("você tem o orbe lunar?(sim/nao)");
item = Console.ReadLine();

Console.WriteLine("você tem a gema estelar?(sim/nao)");
iten = Console.ReadLine();

Console.WriteLine("qual é o seu poder arcano?");
arc = int.Parse(Console.ReadLine());

if (item == "sim" && iten == "sim" || arc >= 50)
{
    Console.WriteLine("você consegue passar pelo portal!");
}
else {
    Console.WriteLine("você não passa pelo portal");
}