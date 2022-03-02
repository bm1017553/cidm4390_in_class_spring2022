using System.Linq;
using mylib;

namespace code
{
    public class Program{

        public static void AskQuestion(string question)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine(question);
        }

        public static void Main()
        {

            AskQuestion("Gimmie a number");

            var list = new List<int>();

            list.Add(new Random().Next(10));

            Console.WriteLine($"{list[0]}");

            var ng = new NumberGuesser();

            var outcome = ng.GuessTheNumber(new Random().Next(10));

            Console.WriteLine($"{outcome}");
        }
    }


}

