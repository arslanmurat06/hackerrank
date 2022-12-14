static int viralAdvertising(int n)
{
    int liked = 0;
    int day = 5;
    int cumulative = 0;

    foreach (var item in Enumerable.Range(1, n))
    {
        if (item != 1)
        {
            day = (day / 2) * 3;
        }

        liked = day / 2;
        cumulative += liked;
    }
    return cumulative;
}


Console.WriteLine(viralAdvertising(3));