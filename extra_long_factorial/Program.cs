using System.Numerics;

static void extraLongFactorials(int n)
{
    BigInteger result = 0;

    result = CalculateFactorial(n);

    Console.WriteLine(result);
}

static BigInteger CalculateFactorial(int n)
{
    BigInteger res = 1;
    if (n == 1) return 1;
    res = n * CalculateFactorial(n - 1);

    return res;
}

extraLongFactorials(5);//120
extraLongFactorials(6);//720
extraLongFactorials(25);//15511210043330985984000000