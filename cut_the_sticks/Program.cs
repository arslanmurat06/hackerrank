static List<int> cutTheSticks(List<int> arr)
{
    var counts = new List<int>();

    var arrList = new List<int>(arr);


    foreach (var num in arrList)
    {
        var count = arrList.Count();
        counts.Add(count);
        var minOne = arrList.Min();

        arrList = arrList.Select(n => n - minOne).Where(n => n > 0).ToList();

        if (!arrList.Any())
            break;
    }

    return counts;
}

cutTheSticks(new List<int> { 5, 4, 4, 2, 2, 8 }).ForEach(n => Console.WriteLine(n));
cutTheSticks(new List<int> { 1, 2, 3, 4, 3, 3, 2, 1 }).ForEach(n => Console.WriteLine(n));


