namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------Exercise 1---------------------------------

            //var random = new Random();
            //var favoriteNumber = random.Next(1, 1000);

            //Console.WriteLine("Try to guess my favorite number between 1 - 1000");
            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput < favoriteNumber)
            //{
            //    Console.WriteLine($"Too Low, the number was {favoriteNumber}");
            //}
            //else if (userInput > favoriteNumber)
            //{
            //    Console.WriteLine($"Too High, the number was {favoriteNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Nevermind");
            //}

            //-------------------Exercise 2---------------------------------

            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "english":
                    Console.WriteLine("English! How Awesome!");
                    break;
                case "math":
                    Console.WriteLine("Math! How Awesome!");
                    break;
                case "science":
                    Console.WriteLine("Science! How Awesome!");
                    break;
                case "history":
                    Console.WriteLine("History! How Awesome!");
                    break;
                case "spanish":
                    Console.WriteLine("Spanish! How Awesome!");
                    break;
                default:
                    Console.WriteLine("I haven't taken that subject yet!");
                    break;
            }
        }
    }
}