namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favoriteNumber = random.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number between 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favoriteNumber)
            {
                Console.WriteLine($"Too Low, the number was {favoriteNumber}");
            }
            else if(userInput > favoriteNumber)
            {
                Console.WriteLine($"Too High, the number was {favoriteNumber}");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}