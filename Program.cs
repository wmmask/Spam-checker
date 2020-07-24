using System;

namespace Spam_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string blackListWord "psycho";
            bool isSpam = false;
            string message = Console.ReadLine();
            //message/string for test with spam:
                //The company has a pyscho culture.
            //message/string for test without spam:
            //The company is forward thinking!

            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam.");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");
            }

        }
    }
}
