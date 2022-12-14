static int beautifulDays(int i, int j, int k)
{
    int count = 0;

    for (int l = i; l < j + 1; l++)
    {
        var a = l.ToString().ToCharArray();
        Array.Reverse(a);

        int reversedNum = Int32.Parse(new String(a));

        if (Math.Abs(l - reversedNum) % k == 0)
            count++;

    }
    return count;
}

Console.WriteLine(beautifulDays(120, 123, 6));