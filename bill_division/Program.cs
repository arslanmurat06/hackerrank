bonAppetit(new List<int> { 3, 10, 2, 9 }, 1, 12);

static void bonAppetit(List<int> bill, int k, int b)
{

    bill.RemoveAt(k);
    var average = bill.Sum() / 2;

    if (average < b)
        Console.WriteLine(b - average);
    else if (b == average)
        Console.WriteLine("Bon Appetit");

}