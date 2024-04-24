public class Jogador
{
    public Jogador(string nome)
    {
        Nome = nome;
        Nivel = 1;
        DefesaJogador = 10;
        PontosDeVida = CalcularPontosDeVida();
    }
    public string Nome { get; set; }
    public int Nivel { get; set; }
    public int PontosDeVida { get; set; }
    public int DefesaJogador { get; set; }

    private int CalcularPontosDeVida()
    {
        return Nivel * 8;
    }
    public string EscolherClasse(string classe)
    {
        do
        {
            switch (classe)
            {
                case "G":
                    Console.WriteLine("\nVocê escolheu a classe Guerreiro!");
                    // Aqui você pode inicializar o jogador como um Guerreiro
                    // Exemplo: jogador = new Guerreiro();
                    return classe;
                case "M":
                    Console.WriteLine("\nVocê escolheu a classe Mago!");
                    // Aqui você pode inicializar o jogador como um Mago
                    // Exemplo: jogador = new Mago();
                    return classe;
                default:
                    Console.WriteLine("\nOpção inválida. Por favor, escolha uma das opções fornecidas.");
                    // Solicita novamente a entrada do usuário
                    Console.WriteLine($"\n{Nome} você é um aventureiro de cavernas qual é sua classe?\n\n(G) Guerreiro: Defesa Alta, Dano: Baixo\n(M) Mago: Defesa Baixa, Dano Alto\n");

                    classe = Console.ReadLine().ToUpper();
                    break;
            }
        } while (true); // Repete o loop indefinidamente até que uma escolha válida seja feita
    }
}