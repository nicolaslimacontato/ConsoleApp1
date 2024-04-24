using System;
using System.Collections.Generic;

//Enum

public enum TipoDeDado
{
    D4, D6, D8, D10, D12, D20
}

public enum TipoInimigo
{
    Monstro,
    Chefe
}

public class Inimigos
{
    public Inimigos()
    {

    }
    public string Nome { get; set; }
    public int Level { get; set; }
    public int Dano { get; set; }
    public int Hp { get; set; }
    public int Defesa { get; set; }
    public TipoInimigo TipoDosInimigos { get; set; } // Adicionando a propriedade Tipo
    public TipoDeDado TipoDado { get; set; }
}