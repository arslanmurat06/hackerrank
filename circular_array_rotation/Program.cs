List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
{

    List<int> result = new List<int>();
    var arr = a.ToArray().Reverse();
    Queue<int> queue = new Queue<int>(arr.ToList());

    foreach (var rotate in Enumerable.Range(0, k))
    {
        var element = queue.Dequeue();
        queue.Enqueue(element);
    }

    var list = queue.ToList().ToArray().Reverse().ToList();

    foreach (var item in queries)
    {
        result.Add(list[item]);
    }

    return result;

}

circularArrayRotation(new List<int> { 3, 4, 5 }, 2, new List<int> { 1, 2 }).ForEach(i => Console.WriteLine(i));