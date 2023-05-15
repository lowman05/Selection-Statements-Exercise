using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            Console.WriteLine("Can you guess my favorite number?");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < num)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > num)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("How did you guess it?!");
            }
            Console.ReadLine(); 
        }
    }
}
