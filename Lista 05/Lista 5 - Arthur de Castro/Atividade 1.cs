int resposta;

Console.WriteLine("Menu de Taverna Simples");
Console.WriteLine("Escolha sua bebida [1] Cerveja Amanteigada, [2] Hidromel dos Anões, [3] Água Fresca");
resposta = int.Parse(Console.ReadLine());
switch (resposta) {
    case 1:
        Console.WriteLine("Lembra uma de um mundo de magia");
        break;
    case 2:
        Console.WriteLine("Sabor forte e poderoso como esperado de um anão");
        break;
    case 3:
        Console.WriteLine("Tem um sabor de água");
        break;
    default :
        Console.WriteLine("Não existe ou escreva direito");
        break;
}