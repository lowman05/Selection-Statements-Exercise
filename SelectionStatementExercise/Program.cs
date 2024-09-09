using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            GuessingGame();
        }

        public static void GuessingGame()
        {
            var r = new Random();
            var favNum = r.Next(1, 10);
            var response = 0;

            while (response != favNum)
            {
                Console.WriteLine("Give me a number");
                response = int.Parse(Console.ReadLine());

                if (response < favNum)
                {
                    Console.WriteLine($"Too low!\nYour guess: {response}");
                }
                else if (response > favNum)
                {
                    Console.WriteLine($"Too high!\nYour guess: {response}");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            }
        }
    }
}
