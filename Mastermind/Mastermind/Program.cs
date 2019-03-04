using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumberOfGuess = 0;
            const int MaxGuess = 10;
            var master = new MasterClass();
            var randomNumber =master.GetRandomNumber(1, 7);
            Console.WriteLine(master.FirstLine);
            Console.WriteLine(master.SecondLine);
            Console.WriteLine("Guess the four digit number");
            do
            {
                var numberEntered = Console.ReadLine();
                var comparedNumber = master.CompareNumber(numberEntered);
                Console.WriteLine(comparedNumber);
                if (comparedNumber == master.SecondLine) break;

            } while (totalNumberOfGuess++ < MaxGuess);
            Console.WriteLine("The correct number is {0}", randomNumber);
        }

    }
}
