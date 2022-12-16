static int findDigits(int n)
{
    int dividerCount = 0;

    var dividers = n.ToString().ToCharArray().Select(c => Int32.Parse(c.ToString()));
    foreach (var item in dividers)
    {
        if (item == 0) continue;

        if (n % item == 0) dividerCount++;
    }

    return dividerCount;
}


Console.WriteLine(findDigits(120));//2
Console.WriteLine(findDigits(111));//3