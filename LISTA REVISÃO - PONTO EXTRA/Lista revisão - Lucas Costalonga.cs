#include <iostream>

using System;

class Program
{
    static void Main()
    {
//sessao 1
        string nome = "Dragão Sombrio";
        int hp = 300;
        float velocidadeDeAtaque = 2.5f;
        bool ehChefeDeFase = true;
        int danoDoJogador = 80;
        int defesaDoMonstro = 30;
        int danoFinal = danoDoJogador - defesaDoMonstro;
        float vidaInicial = 100f;
        float vidaRestante = vidaInicial - danoFinal;
        float vidaRestantePercentual = (vidaRestante / vidaInicial) * 100;
        int dragoesDeOuro = 7;
        float taxaConversao = 15.5f;
        float gemasDePrata = dragoesDeOuro * taxaConversao;
        bool jogadorTemChave = false;
        bool portaEstaAberta = true;
        bool podePassar;
        string nomeHeroi = "Kael";
        string classeHeroi = "Guerreiro";
        int nivelHeroi = 15;

        string tituloCompleto = "Sir " + nomeHeroi + ", o " + classeHeroi + " de Nível " + nivelHeroi;
        int tempoTotal = tempoBase + penalidade;
        string clima = "Nevando";
        string montaria = "Lobo";
        int tempoBase = 10;
        int penalidade = 0;
        int furtividade = 13;
        int agilidade = 15;
        bool temCartaRecomendacao = false;
        string ataque = "Fogo";
        string inimigo = "Grama";
        int danoBase = 50;
        int danoFinal = danoBase;
        string abordagem = "persuadir";
        int ouroOferecido = 40;
        int hp = 100;
        int escolhaPocao = 1; // 1 = Cura, 2 = Força, 3 = Mana
        int ouro = 100;
         int estadoEmocional = 4;

        string tipoArma = "Espada";
        int dano = 10;
        int velocidade = 5;
        string runa = "F", "A", "T";

        string[] cinto = new string[4] { "Poção", "Faca", "Chave", "Mapa" };

        int[] danos = new int[5] { 20, 35, 15, 40, 30 };
        int soma = 0;
        float media = soma / (float)danos.Length;

        string[] ingredientes = { "Raiz", "Olho de Tritão", "Lágrima de Fênix", "Pó de Fada", "Sangue de Lobo", "Cogumelo Mágico" };
        string procurado = "Pó de Fada";
        bool encontrado = false;

        string[] feitiços = { "Bola de Fogo", "Gelo Congelante", "Trovão Mortal", "Cura Sagrada" };

        string[] nomesItens = { "Amuleto do Vento", "Anel das Sombras", "Capa de Invisibilidade" };
        int[] valoresItens = { 150, 200, 300 };
        int slotEscolhido = 2;

        int andar = 1;
        int maxAndares = 5; // Simulação sem input

        int codigoSecreto = 1337;
        int[] palpites = { 1234, 1111, 1337 }; // Três tentativas simuladas
        bool acertou = false;

        Random rnd = new Random();
        int madeiraTotal = 0;
        int turno = 0;
        
        Console.WriteLine("===== FICHA DO MONSTRO =====");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("HP: " + hp);
        Console.WriteLine("Velocidade de Ataque: " + velocidadeDeAtaque);
        Console.WriteLine("É chefe de fase? " + ehChefeDeFase);
        Console.WriteLine();
        
        Console.WriteLine("===== BATALHA =====");
        Console.WriteLine("Dano Final no monstro: " + danoFinal);

        Console.WriteLine("Vida restante do monstro: " + vidaRestantePercentual + "%");
        Console.WriteLine();
        
        Console.WriteLine("===== CONVERSOR DE MOEDAS =====");
        Console.WriteLine("Você possui " + gemasDePrata + " Gemas de Prata.");
        Console.WriteLine();

        if (portaEstaAberta || jogadorTemChave)
        {
            podePassar = true;
        }
        else
        {
            podePassar = false;
        }

        Console.WriteLine("===== VERIFICADOR DE CONDIÇÃO =====");
        Console.WriteLine("Pode passar pela porta? " + podePassar);
        Console.WriteLine();
        

        Console.WriteLine("===== TÍTULO DO HERÓI =====");
        Console.WriteLine(tituloCompleto);
    }

//sessao 2
    using System;

class Program
{
    static void Main()
    {
        int nivelLadinagem = 12;

        Console.WriteLine("===== BAÚ DO TESOURO =====");

        if (nivelLadinagem > 15)
        {
            Console.WriteLine("Você desarmou a armadilha e ganhou o tesouro!");
        }
        else if (nivelLadinagem > 10)
        {
            Console.WriteLine("Você desarmou a armadilha, mas não encontrou nada.");
        }
        else
        {
            Console.WriteLine("A armadilha foi ativada! Você perdeu HP!");
        }

        Console.WriteLine();
        

        Console.WriteLine("===== DIÁLOGO COM O GUARDA =====");

        if (abordagem == "persuadir")
        {
            Random rnd = new Random();
            int dado = rnd.Next(1, 21); // D20

            Console.WriteLine("Resultado do dado: " + dado);

            if (dado > 10)
            {
                Console.WriteLine("Você persuadiu o guarda e passou!");
            }
            else
            {
                Console.WriteLine("O guarda ficou irritado. Você não passou.");
            }
        }
        else if (abordagem == "subornar")
        {
            if (ouroOferecido > 50)
            {
                Console.WriteLine("O guarda aceitou o suborno. Você passou.");
            }
            else
            {
                Console.WriteLine("O guarda recusou o suborno.");
            }
        }
        else if (abordagem == "lutar")
        {
            hp -= 20;
            Console.WriteLine("Você lutou, perdeu HP, mas passou.");
            Console.WriteLine("HP atual: " + hp);
        }

        Console.WriteLine();
        

        Console.WriteLine("===== DANO ELEMENTAL =====");

        if ((ataque == "Fogo" && inimigo == "Grama") ||
            (ataque == "Agua" && inimigo == "Fogo") ||
            (ataque == "Grama" && inimigo == "Agua"))
        {
            danoFinal *= 2;
            Console.WriteLine("É super eficaz!");
        }
        else if ((ataque == "Grama" && inimigo == "Fogo") ||
                 (ataque == "Fogo" && inimigo == "Agua") ||
                 (ataque == "Agua" && inimigo == "Grama"))
        {
            danoFinal /= 2;
            Console.WriteLine("É pouco eficaz!");
        }
        else if (ataque == inimigo)
        {
            danoFinal /= 2;
            Console.WriteLine("É pouco eficaz!");
        }
        else
        {
            Console.WriteLine("Dano normal.");
        }

        Console.WriteLine("Dano final: " + danoFinal);
        Console.WriteLine();
        

        Console.WriteLine("===== ACESSO À GUILDA =====");

        if ((furtividade > 12 && agilidade > 14) || temCartaRecomendacao)
        {
            Console.WriteLine("Você foi aceito na Guilda dos Ladrões!");
        }
        else
        {
            Console.WriteLine("Acesso negado à guilda.");
        }

        Console.WriteLine();
        
        Console.WriteLine("===== CLIMA E VIAGEM =====");

        // Clima
        if (clima == "Chuvoso")
            penalidade += 2;
        else if (clima == "Nevando")
            penalidade += 5;

        // Montaria
        switch (montaria)
        {
            case "Cavalo":
                penalidade += 3;
                break;
            case "Lobo":
                penalidade -= 4;
                break;
        }

        // Desafio especial
        if (clima == "Nevando" && montaria == "Sem Montaria")
        {
            penalidade *= 2;
        }

        
        Console.WriteLine("Tempo total da viagem: " + tempoTotal + " horas");
    }

class Program
{
    static void Main()
    {
        
        Console.WriteLine("===== MÁQUINA DE POÇÕES =====");

        switch (escolhaPocao)
        {
            case 1:
                Console.WriteLine("Você escolheu Poção de Cura. +50 HP.");
                ouro -= 25;
                break;
            case 2:
                Console.WriteLine("Você escolheu Poção de Força. +10 de dano por 5 turnos.");
                ouro -= 40;
                break;
            case 3:
                Console.WriteLine("Você escolheu Poção de Mana. +30 MP.");
                ouro -= 30;
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.WriteLine("Ouro restante: " + ouro + "\n");

                string cidade = "Ventobravo";
        int custo = 0;

        Console.WriteLine("===== TELETRANSPORTE =====");

        switch (cidade)
        {
            case "Ventobravo":
                custo = 15;
                Console.WriteLine("Você viajou para Ventobravo. Capital dos humanos.");
                break;
            case "Orgrimmar":
                custo = 20;
                Console.WriteLine("Você viajou para Orgrimmar. Cidade dos orcs e guerreiros.");
                break;
            case "Dalaran":
                custo = 30;
                Console.WriteLine("Você viajou para Dalaran. Centro dos magos.");
                break;
            default:
                Console.WriteLine("Cidade desconhecida.");
                break;
        }

        Console.WriteLine("Custo da viagem: " + custo + " moedas.\n");

               

        Console.WriteLine("===== INTERAÇÃO COM NPC =====");

        switch (estadoEmocional)
        {
            case 1:
                Console.WriteLine("NPC (Feliz): Olá, aventureiro! Que bom te ver!");
                break;
            case 2:
                Console.WriteLine("NPC (Neutro): O que você quer?");
                break;
            case 3:
                Console.WriteLine("NPC (Triste): Não estou em um bom dia...");
                break;
            case 4:
                Console.WriteLine("NPC (Irritado): Saia da minha frente antes que eu me irrite mais!");
                break;
            default:
                Console.WriteLine("NPC não está disponível.");
                break;
        }

        Console.WriteLine();

        Console.WriteLine("===== BÔNUS DE ARMA =====");

        switch (tipoArma)
        {
            case "Espada":
                dano += 5;
                velocidade += 3;
                break;
            case "Machado":
                dano += 8;
                velocidade -= 2;
                break;
            case "Arco":
                dano += 4;
                velocidade += 5;
                break;
            default:
                Console.WriteLine("Arma desconhecida.");
                break;
        }

        Console.WriteLine("Arma: {tipoArma} | Dano: {dano} | Velocidade: {velocidade}");

        Console.WriteLine("===== CONVERSOR DE RUNA =====");

        switch (runa)
        {
            case 'F':
                Console.WriteLine("Elemento: Fogo");
                break;
            case 'A':
                Console.WriteLine("Elemento: Água");
                break;
            case 'T':
                Console.WriteLine("Elemento: Terra");
                break;
            default:
                Console.WriteLine("Runa inválida.");
                break;
        }

        Console.WriteLine();
    }
}
    

Console.WriteLine("===== Cinto de Utilidades =====");
for (int i = 0; i < cinto.Length; i++)
{
    Console.WriteLine($"Slot {i + 1}: {cinto[i]}");
}
Console.WriteLine();

for (int i = 0; i < danos.Length; i++)
{
    soma += danos[i];
}

Console.WriteLine("===== Histórico de Batalha =====");
Console.WriteLine("Dano total: " + soma);
Console.WriteLine("Dano médio: " + media);
Console.WriteLine();

Console.WriteLine("===== Procurando Ingrediente =====");

for (int i = 0; i < ingredientes.Length; i++)
{
    if (ingredientes[i] == procurado)
    {
        Console.WriteLine($"Ingrediente encontrado no slot #{i + 1}!");
        encontrado = true;
        break;
    }
}

if (encontrado)
{
    Console.WriteLine("Ingrediente não encontrado.");
}

Console.WriteLine();

Console.WriteLine("===== Feitiços Invertidos =====");

for (int i = feitiços.Length - 1; i >= 0; i--)
{
    Console.WriteLine(feitiços[i]);
}

Console.WriteLine();

Console.WriteLine("===== Itens Raros =====");

if (slotEscolhido >= 0 && slotEscolhido < nomesItens.Length)
{
    Console.WriteLine($"Item: {nomesItens[slotEscolhido]}, Valor: {valoresItens[slotEscolhido]} ouro");
}
else
{
    Console.WriteLine("Slot inválido.");
}

Console.WriteLine();

