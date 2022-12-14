
// samples
//1 2 3 4 5 4 3 2 1 3 4 ==> 3

//1 4 4 4 5 3 ==>4


List<int> nlist = new List<int> { };

Console.WriteLine(migratoryBirds(nlist));

static int migratoryBirds(List<int> arr)
{

    Dictionary<int, int> birdTypeNumFDic = new Dictionary<int, int>();

    foreach (var bidrType in arr)
    {
        if (birdTypeNumFDic.TryGetValue(bidrType, out int number))
        {
            number++;
            birdTypeNumFDic[bidrType] = number;
        }
        else
        {
            birdTypeNumFDic[bidrType] = 1;
        }
    }

    var maxNum = birdTypeNumFDic.Values.Max();
    var maxtypes = birdTypeNumFDic.Where(x => x.Value == maxNum).ToDictionary(x => x.Key, x => x.Value).Keys;

    return maxtypes.Min();

}