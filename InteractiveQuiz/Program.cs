// Jillian Carter 9/15/17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var correctAnswers = 0;

                Console.WriteLine("True or False: The C# languge has been around for only 7 years.");
                var userAnswer1 = Console.ReadLine();

                Console.WriteLine("True or False: C# keywords are predefined, reserved identifiers that have special meanings to the compiler.");
                var userAnswer2 = Console.ReadLine();

                Console.WriteLine("True or False: A line of code in C# always ends with a semi-colon.");
                var userAnswer3 = Console.ReadLine();


                if (userAnswer1.ToLower() == "false")
                {
                    correctAnswers ++;
                }
                if (userAnswer2 == "true")
                {
                    correctAnswers ++;
                }
                if (userAnswer3 == "true")
                {
                    correctAnswers ++;
                }


                Console.WriteLine("Your total correct answers: " + correctAnswers + ".");

                Console.WriteLine("Try again?");
                var entry = Console.ReadLine();

                if (entry == "no")
                {
                    break;
                }

            }
        }
    }
}