    //sessao 5

    Console.WriteLine("===== Forjando Espada =====");

for (int i = 1; i <= 8; i++)
{
    Console.WriteLine($"Martelada #{i}...");

    if (i % 2 == 0)
    {
        Console.WriteLine("O ferreiro mergulha a lâmina na água!");
    }
}
Console.WriteLine();

    Console.WriteLine("===== Torre Infinita =====");

while (andar <= maxAndares)
{
    Console.WriteLine($"Você chegou ao andar #{andar}!");
    andar++;
}
Console.WriteLine();

    Console.WriteLine("===== Código Secreto =====");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Tentativa #{i + 1}: {palpites[i]}");

    if (palpites[i] == codigoSecreto)
    {
        Console.WriteLine("Você acertou o código!");
        acertou = true;
        break;
    }
    else
    {
        Console.WriteLine("Código incorreto.");
    }
}

if (!acertou)
{
    Console.WriteLine("Suas tentativas acabaram.");
}
Console.WriteLine();

    Console.WriteLine("===== Coleta de Madeira =====");

while (madeiraTotal < 50)
{
    int coleta = rnd.Next(5, 11); // de 5 a 10
    madeiraTotal += coleta;
    turno++;
    Console.WriteLine($"Turno {turno}: coletou {coleta} madeiras (total: {madeiraTotal})");
}
Console.WriteLine();

Console.WriteLine("===== Batalha Final =====");

int hpChefe = 100;

while (hpChefe > 0)
{
    Console.WriteLine("Usando Combo de 3 Golpes!");

    for (int i = 1; i <= 3; i++)
    {
        int dano = rnd.Next(10, 21); // Dano entre 10 e 20
        Console.WriteLine($"Golpe {i}: causou {dano} de dano!");
        hpChefe -= dano;
    }

    if (hpChefe < 0)
        hpChefe = 0;

    Console.WriteLine($"HP restante do chefe: {hpChefe}\n");
}

Console.WriteLine("Você venceu o chefe!");









    











