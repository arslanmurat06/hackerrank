static int utopianTree(int n)
{
    int year = 0;
    bool isReminder = false;
    if (n % 2 == 0)
        year = n / 2;
    else
    {
        isReminder = true;
        year = (n / 2) + 1;
    }

    int height = (int)(Math.Pow(2, year) + (Math.Pow(2, year) - 1));
    return isReminder ? height - 1 : height;
}

Console.WriteLine(utopianTree(4));