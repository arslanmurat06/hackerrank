string catAndMouse(int x, int y, int z)
{

    var catAToM = Math.Abs(z - x);
    var catBtoM = Math.Abs(z - y);
    var result = "";

    if (catAToM > catBtoM)
        result = "Cat B";
    else if (catBtoM > catAToM)
        result = "Cat A";
    else
        result = "Mouse C";


    return result;

}

Console.WriteLine(catAndMouse(1, 3, 2));