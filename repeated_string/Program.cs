static long repeatedString(string s, long n)
{

    var countA = s.Where(c => c == 'a').Count();

    var divide = n / s.Length;
    var remain = n % s.Length;

    var total = divide * countA;

    for (int i = 0; i < remain; i++)
    {
        if (s[i] == 'a')
            total++;
    }

    return total;
}


Console.WriteLine(repeatedString("a", 1000000000000));