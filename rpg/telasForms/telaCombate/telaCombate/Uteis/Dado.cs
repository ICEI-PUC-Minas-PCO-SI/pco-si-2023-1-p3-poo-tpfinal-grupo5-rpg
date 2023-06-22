using System;

public static class Dado
{
    public static int RandomNumber(int minValue, int maxValue)
    {
        if(minValue > maxValue){
            int temp = minValue;
            minValue = maxValue;
            maxValue = temp;
        }
        Random random = new Random();
        return random.Next(minValue, maxValue + 1);
    }
}
