using System;
using System.Collections.Generic;

Console.Write("Olá jovem aventureiro qual é seu nome?: ");
string nomeDoJogador = Console.ReadLine();
nomeDoJogador = char.ToUpper(nomeDoJogador[0]) + nomeDoJogador.Substring(1).ToLower();
Jogador jogador = new Jogador(nomeDoJogador);

Console.WriteLine($"\n{jogador.Nome} você é um aventureiro de cavernas qual é sua classe?\n\n(G) Guerreiro: Defesa Alta, Dano: Baixo\n(M) Mago: Defesa Baixa, Dano Alto\n");
string escolhaDaClasse = Console.ReadLine().ToUpper();
jogador.EscolherClasse(escolhaDaClasse);

Console.WriteLine("\nPressione qualquer tecla para encerrar !");
Console.ReadKey();