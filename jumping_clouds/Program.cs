int jumpingOnClouds(int[] c, int k)
{
    int energy_level = 100;
    var cloudsLength = c.Length;
    int point = 0;

    while (cloudsLength > point)
    {
        point += k;

        if (point >= cloudsLength) point = point - cloudsLength;

        if (c[point] == 1)
            energy_level -= 2;

        energy_level--;

        if (point == 0) break;
    }
    return energy_level;

}

Console.WriteLine(jumpingOnClouds(new int[] { 0, 0, 1, 0, 0, 1, 1, 0 }, 2));
Console.WriteLine(jumpingOnClouds(new int[] { 0, 0, 1, 0 }, 2));
Console.WriteLine(jumpingOnClouds(new int[] { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0 }, 3));
