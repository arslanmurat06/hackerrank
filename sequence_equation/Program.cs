static List<int> permutationEquation(List<int> p)
{
    List<int> result = new List<int>();
    var dict = new Dictionary<int, int>();

    for (int i = 0; i < p.Count; i++)
    {
        dict[i + 1] = p[i];
    }

    for (int j = 0; j < p.Count; j++)
    {
        var a = dict.Where(kvp => kvp.Value == j + 1).Select(kvp => kvp.Key).FirstOrDefault();
        var b = dict.Where(kvp => kvp.Value == a).Select(kvp => kvp.Key).FirstOrDefault();
        result.Add(b);
    }

    return result;
}


permutationEquation(new List<int> { 5, 2, 1, 3, 4 }).ForEach(i => Console.WriteLine(i));