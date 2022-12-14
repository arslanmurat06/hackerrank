Console.WriteLine(sockMerchant(7, new List<int> { 1, 2, 1, 2, 1, 3, 2 }));

static int sockMerchant(int n, List<int> ar)
{
    Dictionary<int, int> socksDic = new Dictionary<int, int>();

    foreach (var item in ar)
    {
        if (socksDic.TryGetValue(item, out int num))
        {
            num++;
            socksDic[item] = num;
        }
        else
        {
            socksDic[item] = 1;
        }
    }

    var pairedSocks = socksDic.Where(s => s.Value > 1).ToDictionary(x => x.Key, x => x.Value);

    int total = 0;

    foreach (var item in pairedSocks.Values)
    {
        total += item / 2;
    }

    return total;

}

