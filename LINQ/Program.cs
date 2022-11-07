namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> VideoGameList = new List<string>
            {"VHS", "FFXIV", "LoL", "Animal Crossing" };

            IEnumerable<string> length = VideoGameList.Where(x => x.Length < 16).OrderBy(x => x);
             
            foreach (string videoGame in length)
            {
                Console.WriteLine(videoGame);
            }    


        }
    }
}
