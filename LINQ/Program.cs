using System.Security.Cryptography;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {            
            List<string> videoGameList = new List<string>() { "halo", "call of duty", "league of legends", "crysis", };

            var orginizedVideoGames = videoGameList.OrderBy(x => x.Length);

            foreach(var game in orginizedVideoGames)
            {
                Console.WriteLine(game);
            }


        }
    }
}
