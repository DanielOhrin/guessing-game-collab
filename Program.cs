using System;

void Main()
{
    Console.WriteLine("Guess the secret number!");
    int userGuess;

    int secretNumber = 42;


    for (int i = 1; i < 5; i++)
    {
        userGuess = int.Parse(Console.ReadLine());

        if (userGuess == secretNumber)
        {
            Console.WriteLine("You got it correct");
        }
        else
        {
            Console.WriteLine("Try Again");
        }
    }
}

Main();
