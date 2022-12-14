static string angryProfessor(int k, List<int> a)
{
    var arrivedOnTime = a.Where(z => z <= 0).Count();
    return arrivedOnTime >= k ? "NO" : "YES";

}