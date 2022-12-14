

int designerPdfViewer(List<int> h, string word)
{

    var chars = "abcdefghijklmnoprstuvxwyz";
    var charHeights = new int[word.Length];

    for (int i = 0; i < word.Length; i++)
    {
        var index = chars.ToArray().ToList().IndexOf(word[i]);
        charHeights[i] = h[index];
    }

    var max = charHeights.Max();

    return max * word.Length;

}


//Console.WriteLine(designerPdfViewer(new List<int>{1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7}));
