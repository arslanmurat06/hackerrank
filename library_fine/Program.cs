static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
{

    var res = 0;

    var date1 = new DateTime(y1, m1, d1);
    var date2 = new DateTime(y2, m2, d2);

    var days = (date1 - date2).Days;

    if ((y1 == y2 && d1 == d2 && m1 == m2) || days < 0)
        return 0;

    if (y1 == y2 && m1 == m2)
        res = (d1 - d2) * 15;
    else if (y1 == y2 && m1 != m2)
        res = (m1 - m2) * 500;
    else if (y1 > y2)
        res = 10000;

    return res;
}

Console.WriteLine(libraryFine(14, 7, 2018, 5, 7, 2018));//135
Console.WriteLine(libraryFine(9, 6, 2015, 6, 6, 2015));//45
Console.WriteLine(libraryFine(6, 6, 2015, 9, 6, 2016));//0
Console.WriteLine(libraryFine(2, 6, 2014, 5, 7, 2014));//0