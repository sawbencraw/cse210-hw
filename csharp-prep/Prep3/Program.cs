using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int myNumber = randomGenerator.Next(1, 201);

        int guess = -1;
        while (guess != myNumber)
        {
            Console.Write("Guess a number between 1 & 201! ");
            guess = int.Parse(Console.ReadLine());

            if (myNumber > guess)
            {
                Console.WriteLine("Try again, but higher this time!");
            }
            else if (myNumber < guess)
            {
                Console.WriteLine("Try again, but lower this time!");
            }
            else
            {
                Console.WriteLine("You got it!");
            }

        }                    
    }
}