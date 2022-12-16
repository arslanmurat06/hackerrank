/// verilen hamleden az oldugu muddetce YES donulecek


static string appendAndDelete(string s, string t, int k)
{

    var desiredSameCharIndex = 0;
    var changedSameCharIndex = 0;


    while (desiredSameCharIndex < t.Length && changedSameCharIndex < s.Length)
    {

        if (t[desiredSameCharIndex] == s[changedSameCharIndex])
        {
            desiredSameCharIndex++;
            changedSameCharIndex++;
        }
        else
            break;
    }

    var minOperation = t.Length - desiredSameCharIndex + s.Length - changedSameCharIndex;

    if (minOperation > k) return "No";

    if (k >= (s.Length + t.Length)) return "Yes";

    if ((k - minOperation) % 2 == 0) return "Yes";

    return "No";

}





Console.WriteLine(appendAndDelete("hackerhappy", "hackerrank", 9)); //Yes
Console.WriteLine(appendAndDelete("aba", "aba", 7)); //Yes
Console.WriteLine(appendAndDelete("ashley", "ash", 2)); //No
Console.WriteLine(appendAndDelete("qwerasdf", "qwerbsdf", 6)); //No
Console.WriteLine(appendAndDelete("zzzzz", "zzzzzzz", 4)); //No 
Console.WriteLine(appendAndDelete("y", "yu", 2)); //No
Console.WriteLine(appendAndDelete("aaaaaaaaaa", "aaaaa", 7)); //Yes
