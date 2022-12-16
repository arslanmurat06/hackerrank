static int squares(int a, int b)
{
    var sqrRootA = (int)Math.Sqrt(a);
    var sqrRootB = (int)Math.Sqrt(b);

    var isARootable = Math.Ceiling(Math.Sqrt(a)) == Math.Sqrt(a);


    return (sqrRootB - sqrRootA) + (isARootable ? 1 : 0);

}

Console.WriteLine(squares(3, 9));//2
Console.WriteLine(squares(17, 24));//0
Console.WriteLine(squares(24, 49));//3
Console.WriteLine(squares(35, 70));//3
Console.WriteLine(squares(100, 1000));//22