
// Console.WriteLine(pickingNumbers(new List<int> { 1, 1, 2, 2, 4, 4, 5, 5, 5 }));
Console.WriteLine(pickingNumbers(new List<int> { 4, 6, 5, 3, 3, 1 }));

// static int pickingNumbers(List<int> a)
// {

//     int max = 0;
//     int[] arr = a.ToArray();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         int temp = 0;
//         Array.Sort(arr);
//         for (int j = i; j < arr.Length; j++)
//         {
//             if (Math.Abs(arr[i] - arr[j]) <= 1)
//             {
//                 temp++;
//             }
//             else
//                 break;
//         }

//         if (temp > max)
//             max = temp;
//     }
//     return max;
// }

static int pickingNumbers(List<int> a)
{

    int[] freq = new int[101];
    var arr = a.ToArray();
    Array.Sort(arr);

    foreach (var num in arr)
    {
        freq[num]++;
    }

    int max = 0;

    for (int i = 0; i < freq.Length - 1; i++)
    {
        int temp = freq[i] + freq[i + 1];

        if (temp > max) max = temp;
    }

    return max;
}