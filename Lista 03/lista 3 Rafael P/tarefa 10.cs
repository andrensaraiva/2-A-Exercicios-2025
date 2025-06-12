string per = "";
string feit = "";
string crst = "";

Console.WriteLine("um grifo ficou preso em uma armadilha na floresta");
Console.WriteLine("você tem um nível de perícia de armadilhas maior que 7?");
Console.WriteLine("sim/não");
per = Console.ReadLine();

Console.WriteLine("você conheçe algum feitiço de dissipação?");
Console.WriteLine("sim/não");
feit = Console.ReadLine();


Console.WriteLine("você possui algum cristal de aplificação?");
Console.WriteLine("sim/não");
crst = Console.ReadLine();

if (per == "sim" && feit == "sim" && crst == "sim")
{
    Console.WriteLine("ótimo, o seu feitiço pode ser realizado com sucesso e o grifo foi resgatado");
}
else if (per == "sim" && feit == "sim" && crst == "não")
{
    Console.WriteLine("você tentou várias vezes mas sem um cristal de amplificação, o seu feitiço não vai dar certo");
}
else if (per == "sim" && feit == "não" && crst == "sim")
{
    Console.WriteLine("você tentou várias vezes mas sem conhecer um feitiço bom, o seu feitiço não vai dar certo");
}
else if (per == "não" && feit == "sim" && crst == "sim")
{
    Console.WriteLine("você tentou várias vezes mas com um nível tão baixo, o seu feitiço não vai dar certo");
}
else
{
    Console.WriteLine("você não tem o que precisa para concluir o feitiço, talvez seja melhor tentar de outra forma ou tentar resgatar o grifo depois");
}