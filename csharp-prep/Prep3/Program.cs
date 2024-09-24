using System;

class Program
{
    static void Main(string[] args)
    {
        /* Step 1 - ask for a number and then try to guess the number.
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } */
    

        /* Step 2 - step 1 and loop guessing until answer is found.
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        //Random randomGenerator = new Random();
        //int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } */


        /* Step 3 - generate a random number from 1 to 100.*/
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}