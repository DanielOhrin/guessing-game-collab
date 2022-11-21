using System;

void Main()
{
    Console.WriteLine("Guess the secret number!");
    int userGuess;

    int secretNumber = new Random().Next(1, 101);

    for (int i = 1; i < 5; i++)
    {
        userGuess = int.Parse(Console.ReadLine());

        if (userGuess == secretNumber)
        {
            Console.WriteLine("You got it correct");
            break;
        }
        else
        {
            Console.WriteLine($"Try Again. You have {5 - 1} guesses left.");
        }
    }
}

Main();
