

static int nonDivisibleSubset(int k, List<int> s)
{
    Dictionary<int, int> complimantFrequencies = new Dictionary<int, int>();
    var max = 0;

    foreach (var item in s)
    {
        if (complimantFrequencies.TryGetValue(item % k, out int count))
            complimantFrequencies[item % k] += 1;
        else
            complimantFrequencies[item % k] = 1;
    }

    if (complimantFrequencies.TryGetValue(0, out _))
        max++;

    for (int i = 1; i < k; i++)
    {
        if (!complimantFrequencies.TryGetValue(i, out _)) continue;
        if (complimantFrequencies[i] == 0) continue;
        if ((i * 2) == k) max++;
        else
        {
            if (!complimantFrequencies.TryGetValue(k - i, out int count1))
                complimantFrequencies[k - i] = 0;

            max += Math.Max(complimantFrequencies[i], complimantFrequencies[k - i]);
            complimantFrequencies[i] = 0;
            complimantFrequencies[k - i] = 0;
        }
    }

    return max;

}




// Console.WriteLine(nonDivisibleSubset(3, new List<int> { 1, 7, 2, 4 }));//3
// Console.WriteLine(nonDivisibleSubset(4, new List<int> { 19, 12, 10, 24, 25, 22 }));//3
// Console.WriteLine(nonDivisibleSubset(5, new List<int> { 2, 7, 12, 17, 22 }));//5
Console.WriteLine(nonDivisibleSubset(7, new List<int> { 278, 576, 496, 727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436 }));

