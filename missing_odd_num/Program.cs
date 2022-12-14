

Console.WriteLine(findMissingOddNumber(new int[] { 1, 3, 7, 9, 11 }));
int findMissingOddNumber(int[] arr)
{
    Array.Sort(arr);
    Array.Reverse(arr);
    int missingOdd = 0;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        var searchingNumber = arr[i] - 2;

        if (arr[i + 1] != searchingNumber)
        {
            missingOdd = searchingNumber;
            break;
        }
    }

    if (missingOdd == 0 && arr[arr.Length - 1] != 1)
        missingOdd = 1;

    return missingOdd;

}