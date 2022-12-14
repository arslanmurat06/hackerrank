Console.WriteLine(pageCount(11, 7));

static int pageCount(int n, int p)
{

    var isLastPageLeft = n % 2 == 0;

    if (p == 1) return 0;
    if (n == p) return 0;
    if (n - p == 1 && isLastPageLeft) return 1;
    else if (n - p == 1 && !isLastPageLeft) return 0;
    
    if (p > (n / 2)) return ((n - p) / 2);
    else return p / 2;
}
