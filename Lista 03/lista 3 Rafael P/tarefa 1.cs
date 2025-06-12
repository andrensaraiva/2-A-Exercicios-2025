
String verif = "";
Console.WriteLine("elara, você deseja beber uma poção misteriosa? (sim/não)");
verif = Console.ReadLine();
if (verif == "sim")
{
    Console.WriteLine("você sente uma força mística te recuperando + 10 hp");
}
else
{
    Console.WriteLine("o homem te força a beber a poção, seus sentidos ficam estranhos e você desmaia");
}