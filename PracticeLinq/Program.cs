namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
           {
               "Overwatch", "Majoras Mask", "Rust" , "Scum"
           };
            IEnumerable<string> videogamenames = videoGames.Where(name => name.Contains("0"));

            //foreach(var i in videoGames)
            //{
            //    Console.WriteLine(i);
            //}
            var orderOfVideogames = videoGames.OrderBy(name => name.Length).ToList();

            foreach (var i in orderOfVideogames)
            {
                Console.WriteLine(i);
            }
            

        }
    }
}