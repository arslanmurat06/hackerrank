static int hurdleRace(int k, List<int> height)
{

    var max = height.Max();

    if (k >= max) return 0;

    var pos = max - k;

    return pos;

}


Console.WriteLine(hurdleRace(4, new List<int> { 1, 6, 3, 5, 2 }));