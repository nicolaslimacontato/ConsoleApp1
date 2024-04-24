public class RolarDados
{
    private static Random random = new Random();

    public static int RolarD4()
    {
        return random.Next(1, 5);
    }

    public static int RolarD6()
    {
        return random.Next(1, 7);
    }

    public static int RolarD8()
    {
        return random.Next(1, 9);
    }

    public static int RolarD12()
    {
        return random.Next(1, 13);
    }

    public static int RolarD20()
    {
        return random.Next(1, 21);
    }
}

