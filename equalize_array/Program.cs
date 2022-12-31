static int equalizeArray(List<int> arr)
{

    var numberFreq = new Dictionary<int, int>();

    foreach (var num in arr)
    {
        if (!numberFreq.TryGetValue(num, out int count))
        {
            numberFreq.Add(num, 1);
        }
        else
            numberFreq[num]++;
    }

    var maxKey = numberFreq.MaxBy(kvp => kvp.Value).Key;
    var maxvalue = numberFreq[maxKey];

    return arr.Count - maxvalue;
}

Console.WriteLine(equalizeArray(new List<int> { 3, 3, 2, 1, 3 }));//2
Console.WriteLine(equalizeArray(new List<int> { 1, 2, 3, 1, 2, 3, 3, 3 }));//4
