
// Console.WriteLine(countingValleys(8, "UDDDUDUU")); ==>1
// Console.WriteLine(countingValleys(8, "DDUUDDUU")); ==> 2
static int countingValleys(int steps, string path)
{
    int seaLevelCount = 0;
    int valleyCount = 0;
    bool downSeaLevel = false;

    foreach (var step in path)
    {

        if (step == 'U') seaLevelCount++;


        if (step == 'D') seaLevelCount--;

        if (seaLevelCount < 0)
            downSeaLevel = true;

        if (downSeaLevel && seaLevelCount == 0)
            valleyCount++;

        if (seaLevelCount >= 0 && valleyCount > 0)
            downSeaLevel = false;

    }

    return valleyCount;
}
