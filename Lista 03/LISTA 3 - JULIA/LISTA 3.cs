// programa: A Poção Misteriosa 1
        Console.WriteLine("Elara, voce quer beber a pocao? (sim/nao)");
        string pocao = Console.ReadLine();

        if (pocao == "sim")
        {
            Console.WriteLine("Voce bebe a pocao! Um calor percorre seu corpo. (HP +10)");
        }
        else
        {
            Console.WriteLine("Voce guarda a pocao para depois. Quem sabe o que ela faz?");
}

//programa: Bau Trancado 2

        Console.WriteLine("Voce tem a 'Chave de Cobre'? (sim/nao)");
        string chave = Console.ReadLine();
        if (chave == "sim")
        {
            Console.WriteLine("Voce abre o bau e encontra 50 moedas de ouro!");
        }
        else
        {
            Console.WriteLine("O bau esta trancado. Voce precisa da chave certa.");
}

// programa: Ponte Fragil 3
 
Console.WriteLine("A ponte parece instavel. Voce quer atravessar? (sim/nao)");
        string resposta = Console.ReadLine();
        if (resposta == "sim")
        {
            Console.WriteLine("Voce atravessa com cuidado e chega em seguranca.");
        }
        else
        {
            Console.WriteLine("Voce decide procurar outro caminho. Melhor prevenir!");
}

// programa:Nivel Desafio 4
 
        Console.WriteLine("Qual e o seu nivel atual?");
        int nivel = int.Parse(Console.ReadLine());
if (nivel >= 5)
{
    Console.WriteLine("Voce e forte o bastante! A caverna se abre.");
}
else
{
    Console.WriteLine("Volte quando estiver mais forte, Elara.");

}

// programa:Enigma Cores 5
 
        Console.WriteLine("Qual botao voce aperta? (1 = Vermelho, 2 = Azul, 3 = Verde)");
        int botao = int.Parse(Console.ReadLine());
        if (botao == 2)
        {
            Console.WriteLine("A porta se abre! O botao Azul estava certo.");
        }
        else if (botao == 1)
        {
            Console.WriteLine("Nada acontece com o botao Vermelho.");
        }
        else if (botao == 3)
        {
            Console.WriteLine("O botao Verde nao funcionou.");
        }
        else
        {
            Console.WriteLine("Escolha invalida, Elara.");
}

//programa:Oferta do Ferreiro 6
 
        Console.WriteLine("Quantas moedas de ouro voce tem?");
        int moedas = int.Parse(Console.ReadLine());
        Console.WriteLine("Voce e membro da Guilda? (sim/nao)");
        string guilda = Console.ReadLine();
        if (moedas >= 100 && guilda == "sim")
        {
            Console.WriteLine("Desconto especial! Voce compra uma arma rara.");
        }
        else if (moedas >= 100 && guilda == "nao")
        {
            Console.WriteLine("Voce compra uma arma comum.");
        }
        else if (moedas < 100 && guilda == "sim")
        {
            Console.WriteLine("Voce pode comprar uma adaga com desconto.");
        }
        else
        {
            Console.WriteLine("Voce nao tem ouro suficiente.");
}

// programa: Portal Instavel 7

        Console.WriteLine("Voce tem a Gema Estelar? (sim/nao)");
        string gema = Console.ReadLine();
        Console.WriteLine("Voce tem o Orbe Lunar? (sim/nao)");
        string orbe = Console.ReadLine();
        Console.WriteLine("Seu Poder Arcano e maior que 50? (sim/nao)");
        string poder = Console.ReadLine();
        if ((gema == "sim" && orbe == "sim") || poder == "sim")
        {
            Console.WriteLine("O portal se estabiliza e voce atravessa com sucesso!");
        }
        else
        {
            Console.WriteLine("O portal esta instavel demais para usar.");
}

//programa: Goblin Negociador 8 

        Console.WriteLine("O goblin esta de bom humor hoje? (sim/nao)");
        string humor = Console.ReadLine();
        Console.WriteLine("Voce tem um 'Olho de Dragao Polido'? (sim/nao)");
        string item = Console.ReadLine();
        if (humor == "sim" || item == "sim")
        {
            Console.WriteLine("O goblin aceita negociar com voce.");
        }
        else
        {
            Console.WriteLine("O goblin rosna e se recusa a negociar.");
}

// programa: Caverna Ecos 9

        Console.WriteLine("Escolha um tunel: 1 = esquerda (umido), 2 = direita (com brilho)");
        int tunel = int.Parse(Console.ReadLine());
        if (tunel == 1)
        {
            Console.WriteLine("Voce entra no tunel umido e escuta passos atras de voce...");
            Console.WriteLine("Voce quer correr? (sim/nao)");
            string correr = Console.ReadLine();
            if (correr == "sim")
            {
                Console.WriteLine("Voce corre e escapa de uma criatura invisivel!");
            }
            else
            {
                Console.WriteLine("A criatura te alcança e voce precisa lutar!");
            }
        }
        else if (tunel == 2)
        {
            Console.WriteLine("Voce segue o brilho e encontra cristais raros.");
            Console.WriteLine("Quer coletar os cristais? (sim/nao)");
            string coletar = Console.ReadLine();
            if (coletar == "sim")
            {
                Console.WriteLine("Os cristais brilham intensamente. Voce sente-se energizada!");
            }
            else
            {
                Console.WriteLine("Voce respeita o ambiente e segue em frente.");
            }
        }
        else
        {
            Console.WriteLine("Tunel invalido.");
}

//programa: Resgate Grifo 10
 
        Console.WriteLine("Sua Pericia com Armadilhas e maior que 7? (sim/nao)");
        string pericia = Console.ReadLine();
        Console.WriteLine("Voce conhece o Feitico de Dissipacao Menor? (sim/nao)");
        string feitiço = Console.ReadLine();
        Console.WriteLine("Voce possui um Cristal de Amplificacao? (sim/nao)");
        string cristal = Console.ReadLine();
        if ((pericia == "sim" && feitiço == "sim") || (feitiço == "sim" && cristal == "sim"))
        {
            Console.WriteLine("Voce consegue libertar o grifo com sucesso!");
        }
        else
        {
            Console.WriteLine("A armadilha magica permanece firme. O grifo ainda esta preso.");
        }