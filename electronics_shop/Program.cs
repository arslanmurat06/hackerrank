
Console.WriteLine(getMoneySpent(new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10));

int getMoneySpent(int[] keyboards, int[] drives, int b)
{

    int maxPrice = 0;

    foreach (var keyboard in keyboards)
    {
        if (keyboard > b) continue;
        foreach (var drive in drives)
        {
            if (drive > b) continue;

            if ((keyboard + drive) > b) continue;

            var newPrice = keyboard + drive;

            if (newPrice >= maxPrice)
                maxPrice = newPrice;
        }
    }
    if (maxPrice == 0)
        return -1;

    return maxPrice;

}