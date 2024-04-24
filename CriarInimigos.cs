using System;
using System.Collections.Generic;

public class CriarInimigos
{
    // Método para calcular o HP baseado no nível
    private static int CalcularHp(int level)
    {
        return level * 8; // HP = 8 * nível
    }
    // Método para criar monstros pré-definidos
    public static List<Inimigos> CriarMonstros()
    {
        List<Inimigos> monstros = new List<Inimigos>();

        // Adicionar monstros pré-definidos
        monstros.Add(new Inimigos { Nome = "Goblin", Level = 1, TipoDado = TipoDeDado.D4, TipoDosInimigos = TipoInimigo.Monstro, Hp = CalcularHp(1), Defesa = 8 });
        monstros.Add(new Inimigos { Nome = "Zumbi", Level = 3, TipoDado = TipoDeDado.D4, TipoDosInimigos = TipoInimigo.Monstro, Hp = CalcularHp(3), Defesa = 10 });
        monstros.Add(new Inimigos { Nome = "Esqueleto", Level = 2, TipoDado = TipoDeDado.D6, TipoDosInimigos = TipoInimigo.Monstro, Hp = CalcularHp(2), Defesa = 8 });

        return monstros;
    }

    // Método para criar chefes pré-definidos
    public static List<Inimigos> CriarChefes()
    {
        List<Inimigos> chefes = new List<Inimigos>();

        // Adicionar chefes pré-definidos
        chefes.Add(new Inimigos { Nome = "Hobgoblin", Level = 3, TipoDado = TipoDeDado.D6, TipoDosInimigos = TipoInimigo.Chefe, Hp = CalcularHp(3), Defesa = 14 });
        chefes.Add(new Inimigos { Nome = "Bugbear", Level = 5, TipoDado = TipoDeDado.D8, TipoDosInimigos = TipoInimigo.Chefe, Hp = CalcularHp(5), Defesa = 16 });

        return chefes;
    }

}
