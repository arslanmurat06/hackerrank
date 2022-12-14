//n prisoner count
//m count of candy
// s the starting point of the chair

static int saveThePrisoner(int n, int m, int s)
{
    m--;

    var remind = m % n;

    var tot = s + remind;

    var ret = s +remind;

    if(ret<=n)
        return ret;

    else
        return ret%n;    


   
}

Console.WriteLine(saveThePrisoner(5, 2, 2));