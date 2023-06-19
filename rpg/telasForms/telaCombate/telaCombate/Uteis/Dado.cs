using System;

public static class Dado
{
    public static int RandomNumber(int minValue, int maxValue)
    {
        Random random = new Random();
        return random.Next(minValue, maxValue + 1);
    }
}
