
internal class Program
{
    private static void Main(string[] args)
    {
        climbingLeaderboard(new List<int> { 100, 100, 50, 40, 40, 20, 10 }, new List<int> { 5, 25, 50, 120 }).ForEach(x => Console.WriteLine(x));

        static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {

            int[] result = new int[player.Count];
            int count = 0;
            var hashedrankes = new HashSet<int>(ranked);
            var hashedList = hashedrankes.ToList();

            var max = ranked.Max();
            var min = ranked.Min();
            var rangeCount = hashedrankes.Count();
            var hashedLast = hashedList.Count() - 1;

            foreach (var game in player)
            {

                if (game >= max)
                {
                    result[count] = 1;
                    count++;
                    continue;
                }

                if (game < min)
                {
                    result[count] = rangeCount + 1;
                    count++;
                    continue;
                }



                while (hashedList[hashedLast] <= game)
                    hashedLast--;


                result[count] = hashedLast + 2;
                count++;

            }

            return result.ToList();
        }
    }
}