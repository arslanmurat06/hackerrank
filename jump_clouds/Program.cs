static int jumpingOnClouds(List<int> c)
{
    var tot = 0;
    for (int i = 0; i < c.Count; i++)
    {
        if (i == c.Count - 1)
            continue;


        if (c[i] == 1)
            continue;
        else
        {
            if (i + 2 <= c.Count - 1 && i + 1 <= c.Count - 1 && (c[i + 1] == 0 && c[i + 2] == 0))
            {
                tot++;
                i += 1;
            }
            else
                tot++;

        }
    }


    return tot;
}

// Console.WriteLine(jumpingOnClouds(new List<int> { 0, 0, 1, 0, 0, 1, 0 }));//4
// Console.WriteLine(jumpingOnClouds(new List<int> { 0, 0, 0, 0, 1, 0 }));//3
Console.WriteLine(jumpingOnClouds(new List<int> { 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }));//53

